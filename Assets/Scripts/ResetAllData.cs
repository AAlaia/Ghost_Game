using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class ResetAllData : MonoBehaviour
    {
        void Start()
        {
            GlobalControl.Instance.savedPlayerData.health = 100; 
            GlobalControl.Instance.savedPlayerData.fruitCollection = 0; 
            GlobalControl.Instance.savedPlayerData.stopSpawningFruit = false;
            GlobalControl.Instance.savedPlayerData.endingAchieved = false;
            GlobalControl.Instance.savedPlayerData.respawnAfterPhoto = false;
            GlobalControl.Instance.savedPlayerData.fixedPhoto = false; 
            GlobalControl.Instance.savedPlayerData.inventory.items.Clear(); 
        }
    }
}

