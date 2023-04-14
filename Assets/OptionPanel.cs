using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour

{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle muteToggle;

    [SerializeField] Slider bgmSlider;

    [SerializeField] Slider sfxSlider;
    
    private void start()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
        sfxSlider.value = audioManager.SfxVolume;
    }
}
