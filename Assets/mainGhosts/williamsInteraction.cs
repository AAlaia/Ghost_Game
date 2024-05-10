using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    public class williamsInteraction : MonoBehaviour
    {
        InvManager inv; 
        [SerializeField] private string name; 
        [SerializeField] private GameObject reward; 
        private bool bearFound = false; 
        private bool isInteract = false;
        [SerializeField] Text text; 
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isInteract)
            {
                text.text = "Interact[E]"; 
                if (bearFound)
                {
        
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        gameObject.GetComponent<GhostObjective>().ActiveObjectiveCompleted(); 
                        reward.SetActive(true); 
                    }
                }
                else
                {
         
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        gameObject.GetComponent<GhostObjective>().ActivateGhostDialogue();
                    } 
                }   
            }

        }

        void OnTriggerEnter2D(Collider2D other)
        {
            isInteract = true;
            inv = other.GetComponent<InvManager>();
            foreach (Items i in inv.items)
            {
                if (i.name == name)
                {
                    bearFound = true; 
                }
            }

        }

        void OnTriggerExit2D(Collider2D other)
        {
            text.text = ""; 
            isInteract = false; 
        }
    }
}
