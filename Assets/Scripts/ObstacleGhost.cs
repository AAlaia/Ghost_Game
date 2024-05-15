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
        public Animator animator; 
        Vector2 movement; 
        private bool trigEvent = false; 
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(FollowPath()); 
        }

        IEnumerator FollowPath()
        {
            Vector3 target; 
            while(path.TryGetPoints(index, out target))
            {
                Vector3 start = transform.position; 

                float maxDistance = Mathf.Min(speed * Time.deltaTime, (target - start).magnitude); 
                transform.position = Vector3.MoveTowards(start, target, maxDistance);
 
                if (transform.position == target) 
                {
                    index++;
                } 
                yield return null;
                if (index == path.points.Count)
                {
                    index = 0; 
                }
                if (trigEvent == true)
                {
                    yield break; 
                }
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
        }

        public void OnTriggerExit2D(Collider2D other)
        {
            trigEvent = false; 
            StartCoroutine(FollowPath());
        } 
    }

        
}

