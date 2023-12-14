using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    private float movementspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, movementspeed * Time.deltaTime, 0);
    }

    public void GetSpeed(float value)
    {
        movementspeed = value;
    }
}
