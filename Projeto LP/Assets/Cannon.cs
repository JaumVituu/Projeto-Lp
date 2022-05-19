using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    GameObject tiroPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        DetectPlayer();
    }

    void DetectPlayer(){
        RaycastHit hit;
        Ray ray = new Ray(transform.position,new Vector3(0,0,-1));
        if (Physics.Raycast(ray,out hit,Mathf.Infinity)){
            Shoot();
        }
    }
    void Shoot(){
        Instantiate(tiroPrefab,transform.position + new Vector3(0,0,-3));
    }
}
