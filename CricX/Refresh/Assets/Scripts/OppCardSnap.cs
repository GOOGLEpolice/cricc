using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppCardSnap : MonoBehaviour
{
 
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "cubee" || other.gameObject.tag == "OppBatsman" || other.gameObject.tag == "OppBowler")
        {
            other.transform.localPosition = this.transform.localPosition;
            GameManager.instance.oppCardStats = other.gameObject.GetComponent<CardStats>();


        }

        GameManager.instance.oppBattlePoint = other.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cubee")
            GameManager.instance.cardSelected = true;

        if (other.gameObject.tag == "OppBatsman")
        {
            GameManager.instance.oppBatsman= true;
            GameManager.instance.cardSelected = true;
        }

        if (other.gameObject.tag == "OppBowler")
        {
            GameManager.instance.oppBowler = true;
            GameManager.instance.cardSelected = true;
        }

    }
}
