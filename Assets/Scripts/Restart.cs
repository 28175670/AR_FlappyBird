using UnityEngine;
//SceneManager.LoadScene（）函数所在命名控件
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    void Start()
    {
        //设置挂载本脚本物体的父物体 初始状态为隐藏
        //这里即是 初始时隐藏 “GameOver”物体
        this.transform.parent.gameObject.SetActive(false);
    }
    private void Update()
    {
       
    }

    private void SceneManagerRestart()
    {
        //重新加载本游戏场景
        SceneManager.LoadScene("AR_FlappyBird", LoadSceneMode.Single);
    }
}
