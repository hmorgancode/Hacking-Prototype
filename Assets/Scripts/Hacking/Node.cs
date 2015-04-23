using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NodeEditorAssist))]
public class Node : MonoBehaviour {

  //Parent class for all individual nodes in the Hacking layer.
  //Keeps track of the width and height of the "canvas" (but is not a capital-C Unity Canvas)
  //Keeps a list of the AI units and structures
  //Keeps track of entrances and exits

	// Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
	  if(Debug.isDebugBuild)
    {

    }
	}
}
