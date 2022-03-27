using Michsky.UI.ModernUIPack;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MusicPref = " MusicPref";

    [SerializeField] private int firstPlayInt;
    [SerializeField] private RadialSlider musicSlider;
    private float musicFloat;

    [SerializeField] private AudioSource _musicAudio;

    private void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            musicFloat = 0.75f;
            musicSlider.currentValue = musicFloat;
            PlayerPrefs.SetFloat(MusicPref, musicFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            musicFloat = PlayerPrefs.GetFloat(MusicPref);
            musicSlider.currentValue = musicFloat;
        }
    }

    public void SaveSoundSetings()
    {
        PlayerPrefs.SetFloat(MusicPref, musicSlider.currentValue);

    }

    private void OnApplicationFocus(bool infocus)
    {
        if (!infocus)
        {
            SaveSoundSetings();
        }
    }

    public void UpdateSound()
    {
        _musicAudio.volume = musicSlider.currentValue / 100;
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
