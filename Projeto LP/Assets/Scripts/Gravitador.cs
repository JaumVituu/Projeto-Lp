using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitador : MonoBehaviour
{
    void OnTriggerEnter(Collider colisao){
        if(colisao.gameObject.name =="Player"){
            if(colisao.GetComponent<Player>().gravidade == false){
				colisao.GetComponent<Player>().gravidade = true;
				Destroy(gameObject);
			}
			else{
				colisao.GetComponent<Player>().gravidade = false;
				Destroy(gameObject);
			}
        }
    }
}
