using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour {

	// Use this for initialization
    void Start () { 
		_camera.transform.LookAt(target.transform);
    }
	
  	public float   sensitivity = 5F;
	public float scrollSpeed = 10.0f;
	public float zoomMin = 0.01f;
	public float zoomMax = 200.0f;

	public bool isActivated;

	public GameObject target;
  	public Camera  _camera;

	// Update is called once per frame
	void Update () {
	}

	void LateUpdate () {
		if (Input.GetMouseButtonDown(1)){
			isActivated = true;
		} 

		if (Input.GetMouseButtonUp(1))
		{
			isActivated = false;
		} 

	    if (isActivated) { 
			float x = Input.GetAxis("Mouse X") * sensitivity;
	        float y = Input.GetAxis("Mouse Y") * sensitivity;	 

			_camera.transform.RotateAround(target.transform.position,transform.up, x);
			// _camera.transform.RotateAround(target.transform.position,transform.right, y);
		} else {		
	 		if (Input.GetAxis("Mouse ScrollWheel") != 0) 
 
			{	
				// get the distance between camera and target
				float distance = Vector3.Distance (_camera.transform.position , target.transform.position);	

				// get mouse wheel info to zoom in and out	
				distance = ZoomLimit(distance - Input.GetAxis("Mouse ScrollWheel") * scrollSpeed, zoomMin, zoomMax);

				// position the camera FORWARD the right distance towards target
 		        _camera.transform.position = -(_camera.transform.forward * distance) + target.transform.position;
			}
 
		}
	}

	public static float ZoomLimit(float dist, float min, float max)
    {
        if (dist < min)
            dist= min;
 
        if (dist > max)
            dist= max; 

		return dist;
    }
}
