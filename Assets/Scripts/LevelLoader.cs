using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 3f;
    public static LevelLoader Instance;
    private void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadEnd();
        }    
    }*/
    public void LoadPlay()
    {
        StartCoroutine(LoadLevel(1));
    }
    public void LoadEnd()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadWin()
    {
        //end story
        StartCoroutine(LoadLevel(5));
    }
    public void LoadPlayAgain()
    {
        StartCoroutine(LoadLevel(1));
    }
    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel(4));
    }
    public void LoadEndGame()
    {
        StartCoroutine(LoadLevel(3));
    }
    IEnumerator LoadLevel(int index)
    {
        Debug.Log("TRANSITION");
        //play animation
        transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(transitionTime);
        //load scene
        SceneManager.LoadScene(index);
       
    } 
}
