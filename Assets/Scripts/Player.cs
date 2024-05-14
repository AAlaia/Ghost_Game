using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed = 5f; 
        Rigidbody2D rb; 
        public CharacterController controller; 
        public Animator animator; 
        Vector2 movement;
        Inventory mgr; 

        // Start is called before the first frame update
        /*void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            if (GlobalControl.Instance.savedPlayerData.position != null)
            {
                transform.position = GlobalControl.Instance.savedPlayerData.position;
            }
        }*/

        // Update is called once per frame
        void Update()
        {
            // allows player to move around
            float horizontalInput = Input.GetAxisRaw("Horizontal"); 
            float verticalInput = Input.GetAxisRaw("Vertical"); 

            movement.x = horizontalInput;
            movement.y = verticalInput;

            Vector2 horizMoveDirection = Vector2.right * speed * horizontalInput * Time.deltaTime;  
            Vector2 vertMoveDirection = Vector2.up * speed * verticalInput * Time.deltaTime;


            transform.Translate(horizMoveDirection);
            transform.Translate(vertMoveDirection); 
 

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);

            if (movement != Vector2.zero)
            {
                animator.SetFloat("LastHorizontal", movement.x);
                animator.SetFloat("LastVertical", movement.y); 
            }


        }



    }

}
