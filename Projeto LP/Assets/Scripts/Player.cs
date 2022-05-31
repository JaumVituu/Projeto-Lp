using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Vector3 velocidade;
    public int vida;
    float tempoMorte;
    public MeshRenderer mesh;
    public bool gravidade;
    // Start is called before the first frame update
    void Start()
    {
        gravidade = true;
        velocidade.z = 0f;
        vida = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida >0){
        if(Input.GetKey(KeyCode.D)){
            velocidade.z = 0.035f;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }
        if(Input.GetKey(KeyCode.A)){
            velocidade.z = -0.03f;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }

        if(Input.GetKey(KeyCode.W)){
            velocidade.x = -0.03f;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }

        if(Input.GetKey(KeyCode.S)){
            velocidade.x = 0.03f;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }
        }
        if(vida <= 0){
            Morrer(); 
        }
        if (gravidade == false){
            this.rigidbody.useGravity = false;

            if (Input.GetKey("space")){
                velocidade.y = 0.03f;
                Movimentar(velocidade);
                velocidade.y = 0.0f;
            }
        }
        if (gravidade == true){
            this.rigidbody.useGravity = true;
        }
    }

    void Movimentar(Vector3 velocidade){
        transform.Translate(velocidade);
    }

    void Morrer(){

        tempoMorte += Time.deltaTime;
        mesh.enabled = false;
        if(tempoMorte >= 1f){
            SceneManager.LoadScene("Fim de jogo");
        }

    }

    
}
