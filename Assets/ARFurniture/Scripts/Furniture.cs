using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{

	[SerializeField]
	private Sprite mySprite;

	public Sprite GetSprite()
	{
		return mySprite;
	}

}
