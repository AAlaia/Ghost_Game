using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

namespace GhostGame
{
    public class ajInteraction : MonoBehaviour
    {
        private bool isInteract = false;
        [SerializeField] Text text; 
        [SerializeField] GameObject startGame; 
        [SerializeField] GameObject reward; 
        public bool finishedGame = false;  


        void Update()
        {

            if (isInteract)
            {
                if (finishedGame)
                {
                    
                    int num = GlobalControl.Instance.savedPlayerData.fruitCollection; 
                    if (num < 15)
                    {
                        SceneManager.LoadScene(5); 
                    }
                    else
                    {
                        gameObject.GetComponent<GhostObjective>().ActiveObjectiveCompleted(); 
                        reward.SetActive(true);
                    }
                }
                else
                {
                    text.text = "Interact [E]"; 
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        gameObject.GetComponent<GhostObjective>().ActivateGhostDialogue(); 
                        startGame.SetActive(true);    
                    }
                }
            }
            else
            {
                text.text = "";
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            isInteract = true; 
        }

        void OnTriggerExit2D(Collider2D other)
        { 
            isInteract = false; 
        }
    
    }

}

