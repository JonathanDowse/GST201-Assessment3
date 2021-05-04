using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public bool gamePaused = false;

    public GameObject pauseScreen, pauseX, unpauseBtn, optionsBtn, exitBtn;
    public GameObject optionsScreen, optionsX, volumeSlider, musicSlider;
    public GameObject exitScreen, exitX, menuReturnBtn, gameExitBtn;
    public GameObject pauseMenu;


    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gamePaused = false;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        pauseScreen.SetActive(false);
        pauseX.SetActive(false);
        unpauseBtn.SetActive(false);
        optionsBtn.SetActive(false);
        exitBtn.SetActive(false);
        optionsScreen.SetActive(false);
        optionsX.SetActive(false);
        volumeSlider.SetActive(false);
        musicSlider.SetActive(false);
        exitScreen.SetActive(false);
        exitX.SetActive(false);
        menuReturnBtn.SetActive(false);
        gameExitBtn.SetActive(false);
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
        pauseX.SetActive(true);
        unpauseBtn.SetActive(true);
        optionsBtn.SetActive(true);
        exitBtn.SetActive(true);
        optionsScreen.SetActive(false);
        optionsX.SetActive(false);
        volumeSlider.SetActive(false);
        musicSlider.SetActive(false);
        exitScreen.SetActive(false);
        exitX.SetActive(false);
        menuReturnBtn.SetActive(false);
        gameExitBtn.SetActive(false);
    }

   public void Unpause()
    {
        Time.timeScale = 1;
        gamePaused = false;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        
    }


    public void optionsBtnPressed()
    {
        pauseMenu.SetActive(true);
        pauseScreen.SetActive(false);
        pauseX.SetActive(false);
        unpauseBtn.SetActive(false);
        optionsBtn.SetActive(false);
        exitBtn.SetActive(false);
        optionsScreen.SetActive(true);
        optionsX.SetActive(true);
        volumeSlider.SetActive(true);
        musicSlider.SetActive(true);
        exitScreen.SetActive(false);
        exitX.SetActive(false);
        menuReturnBtn.SetActive(false);
        gameExitBtn.SetActive(false);
    }

    public void exitBtnPressed()
    {
        pauseMenu.SetActive(true);
        pauseScreen.SetActive(false);
        pauseX.SetActive(false);
        unpauseBtn.SetActive(false);
        optionsBtn.SetActive(false);
        exitBtn.SetActive(false);
        optionsScreen.SetActive(false);
        optionsX.SetActive(false);
        volumeSlider.SetActive(false);
        musicSlider.SetActive(false);
        exitScreen.SetActive(true);
        exitX.SetActive(true);
        menuReturnBtn.SetActive(true);
        gameExitBtn.SetActive(true);
    }

    public void optionsXPressed()
    {
        pauseMenu.SetActive(true);
        pauseScreen.SetActive(true);
        pauseX.SetActive(true);
        unpauseBtn.SetActive(true);
        optionsBtn.SetActive(true);
        exitBtn.SetActive(true);
        optionsScreen.SetActive(false);
        optionsX.SetActive(false);
        volumeSlider.SetActive(false);
        musicSlider.SetActive(false);
        exitScreen.SetActive(false);
        exitX.SetActive(false);
        menuReturnBtn.SetActive(false);
        gameExitBtn.SetActive(false);
    }    

    public void exitXPressed()
    {
        pauseMenu.SetActive(true);
        pauseScreen.SetActive(true);
        pauseX.SetActive(true);
        unpauseBtn.SetActive(true);
        optionsBtn.SetActive(true);
        exitBtn.SetActive(true);
        optionsScreen.SetActive(false);
        optionsX.SetActive(false);
        volumeSlider.SetActive(false);
        musicSlider.SetActive(false);
        exitScreen.SetActive(false);
        exitX.SetActive(false);
        menuReturnBtn.SetActive(false);
        gameExitBtn.SetActive(false);
    }
}
