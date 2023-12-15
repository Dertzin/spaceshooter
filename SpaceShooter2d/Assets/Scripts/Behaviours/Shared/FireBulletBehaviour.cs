using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletBehaviour : MonoBehaviour
{
    

    [SerializeField] private GameObject Bulletprefab;

    [SerializeField] private Transform _target;

    private float timecountertoshootbullets;
    private float timecountertodestroyufo;
    private float timetoshoot = 0.5f;
    private float timetodestroyufo = 1.5f;
    //private float rotationspeed = 5f;

    private bool laserfired = false;

    [SerializeField] private string _shiptype;

    // Start is called before the first frame update
    void Start()
    {
        
        timecountertoshootbullets = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        timecountertoshootbullets += Time.deltaTime;
        timecountertodestroyufo += Time.deltaTime;
                   
            if (timecountertoshootbullets >= timetoshoot)
            {            
                if (!laserfired)
                {
                    
                    if (_shiptype == "Ship")
                    {
                        CreateBullet();
                    }
                    else if (_shiptype == "Ufo")
                    {

                        CreateLaser();

                        laserfired = true;
                    }
                   
                }else
                {
                    if (_shiptype == "Ship")
                    {
                        CreateBullet();
                    }

                }
                timecountertoshootbullets = 0;
            }else if(timecountertodestroyufo >= timetodestroyufo)
            {
                if(_shiptype == "Ufo")
                {
                    Destroy(gameObject);
                }
            }
    }

    private void CreateBullet()
    {
        GameObject bullet = Instantiate(Bulletprefab, transform.position, Quaternion.identity);
        
        HelperClasses.RotateToPlayer(bullet.transform, _target);
    }
    private void CreateLaser()
    {
        //Vector3 rearangenum = new Vector3(0f, 10f,0f);
        GameObject bigbullet = GameObject.Instantiate(Bulletprefab, transform.position , Quaternion.identity);
        HelperClasses.RotateToPlayer(bigbullet.transform, _target);
        bigbullet.transform.Translate(0, -3f, 0);
        bigbullet.transform.localScale = new Vector3(1f, 20f, 1f);

    }

    public void SetBullet(Transform target,string shiptype)
    {
       
        _target = target;
        _shiptype = shiptype;
    }
}
