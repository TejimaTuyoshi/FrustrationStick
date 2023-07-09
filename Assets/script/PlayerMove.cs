using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    private Rigidbody2D rbody2D;//�����蔻��̖��O�̒�`
    public float speed = 0.05f;//�ړ�����ۂ̈�t���[��������̈ړ�����
    private new SpriteRenderer renderer;//���]����
    public float jumpForce = 350f;//�W�����v�����
    public int jumpCount = 0;//�W�����v�ł���񐔂̐���
    GameObject[] m_Jump;//�W�����v�s����

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetButtonDown("a"))
        {
            position.x -= speed;
            renderer.flipX = false;
        }
        else if (Input.GetButtonDown("d"))
        {
            position.x += speed;
            renderer.flipX = true;
        }
        else if (Input.GetButtonDown("w"))
        {
            position.y += speed;
            renderer.flipX = false;
        }
        else if (Input.GetButtonDown("s"))
        {
            position.y -= speed;
            renderer.flipX = false;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        SceneManager.LoadScene("Gameover", LoadSceneMode.Single);

    }
}