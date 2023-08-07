using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSwichsRules : MonoBehaviour
{
    [SerializeField] GameObject _button;
    [SerializeField] GameObject _lever;
    [SerializeField] GameObject _dr;
    [SerializeField] GameObject _ob;
    [SerializeField] AudioClip _audio = null;
    [SerializeField] protected ActivateTiming _Go;


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
                Destroy(_button,2f);
            }
            else if (_Go == ActivateTiming.Shift)
            {
                select();
                Destroy(_lever,2f);
            }
        }
    }

    protected enum ActivateTiming
    {
        Touch,//ボタン用

        Shift,//レバー用
    }
}
