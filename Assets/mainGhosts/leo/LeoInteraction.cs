using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    public class LeoInteraction : MonoBehaviour
    {
        private bool isInteract = false;
        [SerializeField] Text text; 
        [SerializeField] GameObject removeFire; 
        [SerializeField] GameObject beginFindingPhoto; 
        [SerializeField] Sprite aftermath; 
        public bool finishedGame = false;  
        public bool giveReward = false;

        void Start()
        {
            finishedGame = GlobalControl.Instance.savedPlayerData.fixedPhoto; 
        }
        void Update()
        {
            if (isInteract)
            {
                text.text = "Interact [E]"; 
                if (giveReward)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        gameObject.GetComponent<GhostObjective>().ActiveObjectiveCompleted(); 
                        GlobalControl.Instance.savedPlayerData.respawnAfterPhoto = false; 
                        gameObject.GetComponent<SpriteRenderer>().sprite = aftermath; 
                        removeFire.SetActive(false); 
                    }
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        gameObject.GetComponent<GhostObjective>().ActivateGhostDialogue(); 
                        beginFindingPhoto.SetActive(true); 
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
            if (finishedGame)
            {
                giveReward = true; 
            }
        }

        void OnTriggerExit2D(Collider2D other)
        { 
            isInteract = false; 
        }
    }
}

