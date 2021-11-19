using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDAPlayerController : MonoBehaviour
{
    //[SerializeField] private int lifePlayer = 3;
    [SerializeField] private float cameraAxisX = -90f;
    [SerializeField] private float speedPlayer = 10f;
    [SerializeField] private float speedTurn= 7f;

    //[SerializeField] private Animator animPlayer;
    //[SerializeField] private AudioClip punchSound;
    //[SerializeField] private AudioClip walkSound;
    [SerializeField] private GameObject mPlayer;

    //private AudioSource audioPlayer;
    private Rigidbody rbPlayer;


    // Start is called before the first frame update
    void Start()
    {
        //audioPlayer = GetComponent<AudioSource>();
        rbPlayer = GetComponent<Rigidbody>();
        //animPlayer.SetBool("isRun", false);
        SetPlayerRotation();
    }

    void Update()
    {
        Move();
        RotatePlayer();
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            audioPlayer.PlayOneShot(punchSound, 1f);
            animPlayer.SetBool("isPunch", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animPlayer.SetBool("isPunch", false);
        }*/
    }

    private void FixedUpdate()
    {

    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical   = Input.GetAxis("Vertical");

        if (ejeHorizontal != 0 || ejeVertical != 0) {
            //animPlayer.SetBool("isRun", true);
            rbPlayer.AddRelativeForce(Vector3.forward * speedPlayer * ejeVertical, ForceMode.Force);
            rbPlayer.AddRelativeForce(Vector3.right  * speedPlayer * ejeHorizontal, ForceMode.Force);
            /*if (!audioPlayer.isPlaying)
            {
                audioPlayer.PlayOneShot(walkSound, 0.5f);
            }*/
        }
        else
        {
            //animPlayer.SetBool("isRun", false);
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
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lifePlayer--;
            Destroy(collision.gameObject);
            if(lifePlayer < 0)
            {
                Debug.Log("GAME OVER");
            }
        }
        
    }*/

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Generator"))
        {
            other.gameObject.GetComponent<GeneratorController>().setNewColor(Color.black);
        }
    }*/

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
