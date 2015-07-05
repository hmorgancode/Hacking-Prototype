using UnityEngine;
using System.Collections;
using System.Collections.Generic; //List

//Parent class for individual nodes in the Hacking layer.
[RequireComponent(typeof(NodeEditorAssist))]
public class Node : MonoBehaviour {

  //Keeps track of the width and height of the "canvas" (but is not a capital-C Unity Canvas)
  //(sprite.dimensions.x and .y)
  tk2dSlicedSprite sprite;

  //"Ports" act as entrances and exits
  [Range(1,5)]
  public int numberOfPorts;
  public List<NodePort> ports;

  //Keeps a list of the AI units and structures

  void Awake ()
  {
    sprite = GetComponent<tk2dSlicedSprite>();
  }

	// Use this for initialization
	void Start ()
  {
	  
	}
	
	// Update is called once per frame
	void Update ()
  {
    
	}
}
