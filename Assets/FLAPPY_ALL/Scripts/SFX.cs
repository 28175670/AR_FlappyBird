using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _dead;
    [SerializeField] private AudioClip _coin;

    private static SFX instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        _audioSource.PlayOneShot(_dead);
    }
    public static void EatCoin()
    {
       instance._audioSource.PlayOneShot(instance._coin);
    }
}
