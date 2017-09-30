using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMov : MonoBehaviour {

	private Rigidbody rb;
	private float speedforce = 10f;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector3(-Input.GetAxis("Horizontal")*speedforce,0f,0f);
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Respawn"){
			Destroy(gameObject);
			Time.timeScale = 0f;
		}
	}
}
