using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraEditorAssist : MonoBehaviour
{

	#if UNITY_EDITOR //None of this will be present when built.

	// Will be called whenever something changes in the scene (so, whenever you edit)
	void Update ()
  {
    //Disable during the first frame of Play Mode
	  if(UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
    {
			this.enabled = false;
		}
    else if (transform != null && transform.hasChanged)
    {
      transform.SnapToPixelGrid();
		}
	}
	
  #endif
}
