using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Перетащите сюда вашу панель меню паузы
    private bool isPaused = false;

    void Update()
    {
        // Проверка нажатия клавиши Esc для паузы
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        pauseMenuUI.SetActive(false); // Скрыть меню паузы
        Time.timeScale = 1f; // Возобновить игру
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Показать меню паузы
        Time.timeScale = 0f; // Приостановить игру
        isPaused = true;
    }
}
