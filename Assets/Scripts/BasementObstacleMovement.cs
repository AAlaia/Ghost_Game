using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementObstacleMovement : MonoBehaviour
{
    public float speed = 20f; 
    public float stop = 1.83f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x > stop)
        {
            Destroy(gameObject); 
        }
    }
}
