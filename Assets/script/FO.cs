using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FO : MonoBehaviour
{

    [SerializeField] Image _fadeImage = default;
    [SerializeField] float _fadeTime = 1;
    float _timer = 0;

    public void Fade()
    {
        Debug.Log("Fade Start");
        StartCoroutine(FadeRoutine());
    }


    IEnumerator FadeRoutine()
    {
        while (true)
        {
            _timer += Time.deltaTime;
            Color c = _fadeImage.color;
            c.a = _timer / _fadeTime;
            _fadeImage.color = c;

             if (_timer > _fadeTime)
            {
                Debug.Log("Fade Finish");
                SceneManager.LoadScene("stage1", LoadSceneMode.Single);
                yield break;
            }

            yield return new WaitForEndOfFrame();
        }
    }
}