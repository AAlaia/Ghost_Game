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

            // x cord has is multiplied by 0.1, so changing it to 108.9 will leave it at 10.89f
            // Mathf.PerlinNoise randomly generates a value between 0-1 in terms of "waves" that gradually increase and decrease the pattern. which causes the whole "shaking" part amplified by the intensity
            transform.position = intensity * new Vector3(
                108.9f,
                Mathf.PerlinNoise(speed * Time.time, 2),
                Mathf.PerlinNoise(speed * Time.time, 3));
        
        }
    }

}
