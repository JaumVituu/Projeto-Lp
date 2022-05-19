using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyRange : MonoBehaviour
{
    public bool inRange;
    public Transform colliderObject;

    void OnCollisionEnter(Collision collider){
        if(collider.gameObject.name == "Player"){
            colliderObject = collider.gameObject.transform;
            inRange = true;
            Debug.Log("Entrou");
        }
    }
    void OnCollisionExit(Collision collider){
        if(collider.gameObject.name == "Player"){
            inRange = false;
            Debug.Log("Saiu");
        }
    }
}
