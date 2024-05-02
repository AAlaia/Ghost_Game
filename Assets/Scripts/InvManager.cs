using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

namespace GhostGame
{
    public class InvManager : MonoBehaviour
    {
        public List<Items> items = new List<Items>(); 

        void Start()
        {
            if (GlobalControl.Instance.savedPlayerData.inventory.items != null)
            {
                items = GlobalControl.Instance.savedPlayerData.inventory.items; 
            }
        }

        public void PrintList()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                foreach (Items i in items)
                {
                    print(i.name); 
                }
            }
        } 

        void Update()
        {
            PrintList(); 
        }

    }
}

