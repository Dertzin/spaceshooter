using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _horizontalmovementspeed;
    [SerializeField] private float _verticalmovementspeed;

    private float _horizontalInput;
    private float _verticalInput;

    private float playerHalfWidth;
    private float playerHalfHeight;
    // Start is called before the first frame update
    void Start()
    {
        playerHalfWidth = transform.localScale.x / 2f;
        playerHalfHeight = transform.localScale.y / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(_horizontalInput * _horizontalmovementspeed * Time.deltaTime, 0, 0);
        transform.Translate(0, _verticalInput * _verticalmovementspeed * Time.deltaTime, 0);

        Vector3 newPosition = transform.position + new Vector3(_horizontalInput * _horizontalmovementspeed * Time.deltaTime, _verticalInput * _verticalmovementspeed * Time.deltaTime,0);
        

        newPosition.x = Mathf.Clamp(newPosition.x, HelperClasses.ScreenBounds.MinX + playerHalfWidth, HelperClasses.ScreenBounds.MaxX - playerHalfWidth);
        newPosition.y = Mathf.Clamp(newPosition.y, HelperClasses.ScreenBounds.MinY + playerHalfHeight, HelperClasses.ScreenBounds.MaxY - playerHalfHeight); ;

        transform.position = newPosition;


    }

    //public static class ScreenBounds
    //{
    //    public static float MinX => Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
    //    public static float MaxX => Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    //    public static float MinY => Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
    //    public static float MaxY => Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    //}

}
