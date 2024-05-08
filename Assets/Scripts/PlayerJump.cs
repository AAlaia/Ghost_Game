using UnityEngine;

namespace GhostGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerJump : MonoBehaviour
    {
        float jumpForce = 5f; 
        public bool isFalling = true; 
        public Rigidbody2D rigidbody2D;

    
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 jumpDirection = Vector2.up * jumpForce;

                rigidbody2D.AddForce(jumpDirection, ForceMode2D.Impulse);
            }
            

        }

        
    }
}

