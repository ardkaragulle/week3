using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class car : MonoBehaviour
{

    [SerializeField] int speed = 10;


    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);

    }

}