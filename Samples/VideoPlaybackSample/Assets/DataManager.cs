using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public Text _text;


    public static DataManager instance;

    public List<string> _videoList;
    public List<string> _360videoList;

    void Start()
    {
        string[] args = System.Environment.GetCommandLineArgs();

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-v" && i < args.Length - 1)
            {
                _videoList.Add(args[i + 1]);
            }
            else if (args[i] == "-v360" && i < args.Length - 1)
            {
                _360videoList.Add(args[i + 1]);
            }
        }
        

        if (_videoList.Count < 1 && _360videoList.Count < 1)
        {
            string path = Application.dataPath;
            _videoList.Add(path + "/../../../../Samples/default.mp4");
            _360videoList.Add(path + "/../../../../Samples/default.mp4");
        }
        else if (_360videoList.Count < 1)
        {
            _360videoList.Add(_videoList[0]);
        }
        else
        {
            _videoList.Add(_360videoList[0]);
        }


        PrintValues(_text);
    }

    void Awake()
    { 
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void PrintValues(Text text)
    {
        if (text)
        {
            text.text += "VideoList: \n    " + string.Join("\n    ", _videoList.ToArray()) + "\n";
            text.text += "360VideoList: \n    " + string.Join("\n    ", _360videoList.ToArray()) + "\n";
        }
    }
}