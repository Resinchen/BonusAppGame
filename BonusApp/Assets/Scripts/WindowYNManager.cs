using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowYNManager : MonoBehaviour {

    private static WindowYNManager instance;

    public GameObject template;

    void Awake()
    {
        instance = this;
    }

    // работа с диалоговым окном
    public static void ShowMessage(Action action, string text)
    {
        GameObject message = Instantiate(instance.template);

        Transform panel = message.transform.Find("Panel");

        Text messageBoxText = panel.Find("Text").GetComponent<Text>();
        messageBoxText.text = text;

        Button yes = panel.Find("Yes").GetComponent<Button>();
        Button no = panel.Find("No").GetComponent<Button>();

        yes.onClick.AddListener(() =>
        {
            action();
            Destroy(message);
        });

        no.onClick.AddListener(() =>
        {
            Destroy(message);
        });
    }
}
