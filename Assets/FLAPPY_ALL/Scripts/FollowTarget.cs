using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    
    public float smoothTime = 0.5f; // 跟隨的平滑時間

    private float velocity = 0f; // 用於 Z 軸平滑移動的速度

    private void Update()
    {
        // 更新當前物件的 Z 軸位置,使其平滑地跟隨目標物件的 Z 軸
        float targetZ = followManger.BirdPosition.z;
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            Mathf.SmoothDamp(transform.position.z, targetZ, ref velocity, smoothTime));

    }
}
