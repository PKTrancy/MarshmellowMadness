using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public AudioSource efxSource;                   //Drag a reference to the audio source which will play the sound effects.
    public AudioSource musicSource;                 //Drag a reference to the audio source which will play the music.
    public static Audio instance = null;     //Allows other scripts to call functions from SoundManager.             
                                             //The highest a sound effect will be randomly pitched.
    //sliders for sound
    public Slider efxSlider;
    public Slider musicSlider;

    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("Music Volume");
        efxSlider.value = PlayerPrefs.GetFloat("Efx Volume");
    }

    void Update()
    {
        efxSource.volume = efxSlider.value;
        musicSource.volume = musicSlider.value;
        PlayerPrefs.SetFloat("Music Volume", musicSource.volume);
        PlayerPrefs.SetFloat("Efx Volume", efxSlider.value);
    }

    void Awake()
    {
        //Check if there is already an instance of SoundManager
        if (instance == null)
            //if not, set it to this.
            instance = this;
        //If instance already exists:
        else if (instance != this)
            //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
            Destroy(gameObject);

        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);
    }


    //Used to play single sound clips.
    public void PlaySingle()
    {
        //Play the clip.
        efxSource.Play();
    }

    

}