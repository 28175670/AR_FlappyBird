using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARDeath : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManger.Instance.GameOver();
            FlyBehaviour.deathing();
            Debug.Log("��Ĳ");
        }
    }
}
