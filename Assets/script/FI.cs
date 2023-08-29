using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FI : MonoBehaviour
{

    [SerializeField] Image _fadeImage = default;
    [SerializeField] GameObject _button;
    [SerializeField] float _fadeTime = 1;
    float _timer = 5;

    public void Fade()
    {
        Debug.Log("Fade Start");
        StartCoroutine(FadeRoutine());
    }

    public void Delete()
    { 
       Destroy(_button);
    }

    IEnumerator FadeRoutine()
    {
        while (true)
        {
            _timer -= Time.deltaTime;
            Color c = _fadeImage.color;
            c.a = _timer / _fadeTime;
            Debug.Log(_timer);
            _fadeImage.color = c;

            if (_timer > _fadeTime)
            {
                Debug.Log("Fade Finish");
                yield break;
            }

            yield return new WaitForEndOfFrame();
        }
    }
}