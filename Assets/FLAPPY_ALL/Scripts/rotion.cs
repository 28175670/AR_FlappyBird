using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class rotion : MonoBehaviour
{
    public Camera cam;

    private void LateUpdate()
    {
        // 禁用攝像機的旋轉
        cam.transform.rotation = Quaternion.identity;
    }

}
