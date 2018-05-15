using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initPlayer : MonoBehaviour {

	public UnityEngine.Video.VideoPlayer player;

	// Use this for initialization
	void Start () {
		string [] args = System.Environment.GetCommandLineArgs ();

		if (args.Length > 1)
		{
			player.url = args[1];
		}
		else
		{
			string path = Application.dataPath;
			player.url = path + "../../../../default.mp4";
		}

		player.Play();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
