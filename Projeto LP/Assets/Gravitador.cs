using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitador : MonoBehaviour
{
    void OnTriggerEnter(Collider colisao){
        if(colisao.gameObject.name =="Player"){
            colisao.GetComponent<Player>().gravidade = false;
        }
    }
}
