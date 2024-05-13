using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

namespace GhostGame
{
    public class DialogueLoadScene : MonoBehaviour
    {
        [SerializeField] int index; 
        void Start()
        {
            SceneManager.LoadScene(index); 
        }
    }

}
