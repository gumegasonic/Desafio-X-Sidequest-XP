using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameOverMenu gameOverUI;

    public string levelName = SAME_SCENE;

    public const string SAME_SCENE = "0";

    public string firstLevel;

    public IsEnabled enabledScript;

    public GameObject Destroy1;
    public GameObject Destroy2;
    public GameObject Destroy3;
    public GameObject Destroy4;
    public GameObject Destroy5;
    public GameObject Destroy6;
    public GameObject Destroy7;

    public string gameSelectionScene;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && enabledScript.enabled == false)
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
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()

    {
        Resume();
        Time.timeScale = 1f;
        Destroy(Destroy1);
        Destroy(Destroy2);
        Destroy(Destroy3);
        Destroy(Destroy4);
        Destroy(Destroy5);
        Destroy(Destroy6);
        Destroy(Destroy7);
        SceneManager.LoadScene("Menu");
        StopAllCoroutines();
        Physics2D.IgnoreLayerCollision(8, 11, false);
    }

    public void QuitGame()
    {
        Resume();
        Time.timeScale = 1f;
        Destroy(Destroy1);
        Destroy(Destroy2);
        Destroy(Destroy3);
        Destroy(Destroy4);
        Destroy(Destroy5);
        Destroy(Destroy6);
        Destroy(Destroy7);
        SceneManager.LoadScene(gameSelectionScene, LoadSceneMode.Single);
        StopAllCoroutines();
        Physics2D.IgnoreLayerCollision(8, 11, false);
    }

    public void Restart()

    {
        Resume();
        Time.timeScale = 1f;
        Destroy(Destroy1);
        Destroy(Destroy2);
        Destroy(Destroy3);
        Destroy(Destroy4);
        Destroy(Destroy5);
        Destroy(Destroy6);
        Destroy(Destroy7);
        SceneManager.LoadScene(firstLevel, LoadSceneMode.Single);
        StopAllCoroutines();
        Physics2D.IgnoreLayerCollision(8, 11, false);
    }

    public void Respawn()
    {
        Resume();
        Time.timeScale = 1f;
        Destroy(Destroy1);
        Destroy(Destroy2);
        Destroy(Destroy3);
        Destroy(Destroy4);
        Destroy(Destroy5);
        Destroy(Destroy6);
        Destroy(Destroy7);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        enabledScript.enabled = false;
        StopAllCoroutines();
        Physics2D.IgnoreLayerCollision(8, 11, false);
    }
}