using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadBilboard() {
        SceneManager.LoadScene("Bilboard", LoadSceneMode.Single);
    }
    public void LoadSphere()
    {
        SceneManager.LoadScene("Sphere", LoadSceneMode.Single);
    }
    public void LoadSkySphere()
    {
        SceneManager.LoadScene("SkySphere", LoadSceneMode.Single);
    }
    public void Load2Eyes()
    {
        //SceneManager.LoadScene("2Eyes", LoadSceneMode.Single);
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
