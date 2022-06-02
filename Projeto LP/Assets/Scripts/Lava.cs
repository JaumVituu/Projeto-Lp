using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{   
    public Vector3 escala;
    
    // Update is called once per frame
    void Update()
    {
        Aumenta();
    }
    
    void Aumenta(){
        transform.localScale += escala*Time.deltaTime;
    }

    void OnTriggerEnter(Collider colisao){
        colisao.gameObject.GetComponent<Player>().vida -= 100f;

    }
}
