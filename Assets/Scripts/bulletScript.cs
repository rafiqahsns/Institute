using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
	
	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this.gameObject);
		if(collision.gameObject.CompareTag("tower"))
		{
			Destroy(collision.gameObject);
		}
		if(collision.gameObject.CompareTag("obstacle"))
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
	void Update()
	{
		if(this.gameObject.transform.position.z>=30){
	
			Destroy(this.gameObject);
		}
	}

}
