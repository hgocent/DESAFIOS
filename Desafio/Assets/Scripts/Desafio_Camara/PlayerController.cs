using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speedPlayer;
    public Vector3 initPosition = new Vector3(4, 2, 1);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }
    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(-ejeVertical, 0, ejeHorizontal));
    }
}
