using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    bool isPaused = false;
    [SerializeField] GameObject pausemenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnPause()
    {
        if (isPaused)
        {
            Time.timeScale = 1.0f;
            isPaused = false;
            pausemenu.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            pausemenu.SetActive(true);
        }
    }

}
