using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActAdapter : MonoBehaviour {

    public Text costInput;
    public Text targetInput;


    public Act GenerateAct()
    {
        return new Act(costInput.text, targetInput.text);
    }

    public void SetDefaultActs()
    {
        ActManager.DefaultActs();
    }

    public void AddActs()
    {
        Act act = GenerateAct();
        ActManager.UpdateActs(act);
    }

}
