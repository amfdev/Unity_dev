using UnityEngine;

public class PlayerController : MonoBehaviour {

    public UnityEngine.Video.VideoPlayer player;
    public AmfUnityPlugin amfPlayer;

    public void Play(string file, RenderMode mode)
    {
        if (mode == RenderMode.Unity)
        {
            amfPlayer.Stop();

            player.url = file;
            player.Play();
        }
        else
        {
            player.Stop();
            Material mat = gameObject.GetComponent<MeshRenderer>().materials[0];
            mat.SetTextureScale("_MainTex", new Vector2(-1, -1));
            amfPlayer.SetFile(file);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
