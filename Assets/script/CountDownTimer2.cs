using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer2 : MonoBehaviour
{
    [SerializeField] static float CountDownTime;    // カウントダウンタイム
    public Text TextCountDown;              // 表示用テキストUI
    public static float cleartime = 99.0f;
    bool onstart = false;

    // Use this for initialization
    void Start()
    {
        CountDownTime = 80.0F;    // ステージ１用のタイマー
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);// カウントダウンタイムを整形して表示

        if (onstart == true)
        {
            CountDownTime -= Time.deltaTime;// 経過時刻を引いていく 
        }

        if (CountDownTime <= 0.0F) // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        {
            CountDownTime = 0.0F;
        }
        if (CountDownTime == 0.0F)//タイムオーバー時、Gameover画面に飛ばす。
        {
            SceneManager.LoadScene("Gameover2", LoadSceneMode.Single);
        }
    }


    public void Addtime(int time)
    {
        CountDownTime += time;

        if (CountDownTime > 0)
        {
            Debug.Log("タイマー追加!");
        }
    }

    public void Starttime()
    {
        onstart = true;
    }

    public static void clearscene()
    {
        cleartime = CountDownTime;
    }

}
