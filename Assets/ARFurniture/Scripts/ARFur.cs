using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARFur
{

	interface IUserInterfaceElement
	{
		Animator UIAnimator
		{
			get;
		}
		void Show();
		void Hide();
	}

	public delegate void UIHandler();

}
