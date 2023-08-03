using UnityEngine;

public class Button : GameSwichsRules
{
    
    [SerializeField] int _time = 1 ;
    [SerializeField] GameObject _door;


    public override void On()
    {
        FindObjectOfType<CountDownTimer>().Addtime(_time);
        Destroy(_door, 2f);
    }

}
