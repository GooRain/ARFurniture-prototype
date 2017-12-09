using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryButton : MonoBehaviour
{

	[SerializeField] private Text buttonName;

	private int index = 0;
	private Button button;
	private Category category;

	private void Awake()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(OnClick);
	}

	public void SetButton(int newIndex, Category category)
	{
		this.category = category;
		index = newIndex;
		buttonName.text = category.categoryName;
	}

	public void OnClick()
	{
		ReferenceHolder.ins._objectMenu.SelectCategory(category);
	}

}
