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

    public virtual void select()
    {
        Debug.LogError("Not select　class");
    }
    // Start is called before the first frame update
    void Start()
    {
        _button.SetActive(true);
        _lever.SetActive(true);      
    }

    // Update is called once per frame
    void Update()
    {

    }
        

        
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (_Go == ActivateTiming.Touch)
            {
                On();
                Destroy(_door, 2f);
            }
            else if (_Go == ActivateTiming.Shift)
            {
                select();
                Destroy(_obstacle, 2f);
            }
        }
    }

    enum ActivateTiming
    {
        Touch,//ボタン用

        Shift,//レバー用
    }
}
