using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        private float speed = 5f; 
        Rigidbody2D rb; 
        public CharacterController controller; 
        public Animator animator; 
        Vector2 movement;
        public PlayerStatistics localPlayerData = new PlayerStatistics();
        Inventory mgr; 

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            if (GlobalControl.Instance.savedPlayerData.position != null)
            {
                localPlayerData = GlobalControl.Instance.savedPlayerData;
                transform.position = localPlayerData.position;
            }
        }

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

            /* rb.AddForce(horizMoveDirection); 
            rb.AddForce(vertMoveDirection); */ 

            //focuses on changing player movement depending on direction

            transform.Translate(horizMoveDirection);
            transform.Translate(vertMoveDirection); 
 

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);


        }



    }

}
