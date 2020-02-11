using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    //private Ray lastRay;
    
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //}    
        //Debug.DrawRay(lastRay.origin, lastRay.direction * 100, Color.white);
        GetComponent<NavMeshAgent>().destination = target.position;
        GetComponent<NavMeshAgent>().stoppingDistance = 5f;
    }

}
