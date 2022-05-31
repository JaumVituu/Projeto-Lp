using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject tiroPrefab;
    public Vector3 posicaoAtual;
    public LayerMask layerMask;
    float tempoTiro;

    void Start()
    {
        tempoTiro = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (tempoTiro <1f){
            tempoTiro += Time.deltaTime;
        }
        posicaoAtual = transform.position;
        DetectPlayer();
    }

    void DetectPlayer(){
        RaycastHit hit;
        Ray ray = new Ray(posicaoAtual,new Vector3(0,0,-1));
        if (Physics.Raycast(ray,out hit,9f,layerMask)){
            Shoot();
        }
    }
    void Shoot(){
        if (tempoTiro >= 1f){
            Instantiate(tiroPrefab, posicaoAtual + new Vector3(0,0,-2), Quaternion.identity);
            Debug.Log("Atirou");
            tempoTiro = 0f;
        }        
    }
}
