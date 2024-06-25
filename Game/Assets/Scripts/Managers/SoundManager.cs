using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public enum SceneSound
{
    Title,
    Game
}

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] SceneSound sceneSound;
    [SerializeField] AudioSource effectSource;
    [SerializeField] AudioSource scenerySource;


    public void Sound(AudioClip audioClip)
    {
        effectSource.PlayOneShot(audioClip);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        sceneSound = (SceneSound)scene.buildIndex;
        scenerySource.clip = ResourcesManager.Instance.Load<AudioClip>(sceneSound.ToString());

        scenerySource.loop = true;
        scenerySource.Play();
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
