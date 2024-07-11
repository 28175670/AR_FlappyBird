using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Bird : MonoBehaviour {
    /// <summary>
    /// 声明游戏分数的TextMesh
    /// </summary>
    public TextMesh ScoreText;
    /// <summary>
    /// 申明一个游戏物体
    /// 此处由外部指定 指定为游戏结束界面 即“GameOver”物体
    /// </summary>
    public GameObject GameOverGo;
    /// <summary>
    /// 声明一个刚体rig
    /// </summary>
    private Rigidbody2D rig;
    /// <summary>
    /// 声明一个整数的分数
    /// </summary>
    private int score;



    void Start () {
        //指定rig为“bird”的组件 Rigidbody2D
        rig = this.GetComponent<Rigidbody2D>();
        //初始时 分数为0
        score = 0;
    }
	
	// Update is called once per frame
	//void Update()
 //   {
 //       //若按下鼠标左键 并且 游戏正在运行
 //       if (Input.GetMouseButtonDown(0)&& !GameState.Instance.GameOver)
 //       {
 //           //为刚体rig添加一个力 让物体进行移动
 //           //参数为 让物体向Y轴移动
 //           rig.AddForce(new Vector2(0, 270));
 //       }
	//}
    /// <summary>
    /// 若小鸟与其他碰撞体发生碰撞时触发本函数
    /// </summary>
    /// <param name="collision">与小鸟碰撞的碰撞体</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        //如果碰撞体的Tag 为 Death
        if (collision.collider.tag == "Death")
        {
            //设置为游戏结束
            GameState.Instance.isPlaying= true;
            //显示 游戏结束界面
            GameOverGo.SetActive(true);
        }
        //输出 游戏结束
        Debug.Log("GameOver");
    }
    /// <summary>
    /// 若小鸟穿过触发器时触发本函数
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit2D(Collider2D other)
    {
        //分数累加
        score++;
        //设置显示分数的3D Text显示内容为 当前的分数
        ScoreText.text = score + "";
    }
}
