using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    private Rigidbody2D rbody2D;//当たり判定の名前の定義
    public float speed = 0.05f;//移動する際の一フレームあたりの移動距離
    private new SpriteRenderer renderer;//反転する
    public float jumpForce = 350f;//ジャンプする力
    public int jumpCount = 0;//ジャンプできる回数の制限
    GameObject[] m_Jump;//ジャンプ行動時

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