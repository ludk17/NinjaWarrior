using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaControlador : MonoBehaviour {

	public float velocidad = 10f;

	private Rigidbody2D rigidBody;
	private Animator animator;
	private SpriteRenderer spriteRender;

	private const int ANIMATION_QUIETO = 0;
	private const int ANIMATION_CORRER = 1;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		spriteRender = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		float v = 0;

		animator.SetInteger ("Estado", ANIMATION_QUIETO);

		if (Input.GetKey (KeyCode.RightArrow)) {
			v = velocidad;
			spriteRender.flipX = false;
			animator.SetInteger ("Estado", ANIMATION_CORRER);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			v = velocidad * -1;
			spriteRender.flipX = true;
			animator.SetInteger ("Estado", ANIMATION_CORRER);
		}
		
		rigidBody.velocity = new Vector3 (v, rigidBody.velocity.y);
	}


}
