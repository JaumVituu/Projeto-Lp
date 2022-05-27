using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour{

    void OnTriggerEnter(Collider colisao){
        Scene currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "Fase 1")
            SceneManager.LoadScene("Fase 2");
        if(currentScene.name == "Fase 2")
            SceneManager.LoadScene("Você Ganhou");
    }

}
