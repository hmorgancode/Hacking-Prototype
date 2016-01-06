using UnityEngine;
using System.Collections;

namespace Daemon_Interfaces
{

// Methods for moving between nodes in a network
public interface INavigateNodes
{
  // Get the vector we should move along
  Vector2 UpdateNodePath();
}

// Different methods of Daemon movement (picture straightforward movement,
// short-range jumps, transparency, etc...)
public interface IMove
{
  // Adjust our position
  void UpdatePosition(Vector2 path);
}

// Different interfaces for moving between and within nodes? Add that later if it becomes relevant.

}