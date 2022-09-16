using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Singleton
    public static ScoreManager instance;
    

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);


            return;
        }
        instance = this;
    }
    #endregion;

    public CardStats cardStats;
    
    public int playerTurn;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Cases()
    {
        switch(cardStats.playerStats.playerBC)
        {
            case 1:
                playerTurn = cardStats.playerStats.ball1;
                break;
            case 2:
                playerTurn = cardStats.playerStats.ball2;
                break;
            case 3:
                playerTurn = cardStats.playerStats.ball3;
                break;
            case 4:
                playerTurn = cardStats.playerStats.ball4;
                break;
            case 5:
                playerTurn = cardStats.playerStats.ball5;
                break;
            case 6:
                playerTurn = cardStats.playerStats.ball6;
                break;
        }
    }

}
