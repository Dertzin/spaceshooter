using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamageBehaviopur : MonoBehaviour
{
    // Start is called before the first frame update
    //private float _damage = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Console.WriteLine(collision.name);
        if(collision.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
