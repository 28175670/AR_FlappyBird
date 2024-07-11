using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    
    public float smoothTime = 0.5f; // ���H�����Ʈɶ�

    private float velocity = 0f; // �Ω� Z �b���Ʋ��ʪ��t��

    private void Update()
    {
        // ��s��e���� Z �b��m,�Ϩ䥭�Ʀa���H�ؼЪ��� Z �b
        float targetZ = followManger.BirdPosition.z;
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            Mathf.SmoothDamp(transform.position.z, targetZ, ref velocity, smoothTime));

    }
}
