﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour {

	public void IniciarNivel(string scene)
	{
		SceneManager.LoadScene (scene);
	}

}