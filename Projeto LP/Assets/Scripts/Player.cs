using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Vector3 velocidade;
    public int vida;
    float tempoMorte;
    // Start is called before the first frame update
    void Start()
    {
        velocidade.z = 0f;
        vida = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vida);
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
    
        if(vida == 0){
            Morrer(); 
        }
    }

    void Movimentar(Vector3 velocidade){
        transform.Translate(velocidade);
    }

    void Morrer(){
        tempoMorte += Time.deltaTime;
        if(tempoMorte >= 1f){
            SceneManager.LoadScene("GameOver");
        }

    }

    
}
