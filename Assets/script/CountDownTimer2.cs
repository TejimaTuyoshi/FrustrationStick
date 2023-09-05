using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer2 : GameManegar
{
    [SerializeField] static float CountDownTime2;    // �J�E���g�_�E���^�C��
    public Text TextCountDown2;              // �\���p�e�L�X�gUI
    public static float cleartime2 = 99.0f;
    bool onstart2 = false;

    // Use this for initialization
    void Start()
    {
        CountDownTime2 = 90.0F;    // �X�e�[�W2�p�̃^�C�}�[
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown2.text = String.Format("Time: {0:00.00}", CountDownTime2);// �J�E���g�_�E���^�C���𐮌`���ĕ\��

        if (onstart2 == true)
        {
            CountDownTime2 -= Time.deltaTime;// �o�ߎ����������Ă��� 
        }

        if (CountDownTime2 <= 0.0F) // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j
        {
            CountDownTime2 = 0.0F;
        }
        if (CountDownTime2 == 0.0F)//�^�C���I�[�o�[���AGameover��ʂɔ�΂��B
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
        }
    }


    public void Addtime(int time)
    {
        CountDownTime2 += time;

        if (CountDownTime2 > 0)
        {
            Debug.Log("�^�C�}�[�ǉ�!");
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