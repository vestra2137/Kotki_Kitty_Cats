using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] PlayerMovement playerMovement;

    public static bool isPaused = false;

    private void Start()
    {
        if (pauseMenu != null) pauseMenu.SetActive(false);

        // Na starcie: zablokuj kursor i ukryj (jeśli zaczynasz w trybie gry)
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
    }

    public void PauseGame()
    {
        Debug.Log("PauseMenu.PauseGame()");
        if (pauseMenu != null) pauseMenu.SetActive(true);

        Time.timeScale = 0f;
        isPaused = true;

        // Odblokuj kursor i pokaż go
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Zabezpieczenie: jeśli referencja nie przypisana — informujemy
        if (playerMovement != null)
            playerMovement.SetCanMove(false);
        else
            Debug.LogWarning("PauseMenu: playerMovement nieprzypisany!");
    }

    public void ResumeGame()
    {
        Debug.Log("PauseMenu.ResumeGame()");
        if (pauseMenu != null) pauseMenu.SetActive(false);

        Time.timeScale = 1f;
        isPaused = false;

        // Zablokuj i ukryj kursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (playerMovement != null)
            playerMovement.SetCanMove(true);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        isPaused = false;
        if (playerMovement != null) playerMovement.SetCanMove(true);
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
