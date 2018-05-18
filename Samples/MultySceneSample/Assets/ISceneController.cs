using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RenderMode
{
    Unity,
    AMF,

    None
};


public abstract class ISceneController : MonoBehaviour
{
    public virtual void SetRenderMode(RenderMode mode) { }
    public virtual RenderMode GetRenderMode() { return RenderMode.None; }
}


