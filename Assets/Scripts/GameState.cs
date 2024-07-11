using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    /// <summary>
    /// 申明该类的单例
    /// 其他类可以使用 GameState.Instance.来访问本类的公共字段、属性、方法等
    /// </summary>
    public static GameState Instance;
    /// <summary>
    /// 游戏是否结束
    /// </summary>
    public bool isPlaying;

    void Awake()
    {
        //实现单例
        Instance = this;
    }
}
