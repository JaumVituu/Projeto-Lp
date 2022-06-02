using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    public GameObject player;
    public Text texto;
    float vidaPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaPlayer = player.GetComponent<Player>().vida;
        texto = GetComponent<Text>();
        if (gameObject.tag == "VidaUI"){
            if (vidaPlayer >= 0){
                texto.text = "Vida: " + Mathf.Round(vidaPlayer).ToString() + "%";
            }
            if (vidaPlayer < 0){
                texto.text = "Vida: 0%";
            }
        }
    }
}
