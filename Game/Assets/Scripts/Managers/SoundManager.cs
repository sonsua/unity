using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] AudioSource effectSource;
    [SerializeField] AudioSource scenerySource;


    public void OnEnable()
    {
        
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}
