using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goaltreport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector2(-95,-41);
    }
}
