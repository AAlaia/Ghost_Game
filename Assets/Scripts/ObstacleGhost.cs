using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class ObstacleGhost : MonoBehaviour
    {
        [SerializeField] private GameObject target; 
        [SerializeField] GhostPath path; 
        float speed = 3f;
        int index = 0; 
        public CharacterController controller; 
        public Animator animator; 
        Vector2 movement; 
        private bool trigEvent = false; 
        private bool followPathInfinitely = true; 
        Health health; 

        // Start is called before the first frame update
        void Start()
        {
            // path = FindObjectOfType<GhostPath>();
            StartCoroutine(FollowPath()); 
        }

        IEnumerator FollowPath()
        {
            Vector3 target; 
            while(followPathInfinitely)
            {
                while(path.TryGetPoints(index, out target))
                {
                    Vector3 start = transform.position; 

                    float maxDistance = Mathf.Min(speed * Time.deltaTime, (target - start).magnitude); 
                    transform.position = Vector3.MoveTowards(start, target, maxDistance);

                    // Rotate towards next point
                    // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target - start), 0.05f);  
                    if (transform.position == target) 
                    {
                        index++;
                    } 
                    yield return null;
                    if (trigEvent == true)
                    {
                        yield break; 
                    }
                }
                index = 0; 
            }

        } 

        void Update()
        {
            movement.x = transform.position.x;
            movement.y = transform.position.y;

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude); 
        }

        public void OnTriggerStay2D(Collider2D other)
        {
            trigEvent = true; 
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            health.tryDamage(other.gameObject, 2);
        }

        public void OnTriggerExit2D(Collider2D other)
        {
            trigEvent = false; 
            StartCoroutine(FollowPath());
        } 
    }

        
}

