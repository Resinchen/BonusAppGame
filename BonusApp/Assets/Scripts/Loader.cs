using UnityEngine;

public class Loader : MonoBehaviour {

    public PlayerManager player;

    void Update () {
        PlayerPrefs.SetInt("Score", player.score);
        PlayerPrefs.SetInt("Level", player.level);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        player.score = 0;
        player.level = 0;
        PlayerPrefs.Save();
    }
}
