using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [SerializeField] private List<GameObject> Fruits = new List<GameObject>(); //List  
    //[SerializeField] private List<GameObject> Food = new List<GameObject>();
    [SerializeField] private GameObject[] Food; //Array

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
        
        if ((obj.collider.tag == "Fruit") || (obj.collider.tag == "Food"))
        {   
            //Debug.Log(obj.collider.tag);

            //Debug.Log(obj.gameObject.name);
            obj.gameObject.SetActive(false);
            
        }
        
     }


    private void OnTriggerEnter(Collider other)
    {
        
        //Debug.Log(other.tag);
        
        if(other.tag == "Fruit")
        {
            foreach (GameObject fruit in Fruits) //foreach (var fruit in Fruits)
            {
                //Debug.Log(fruit.name);
                fruit.SetActive(true);
                
                switch (fruit.name)
                {
                    case "Olive":
                        GameObject.Find(fruit.name).transform.position = new Vector3(7f,2f,-7.73f);
                        break;
                    case "Cherry":
                        GameObject.Find(fruit.name).transform.position = new Vector3(7.44f,2f,-8.6f);
                        break;
                    case "Banana":
                        GameObject.Find(fruit.name).transform.position = new Vector3(6.54f,2f,-8.12f);
                        break;
                    default:
                        break;
                } 
                
            }
        }

        if(other.tag == "Food")
        {

            foreach (GameObject food in Food) 
            {
                
                food.SetActive(true);
                
                switch (food.name)
                {
                    case "Hotdog":
                        GameObject.Find(food.name).transform.position = new Vector3(6.86f,2f,2.34f);
                        break;
                    case "Hamburger":
                        GameObject.Find(food.name).transform.position = new Vector3(6.31f,2f,2.83f);
                        break;
                    case "Cheese":
                        GameObject.Find(food.name).transform.position = new Vector3(6.31f,2f,1.94f);
                        break;
                    default:
                        break;
                } 

            }

        }
    }

    
}
