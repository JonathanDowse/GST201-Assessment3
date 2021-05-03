using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public GameObject exitMenu, optionsMenu, exitButton, optionsButton, menuReturn, gameExit, exitX, pauseMenu, unpauseBtn, pauseX, optionsX, musicSlider, volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void optionsBtnPressed()
    {
        exitMenu.SetActive(false);
        exitButton.SetActive(false);
        optionsMenu.SetActive(true);
        optionsButton.SetActive(false);
        menuReturn.SetActive(false);
        gameExit.SetActive(false);
        exitX.SetActive(false);
        pauseMenu.SetActive(false);
        unpauseBtn.SetActive(false);
        pauseX.SetActive(false);
        optionsX.SetActive(true);
        musicSlider.SetActive(true);
        volumeSlider.SetActive(true);
    }

    public void exitBtnPressed()
    {
        exitMenu.SetActive(true);
        exitButton.SetActive(false);
        optionsMenu.SetActive(false);
        optionsButton.SetActive(false);
        menuReturn.SetActive(true);
        gameExit.SetActive(true);
        exitX.SetActive(true);
        pauseMenu.SetActive(true);
        unpauseBtn.SetActive(true);
        pauseX.SetActive(true);
        optionsX.SetActive(true);
        musicSlider.SetActive(true);
        volumeSlider.SetActive(true);
    }

    public void exitXPressed()
    {
        exitMenu.SetActive(false);
        exitButton.SetActive(true);
        optionsMenu.SetActive(false);
        optionsButton.SetActive(true);
        menuReturn.SetActive(false);
        gameExit.SetActive(false);
        exitX.SetActive(false);
        pauseMenu.SetActive(true);
        unpauseBtn.SetActive(true);
        pauseX.SetActive(true);
        optionsX.SetActive(false);
        musicSlider.SetActive(false);
        volumeSlider.SetActive(false);
    }

    public void optionsXPressed()
    {
        exitMenu.SetActive(false);
        exitButton.SetActive(true);
        optionsMenu.SetActive(false);
        optionsButton.SetActive(true);
        menuReturn.SetActive(false);
        gameExit.SetActive(false);
        exitX.SetActive(false);
        pauseMenu.SetActive(true);
        unpauseBtn.SetActive(true);
        pauseX.SetActive(true);
        optionsX.SetActive(false);
        musicSlider.SetActive(false);
        volumeSlider.SetActive(false);

    }
   
}
