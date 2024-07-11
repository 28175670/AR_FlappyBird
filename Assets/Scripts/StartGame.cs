using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartGame : MonoBehaviour {
    /// <summary>
    /// 申明一个物体
    /// 从外部指定为小鸟
    /// </summary>
    /// 
    [SerializeField] private float readytime = 3.0f;
    [SerializeField] private UnityEvent Playing;
    [SerializeField] private UnityEvent Startui;
    
    void Start()
    {
        
    }

    /// <summary>
    /// 当鼠标在挂载脚本的物体上按下时 触发该函数
    /// 这里即是点击开始游戏图片时触发
    /// </summary>
    void OnMouseDown()
    {
        //设置游戏的状态为 开始
        GameState.Instance.isPlaying= true;
        //显示小鸟
        Startui.Invoke();
        Invoke("GameReady", 3.0f);

    }
    public void GameReady()
    {
        Playing.Invoke();
    }
}
