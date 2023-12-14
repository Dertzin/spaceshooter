using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehaviour : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private GameObject bulletprefab;

    private float verticalInput;
    private float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Cross")) 
        {
            GameObject bullet = Instantiate(bulletprefab, transform.position, Quaternion.identity);
            PlayerBulletMovement speed = bullet.GetComponent<PlayerBulletMovement>();
            if (speed != null)
            {
                speed.GetSpeed(bulletspeed);
            }
        }
    }
}
