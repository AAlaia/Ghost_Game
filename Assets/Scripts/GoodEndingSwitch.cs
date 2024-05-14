using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

namespace GhostGame
{
    public class GoodEndingSwitch : MonoBehaviour
    {
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            Timer end = gameObject.GetComponent<Timer>(); 
            
            if (end.remainingTime < 0)
            {
                SceneManager.LoadScene(4); 
            }
        }
    }

}
