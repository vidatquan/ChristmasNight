using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnEnable()
    {
        LevelLoader.Instance.LoadEndGame();
    }
}
