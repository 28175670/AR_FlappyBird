using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateChildFromParent : MonoBehaviour
{
    public Transform childToSeparate; // 要分離的子物件

    private void Start()
    {
        // 在 Start() 函數中分離指定的子物件
        SeparateChildTransformFromParent();
    }

    private void SeparateChildTransformFromParent()
    {
        // 確保要分離的子物件不為空
        if (childToSeparate != null)
        {
            // 記錄子物件相對於父物件的本地位置和旋轉
            Vector3 localPosition = childToSeparate.localPosition;
            Quaternion localRotation = childToSeparate.localRotation;

            // 將子物件從父物件中分離
            childToSeparate.SetParent(null);

            // 設置子物件的位置和旋轉為之前記錄的本地值
            childToSeparate.localPosition = localPosition;
            childToSeparate.localRotation = localRotation;
        }
    }
}
