using UnityEngine;

public class GameManegar : MonoBehaviour
{
    [SerializeField] int _time = 5;

    public void Addtime(int time)
    {
        _time += time;

        if (_time > 0)
        {
            Debug.Log("タイマー追加!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
