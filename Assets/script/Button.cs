using DG.Tweening;
using UnityEngine;

public class Button : GameSwichsRules
{
    

    [SerializeField] GameObject _door;
    public AudioClip sound;
    AudioSource audioSource;
    bool _isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (_isPlaying == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }


    public override void On()
    {
        Destroy(_door, 2f);
        _isPlaying = true;
    }

}
