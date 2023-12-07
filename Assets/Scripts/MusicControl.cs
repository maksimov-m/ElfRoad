using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using System;


public class MusicControl {

    private static MusicControl _instance;
    private AudioSource _audioSource;
    private DateTime _time;  
    public AudioSource AudioSource 
    {
        get { return _audioSource; }
        set { _audioSource = value; }
    }
    public bool IsPlayMusic { get; set; } = false;
    private MusicControl() { }

    public static MusicControl Instance() 
    {
        if (_instance == null)
            _instance = new MusicControl();
        return _instance; 
    }

    public void PlayBackgroundSound()
    {

        if (_audioSource != null)
        {
            IsPlayMusic = true;
            _audioSource?.Play();
        }
    }

    public void StopBackgroundSound() 
    {
       IsPlayMusic = false;
       AudioSource?.Stop();
    }

}
