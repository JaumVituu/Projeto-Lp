using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour
{
    public GameObject Range;
    void Start()
    {

    }

    void Update()
    {       

    }
       
    void InRange(){
        bool insideRange = Range.GetComponent<EnemyRange>().inRange;
        Transform Player = Range.GetComponent<EnemyRange>().colliderObject;

        if (insideRange == true){
            transform.LookAt(Player);
        }
    }
}
