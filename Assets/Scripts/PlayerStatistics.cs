using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class PlayerStatistics
    {
        // public Vector3 position; 
        public double health = 100;
        public InvManager inventory; 

        public int fruitCollection = 0; 
        public bool fixedPhoto = false; 
        public bool respawnAfterPhoto = false; 
        public bool stopSpawningFruit = false; 
        public bool endingAchieved = false;  
    }

}
