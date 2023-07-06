using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSwichsRules : MonoBehaviour
{
    [SerializeField] GameObject _button;
    [SerializeField] GameObject _lever;
    [SerializeField] GameObject _door;
    [SerializeField] GameObject _obstacle;
    [SerializeField] AudioClip _audio = null;
    [SerializeField] ActivateTiming _Go;


    public virtual void On()
    {
        Debug.LogError("Not select　class");
    }
    // Start is called before the first frame update
    void Start()
    {
        _button.SetActive(false);
        _lever.SetActive(false);      
    }

    // Update is called once per frame
    void Update()
    {
        if (_button != null) 
        {
            Destroy(_button,2f);
            AudioSource.PlayClipAtPoint(_audio, new Vector3(0,0,0));
        }

        if (_lever != null) 
        {
            Destroy(_lever, 2f);
            AudioSource.PlayClipAtPoint(_audio, new Vector3(0, 0, 0));
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag.Equals("Player"))
            {
                if (_Go == ActivateTiming.Touch)
                {
                    On();
                    Destroy(_door,2f);
                }
                else if (_Go == ActivateTiming.Shift)
                {
                    Destroy(_obstacle,2f);
                }
            }
        }

    }
    enum ActivateTiming
    {
        Touch,//ボタン用

        Shift,//レバー用
    }
}
