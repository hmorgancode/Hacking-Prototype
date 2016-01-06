using UnityEngine;
using System.Collections;
using Daemon_Interfaces;

namespace Daemon
{

// Finds the node horizontally closest to the player and returns a vector to it
public class Navigation_SimpleFollow : MonoBehaviour, INavigateNodes
{

  private GameObject player;

  void Awake()
  {
    player = GameObject.FindWithTag("Player");
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public Vector2 UpdateNodePath()
  {
    // Find the node nearest the player
    // (just iterate through a list and get the optimal solution later)
    // but for now just follow them!
    Vector3 toPlayer = Vector3.Normalize(new Vector3(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y));
    return new Vector2(toPlayer.x, toPlayer.y);
  }

}

}
