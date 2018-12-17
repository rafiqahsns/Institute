using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class kingScript : MonoBehaviour {
	
	 int blood=10;
	void OnCollisionEnter(Collision collision)
	{

		if(collision.gameObject.CompareTag("bullet"))
		{

			blood=blood-1;
		}
		if(blood==0)
		{
			Destroy(this.gameObject);
			 GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle");
   			foreach(GameObject obstacle in obstacles)
   			GameObject.Destroy(obstacle);
		}
	}
}
