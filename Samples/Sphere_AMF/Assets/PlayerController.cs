using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

	public GameObject renderObject;

	// Use this for initialization
	void Start () {
		string [] args = System.Environment.GetCommandLineArgs ();
		string file;

		if (args.Length > 1)
		{
			file = args[1];
		}
		else
		{
			string path = Application.dataPath;
			file = "D:/dima/test_assets/360_4k.mp4";//path + "../../../../../default.mp4";
		}
		Amf360UnityPlugin script = renderObject.GetComponent("Amf360UnityPlugin").GetComponent<Amf360UnityPlugin>();
		script.setFile(file);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
