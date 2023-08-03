using UnityEngine;

public class Lever : GameSwichsRules
{
    
    [SerializeField] int _time = 1;
    [SerializeField] GameObject _obstacle;

    public void Start()
    {
        
        _Go = ActivateTiming.Shift;
    }

    public override void select()
    {
        FindObjectOfType<CountDownTimer>().Addtime(_time);
        Destroy(_obstacle, 2f);
    }

}