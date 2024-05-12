using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class ItemDialogue : MonoBehaviour
    {
        // single use dialogue
        private IEnumerator dialogueSeq; 
        [SerializeField] private GameObject endingAchieved; 
        [SerializeField] private bool shouldSpawn; 

        private void Awake()
        {
            dialogueSeq = dialogueSequence(); 
            StartCoroutine(dialogueSeq);
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Deactivate();
                gameObject.SetActive(false); 
                StopCoroutine(dialogueSeq); 
            }
        }
        private IEnumerator dialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate(); 
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished); 
            }
            endingAchieved.SetActive(shouldSpawn);  
            gameObject.SetActive(false); 
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false); 
            }
        }
    }

}