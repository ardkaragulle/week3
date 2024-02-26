using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RunnerCounter : MonoBehaviour
{
    [SerializeField] private TextMeshPro runnerCounterText;
    [SerializeField] private Transform runnersParent;

    void Start()
    {
        
    }

    
    void Update()
    {
        runnerCounterText.text = runnersParent.childCount.ToString();
    }
}
