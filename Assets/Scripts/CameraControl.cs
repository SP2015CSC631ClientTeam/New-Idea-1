
using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public float speed = 5.0f;
	int defaultCameraHeight = 50;
	float defaultFOV = 75.0f;
	const float maxFOV = 110.0f;
	const float minFOV = 60.0f;
	float fov;
	Vector3 terrainBoundaries;

	// Use this for initialization
	void Start () {
		fov = defaultFOV;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(new Vector3 (speed*Time.deltaTime, 0, 0));
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(-speed*Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(new Vector3(0,-speed*Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(new Vector3(0,speed*Time.deltaTime,0));
		}
		if (Input.GetKey (KeyCode.Plus)) {
			fov = Camera.main.fieldOfView;
			if(fov < 110.0f)
				Camera.main.fieldOfView = Mathf.Lerp(fov, fov + 1, 1);
		}
		if (Input.GetKey(KeyCode.Minus)) {
			if(fov > 60.0f)
				Camera.main.fieldOfView = Mathf.Lerp(fov, fov - 1, 1);
		}

	}
}
