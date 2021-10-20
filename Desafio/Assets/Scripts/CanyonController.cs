using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CanyonController : MonoBehaviour
{   
    public GameObject[] bulletPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Disparo", 2f, 4f); this line belonged to the previous desafio.
       
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparo();
        }
    }

    void Disparo()
    {
        int enemyIndex = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[enemyIndex], transform.position, bulletPrefab[enemyIndex].transform.rotation);
    }
}
