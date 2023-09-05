using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevemovethe2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("stage2", LoadSceneMode.Single);
    }
}
