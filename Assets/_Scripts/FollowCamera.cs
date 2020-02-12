using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target; 
    
    void LateUpdate()
    {
        transform.position = target.position;
        
        RotateCamera();
    }

    private void RotateCamera()
    {
        //transform.rotation = target.rotation;
    }
}
