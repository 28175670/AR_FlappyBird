using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour {
    /// <summary>
    /// 申明一个UV运动时的速度
    /// </summary>
    public Vector2 Speed = new Vector2(1, 0);
    /// <summary>
    /// UV运动的值
    /// </summary>
    private Vector2 offsetVec2 = Vector2.zero;
    /// <summary>
    /// 需要进行UV运动的材质球
    /// </summary>
    private Material mat;

    void Start()
    {
        //指定材质球为挂载本脚本物体上的材质球
        mat = this.GetComponent<Renderer>().material;
    }
    void Update()
    {
        //若游戏处于运行中执行
        if (!GameState.Instance.isPlaying)
        {
            //在每一帧中 偏移值等于原始的偏移值加上速度乘以增量时间
            offsetVec2 += (Speed * Time.deltaTime);
            //设置材质球的UV运动
            //参数为（贴图，偏移的位置）
            mat.SetTextureOffset("_MainTex", offsetVec2);
        }
    }
}
