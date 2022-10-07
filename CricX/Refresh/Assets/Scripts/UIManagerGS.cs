using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerGS : MonoBehaviour
{
    public TMP_Text playerScore;
    public TMP_Text oppScore;
    void Update()
    {
        oppScore.text = GameManager.instance.oppScore.ToString("f0");
        playerScore.text = GameManager.instance.mScore.ToString("f0");
    }
}
