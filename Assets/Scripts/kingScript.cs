using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kingScript : MonoBehaviour {
	private int blood=50;
	private void OnCollisionEnter(Collision collision)
	{
		
		if(collision.gameObject.CompareTag("bullet"))
		{
			blood=blood-1;
		}
		if(blood==0)
		{
			Destroy(this.gameObject);
		}
	}
}
