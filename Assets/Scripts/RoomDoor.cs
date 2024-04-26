using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

namespace GhostGame
{
    public class RoomDoor : MonoBehaviour
{
    [SerializeField] private Text interactableName;
    private string interactionText = "Interact [E]";

    [SerializeField] private int scene; 

    private bool isOpened = false; 

    [SerializeField] Player player; 

    void Start()
    {
        player.transform.position = transform.position; 
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
        isOpened = true; 
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        interactableName.text = null;
        isOpened = false;
    }

}

}