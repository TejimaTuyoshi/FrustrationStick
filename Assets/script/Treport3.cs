using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treport3 : MonoBehaviour
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
        collision.gameObject.transform.position = new Vector2(-80, 30);
    }
}
