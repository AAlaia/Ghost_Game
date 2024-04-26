using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

namespace GhostGame
{
    public class Inventory : MonoBehaviour
    {
        InvManager mgr; 
        [SerializeField] private Text interactableName;
        [SerializeField] private string itemName;
        private string interactionText = "Pick Up [E]"; 
       //  private string finishedInteraction = "Item acquired."; 
        private Items newItem = new Items(); 
        private bool isPickUp = false; 


        void Start()
        {
            mgr = FindObjectOfType<InvManager>(); 
        }


        // Update is called once per frame
        
        void Update()
        { 
            if (isPickUp)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    // interactableName.text = finishedInteraction;
                    mgr.items.Add(newItem); 
                    interactableName.text = "";
                    Destroy(gameObject); 
                }
            }


        }

        void OnTriggerEnter2D(Collider2D other)
        {
            interactableName.text = interactionText;
            newItem.name = itemName; 
            isPickUp = true; 
             
        }
        void OnTriggerExit2D()
        {
            interactableName.text = ""; 
            isPickUp = false; 
        }


    }

}
