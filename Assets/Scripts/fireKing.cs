using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireKing : MonoBehaviour {

public GameObject bulletPrefab;
	public float bulletSpeed = 10.0f;
	private GameObject bulletSpawn;
	
	// Use this for initialization
	void Start () {
		bulletSpawn = GameObject.Find("KingSpawn");

	}
	
	// Update is called once per frame
	void Update () {
		if((this.gameObject.transform.position.y<1)&&(Input.GetButtonDown("Fire1")))
		{
			GameObject tempBullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, Quaternion.identity);
			tempBullet.GetComponent<Rigidbody>().velocity = -bulletSpawn.transform.up*bulletSpeed;
			
		}
	}
}
