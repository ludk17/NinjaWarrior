using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {


	float velocidad = 3f;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (velocidad, 0);
	}

	void OnCollisionEnter2D(Collision2D coll) {



		if (coll.gameObject.tag == "Caja")
			velocidad = velocidad * -1;

	}
}
