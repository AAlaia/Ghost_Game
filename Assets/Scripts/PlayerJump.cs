using UnityEngine;

namespace GhostGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerJump : MonoBehaviour
    {
        float jumpForce = 15f; 
        public bool isGrounded = false; 
        public Rigidbody2D rigidbody2D;

    
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    Vector2 jumpDirection = Vector2.up * jumpForce;

                    rigidbody2D.AddForce(jumpDirection, ForceMode2D.Impulse);
                    isGrounded = false; 
                }

            }
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("ground"))
            {
                if (isGrounded == false)
                {
                    isGrounded = true;
                }
            }
        }

        
    }
}

