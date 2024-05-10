using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GhostObjective : MonoBehaviour
    {
        [SerializeField] GameObject ghostDialogue; 
        [SerializeField] GameObject objectiveCompleted; 

        public void ActivateGhostDialogue()
        {
            ghostDialogue.SetActive(true); 
        }

        public void ActiveObjectiveCompleted()
        {
            objectiveCompleted.SetActive(true); 
        }

        public bool ghostDialogueActive()
        {
            return ghostDialogue.activeInHierarchy;
        }

        public bool completedObjectiveActive()
        {
            return objectiveCompleted.activeInHierarchy;
        }
    }
}

