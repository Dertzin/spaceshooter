using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieShotLaserBehaviour : MonoBehaviour
{
    [SerializeField] private float _bulletspeed;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1* _bulletspeed * Time.deltaTime, 0);
    }
}
