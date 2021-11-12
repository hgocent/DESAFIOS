using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerVectores : MonoBehaviour
{
    [SerializeField] private float speedPlayer = 5f;
    [SerializeField] private float rotationSpeed = 100;
    private float mouseX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovePlayer();
    }
    private void MovePlayer(){
        float Vmove = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * new Vector3(0,0, Vmove) * Time.deltaTime);
    }
    
    private void RotatePlayer()
    {
        float hRotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hRotate * rotationSpeed * Time.deltaTime);
    }
    
}
