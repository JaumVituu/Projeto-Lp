using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 velocidade;
    // Start is called before the first frame update
    void Start()
    {
        velocidade.z = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            velocidade.z = 0.02f;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }
        if(Input.GetKey(KeyCode.A)){
            velocidade.z = -0.02f;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }

        if(Input.GetKey(KeyCode.W)){
            velocidade.x = -0.02f;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }

        if(Input.GetKey(KeyCode.S)){
            velocidade.x = 0.02f;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }
    

    }

    void Movimentar(Vector3 velocidade){
        transform.Translate(velocidade);
    }
}
