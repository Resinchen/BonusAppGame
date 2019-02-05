using System;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour {

    public Image barPlus;
    public Image barMinus;
    public PlayerManager player;
    const float MAXSCORE = 500;

    void Update () {
        if (player.score >= 0)
        {
            barMinus.fillAmount = 0;
            barPlus.fillAmount = player.score / MAXSCORE;
        }
        else
        {
            barPlus.fillAmount = 0;
            barMinus.fillAmount = Math.Abs(player.score) / MAXSCORE;
        }

    }
}
