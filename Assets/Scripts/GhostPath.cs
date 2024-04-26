using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhostGame
{
    public class GhostPath : MonoBehaviour
{
    private List<Vector3> points = new List<Vector3>();

    void Awake()
    {
        GetPoints();
    }

    private void GetPoints()
    {
        points = new List<Vector3>();

        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;

            Vector3 point = child.transform.position;
            points.Add(point);

            child.SetActive(false);
        }  
    }

    public bool TryGetPoints(int index, out Vector3 point)
    {
        point = Vector3.zero;
        if (index < 0 || index >= points.Count) return false;

        point = points[index];
        return true;
    }
}
}

