using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] private List<GameObject> Fruits = new List<GameObject>(); //List  
    [SerializeField] private List<GameObject> Food = new List<GameObject>();
    //[SerializeField] GameObject[] Food; //Array

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision obj)
     {
        
        if (obj.collider.tag == "Fruit")
        {   
            //Debug.Log(obj.collider.tag);

            //Debug.Log(obj.gameObject.name);
            obj.gameObject.SetActive(false);
            
        }
        if (obj.collider.tag == "Food")
        {   
            //Debug.Log(obj.collider.tag);

            //obj.gameObject.SetActive(false);
            //Food.Add(GameObject);
            //GameObject.SetActive(false);
            
        }
     }

}
