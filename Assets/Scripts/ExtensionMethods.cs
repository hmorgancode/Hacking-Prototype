using UnityEngine;
using System.Collections;

public static class ExtensionMethods
{
  public static float PIXELS_PER_METER = 128.0f;

  //Snaps any sprite to begin at the nearest pixel.
  public static void SnapToPixelGrid(this Transform transf)
  {
    //Snap camera to pixel boundaries
    transf.position = new Vector3(Mathf.Round(transf.position.x * PIXELS_PER_METER) / PIXELS_PER_METER,
                           Mathf.Round(transf.position.y * PIXELS_PER_METER) / PIXELS_PER_METER,
                           transf.position.z);
  }

}