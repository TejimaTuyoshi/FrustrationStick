using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class DateShare : MonoBehaviour
{
    
    [SerializeField] float _time = 0;
    //string _Time = _time.Tostring("F1");
    /// <summary>Start �֐��̏������I����Ă��邩�\���t���O</summary>
    bool _isStarted = false;
    string _Stoptime = null;

     public void Start()
     {
        string _Time = _time.ToString("F1");
        if (FindObjectsOfType<DateShare>().Length > 1)
        {
            // �d�����Ȃ��悤�ɁA���ɂ��鎞�͎������g��j������
            Destroy(this.gameObject);
        }
        else
        {
            // �����������Ȃ����́A������ DontDestroyOnLoad �ɓo�^����
            DontDestroyOnLoad(this.gameObject);
            ShowMessage();
            _isStarted = true;
        }
    }

    /// <summary>
    /// ���O��ۑ�����
    /// </summary>
    /// <param name="input"></param>
    public void Settime(InputField time) => _Stoptime = time.text;

    /// <summary>
    /// �V�[�������[�h���ꂽ���ɌĂ΂��B
    /// ���̊֐����g���ƌx�����o�āA����� SceneManager.sceneLoaded ���g���悤�������B
    /// �������A������g���ɂ̓f���Q�[�g��m��Ȃ���΂Ȃ�Ȃ��̂ŁA���͂�������g���B
    /// </summary>
    /// <param name="level"></param>
    void OnLevelWasLoaded(int level)
    {
        if (_isStarted) ShowMessage();
    }

    /// <summary>
    /// ���b�Z�[�W��\������
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

