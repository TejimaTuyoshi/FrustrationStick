using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutZone2D : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player"))//Player�^�O���g�������̂����������Ə����t����
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
            Console.WriteLine("�Q�[���I�[�o�[��ʂɈړ�");//����m�F�p�R���\�[��
        }
    }
}
