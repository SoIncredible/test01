using UnityEngine;
using System.Collections;
using HighlightingSystem;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace HighlightingSystem.Demo
{
	[System.Obsolete]
	public class HighlighterInteractive : MonoBehaviour
	{
		public bool seeThrough = true;
	}

	#if UNITY_EDITOR
	[System.Obsolete]
	[CustomEditor(typeof(HighlighterInteractive))]
	public class HighliterInteractiveEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.HelpBox("Component deprecated. Press upgrade button to automatically convert it.", MessageType.Warning);

			if (GUILayout.Button("Upgrade", GUILayout.Height(30f)))
			{
				HighlightingUpgrade.Upgrade((target as MonoBehaviour).transform);
			}
		}
	}
	#endif
}