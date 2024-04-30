using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] AudioSource music;

    public GameObject pauseMenuUI;

    float musicTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        music.Play();
        music.time = musicTime;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

        musicTime = music.time;

        GameIsPaused = true;
        music.Stop();
    }

    public void Loadmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
