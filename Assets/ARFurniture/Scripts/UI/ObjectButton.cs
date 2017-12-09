using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectButton : MonoBehaviour
{

	private int index = 0;
	private GameObject myObject;

	private Image myImage;
	private Button button;

	private void Awake()
	{
		button = GetComponent<Button>();
		myImage = GetComponent<Image>();
		button.onClick.AddListener(OnClick);
	}

	public void SetButton(int newIndex, GameObject newObject)
	{
		index = newIndex;
		myObject = newObject;
		myImage.sprite = myObject.GetComponent<Furniture>().GetSprite();
	}

	public void OnClick()
	{
		ReferenceHolder.ins._ARController.SetFurntiturePrefab(myObject);
	}

}
