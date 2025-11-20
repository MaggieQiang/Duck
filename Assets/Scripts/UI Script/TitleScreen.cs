using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToHome()
    {
        SceneManager.LoadScene("HomePage");
    }

    public void GoToPlay()
    {
        SceneManager.LoadScene("Main Game Scene");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void GoToCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
