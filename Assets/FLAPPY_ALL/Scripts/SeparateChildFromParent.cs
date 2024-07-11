using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateChildFromParent : MonoBehaviour
{
    public Transform childToSeparate; // �n�������l����

    private void Start()
    {
        // �b Start() ��Ƥ��������w���l����
        SeparateChildTransformFromParent();
    }

    private void SeparateChildTransformFromParent()
    {
        // �T�O�n�������l���󤣬���
        if (childToSeparate != null)
        {
            // �O���l����۹������󪺥��a��m�M����
            Vector3 localPosition = childToSeparate.localPosition;
            Quaternion localRotation = childToSeparate.localRotation;

            // �N�l����q�����󤤤���
            childToSeparate.SetParent(null);

            // �]�m�l���󪺦�m�M���ର���e�O�������a��
            childToSeparate.localPosition = localPosition;
            childToSeparate.localRotation = localRotation;
        }
    }
}
