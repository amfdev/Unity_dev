using UnityEngine;

public class PlayerController : MonoBehaviour {

    public UnityEngine.Video.VideoPlayer player;
    public AmfUnityPlugin amfPlayer;

    public void Play(string file, RenderMode mode)
    {
        if (mode == RenderMode.Unity)
        {
            amfPlayer.Stop();
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            if (!audioSource)
                audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.volume = 1.0f;
            audioSource.spatialBlend = 1.0f;
            audioSource.ignoreListenerVolume = false;
            audioSource.loop = true;
            audioSource.maxDistance = 10;

            player.url = file;
            player.Prepare();

            player.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
            player.SetTargetAudioSource(0, audioSource);
            player.EnableAudioTrack(0, true);
            player.controlledAudioTrackCount = 1;

            player.Stop();
            player.Play();
            audioSource.Play();
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
