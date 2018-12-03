using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this.gameObject);
		print("hi");
		if(collision.gameObject.CompareTag("tower"))
		{
			Destroy(collision.gameObject);
			print("hi");
		}
	}
}
