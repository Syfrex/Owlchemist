using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MasterVolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;

        public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("MasterVolumeParam", Mathf.Log10(sliderValue) * 20);
    }
}
