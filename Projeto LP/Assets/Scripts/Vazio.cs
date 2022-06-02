using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vazio : MonoBehaviour
{
    void OnCollisionEnter(Collision colisao){
		if(colisao.gameObject.name == "Player"){
			SceneManager.LoadScene("Fim de jogo");
		}
	}
}
