using UnityEngine;
using System.Collections;

[ExecuteInEditMode, RequireComponent(typeof(tk2dSlicedSprite))]
public class NodeEditorAssist : MonoBehaviour
{
  #if UNITY_EDITOR //None of this will be present when built.

	// Will be called whenever something changes in the scene (so, whenever you edit)
	void Update ()
  {
    //Disable during the first frame of Play Mode
	  if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
    {
			this.enabled = false;
		}
    else if (transform != null && transform.hasChanged)
    {
      Refresh();
		}
	}

  //Called when we're changed.
  private void Refresh ()
  {
    //Snap us to the pixel grid
    if (transform != null)
    {
      //transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y),transform.position.z);
      transform.SnapToPixelGrid();
    }

    //If we're resized, this makes sure that our edges lie on pixel bounds.
    tk2dSlicedSprite sprite = GetComponent<tk2dSlicedSprite>();
    if (sprite != null) //This shouldn't be necessary with RequireComponent up top, but this (maybe) got rid of a harmless-seeming error
    {
      sprite.dimensions = new Vector2(Mathf.Round(sprite.dimensions.x), Mathf.Round(sprite.dimensions.y));
    }
    
    transform.hasChanged = false; //It got reset in the editor automatically when I wrote this, but that behavior was undocumented.
    HelperMethods.Log(sprite.dimensions.x);
  }
  
  #endif
}
