using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesController : MonoBehaviour {

    public Amf360UnityPlugin plugin;

    void Play()
    {
        if (!DataManager.instance)
        {
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
