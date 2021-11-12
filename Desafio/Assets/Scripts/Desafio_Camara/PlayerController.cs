using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{   
    [SerializeField] private float speedPlayer = 5f;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private float rayLenght = 10f;
     private float mouseX;

    //public Vector3 initPosition = new Vector3(4, 2, 1);
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = initPosition;
       
        
    }

    // Update is called once per frame
    void Update()
    { 
        RaycastPlayer();
        
        RotatePlayer();
        MovePlayer();

        if (GameManager.getLife() < 0)
        {
            Destroy(gameObject);
            Debug.Log("YOU ARE DEAD");
        }

    }

    private void FixedUpdate()
    {
        
    }

    /*private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(-ejeVertical, 0, ejeHorizontal));
    }*/
    private void MovePlayer()
    {
        float Vmove = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * new Vector3(0,0, Vmove) * Time.deltaTime);
    }
    
    private void RotatePlayer()
    {
        float hRotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hRotate * rotationSpeed * Time.deltaTime);
    }

    private void RaycastPlayer()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayLenght))
        {
            //Debug.Log("HIT");

            //Debug.Log(GameManager.getScore());
            GameManager.increaseScore(2);
            Debug.Log("MY SCORE IS: " + GameManager.getScore());

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayLenght);
    }


}
