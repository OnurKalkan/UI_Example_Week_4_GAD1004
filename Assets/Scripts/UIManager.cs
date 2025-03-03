using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu, settings;
    public AudioSource bgsound;
    public Slider soundSlider;

    public void VolumeControl()
    {
        bgsound.volume = soundSlider.value;
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        mainMenu.SetActive(false);
        settings.SetActive(false);
    }
    public void SettingsButton()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void MainMenuButton()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }
}
