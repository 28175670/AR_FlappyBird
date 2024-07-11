using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipepositionmanger : MonoBehaviour
{
    private static pipepositionmanger _instance;
    public Transform Pipe;
    public static Vector3 PipePosition
    {
        get { return _instance.Pipe.position; }
    }
    // Start is called before the first frame update

    private void Awake()
    {
        _instance = this;
    }
}
