using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public static GameController ins;

	private void Awake()
	{
		if (ins == null)
		{
			ins = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	//#####################################################

	public void ToggleMenu(GameObject menu)
	{
		menu.SetActive(!menu.activeSelf);
	}

}
