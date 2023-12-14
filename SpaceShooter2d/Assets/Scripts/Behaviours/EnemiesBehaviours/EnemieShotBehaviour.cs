using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemieShotBehaviour : MonoBehaviour // THIS SCRIPT IS TEMPORARY/TEST
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {               
        //if(transform.position.y > HelperClasses.ScreenBounds.MaxY || transform.position.x > HelperClasses.ScreenBounds.MaxX) // verify if the bullet is ouside the screen
        //{
        //    Destroy(gameObject); // if outside it destroys itself
        //}
        //else
        //{
             // if inside  just do the movement
        //}
        BulletMovement();
        if (!IsObjectInsideScreen())
        {
            Destroy(gameObject);
        }
        

    }

    private void BulletMovement()
    {
        transform.Translate(0, speed * Time.deltaTime, 0); 
    }

    bool IsObjectInsideScreen()
    {
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        return screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
    }
}
