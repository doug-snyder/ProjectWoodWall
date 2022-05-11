using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    
    public void StartButton(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitButton() => Application.Quit();

}
