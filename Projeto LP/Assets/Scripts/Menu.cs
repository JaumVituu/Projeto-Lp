using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PassarFase(){
        SceneManager.LoadScene("Fase 1");
    }
    public void Sair(){
        Application.Quit();
    }
    public void IrMenu(){
        SceneManager.LoadScene("Menu");
    }
}
