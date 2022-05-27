using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float angVel;
    void Update()
    {
        Girar();
    }

    void Girar (){
        transform.Rotate(0,angVel,0);
    }
}
