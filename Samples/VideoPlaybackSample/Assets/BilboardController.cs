using UnityEngine.UI;


public class BilboardController : ISceneController{
    // Update is called once per frame

    public Text _text;
    public PlayerController _controller;

    public RenderMode _renderMode;

    void Update () {
		
	}

    public override void SetRenderMode(RenderMode mode)
    {
        _renderMode = mode;
        Play();
    }
    public override RenderMode GetRenderMode()
    {
        return _renderMode;
    }

    void Play()
    {
        _text.text = "";
        DataManager.instance.PrintValues(_text);
        if (DataManager.instance._videoList.Count > 0)
        {
            _controller.Play(DataManager.instance._videoList[0], GetRenderMode());
        }
    }
    void Start()
    {
        Play();
    }
}
 