using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemieShotBehaviour : MonoBehaviour 
{
    //[SerializeField] private float _movementspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {               
        
        BulletMovement();
        if (!IsObjectInsideScreen())
        {
            Destroy(gameObject);
        }
        

    }

    private void BulletMovement()
    {
        transform.Translate(0, -10 * Time.deltaTime, 0); 
    }

    bool IsObjectInsideScreen()
    {
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        return screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
    }

    
}
