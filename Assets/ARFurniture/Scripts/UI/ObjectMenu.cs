using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMenu : MonoBehaviour
{

	private Category selectedCategory;
	public GameObject[] objectsButtons;

	[SerializeField]
	private GameObject objectButtonPrefab;

	private void Awake()
	{
		objectsButtons = new GameObject[10];
	}

	public void SelectCategory(Category newCategory)
	{
		selectedCategory = newCategory;
		ClearObjects();
		AddObjects();
		ReferenceHolder.ins._objectMenuUIPanel.Show();
	}

	public void AddObjects()
	{
		objectsButtons = new GameObject[selectedCategory.objects.Length];
		for (int i = 0; i < selectedCategory.objects.Length; i++)
		{
			var go = Instantiate(objectButtonPrefab, transform);
			go.GetComponent<ObjectButton>().SetButton(i, selectedCategory.objects[i]);
			go.transform.SetParent(transform);
			go.transform.localScale = new Vector3(1, 1, 1);
			go.GetComponent<RectTransform>().localPosition = Vector3.zero;
			objectsButtons[i] = go;
		}
	}

	public void ClearObjects()
	{
		for (int i = 0; i < objectsButtons.Length; i++)
		{
			Destroy(objectsButtons[i]);
		}
	}

}
