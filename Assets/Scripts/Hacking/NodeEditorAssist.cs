using UnityEngine;
using System.Collections;

[ExecuteInEditMode, RequireComponent(typeof(Node)), RequireComponent(typeof(tk2dSlicedSprite))]
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
    transform.SnapToPixelGrid();

    tk2dSlicedSprite sprite = GetComponent<tk2dSlicedSprite>();
    //In case we're resized, this makes sure that our edges lie on pixel bounds.
    sprite.dimensions = new Vector2(Mathf.Round(sprite.dimensions.x), Mathf.Round(sprite.dimensions.y));
    //Make sure that all of our ports remain on the edges of the 'canvas'

    //It got reset in the editor automatically when I wrote this, but that behavior was undocumented.
    transform.hasChanged = false;
  }
  
  #endif
}
