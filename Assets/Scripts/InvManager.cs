using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

namespace GhostGame
{
    public class InvManager : MonoBehaviour
    {
        public List<Items> items = new List<Items>(); 

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

