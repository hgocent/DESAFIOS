using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float rayLenght = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastTurret();
    }

    private void RaycastTurret()
    {
        //Debug.Log("Shoot Tank");
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, rayLenght))
        {
            //Debug.Log(GameManager.getLife());
            GameManager.decreaseLife(1);
            Debug.Log("I WAS HIT, LIFE DECREASED: " + GameManager.getLife());

        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, Vector3.forward * rayLenght);
    }

}
