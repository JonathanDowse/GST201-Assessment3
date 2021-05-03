using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu, exitMenu, optionsMenu, exitButton, optionsButton, menuReturn, gameExit, exitX, unpauseBtn, pauseX, optionsX, musicSlider, volumeSlider;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gamePaused = false;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                Pause();
                
            }

            else if (gamePaused == true)
            {
                Unpause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        gamePaused = true;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        pauseScreen.SetActive(true);
        exitMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

   public void Unpause()
    {
        Time.timeScale = 1;
        gamePaused = false;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        pauseScreen.SetActive(false);
    }
}
