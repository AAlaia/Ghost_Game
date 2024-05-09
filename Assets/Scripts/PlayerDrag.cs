using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class PlayerDrag : MonoBehaviour
    {
        public float speed = 2f;  

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

}
