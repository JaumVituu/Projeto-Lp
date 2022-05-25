using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    float tempoRestante;    
    
    void Update()
    {
        tempoRestante += Time.deltaTime;
        Movimenta();
        if(tempoRestante >= 1f){
            Destroi();
        }
    }

    void Movimenta(){
        transform.Translate(new Vector3(0,0,-0.05f));
    }

    void Destroi(){
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider colisao){
        if(colisao.name == "Player"){
            Debug.Log("Atingiu");
            colisao.gameObject.GetComponent<Player>().vida -= 50;
            Destroi();
        }
    }
}
