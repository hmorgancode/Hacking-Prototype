using UnityEngine;
using System.Collections;
using UnityEditor; //PrefabUtility

[ExecuteInEditMode, RequireComponent(typeof(Node)),
                    RequireComponent(typeof(tk2dSlicedSprite))]
public class NodeEditorAssist : MonoBehaviour
{
  #if UNITY_EDITOR //None of this will be present when built.

  Node myNode;
  int lastPortCount = 0; //Set the first time we edit the node's number of ports

	// Will be called whenever something changes in the scene
	void Update ()
  {
    //Disable during the first frame of Play Mode
	  if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
    {
			this.enabled = false;
      return;
		}
    
    //If our node was actually moved/scaled.
    if (transform.hasChanged)
    {
      AdaptSize();
      //The Unity docs imply we need to do this manual reset. Works either way.
      transform.hasChanged = false;
		}

    //Get our Node if we don't already have it.
    if (myNode || (myNode = GetComponent<Node>()))
    {
      //If our port count has changed, add any new ports.
      if (myNode.numberOfPorts != lastPortCount)
      {
        AdjustPortCount();
      }
    }

	}

  //Called when we're changed.
  private void AdaptSize ()
  {
    //Snap us to the pixel grid
    transform.SnapToPixelGrid();

    tk2dSlicedSprite sprite = GetComponent<tk2dSlicedSprite>();
    // In case we're resized, this makes sure that our edges lie on pixel bounds.
    // (This is a 2DToolkit sliced sprite, so it's measured in pixel units)
    sprite.dimensions = new Vector2(Mathf.Round(sprite.dimensions.x), Mathf.Round(sprite.dimensions.y));
    // Make sure that all of our ports remain on the edges of the 'canvas'

  }

  private void AdjustPortCount ()
  {
    //Either add or remove ports until we have as many as were set in the editor
    if (lastPortCount < myNode.numberOfPorts)
    {
      for (int i = lastPortCount; i < myNode.numberOfPorts; ++i)
      {
        //We're guaranteed at least one port by the Node, which we use as our Prefab.
        //GameObject nodeObj = PrefabUtility.InstantiatePrefab(myNode.ports[0].gameObject) as GameObject;
      }
    }
    else
    {
      for (int i = lastPortCount; i > myNode.numberOfPorts; --i)
      {
        Destroy(myNode.ports[i].gameObject);
      }
    }

    //Update our port count
    lastPortCount = myNode.numberOfPorts;
  }
  
  #endif //UNITY_EDITOR
}
