using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class mainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    //the play button
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //the quit button
    public void QuitGame()
    {
        Debug.Log("Quitting");
            Application.Quit();
    }

    //fullscreen
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
