using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceHolder : MonoBehaviour
{

	public static ReferenceHolder ins;

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

	//#####################################################//

	public ARController _ARController;
	public CategoryMenu _categoryMenu;
	public ObjectMenu _objectMenu;

	public UIPanel _objectMenuUIPanel;

}
