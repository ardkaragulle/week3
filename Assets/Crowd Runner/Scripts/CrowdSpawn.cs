using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdSpawn : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float angle;
    [SerializeField] private float radius;

    [Header("Elements")]
    [SerializeField] private Transform runnersParent;

    void Start()
    {
        
    }

    
    void Update()
    {
        PlaceRunners();
    }

    private void PlaceRunners()
    {
        for (int i = 0; i < runnersParent.childCount; i++)
        {
            Vector3 childLocalPosition = GetRunnerLocalPostion(i); 
            runnersParent.GetChild(i).localPosition = childLocalPosition;
        }
    }

    private Vector3 GetRunnerLocalPostion(int index)
    {
        float x = radius * Mathf.Sqrt(index) * Mathf.Cos(Mathf.Deg2Rad * index * angle);
        float z = radius * Mathf.Sqrt(index) * Mathf.Sin(Mathf.Deg2Rad * index * angle);

        return new Vector3(x, 0, z);
    }

    public float GetCrowdRadius()
    {
        return radius * Mathf.Sqrt(runnersParent.childCount);
    }
}
