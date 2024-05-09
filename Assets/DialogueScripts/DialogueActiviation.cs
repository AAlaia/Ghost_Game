using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class DialogueActiviation : MonoBehaviour
    {
        [SerializeField] private GameObject dialogue; 
        public void ActivateDialogue()
        {
            dialogue.SetActive(true); 
        }

        public bool DialogueActive()
        {
            return dialogue.activeInHierarchy; 
        }
    }


}
