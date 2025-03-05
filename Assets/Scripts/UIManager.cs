using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel, settingsPanel, mainMenu, inGameMenu;
    public AudioSource bgsound;
    public Slider volumeSlider;
    public TMP_Dropdown antiAliasingDropdown, resolutionDropdown;
    public Toggle vsyncToggle;

    void Start()
    {
        OpenMainMenu();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && mainMenu.activeInHierarchy == true)
        {
            StartTheGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && mainMenu.activeInHierarchy == false)
        {
            OpenMainMenu();
        }
    }

    public void SetVysnc()
    {
        if(vsyncToggle.isOn)
            QualitySettings.vSyncCount = 1;
        else
            QualitySettings.vSyncCount = 0;
    }

    public void SetResolution()
    {
        if (resolutionDropdown.value == 0)
            Screen.SetResolution(1366, 768, true);
        else if (resolutionDropdown.value == 1)
            Screen.SetResolution(1920, 1080, true);
        else if (resolutionDropdown.value == 2)
            Screen.SetResolution(2560, 1440, true);
        else if (resolutionDropdown.value == 3)
            Screen.SetResolution(3840, 2160, true);
    }

    public void SetAntiAliasing()
    {
        if (antiAliasingDropdown.value == 0)
            QualitySettings.antiAliasing = 0;
        else if (antiAliasingDropdown.value == 1)
            QualitySettings.antiAliasing = 2;
        else if (antiAliasingDropdown.value == 2)
            QualitySettings.antiAliasing = 4;
        else if (antiAliasingDropdown.value == 3)
            QualitySettings.antiAliasing = 8;
    }

    public void VolumeControl()
    {
        bgsound.volume = volumeSlider.value;
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartTheGame()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
        bgsound.Stop();
        inGameMenu.SetActive(true);
    }
    public void SettingsButton()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
    public void BacktoMainMenuButton()
    {
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        inGameMenu.SetActive(false);
        bgsound.Play();
    }
}
