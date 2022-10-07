using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;
    public bool cardSelected;

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

    public GameObject battlePoint;
    //public PlayerStats playerStats;
    public CardStats cardStats;
    //public CardSnap cardSnap;
    //public OppCardSnap oppCardSnap;
    public int score;
    public bool set;
    public bool chase;
    public bool playerBatsman;
    public bool playerBowler;
    public bool oppBatsman;
    public bool oppBowler;
    public int mScore;
    public int oppScore;
    public int playerTurn;
    public int pBallCount;


    void Start()
    {
        
    }


    void Update()
    {

    }


    public void PlayerTurn()
    {
        if (cardSelected)
        {
            cardStats.playerStats.playerBC++;
            //playerStats.playerBC += 1;
            Cases();
            score = playerTurn;
            pBallCount = cardStats.playerStats.playerBC;
            if (cardStats.playerStats.playerBC >= 6)
            {
                cardStats.gameObject.SetActive(false);
            }
            //Debug.Log(cardStats.playerStats.playerBC);
        }
    }
    public void Cases()
    {
        switch (cardStats.playerStats.playerBC)
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

    public void ScoreCalculation()
    {
        if (set)
        {
            //mScore = 0;

            if (playerBatsman)
            {

                mScore = mScore + score;
                
            }

            /*if (oppBatsman)
            {
                oppScore = oppScore + score;
            }*/

            if (playerBowler)
            {
                for (oppScore = 0; oppScore >= 0;) 
                {
                    oppScore = oppScore - score;
                }
            }

            /*if (oppBowler)
            {
                for (mScore = 0; mScore >= 0;)
                {
                    mScore = mScore - score;
                }
            }*/

            Debug.Log("My Score is -" + mScore + "and opponent score is -" + oppScore);
        }

        if (chase)
        {
            mScore = 100;

            if (playerBatsman)
            {
                mScore = mScore - score;
            }

            if (oppBatsman)
            {
                oppScore = oppScore - score;
            }

            if (playerBowler)
            {
                for (oppScore = 100; oppScore < 100;)
                {
                    oppScore = oppScore + score;
                }
            }

            if (oppBowler)
            {
                for (mScore = 100; mScore < 100;)
                {
                    mScore = mScore + score;
                }
            }

            Debug.Log("My Score is -" + mScore + "and opponent score is -" + oppScore);

        }
    }
}
