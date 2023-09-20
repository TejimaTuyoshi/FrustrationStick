using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treport3 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound; 
    AudioSource audioSource;
    bool _isPlaying = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlaying == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector2(-80, 30);
        _isPlaying = true;
    }
}
