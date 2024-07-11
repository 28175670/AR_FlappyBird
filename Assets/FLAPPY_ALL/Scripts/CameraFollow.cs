using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CameraFollow : MonoBehaviour
{
    private ARSessionOrigin arSessionOrigin;
    private Camera arCamera;

    //public Transform targetTransform; // �ؼЪ���Transform
    private float desiredDistance = 7.8f; // ����P�ؼЫO�����Z��

    private void Start()
    {
        // ��� AR Session Origin �M AR �۾�
        arSessionOrigin = GetComponent<ARSessionOrigin>();
        arCamera = arSessionOrigin.camera;
    }

    private void Update()
    {
        // �P�_�O�_�ݭn�վ� AR �۾� Z �b��m
        if (pipepositionmanger.PipePosition != null)
        {
            AdjustARCameraZAxisToTarget();
        }
    }

    private void AdjustARCameraZAxisToTarget()
    {
        // �p�� AR �۾��P�ؼЪ��� Z �b�Z���t
        float distanceDiff = pipepositionmanger.PipePosition.z - arCamera.transform.position.z;

        // �p�G�Z���t�P����Z�����P
        if (Mathf.Abs(distanceDiff) != desiredDistance)
        {
            // �p��s�� AR �۾���m
            Vector3 newPosition = arSessionOrigin.transform.position;
            newPosition.z = pipepositionmanger.PipePosition.z - desiredDistance;

            // ��s AR �۾�����m
            arCamera.transform.position = newPosition;
        }
    }
}
