using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Daemon_Interfaces;

namespace Daemon
{

[RequireComponent(typeof(INavigateNodes))]
public class Daemon : MonoBehaviour
{

  // Plan: Interface for each part of AI state machine?


  // gameObject.GetComponents(typeof(IDamageable))
  // or just cast to the interface at runtime i.e. in a function call

  private INavigateNodes navigation;
  private IMove movement;

  void Awake()
  {
    navigation = GetComponents(typeof(INavigateNodes))[0] as INavigateNodes;
    movement = GetComponents(typeof(IMove))[0] as IMove;
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    movement.UpdatePosition(navigation.UpdateNodePath());
  }
}

}
// end namespace Daemon
