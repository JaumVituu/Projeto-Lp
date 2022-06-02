using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float delay;
    
    void Update()
    {
        Vector3 delayedPosition = target.position + offset;  
        transform.position = Vector3.Lerp(transform.position,delayedPosition,delay*Time.deltaTime);
    }
}
