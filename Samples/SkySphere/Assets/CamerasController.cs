using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour {

	// Use this for initialization
    void Start () { 
		Cursor.visible = false;
    }
	
  	public float   sensitivity = 5F;
	public float step = 50f;
	// Update is called once per frame
	void Update () {
	}

	void LateUpdate () {
		float x = Input.GetAxis("Mouse X") * sensitivity;
		float y = - Input.GetAxis("Mouse Y") * sensitivity;	 

		transform.RotateAround(transform.position, Vector3.up, x);
		transform.RotateAround(transform.position, transform.right, y);	

		transform.Translate (new Vector3 (Input.GetAxis("Horizontal") * step * Time.deltaTime, 0, Input.GetAxis("Vertical") * step * Time.deltaTime));

	}
}
