using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer2 : GameManegar
{
    [SerializeField] static float CountDownTime2;    // カウントダウンタイム
    public Text TextCountDown2;              // 表示用テキストUI
    public static float cleartime2 = 99.0f;
    bool onstart2 = false;

    // Use this for initialization
    void Start()
    {
        CountDownTime2 = 90.0F;    // ステージ2用のタイマー
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown2.text = String.Format("Time: {0:00.00}", CountDownTime2);// カウントダウンタイムを整形して表示

        if (onstart2 == true)
        {
            CountDownTime2 -= Time.deltaTime;// 経過時刻を引いていく 
        }

        if (CountDownTime2 <= 0.0F) // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        {
            CountDownTime2 = 0.0F;
        }
        if (CountDownTime2 == 0.0F)//タイムオーバー時、Gameover画面に飛ばす。
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
        }
    }


    public void Addtime(int time)
    {
        CountDownTime2 += time;

        if (CountDownTime2 > 0)
        {
            Debug.Log("タイマー追加!");
        }
    }

    public void Starttime()
    {
        onstart2 = true;
    }

    public static void clearscene()
    {
        cleartime2 = CountDownTime2;
    }

}