using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutZone(second) : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//Playerタグを使ったものが当たったと条件付ける
        {
            SceneManager.LoadScene("Gameover2", LoadSceneMode.Single);
            Console.WriteLine("ゲームオーバー画面に移動");//動作確認用コンソール
        }
    }
}
