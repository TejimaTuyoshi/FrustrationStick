using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemFade : MonoBehaviour
{

    [SerializeField] int _time = 5;
    [SerializeField] GameObject _timer;
    public AudioClip sound;
    AudioSource audioSource;
    bool _isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        var sprite = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        sprite.DOFade(0, 0.5f).SetLoops(1000, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlaying == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<CountDownTimer2>().Addtime(_time);
        Destroy(_timer,3f);
        _isPlaying = true;
    }
}
