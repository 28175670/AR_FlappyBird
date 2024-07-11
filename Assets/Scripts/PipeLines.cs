using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLines : MonoBehaviour {
    //生成管道时 管道初始坐标的X轴
    public float  InitPosX;
    //生成管道的速度
    public float Speed;
    //管道坐标的Y轴
    private float InitPosY;
    //所有已经生成了的管道集合
    private List<GameObject> PipeList;
    void Start()
    {   
        //初始化集合
        PipeList = new List<GameObject>();
        //重复定时器
        //参数为（需要执行的函数名，延时执行时间，执行的间隔时间）
        //1秒后执行CreatePipe（）函数，之后每“Speed”秒后执行一次
        InvokeRepeating("CreatePipe", 1, Speed);

    }
    void CreatePipe()
    {
        //若游戏运行中
        if (!GameState.Instance.isPlaying)
        {
            //如果管道集合中的管道大于3个时执行
            //防止管道无控制一直生成
            if (PipeList.Count > 3)
            {
                //销毁集合中最初的一个管道
                Destroy(PipeList[0]);
                //将集合中最初的管道从集合中移除
                PipeList.RemoveAt(0);
            }
            //从“Project”的“Resources”文件夹中加载一个名为“Pipe”的“GameObject”类型物体
            GameObject go = Resources.Load<GameObject>("Pipe");
            //实例化该物体
            go = Instantiate(go);
            //设置该物体的父物体为“PipeLines”
            go.transform.SetParent(this.transform);
            //设置该物体的坐标
            //Random.Range(min,max) 从min与max两个浮点数中随机一个浮点数
            //这里minx与max为-2.4、1.5 是源自管道“Pipe”在场景中能被看到的最大值与最小值
            //让每此生成的物体 Y 轴的坐标都不一样 让游戏更有可玩性
            go.transform.position = new Vector3(InitPosX, Random.Range(-2.4f, 1.5f))+this.transform.position;
            //将生成的物体放入集合中
            PipeList.Add(go);
        }
    }
}
