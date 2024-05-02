using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

namespace GhostGame
{
    public class LockedDoor : MonoBehaviour
    {
    [SerializeField] private Text interactableName;
    private string interactionText = "Interact [E]";

    [SerializeField] private int scene; 

    private bool isOpened = false;

    private bool foundItem = false; 

    [SerializeField] private string itemNeeded; 

    InvManager mgr; 

    void Start()
    {
        mgr = FindObjectOfType<InvManager>(); 
    }

    void Update()
    {
        if (isOpened)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        interactableName.text = interactionText;
        searchForItem(); 
        if (foundItem)
        {
            isOpened = true; 
        }
        else
        {
            interactableName.text = "The door is locked.";
        }
        GlobalControl.Instance.savedPlayerData.position = transform.position; 
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        interactableName.text = null;
        isOpened = false;
    }

    private void searchForItem()
    {
        foreach (Items i in mgr.items)
        {
            if (string.Equals(i.name, itemNeeded))
            {
                interactableName.text = "Door unlocked!"; 
                foundItem = true; 
            }
        }

    }

    }
}