using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonManager : MonoBehaviour {

    // Переход в меню добавления очков
    public void ButtonAddScore()
    {
        SceneManager.LoadScene(1);
    }

    // Переход в меню вычитания очков
    public void ButtonSubScore()
    {
        SceneManager.LoadScene(2);

    }
}
