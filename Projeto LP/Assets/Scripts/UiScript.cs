using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    public GameObject player;
    public Text texto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texto = GetComponent<Text>();
        if (gameObject.tag == "VidaUI"){
            texto.text = "Vida: " + player.GetComponent<Player>().vida.ToString() + "%";
        }
    }
}
