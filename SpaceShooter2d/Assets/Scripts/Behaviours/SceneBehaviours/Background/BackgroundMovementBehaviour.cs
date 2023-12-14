using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _resetpos = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _speed = -10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, _speed * Time.deltaTime, 0); 

        if(transform.position.y < _resetpos) 
        {
            ResetPosition();
        }

    }

    void ResetPosition()
    {
        var newposition = new Vector2(transform.position.x, -1 * _resetpos);

        transform.position = newposition;
    }
}
