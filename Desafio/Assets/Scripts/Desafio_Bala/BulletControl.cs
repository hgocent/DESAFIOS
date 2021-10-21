using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{   
    public float SpeedBullet = 1f;
    public float Damage = 50;
    public Vector3 Direction;
    public float timeBomb = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
        
        timeBomb -= Time.deltaTime;
        
        if (timeBomb < 0)
        {
            Destroy(gameObject);
        }
        
    }
    
    void MoveBullet()
    {
        //transform.Translate(Direction * SpeedBullet * Time.deltaTime);
        transform.Translate(SpeedBullet * Time.deltaTime * Direction);
    }
}
