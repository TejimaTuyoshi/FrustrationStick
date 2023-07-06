using UnityEngine;

public class Button : GameSwichsRules
{
    
    [SerializeField] int _time = 5 ;

    
    public override void On()
    {
        FindObjectOfType<GameManegar>().Addtime(_time);
    }

}
