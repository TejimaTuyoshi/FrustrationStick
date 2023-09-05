using UnityEngine;

public class Button : GameSwichsRules
{
    

    [SerializeField] GameObject _door;


    public override void On()
    {
        Destroy(_door, 2f);
    }

}
