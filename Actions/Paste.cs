﻿using UnityEngine.VR.Utilities;

namespace UnityEngine.VR.Actions
{
	[ActionMenuItem("Paste", ActionMenuItemAttribute.kDefaultActionSectionName, 6)]
	public class Paste : MonoBehaviour, IAction
	{
		public Sprite icon { get { return m_Icon; } }
		[SerializeField]
		private Sprite m_Icon;

		public static Object buffer { get; set; }

		public bool ExecuteAction()
		{
			//return EditorApplication.ExecuteActionMenuItem("Edit/Paste");

			if (buffer != null)
			{
				var pasted = Instantiate(buffer);
				pasted.hideFlags = HideFlags.None;
				var go = pasted as GameObject;
				if (go)
					go.SetActive(true);
				return true;
			}

			return false;
		}
	}
}