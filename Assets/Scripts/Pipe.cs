using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {
    //运动速度
    public float Speed;
	void Update ()
    {
        //若游戏处于运行中
        if (!GameState.Instance.isPlaying)
        {
            //物体向X方向移动
            transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
        }
    }
}
