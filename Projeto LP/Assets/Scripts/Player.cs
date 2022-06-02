using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Vector3 velocidade;
    public float vida;
	public Color corSecundaria;
	public Color corPrimaria;
    float tempoMorte;
    public MeshRenderer mesh;
    public bool gravidade;
    
    void Start()
    {	
        gravidade = true;
        velocidade.z = 0f;
		vida = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida >0f){
        if(Input.GetKey(KeyCode.D)){
            velocidade.z = 5f*Time.deltaTime;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }
        if(Input.GetKey(KeyCode.A)){
            velocidade.z = -5f*Time.deltaTime;
            Movimentar(velocidade);
            velocidade.z = 0f;
        }

        if(Input.GetKey(KeyCode.W)){
            velocidade.x = -5f*Time.deltaTime;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }

        if(Input.GetKey(KeyCode.S)){
            velocidade.x = 5f*Time.deltaTime;
            Movimentar(velocidade);
            velocidade.x = 0.0f;
        }
        }
        if(vida <= 0f){
            Morrer(); 
        }
        if (gravidade == false){
            this.GetComponent<Rigidbody>().useGravity = false;
			vida -= 5f*Time.deltaTime;
			GetComponent<Renderer>().material.color = corSecundaria;
            if (Input.GetKey("space")){
                velocidade.y = 5f*Time.deltaTime;
                Movimentar(velocidade);
                velocidade.y = 0.0f;
            }
			if (Input.GetKey(KeyCode.LeftControl)){
                velocidade.y = -5f*Time.deltaTime;
                Movimentar(velocidade);
                velocidade.y = 0.0f;
            }
        }
        if (gravidade == true){
            this.GetComponent<Rigidbody>().useGravity = true;
			GetComponent<Renderer>().material.color = corPrimaria;
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
