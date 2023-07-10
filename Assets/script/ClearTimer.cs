using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimer : MonoBehaviour
{
    [SerializeField] Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = CountDownTimer.cleartime.ToString("F1") + "•b";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
