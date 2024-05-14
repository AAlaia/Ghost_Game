using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GhostDamage : MonoBehaviour
    {
        void OnTriggerEnter2D()
        {
            StartCoroutine(dealDamage()); 
        }

        void OnTriggerExit2D()
        {
            StopCoroutine(dealDamage()); 
        }

        private IEnumerator dealDamage()
        {
            GlobalControl.Instance.savedPlayerData.health =- 5; 
            yield return new WaitForSeconds(5); 
        }
    }

}
