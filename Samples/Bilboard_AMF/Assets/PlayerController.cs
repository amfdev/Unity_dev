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
			file = path + "../../../../../default.mp4";
		}
		AmfUnityPlugin script = renderObject.GetComponent("AmfUnityPlugin").GetComponent<AmfUnityPlugin>();
		script.setFile(file);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
