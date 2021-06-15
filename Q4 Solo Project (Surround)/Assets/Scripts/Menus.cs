using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject menuUI;
    public GameObject p1Win;
    public GameObject p2Win;

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

        if (P1Score.p1Score >= 13)
        {
            P1();
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        if (P2Score.p2Score >= 13)
        {
            P2();
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        P1Score.p1Score = 0;
        P2Score.p2Score = 0;
        p1Win.SetActive(false);
        p2Win.SetActive(false);
        Resume();
    }

    void P1()
    {
        p1Win.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void P2()
    {
        p2Win.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Surround");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}