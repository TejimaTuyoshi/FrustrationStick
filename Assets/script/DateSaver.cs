using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class DateSaver : MonoBehaviour
{
    
    [SerializeField] int _time = 0;
    /// <summary>Start �֐��̏������I����Ă��邩�\���t���O</summary>
    bool _isStarted = false;
    string _Stoptime = null;

     public void Start()
     {
        if (FindObjectsOfType<DateSaver>().Length > 1)
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
    public void Settime(InputField time)
    {
        _Stoptime = time.text;
    }

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
        GameObject go = GameObject.Find(_messageTextName);
        Text text = go?.GetComponent<Text>();

        if (text)
        {
            text.text = $"�����I<b><color=red>{_name}</color></b> ��I����ł��܂��Ƃ� �Ȃɂ��Ƃ��I";
            Debug.Log(text.text);
        }
    }
}

