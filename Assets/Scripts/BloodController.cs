using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;
using UnityEngine.SceneManagement;

public class BloodController : MonoBehaviour
{
     public Animator transition;
    public static BloodController Instance;
    private void Awake()
    {
        transition = GetComponent<Animator>();
        Instance = this;
    }
    public void LoadBlood()
    {
        StartCoroutine(LoadEffectBlood());
    }
    IEnumerator LoadEffectBlood()
    {
            //play animation
            transition.SetTrigger("Start");
            //wait
            yield return new WaitForSeconds(1);
            transition.SetTrigger("End");
    }
}
