using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followManger : MonoBehaviour
{
    private static followManger _instance;
    public Transform flybird;
    public static Vector3 BirdPosition
    {
        get { return _instance.flybird.position; }
    }
    // Start is called before the first frame update
 
    private void Awake()
    {
        _instance = this;
    }
}
