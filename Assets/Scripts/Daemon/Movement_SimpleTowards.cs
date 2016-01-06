using UnityEngine;
using System.Collections;
using Daemon_Interfaces;

namespace Daemon
{

public class Movement_SimpleTowards : MonoBehaviour, IMove
{

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void UpdatePosition(Vector2 path)
  {
    transform.position = transform.position + new Vector3(path.x * Time.deltaTime, path.y * Time.deltaTime);
  }
}

}