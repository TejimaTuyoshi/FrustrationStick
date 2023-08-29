using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class DateShare : MonoBehaviour
{
    
    [SerializeField] float _time = 0;
    //string _Time = _time.Tostring("F1");
    /// <summary>Start 関数の処理が終わっているか表すフラグ</summary>
    bool _isStarted = false;
    string _Stoptime = null;

     public void Start()
     {
        string _Time = _time.ToString("F1");
        if (FindObjectsOfType<DateShare>().Length > 1)
        {
            // 重複しないように、既にある時は自分自身を破棄する
            Destroy(this.gameObject);
        }
        else
        {
            // 自分しかいない時は、自分を DontDestroyOnLoad に登録する
            DontDestroyOnLoad(this.gameObject);
            ShowMessage();
            _isStarted = true;
        }
    }

    /// <summary>
    /// 名前を保存する
    /// </summary>
    /// <param name="input"></param>
    public void Settime(InputField time) => _Stoptime = time.text;

    /// <summary>
    /// シーンがロードされた時に呼ばれる。
    /// この関数を使うと警告が出て、代わりに SceneManager.sceneLoaded を使うよう促される。
    /// しかし、これを使うにはデリゲートを知らなければならないので、今はこちらを使う。
    /// </summary>
    /// <param name="level"></param>
    void OnLevelWasLoaded(int level)
    {
        if (_isStarted) ShowMessage();
    }

    /// <summary>
    /// メッセージを表示する
    /// </summary>
    void ShowMessage()
    {
        GameObject go = GameObject.Find("_Time");
        Text text = go?.GetComponent<Text>();

        if (text)
        {
            text.text = CountDownTimer.cleartime.ToString("F1");


        }
    }
}

