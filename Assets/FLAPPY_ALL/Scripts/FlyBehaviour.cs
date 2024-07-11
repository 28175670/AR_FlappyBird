using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.Events;

public class FlyBehaviour : MonoBehaviour
{
    //[SerializeField] private Transform flybird;
    [SerializeField] private UnityEvent Die;
    private static FlyBehaviour _instance;
    
    
   //public static Vector3 BirdPosition
   //{
   //     get { return _instance.flybird.position; }
   //}
    private void Awake()
    {
        _instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
   
    public static void deathing()
   {
        _instance.Die.Invoke();
   }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("death"))
        {
            GameManger.Instance.GameOver();
            FlyBehaviour.deathing();
            Debug.Log("±µÄ²");
        }
    }

}
