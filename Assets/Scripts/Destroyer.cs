using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	void Update () {
		if(gameObject.transform.position.y <= -4)
		{
			Destroy(gameObject);
		}
	}
}
