using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject Pumpkin;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnPumkin());
	}
	IEnumerator SpawnPumkin(){
		yield return new WaitForSeconds(Random.Range(1f,3f));
		Instantiate(Pumpkin,spawnPoints[Random.Range(0,spawnPoints.Length)].position,Quaternion.identity);
		StartCoroutine(SpawnPumkin());
	}	
	// Update is called once per frame
}
