using UnityEngine;

//If this class gets really big I'm going to give it a person's name.
public static class HelperMethods {

  // Use this for initialization
  public static void Log (object log) {
    if (Debug.isDebugBuild)
    {
      Debug.Log(log);
    } 
  }
}
