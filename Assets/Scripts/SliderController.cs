using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public Slider slider;

    void Start()
    {
        float value;
        bool result = AudioMixer.GetFloat("volume", out value);
        Debug.Log("audio" + (result ? value : 0f));
        Debug.Log(slider);
        this.slider.value = value;
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
