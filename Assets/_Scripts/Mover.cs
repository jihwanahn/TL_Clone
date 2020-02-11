using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    //[SerializeField] Transform target;
    // Ray lastRay;
    // NavMeshAgent agent;
    
    // void Start()
    // {
    //     agent = GetComponent<NavMeshAgent>();
    // }

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
        //lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(lastRay.origin, lastRay.direction * 100);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if(hasHit)        
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
            //Debug.Log(hit.point.x + " & " + hit.point.y + " & " + hit.point.z);
        }
    }
}
