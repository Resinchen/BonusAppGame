using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButtonManager : MonoBehaviour {

    public PlayerManager player;
    public List<Act> acts = new List<Act>();
    public GameObject prefButton;
    public Transform content;
    public int isPositive;

    void Start()
    {
        acts = ActManager.LoadActs();


        foreach (Act act in acts)
        {
            if (isPositive == Math.Sign(act.cost))
            {
                GameObject newButton = GameObject.Instantiate(prefButton) as GameObject;
                newButton.transform.Find("Cost").GetComponent<Text>().text = act.cost.ToString();
                newButton.transform.Find("Target").GetComponent<Text>().text = act.target;

                
                newButton.transform.SetParent(content);
                newButton.transform.localScale = new Vector3(1, 1, 1);

                newButton.GetComponent<Button>().onClick.AddListener(() => {
                    act.makeAct(player);
                });
            }
        }
    }
 
}
