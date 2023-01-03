using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void PlayGame()
    {
        var canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);

        LevelLoader.Instance.LoadPlay();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  == 2 ? SceneManager.GetActiveScene().buildIndex - 1 : SceneManager.GetActiveScene().buildIndex == 3 ? 1 : SceneManager.GetActiveScene().buildIndex + 1);

       // Destroy(gameObject);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
