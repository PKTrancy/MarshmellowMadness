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
    public float efxSlider = 0.5f;
    public float musicSlider = 0.5f;


    void Update()
    {
        efxSource.volume = efxSlider;
        musicSource.volume = musicSlider;
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

    public void SetMusicVolume(float musicVol)
    {
        musicSlider = musicVol;
    }

    public void SetEfxVolume(float efxVol)
    {
        efxSlider = efxVol;
    }

}