using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using static UnityEditor.PlayerSettings;

public class MovingSpike : MonoBehaviour
{
    [SerializeField] int _time = -1;
    [SerializeField] int _speed = 50;
    [SerializeField] GameObject _Spike;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//Player�^�O���g�������̂����������Ə����t����
        {
            FindObjectOfType<CountDownTimerThird>().Addtime(_time);
            _isPlaying = true;
            Destroy(_Spike, 3f);
            FindObjectOfType<PlayerMove>().Addspeed(_speed);

        }
    }

 
}
