using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GlobalControl : MonoBehaviour
    {   
        public static GlobalControl Instance; 

        public PlayerStatistics savedPlayerData = new PlayerStatistics();  

        void Awake()
        {
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this; 
            }
            else if (Instance != this)
            {
            Destroy(gameObject); 
                }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

