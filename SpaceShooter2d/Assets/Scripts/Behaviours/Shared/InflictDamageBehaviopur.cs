using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamageBehaviopur : MonoBehaviour
{
    // Start is called before the first frame update
    //private float _damage = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
