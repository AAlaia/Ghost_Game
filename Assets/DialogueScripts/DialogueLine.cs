using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    public class DialogueLine : DialogueClass
    {
        private Text textHolder; 

        [Header ("Text Options")]
        [SerializeField] private string input; 
        [SerializeField] private Color textColor; 
        [SerializeField] private Font textFont; 

        [Header ("Time Parameter")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header ("Sound")]
        [SerializeField] private AudioClip sound;

        [Header ("Character Image")]
        [SerializeField] private Sprite character;
        [SerializeField] private Image imageHolder; 

        private IEnumerator lineAppear; 


        public void Awake()
        {
            imageHolder.sprite = character; 
            imageHolder.preserveAspect = true; 
        }

        private void OnEnable()
        {
            ResetLine(); 
            lineAppear = WriteText(input, textHolder, textColor, textFont, delay, sound, delayBetweenLines);
            StartCoroutine(lineAppear); 
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (textHolder.text != input)
                {
                    StopCoroutine(lineAppear); 
                    textHolder.text = input;
                }
                else
                {
                    finished = true; 
                }
            }
        }

        private void ResetLine()
        {
            textHolder = GetComponent<Text>(); 
            textHolder.text = ""; 
            finished = false;
        }

    }

}
