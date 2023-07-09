using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rbody2D;//当たり判定の名前の定義
    public float speed = 0.05f;//移動する際の一フレームあたりの移動距離
    private new SpriteRenderer renderer;//反転する
    

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("a"))
        {
            position.x -= speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("d"))
        {
            position.x += speed;
            renderer.flipX = true;
        }
        else if (Input.GetKey("w"))
        {
            position.y += speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("s"))
        {
            position.y -= speed;
            renderer.flipX = false;
        }
        transform.position = position;

    }

   
}