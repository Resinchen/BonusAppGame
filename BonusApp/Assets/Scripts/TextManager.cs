using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public string label;

    public PlayerManager player;
	
	void Update () {
        if (label == "level")
        {
            GetComponent<Text>().text = "Твой уровень: " + player.level.ToString();
        }
        else if (label == "score")
        {
            GetComponent<Text>().text = "Твои очки: " + player.score.ToString();
        }
        if (label == "fall")
        {
            if (player.level < 0)
            {
                GetComponent<Text>().text = "Ты проиграл((((";
            }
            else
            {
                GetComponent<Text>().text = "";
            }

        }
        
    }
}
