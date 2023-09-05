using UnityEngine;

public class Lever : GameSwichsRules
{
    
    [SerializeField] GameObject _obstacle;

    public void Start()
    {      
        _Go = ActivateTiming.Shift;
    }

    public override void select()
    {
        Destroy(_obstacle, 2f);
    }

}