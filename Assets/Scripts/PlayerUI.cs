using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{

    public class PlayerUI : MonoBehaviour
    {
        Health playerHealth;
        public Image [] blocks;
        int healthNum = 0;

        void Start()
        {
            playerHealth = FindObjectOfType<Health>();

            
        }

        // Update is called once per frame
        void Update()
        {
            if (healthNum != playerHealth.getHealth())
            {
                updateHealth();
            }
        }

        void updateHealth()
        {
            healthNum = playerHealth.getHealth();

            for (int i = 0; i < 10; i++)
            {
               

                    blocks[i].gameObject.SetActive(true);
                
            //    // else
            //     {
            //         blocks[i].gameObject.SetActive(false);
            //     }
            }
            

            for (int i = 0; i < healthNum/10; i++)
            {
                print(healthNum);

                    blocks[i].gameObject.SetActive(false);
                
            //    // else
            //     {
            //         blocks[i].gameObject.SetActive(false);
            //     }
            }
        }







    }
}