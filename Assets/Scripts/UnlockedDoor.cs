using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

namespace GhostGame
{
    public class UnlockedDoor : MonoBehaviour
{
    [SerializeField] private Text interactableName;
    
    [SerializeField] private GameObject spawner; 
    [SerializeField] private AudioSource doorOpen; 
    private string interactionText = "Interact [E]";

    Player player; 

    private bool isOpened = false;  

    void Update()
    {
        if (isOpened)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.transform.position = spawner.transform.position; 
                doorOpen.enabled = true; 
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>(); 
        interactableName.text = interactionText;
        isOpened = true; 
        GlobalControl.Instance.savedPlayerData.position = transform.position; 
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        interactableName.text = null;
        isOpened = false;
    }

}

}