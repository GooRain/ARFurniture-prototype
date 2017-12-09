using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ARFur;

public class UIPanel : MonoBehaviour
{

	private Animator anim;

	[SerializeField]
	private GameObject myMenu;

	public event UIHandler OnHide = () => { };

	private void Awake()
	{
		anim = GetComponent<Animator>();
	}

	public Animator UIAnimator
	{
		get
		{
			if (anim == null)
			{
				anim = GetComponent<Animator>();
			}
			return anim;
		}
	}

	public void Show()
	{
		if (!UIAnimator.GetBool("IsOpen"))
		{
			UIAnimator.SetBool("IsOpen", true);
		}
	}

	public void Hide()
	{
		if (UIAnimator.GetBool("IsOpen"))
		{
			UIAnimator.SetBool("IsOpen", false);
			OnHide();
		}
	}

	public void Toggle()
	{
		if (UIAnimator.GetBool("IsOpen"))
		{
			Hide();
		}
		else
		{
			Show();
		}
	}

	public void ChangeCullingMode(AnimatorCullingMode newMode)
	{
		anim.cullingMode = newMode;
	}

}
