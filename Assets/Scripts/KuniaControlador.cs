using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuniaControlador : MonoBehaviour {

	public float velocidad = 15f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		Destroy (gameObject, 5f);

	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector3 (velocidad, rb.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "Romper")
			Destroy (coll.gameObject);

	}
}
