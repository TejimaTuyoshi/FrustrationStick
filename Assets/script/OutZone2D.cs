using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutZone2D : MonoBehaviour
{
    [SerializeField] int _time = -5;
    public AudioClip sound;
    AudioSource audioSource;
    bool _isPlaying = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (_isPlaying == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//Playerタグを使ったものが当たったと条件付ける
        {
            FindObjectOfType<CountDownTimer>().Addtime(_time);
            _isPlaying = true;
        }
    }
}
