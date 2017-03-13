using UnityEngine;
using System.Collections;

public class WorldDrag : MonoBehaviour {

	private int myCase;
	private Vector2 oldMousePos;
	private float boundsX;
	private float boundsZ;
	private float boundsY = 19;

	private Camera camera;

	[SerializeField]
	private float speed = 1;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		//Debug.Log (Application.platform);
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			myCase = 2;
		} else {

			//Debug.Log ("yeah yeah");
			myCase = 1;
		}

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		switch (myCase) {
		case 1:
			//Debug.Log (Input.mouseScrollDelta);
			if (Input.GetMouseButtonDown (0)) {
				oldMousePos = Input.mousePosition;
			} else if (Input.GetMouseButton (0)) {
				Vector2 newMousePos = Input.mousePosition;
				Vector3 Displacement = new Vector3 ((newMousePos.x - oldMousePos.x) * -speed, 0, (newMousePos.y - oldMousePos.y) * -speed);
				//Displacement.y = 
				transform.position = transform.position + Displacement;
				oldMousePos = newMousePos;
				//Debug.Log (Displacement);
			}
			Vector3 temp = transform.position;
			temp.y += -Input.mouseScrollDelta.y;
			transform.position = temp;
			break;
		case 2:
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
				// Get movement of the finger since last frame
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

				// Move object across XY plane
				transform.Translate(-touchDeltaPosition.x * speed * Time.deltaTime, -touchDeltaPosition.y * speed * Time.deltaTime, 0);
			}
			break;
		}

		boundsX = Mathf.Tan(camera.fieldOfView * Mathf.Deg2Rad / 2 * camera.aspect) * ((boundsY * 2) - transform.position.y);
		boundsZ =  Mathf.Tan(camera.fieldOfView * Mathf.Deg2Rad / 2) * ((boundsY * 2) - transform.position.y);
		//Debug.Log (gameObject.GetComponent<Camera>().aspect);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -boundsX, boundsX), Mathf.Clamp(transform.position.y, 3, 19), Mathf.Clamp(transform.position.z, -boundsZ, boundsZ));
	}
}
