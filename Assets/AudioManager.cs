using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource sfx;

    public bool IsMute { get => bgm.mute; }
    public float BgmVolume { get => bgm.volume; }
    public float SfxVolume { get => sfx.volume; }
    public void PlayBGM(AudioClip clip, bool loop = true)
    {
        // if (bgm.isPlaying)
        //     bgm.stop();

        bgm.clip = clip;
        bgm.loop = loop;
        bgm.Play();
    }

    public void PlaySFX(AudioClip clip)
    {   
        // if (sfx.isPlaying)
        //     sfx.stop();

        sfx.clip = clip;
        sfx.Play();
    }

    public void setmute(bool value)
    {
        bgm.mute = value;
        sfx.mute = value;
    }

    public void setBgmVolume(float value)
    {
        bgm.volume = value;
    }

    public void setSfxVolume(float value)
    {
        sfx.volume = value;
    }
}
