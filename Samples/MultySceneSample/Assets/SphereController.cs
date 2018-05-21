using UnityEngine.UI;

public class SphereController : ISceneController
{

    public Text _text;
    public PlayerController _controller;

    public RenderMode _renderMode;

    void Update()
    {

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
        if (DataManager.instance._360videoList.Count > 0)
        {
            _controller.Play(DataManager.instance._360videoList[0], GetRenderMode());
        }
    }
    void Start()
    {
        Play();
    }
}
