using UnityEngine;
using System.Collections;

namespace Daemon
{

// Methods for moving between nodes in a network
public interface INavigateNodes
{
  void getNodePath();
}

public interface IMove
{
  void updatePosition();
}

}