using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;

    void Start() 
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
        // else if (Input.GetMouseButtonDown(1))
        // {
        // }
    }

    void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //bool hasHit = 
        if(Physics.Raycast(ray, out hit))        
        {
            agent.destination = hit.point;
            Debug.Log(hit.point.x + " & " + hit.point.y + " & " + hit.point.z);
        }
    }
}
