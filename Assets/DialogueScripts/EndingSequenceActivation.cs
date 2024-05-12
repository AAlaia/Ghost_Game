using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class EndingSequenceActivation : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            gameObject.GetComponent<DialogueActiviation>().ActivateDialogue(); 
        }

    
    }   
}

