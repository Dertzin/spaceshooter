using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LevelManager : MonoBehaviour
{
    private float _timecounter = 0;
    [SerializeField] GameObject _ufoprefab;
    [SerializeField] GameObject _shipprefab;
    [SerializeField] Transform _target;

    private Vector2 TopMiddlestartpos;
    private Vector2 TopLeftstartpos;
    private Vector2 TopRightstartpos;

    private Vector2 LeftMiddlestartpos;
    private Vector2 RightMiddlestartpos;
    private Vector2 DownLeftstartpos;
    private Vector2 DownRightstartpos;
    private Vector2 DownMiddlestartpos;
    // Start is called before the first frame update
    void Start()
    {   
        TopMiddlestartpos = new Vector2(0f,4.7f);
        TopLeftstartpos = new Vector2(-10.1f, 4.7f);
        TopRightstartpos = new Vector2(10.1f, 4.7f);
        LeftMiddlestartpos = new Vector2(-10.1f, 0f);
        RightMiddlestartpos = new Vector2(10.1f,0f);
        DownLeftstartpos = new Vector2(-10.1f, -4.7f);
        DownRightstartpos = new Vector2(10.1f, -4.7f);
        DownMiddlestartpos = new Vector2(0f, -4.7f);


        SetupLevel1();

        
    }

    // Update is called once per frame
    void Update()
    {
        _timecounter += Time.deltaTime;
    }

    private void SetupLevel1()
    {

        CreateShip(DownMiddlestartpos, "Horizontal");

        CreateUfo(DownLeftstartpos, "Vertical");
    }

    private void CreateShip(Vector2 startpos,string direction)
    {
        GameObject ship1 = Instantiate(_shipprefab, startpos, Quaternion.identity);
        Enemieshipbehaviour enemieshipbehaviour = ship1.GetComponent<Enemieshipbehaviour>();
        FireBulletBehaviour fireBulletBehaviour = ship1.GetComponent<FireBulletBehaviour>();

        fireBulletBehaviour.SetBullet(_target, "Ship");
        enemieshipbehaviour.SetShipActions(direction, "Ship", _target);
    } 

    private void CreateUfo(Vector2 startpos, string direction)
    {
        GameObject ufo = Instantiate(_ufoprefab, startpos, Quaternion.identity);
        Enemieshipbehaviour enemieshipbehaviour = ufo.GetComponent<Enemieshipbehaviour>();
        FireBulletBehaviour fireBulletBehaviour = ufo.GetComponent<FireBulletBehaviour>();

        fireBulletBehaviour.SetBullet(_target, "Ufo");
        enemieshipbehaviour.SetShipActions(direction, "Ufo", _target);
    }
    



}
