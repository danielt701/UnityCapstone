using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;

    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.80f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("Music", Mathf.Log10(sliderValue) * 20);

        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

 

}
