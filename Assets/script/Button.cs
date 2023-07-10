using UnityEngine;

public class Button : GameSwichsRules
{
    
    [SerializeField] int _time = 1 ;

    
    public override void On()
    {
        FindObjectOfType<CountDownTimer>().Addtime(_time);
    }

}
