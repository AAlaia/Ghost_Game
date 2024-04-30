using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GhostGame
{
    public class PlayerHealth : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (!stillAlive())
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        public bool stillAlive()
        {
            Health playerHealth = GetComponent<Health>();

            if (playerHealth.health <= 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}