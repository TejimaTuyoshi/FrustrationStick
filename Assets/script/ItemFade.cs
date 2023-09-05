using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemFade : MonoBehaviour
{

    [SerializeField] int _time = 5;
    [SerializeField] GameObject _timer;

    // Start is called before the first frame update
    void Start()
    {
        var sprite = GetComponent<SpriteRenderer>();
        sprite.DOFade(0, 0.5f).SetLoops(1000, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<CountDownTimer2>().Addtime(_time);
        Destroy(_timer,3f);
    }
}
