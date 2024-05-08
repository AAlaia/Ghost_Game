using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class BasementFloors : MonoBehaviour
    {
        public Transform[] tiles; 

        public float right = -19f;
        private float speed = 5f;  
        public Vector3 left = new Vector3(-19f, -4.97f, 0f); 
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            for(int i = 0; i < tiles.Length; i++)
            {
                tiles[i].position += Vector3.right * speed * Time.deltaTime; 

                if (tiles[i].position.x >= right)
                {
                    tiles[i].position = left; 
                }
            }
        }  
    }
}

