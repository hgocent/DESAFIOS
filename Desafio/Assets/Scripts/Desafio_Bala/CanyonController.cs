using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CanyonController : MonoBehaviour
{   
    public GameObject[] bulletPrefab;
    public float timeSpawn;
    public float timeDelay;
    public Transform bulletScale1;
    public Transform bulletScale2;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", timeDelay, timeSpawn);
       
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Space))
        {
            EscalaX2();//Disparo();Test
        } else {
            Escala();
        }
    }

    void Disparo()
    {
        int enemyIndex = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[enemyIndex], transform.position, bulletPrefab[enemyIndex].transform.rotation);
    }

    void Escala(){
        bulletScale1.transform.localScale = new Vector3(0.15f,0.15f,0.15f);
        bulletScale2.transform.localScale = new Vector3(0.15f,0.15f,0.15f);
        return;
    }
    void EscalaX2(){
        bulletScale1.transform.localScale = new Vector3(0.30f,0.30f,0.30f);
        bulletScale2.transform.localScale = new Vector3(0.30f,0.30f,0.30f);
        return;
    }


}
