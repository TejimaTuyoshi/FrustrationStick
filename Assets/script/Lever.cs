using UnityEngine;

public class Lever : GameSwichsRules
{

    [SerializeField] int _time = 5;


    public override void select()
    {
        FindObjectOfType<GameManegar>().Addtime(_time);
    }

}