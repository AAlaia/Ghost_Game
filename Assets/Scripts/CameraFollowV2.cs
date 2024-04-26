using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class CameraFollowV2 : MonoBehaviour
    {
        [SerializeField] private GameObject target; 
        private Vector3 offset;
        // Start is called before the first frame update
        void Start()
        {
            if (target)
            {
                offset = transform.position - target.transform.position;
            }
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = target.transform.position + offset;
        }
    }

}
