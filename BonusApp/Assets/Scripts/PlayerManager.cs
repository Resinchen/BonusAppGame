using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;

public class PlayerManager : MonoBehaviour {

    public int score;
    public int level;
    const int MAXSCORE = 500;

    void Start () {
        score = PlayerPrefs.GetInt("Score");
        level = PlayerPrefs.GetInt("Level");

    }

    void Update () {
		if (score >= 500)
        {
            score %= MAXSCORE;
            level += 1;
        }
        else if (score <= -500)
        {
            score %= MAXSCORE;
            level -= 1;
        }
        if (level < 0)
        {
            if (SceneManager.GetActiveScene().name != "Main")
            {
                SceneManager.LoadScene(0);
            }
        }
	}
}
