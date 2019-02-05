using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetManager : MonoBehaviour {

    Button button;
    public PlayerManager player;

    void Start()
    {
        button = GameObject.Find("ResetButton").GetComponent<Button>();


        button.onClick.AddListener(() => 
        {
            WindowYNManager.ShowMessage(() => 
            {
                player.GetComponent<Loader>().Reset();
            }, "Сбросить очки?");
        });
    }
}
