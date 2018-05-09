using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour {

	public Transform ninja;

	private Transform camara;

	// Use this for initialization
	void Start () {
		camara = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		// si quiero que la camara siga al nija solo en x
		camara.position = new Vector3 (ninja.position.x, camara.position.y , camara.position.z);

	}
}
