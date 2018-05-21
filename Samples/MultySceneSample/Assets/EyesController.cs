using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesController : MonoBehaviour {

    public Amf360UnityPlugin plugin;

    void Play()
    {
        if (!DataManager.instance)
        {
            plugin.SetFile("D:/Work/test_assets/360.mp4");
            print("Is Null");
            return;
        }
        if (DataManager.instance._360videoList.Count > 0)
        {
            plugin.SetFile(DataManager.instance._360videoList[0]);
        }
    }
    // Use this for initialization
    void Start () {
        Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
