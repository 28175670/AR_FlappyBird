using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class rotion : MonoBehaviour
{
    public Camera cam;

    private void LateUpdate()
    {
        // �T���ṳ��������
        cam.transform.rotation = Quaternion.identity;
    }

}
