using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCameraController : MonoBehaviour {

    // Use this for initialization
    private bool mouseControl = false; 

    void Start () { 

    }
	
  	public float   sensitivity = 5F;
	public float step = 20f;
	// Update is called once per frame
	void Update () {
	}

    void ToggleMouseControl()
    {
        mouseControl = !mouseControl;
        Cursor.visible = !mouseControl;
    }

	void LateUpdate () {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
            ToggleMouseControl();


        float x = 0;
        float y = 0;

        if (mouseControl)
        {
            x = Input.GetAxis("Mouse X") * sensitivity;
            y = -Input.GetAxis("Mouse Y") * sensitivity;

            transform.RotateAround(transform.position, Vector3.up, x);
            transform.RotateAround(transform.position, transform.right, y);

            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * step * Time.deltaTime, 0, Input.GetAxis("Vertical") * step * Time.deltaTime));
        }
        

        x = Input.GetAxis("Mouse Arrows X") * sensitivity;
        y = -Input.GetAxis("Mouse Arrows Y") * sensitivity;

        transform.RotateAround(transform.position, Vector3.up, x);
        transform.RotateAround(transform.position, transform.right, y);

        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * step * Time.deltaTime, 0, Input.GetAxis("Vertical") * step * Time.deltaTime));

    }
}
