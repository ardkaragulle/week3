using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [SerializeField] private Road chunkPrefab;
    void Start()
    {
        Vector3 chunkPostition = Vector3.zero;

        for (int i = 0; i < 5; i++)
        {

            
            chunkPostition.z = i * 20;

            Road chunkInstance = Instantiate(chunkPrefab, chunkPostition, Quaternion.identity, transform);
            
        }
    }

    
    void Update()
    {
        
    }
}
