using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDAPlayerController : MonoBehaviour
{
    //[SerializeField] private int lifePlayer = 3;
    [SerializeField] private float cameraAxisX = -90f;
    [SerializeField] private float speedPlayer = 10f;
    [SerializeField] private float speedTurn= 7f;

    [SerializeField] private GameObject mPlayer;

    
    private Rigidbody rbPlayer;


    // Start is called before the first frame update
    void Start()
    {
    
        rbPlayer = GetComponent<Rigidbody>();

        SetPlayerRotation();
    }

    void Update()
    {

     
    }

    private void FixedUpdate()
    {
        Move();
        RotatePlayer();
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical   = Input.GetAxis("Vertical");

        if (ejeHorizontal != 0 || ejeVertical != 0) {
            //animPlayer.SetBool("isRun", true);
            rbPlayer.AddRelativeForce(Vector3.forward * speedPlayer * ejeVertical, ForceMode.Force);
            rbPlayer.AddRelativeForce(Vector3.right  * speedPlayer * ejeHorizontal, ForceMode.Force);
           
        }
        else
        {
            
            ResetVelocities();
        }
    }
    private void RotatePlayer()
    {
        if(Input.GetAxisRaw("Mouse X") != 0) { 
            cameraAxisX += Input.GetAxisRaw("Mouse X");
            SetPlayerRotation();
        }
    }
    

    private void SetPlayerRotation()
    {
        Quaternion angulo = Quaternion.Euler(0, cameraAxisX * speedTurn, 0);
        transform.rotation = angulo;
        mPlayer.transform.rotation = transform.rotation;
    }

    private void ResetVelocities()
    {
        rbPlayer.velocity = Vector3.zero;
        rbPlayer.angularVelocity = Vector3.zero;
    }
}
