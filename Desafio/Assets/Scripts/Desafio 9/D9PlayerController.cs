using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D9PlayerController : MonoBehaviour

{
    [SerializeField] private float speedPlayer;
    
    private Vector3 newPosition;
    private float timerCountDown = 2.0f;
    private bool isPlayerColliding = false;
    public Transform wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();

        // Collision timer
        if (isPlayerColliding == true)
        {
            timerCountDown -= Time.deltaTime;

            if (timerCountDown <= 0)
            {
                //
                //Debug.Log("Hit wall for 2 seconds");
                
                newPosition=new Vector3(Random.Range(1,6),2,Random.Range(-3,3));
                wall.position = newPosition;
                wall.Rotate(0,Random.Range(0,360),0);
                
                timerCountDown = 2.0f;
                isPlayerColliding = false;
            }
        }
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Portal")
        {
            Invoke("scaleMe",0.3f);
        }

        
    }

   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            //Debug.Log(collision.gameObject.name);
            isPlayerColliding = true;
            
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            //Debug.Log(collision.gameObject.name);
            isPlayerColliding = false;
           
        }
        
    }

    private void scaleMe()
    {
        
       if (transform.localScale == Vector3.one)
        {
            gameObject.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        else
        {
            gameObject.transform.localScale = Vector3.one;
        } 
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(-ejeVertical, 0, ejeHorizontal));
        
    }

}
