using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerVectores : MonoBehaviour
{
    enum TypesEnemys { Follow, Look};
    [SerializeField] private TypesEnemys typeEnemy;
    [SerializeField] private float speedEnemy = 10f;
    [SerializeField] private float speedRotation = 1f;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch (typeEnemy)
        {
            case TypesEnemys.Follow:
                LookAt(player);
                MoveTowards();
                break;
            case TypesEnemys.Look:
                LookAt(player);
                break;
        }
    }
    private void LookAt(GameObject lookObject)
    {
        Quaternion newRotation = Quaternion.LookRotation(lookObject.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedRotation * Time.deltaTime);
    }
    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 2)
        {
            transform.position += speedEnemy * direction.normalized * Time.deltaTime;
        }
    }

}
