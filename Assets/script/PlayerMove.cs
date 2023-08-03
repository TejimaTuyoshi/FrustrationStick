using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rbody2D;//�����蔻��̖��O�̒�`
    public float speed = 0.05f;//�ړ�����ۂ̈�t���[��������̈ړ�����
    private new SpriteRenderer renderer;//���]����
    float _h;
    float _v;
    
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
       

        rbody2D.AddForce(Vector2.right * _h * speed, ForceMode2D.Force);
        rbody2D.AddForce(Vector2.up * _v * speed, ForceMode2D.Force);
        

        //if (_h < 0)
        //{
        //    renderer.flipX = true;
        //}
        //else 
        //{
        //    renderer.flipX = false;
        //}
        //transform.position = position;
    }
    void LateUpdate()
    {
        if(_h != 0)
        {
            renderer.flipX = (_h < 0);
        }
    }
}