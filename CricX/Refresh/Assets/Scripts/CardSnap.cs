using UnityEngine;

public class CardSnap : MonoBehaviour
{
    //public CardStats cardStats;
    public bool referStat;

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "cubee")
        {
            other.transform.localPosition = this.transform.localPosition;
            GameManager.instance.cardStats = other.gameObject.GetComponent<CardStats>();
            Debug.Log("cube placed");
        }

        else if (other.gameObject.tag == "PlayerBatsman")
        {
            other.transform.position = this.transform.position;
            GameManager.instance.cardStats = other.gameObject.GetComponent<CardStats>();
            //ScoreManager.instance.cardStats = other.gameObject.GetComponent<CardStats>();
            //referStat = true;
        }

        else if (other.gameObject.tag == "PlayerBowler")
        {
            other.transform.localPosition = this.transform.localPosition;
            GameManager.instance.cardStats = other.gameObject.GetComponent<CardStats>();
            //ScoreManager.instance.cardStats = other.gameObject.GetComponent<CardStats>();
        }

       /* if (referStat)
        {




            GameManager.instance.ScoreCalculation();
        }*/

        GameManager.instance.battlePoint = other.gameObject;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cubee")
            GameManager.instance.cardSelected = true;

        if (other.gameObject.tag == "PlayerBatsman")
        {
            GameManager.instance.playerBatsman= true;
            GameManager.instance.cardSelected = true;
        }

        if (other.gameObject.tag == "PlayerBowler")
        {
            GameManager.instance.playerBowler = true;
        }



    }

}
