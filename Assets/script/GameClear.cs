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

    private void OnTriggerEnter2D(Collider2D collision)//Player���S�[���ɓ���������
    {
        if (collision.gameObject.CompareTag("Player"))//Player�^�O���g�������̂����������Ə����t����
        {
            CountDownTimer.clearscene();
            SceneManager.LoadScene("Gameclear", LoadSceneMode.Single);
            Console.WriteLine("�Q�[���N���A��ʂɈړ�");//����m�F�p�R���\�[��
        }
    }


}