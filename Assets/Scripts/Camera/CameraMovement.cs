using UnityEngine;
using System.Collections;

//using UnityStandardAssets.ImageEffects; //Motion bluuuur

[RequireComponent(typeof(CameraEditorAssist))]
public class CameraMovement : MonoBehaviour {
  public float PIXELS_PER_SECOND;


  // When this object becomes active
  void OnEnable()
  {
  }
  // When this object becomes inactive
  void OnDisable()
  {
  }

  // Called before Start, just after instantiation, or whenever object is first enabled
  void Awake()
  {

  }

	// Use this for initialization
  //Called just before the first frame update, IF object is enabled
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
	  //dt = Time.deltaTime

    Vector3 newPosition = transform.position;
    if (Input.GetKey(KeyCode.A))
    {
      newPosition.x -= PIXELS_PER_SECOND * Time.deltaTime;
    }
    else if (Input.GetKey(KeyCode.D))
    {
      newPosition.x += PIXELS_PER_SECOND * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.W))
    {
      newPosition.y += PIXELS_PER_SECOND * Time.deltaTime;
    }
    else if (Input.GetKey(KeyCode.S))
    {
      newPosition.y -= PIXELS_PER_SECOND * Time.deltaTime;
    }

    if (newPosition.x < 0.0f)
      newPosition.x = 0.0f;
    if (newPosition.y < 0.0f)
      newPosition.y = 0.0f;

    transform.position = newPosition;
	}

  // Called after Update is finished on every object in-game
  void LateUpdate()
  {
    transform.SnapToPixelGrid();    
  }

  //All physics calculations and updates
  void FixedUpdate()
  {
    //Use Time.fixedDeltaTime to get time between physics steps
  }
}
