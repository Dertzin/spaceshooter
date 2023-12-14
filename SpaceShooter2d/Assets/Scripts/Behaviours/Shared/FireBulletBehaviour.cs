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
            GameObject bullet = Instantiate(Bulletprefab,transform.position,Quaternion.identity);
            
            HelperClasses.RotateToPlayer(bullet.transform,_target,5f);// not working

            timecounter = 0;
        }
        
    }

    

    
}
