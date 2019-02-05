using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonManager : MonoBehaviour {

    public int numLevel;

    // переход к numLevel сцене
    public void GoToScene()
    {
        SceneManager.LoadScene(numLevel);
    }
}
