using UnityEngine;
using UnityEngine.UI;

public class MetticsController : MonoBehaviour {

    private ISceneController _sceneController;
    public GameObject _controllerHolder;
    public Text _text;
    public Text _helpText;

    public void SwitchRenderMode()
    {
        if (_sceneController.GetRenderMode() == RenderMode.Unity)
        {
            _sceneController.SetRenderMode(RenderMode.AMF);
            _text.text = "AMF";
        }
        else
        {
            _sceneController.SetRenderMode(RenderMode.Unity);
            _text.text = "Unity";
        }
    }
	// Use this for initialization
	void Start () {
        _sceneController = _controllerHolder.GetComponent<ISceneController>();
        _helpText.text = "Press <b>Ctrl</b> to toggle mouse control\n" +
                         "Press <b>AWSD</b> to move\n" +
                         "<b>Arrows</b> to rotate camera\n";
        if (_sceneController.GetRenderMode() == RenderMode.AMF)
        {
            _text.text = "AMF";
        }
        else
        {
            _text.text = "Unity";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
