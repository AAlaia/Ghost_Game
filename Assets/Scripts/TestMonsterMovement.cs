using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class TestMonsterMovement : MonoBehaviour
    {
    
        void Update()
        {
            var speed = 5.0f;
            var intensity = 0.1f;
 
            transform.position = intensity * new Vector3(
                Mathf.PerlinNoise(speed * Time.time, 1),
                Mathf.PerlinNoise(speed * Time.time, 2),
                Mathf.PerlinNoise(speed * Time.time, 3));
        
        }
    }

}
