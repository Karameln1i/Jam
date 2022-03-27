using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSound : MonoBehaviour
{
    [SerializeField] private AudioSource _musicAudio;
    
    private static readonly string MusicPref = " MusicPref";
    private float musicFloat;

    private void Awake()
    {
        LevelSoundSetings();
    }

    private void LevelSoundSetings()
    {
        musicFloat = PlayerPrefs.GetFloat(MusicPref);

        _musicAudio.volume = musicFloat;
    }
}
