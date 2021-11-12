using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static int playerLife;
    public static int playerScore;

    //Make singleton
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            playerLife = 100;
            playerScore = 0;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getLife()
    {
        return playerLife;
    }

    public static int getScore()
    {
        return playerScore;
    }


    public static void decreaseLife(int damage)
    {
        playerLife -= damage;
    }

    public static void increaseScore(int score)
    {
        playerScore += score;
    }


}
