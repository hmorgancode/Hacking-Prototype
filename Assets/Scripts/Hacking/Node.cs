using UnityEngine;
using System.Collections;
using System.Collections.Generic; //List

//Parent class for individual nodes in the Hacking layer.
[RequireComponent(typeof(NodeEditorAssist))]
public class Node : MonoBehaviour {

  //Keeps track of the width and height of the "canvas" (but is not a capital-C Unity Canvas)
  //(sprite.dimensions.x and .y)
  tk2dSlicedSprite sprite;

  //"Ports" act as entrances and exits (the range is for an easy slider, expand as necessary)
  [Range(1,10)]
  public int numberOfPorts;
  [HideInInspector]
  public List<NodePort> ports;

  void Awake ()
  {
    sprite = GetComponent<tk2dSlicedSprite>();
  }

	// Use this for initialization
	void Start ()
  {
    // to irresponsibly get rid of lack-of-use warning
    sprite.enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
  {

	}
}
