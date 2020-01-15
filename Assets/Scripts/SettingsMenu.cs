using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume0 (float volume = -80)
    {
        audioMixer.SetFloat("Volume", -80);
    }

    public void SerVolume1(float volume = 0)
    {
        audioMixer.SetFloat("Volume", 0);
    }

}
