using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryMenu : MonoBehaviour {

	[SerializeField]
	private Category[] categories;
	[SerializeField]
	private GameObject buttonPrefab;

	private void Awake()
	{
		InitButtons();
	}

	private void InitButtons()
	{
		for (int i = 0; i < categories.Length; i++)
		{
			var go = Instantiate(buttonPrefab, transform);
			go.GetComponent<CategoryButton>().SetButton(i, categories[i]);
			go.transform.SetParent(transform);
			go.transform.localScale = new Vector3(1, 1, 1);
			go.GetComponent<RectTransform>().localPosition = Vector3.zero;
		}
	}

}
