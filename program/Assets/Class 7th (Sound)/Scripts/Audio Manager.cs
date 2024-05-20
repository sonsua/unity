using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource scenerySource;
    public AudioSource effectSource;

    public AudioClip[] audioClip;
    public Slider slider;

    public void Awake()
    {
        slider.value = scenerySource.volume;
    }
    public void Control(float volume)
    {        
        scenerySource.volume = volume;        
    }
    public void Sound(int audioValue)
    {
        //���ÿ� ���� �������� ���带 ����ϴ� �Լ�
        effectSource.PlayOneShot(audioClip[audioValue]);
    }
 
}
