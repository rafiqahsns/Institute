using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject bulletPrefab;
	public float bulletSpeed = 10.0f;
	private GameObject bulletSpawn;
	
	// Use this for initialization
	void Start () {
		bulletSpawn = GameObject.Find("BulletSpawn");
		print("hey");
	}
	
	// Update is called once per frame

	public void Jump(){
         Vector3 up = transform.TransformDirection(Vector3.up);
         this.GetComponent<Rigidbody>().AddForce (up * 5, ForceMode.Impulse);
     }

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
                 Jump();
         }
		if(Input.GetButtonDown("Fire1"))
		{
			GameObject tempBullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, Quaternion.identity);
			tempBullet.GetComponent<Rigidbody>().velocity = bulletSpawn.transform.up*bulletSpeed;
		}
	}
}
