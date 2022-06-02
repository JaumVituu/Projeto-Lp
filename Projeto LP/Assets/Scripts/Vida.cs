using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
	void Update()
	{	
		transform.Rotate(0,30f *Time.deltaTime,0);
	}
	
    void OnTriggerEnter(Collider colisao){
		if(colisao.gameObject.name =="Player"){
			colisao.GetComponent<Player>().vida += 50f;	
			Destroy(gameObject);
		}
	}
}
