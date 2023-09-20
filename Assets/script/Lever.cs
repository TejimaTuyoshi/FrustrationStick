using UnityEngine;

public class Lever : GameSwichsRules
{
    
    [SerializeField] GameObject _obstacle;
    public AudioClip sound;
    AudioSource audioSource;
    bool _isPlaying = false;


    public void Start()
    {      
        _Go = ActivateTiming.Shift;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (_isPlaying == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }

    public override void select()
    {
        Destroy(_obstacle, 2f);
        _isPlaying = true;
    }

}