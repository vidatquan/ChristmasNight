using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextMainMenu : MonoBehaviour
{
    private void OnEnable()
    {
        LevelLoader.Instance.LoadMainMenu();
    }
}
