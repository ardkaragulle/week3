using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private CrowdSpawn crowdSystem;
    


    [Header("Settings")]
    [SerializeField] private float PlayerSpeed;
    [SerializeField] private float roadWidth;

    [Header("Control")]
    [SerializeField] private float SlideSpeed;
    private Vector3 clickedScreenPosition;
    private Vector3 clickedPlayerPosition;
   

    void Start()
    {

    }


    void Update()
    {
        MoveForward();

        ManageControl();
    }
    private void MoveForward()
    {
        transform.position += Vector3.forward * Time.deltaTime * PlayerSpeed;
    }

    private void ManageControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickedScreenPosition = Input.mousePosition;
            clickedPlayerPosition = transform.position;
        }
        else if (Input.GetMouseButton(0))
        {
            float xScreenDifference = Input.mousePosition.x - clickedScreenPosition.x;

            xScreenDifference /= Screen.width;
            xScreenDifference *= SlideSpeed;

            Vector3 position = transform.position;
            position.x = clickedPlayerPosition.x + xScreenDifference;

            position.x = Mathf.Clamp(position.x, -roadWidth / 2 + crowdSystem.GetCrowdRadius(), 
                roadWidth / 2 - crowdSystem.GetCrowdRadius());

            transform.position = position;

            //transform.position = clickedPlayerPos + Vector3.right * xScreenDifference;
             
        }
    }
}
