using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletBehaviour : MonoBehaviour
{
    [SerializeField] private float _bulletspeed;

    [SerializeField] private GameObject Bulletprefab;

    [SerializeField] private Transform _target;

    private float timecounter;
    private float timetoshoot = 0.5f;

    //private float rotationspeed = 5f;

    [SerializeField] private string bulletType;


    // Start is called before the first frame update
    void Start()
    {
        timecounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        timecounter += Time.deltaTime;

        if(timecounter >= timetoshoot)
        {
            if (bulletType == "Ufo") // if is a Ufo then instantiate a Ufo
            {
                GameObject bullet = Instantiate(Bulletprefab,transform.position,Quaternion.identity);
            
                HelperClasses.RotateToPlayer(bullet.transform,_target);               
            }
            else if (bulletType == "Ship") // if is a ship then instantiate a ship
            {
                GameObject laser = Instantiate(Bulletprefab, transform.position, Quaternion.identity);
                
                HelperClasses.RotateToPlayer(_target.transform,_target);
            }

            timecounter = 0;
        }
        
    }

    public void GetBulletType(string value)
    {
        bulletType = value;
    }
}
