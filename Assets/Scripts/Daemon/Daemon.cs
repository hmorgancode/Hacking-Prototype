using UnityEngine;
using System.Collections;
using Interfaces;

public class Daemon : MonoBehaviour
{

  // Plan: Interface for each part of AI state machine? INavigable


  // gameObject.GetComponents(typeof(IDamageable))
  // or just cast to the interface at runtime i.e. in a function call

  //private INavigateNodes navigation;

  void Awake()
  {
    //navigation = GetComponents(typeof(INavigateNodes))[0];
  }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
