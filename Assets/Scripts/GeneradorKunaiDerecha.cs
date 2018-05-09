using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorKunaiDerecha : MonoBehaviour {
	
	public GameObject kunai;

	public void Lanzar()
	{
		Instantiate (kunai, transform.position, Quaternion.identity);
	}

}
