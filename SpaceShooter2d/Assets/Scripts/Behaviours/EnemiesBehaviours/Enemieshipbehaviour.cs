using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerMovementBehaviour;

public class Enemieshipbehaviour : MonoBehaviour
{
    private float _movementspeed = 3;
    private string _shipType;
    private string _direction;
    //[SerializeField] private string _speed;
    private float shipHalfWidth;
    private float shipHalfHeight;

    [SerializeField] private Transform _target;

    private float rotationSpeed = 5f;
    private Vector3 originalDirectionX;
    private Vector3 originalDirectionY;

    // Start is called before the first frame update
    void Start()
    {
        shipHalfWidth = transform.localScale.x / 2f;
        shipHalfHeight = transform.localScale.y / 2f;

        originalDirectionX = transform.right;
        originalDirectionY = transform.up;

        //if(_direction == "Left")
        //{
        //    transform.Rotate(0, 0, 90f);
        //}
        //else if(_direction == "Right")
        //{
        //    transform.Rotate(0, 0, -90f);
        //}
        //else if(_direction == "Down")
        //{
        //    transform.Rotate(0, 0, 180f);                           
        //}
    }

    // Update is called once per frame
    void Update()
    {
        HelperClasses.RotateToPlayer(transform,_target,rotationSpeed);
        EnemieMovement();
    }
    
    private void EnemieMovement()
    {
        if (_shipType == "Ship")
        {                    
            if (_direction == "Horizontal") // Direction top
            {
                MoveHorizontal();
            }
            else if (_direction == "Vertical")
            {
                MoveVertical();
            }
        }

    }

    private void MoveHorizontal()
    {
        transform.Translate(originalDirectionX * Time.deltaTime *_movementspeed, Space.World);

        if (transform.position.x + shipHalfWidth > HelperClasses.ScreenBounds.MaxX)
        {
            _movementspeed = -Mathf.Abs(_movementspeed);
        }

        if (transform.position.x - shipHalfWidth < HelperClasses.ScreenBounds.MinX)
        {
            _movementspeed = Mathf.Abs(_movementspeed);
        }
    }

    private void MoveVertical()
    {
        transform.Translate(originalDirectionY * Time.deltaTime * _movementspeed, Space.World);

        if (transform.position.y + shipHalfHeight > HelperClasses.ScreenBounds.MaxY)
        {
            _movementspeed = -Mathf.Abs(_movementspeed);
        }

        if (transform.position.y - shipHalfHeight < HelperClasses.ScreenBounds.MinY)
        {
            _movementspeed = Mathf.Abs(_movementspeed);
        }
    }
    public void SetShipActions(string direction, string type,Transform target)
    {
        _direction = direction;
        _shipType = type;
        _target = target;
    }
}
