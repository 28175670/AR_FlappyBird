using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    [SerializeField] public UnityEvent DeathFlicker;
    [SerializeField] public UnityEvent stopbutton;
    [SerializeField] public UnityEvent goonbutton;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //BoxCollider2D[] boxes = FindObjectsOfType<BoxCollider2D>();
        //foreach (BoxCollider2D box in boxes)
        //{
        //    Gizmos.DrawWireCube(box.bounds.center, box.bounds.size);
        //}
        BoxCollider[] boxes = FindObjectsOfType<BoxCollider>();
        foreach (BoxCollider box in boxes)
        {
            Gizmos.DrawWireCube(box.bounds.center, box.bounds.size);
        }
    }


    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
        }
        Time.timeScale = 1.0f;
    }

   public void GameOver()
   {      
        DeathFlicker.Invoke();
        Time.timeScale = 0.0f;       
   }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StopGame()
    {
        Time.timeScale = 0.0f;
        stopbutton.Invoke();
    }
    public void GoonGame()
    {
        Time.timeScale = 1.0f;
       goonbutton.Invoke();
    }


}
