using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class EndingSequence : MonoBehaviour
    {
        void Start()
        {
            gameObject.GetComponent<DialogueActiviation>().ActivateDialogue(); 
        }
    }
}
