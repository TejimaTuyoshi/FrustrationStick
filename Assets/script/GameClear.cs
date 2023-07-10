using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)//Playerがゴールに当たった時
    {
        if (collision.gameObject.CompareTag("Player"))//Playerタグを使ったものが当たったと条件付ける
        {
            CountDownTimer.clearscene();
            SceneManager.LoadScene("Gameclear", LoadSceneMode.Single);
            Console.WriteLine("ゲームクリア画面に移動");//動作確認用コンソール
        }
    }


}