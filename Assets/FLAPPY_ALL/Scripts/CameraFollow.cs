using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CameraFollow : MonoBehaviour
{
    private ARSessionOrigin arSessionOrigin;
    private Camera arCamera;

    //public Transform targetTransform; // 目標物件的Transform
    private float desiredDistance = 7.8f; // 期望與目標保持的距離

    private void Start()
    {
        // 獲取 AR Session Origin 和 AR 相機
        arSessionOrigin = GetComponent<ARSessionOrigin>();
        arCamera = arSessionOrigin.camera;
    }

    private void Update()
    {
        // 判斷是否需要調整 AR 相機 Z 軸位置
        if (pipepositionmanger.PipePosition != null)
        {
            AdjustARCameraZAxisToTarget();
        }
    }

    private void AdjustARCameraZAxisToTarget()
    {
        // 計算 AR 相機與目標物件的 Z 軸距離差
        float distanceDiff = pipepositionmanger.PipePosition.z - arCamera.transform.position.z;

        // 如果距離差與期望距離不同
        if (Mathf.Abs(distanceDiff) != desiredDistance)
        {
            // 計算新的 AR 相機位置
            Vector3 newPosition = arSessionOrigin.transform.position;
            newPosition.z = pipepositionmanger.PipePosition.z - desiredDistance;

            // 更新 AR 相機的位置
            arCamera.transform.position = newPosition;
        }
    }
}
