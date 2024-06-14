using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControler : Singleton<SceneControler>
{
    [SerializeField] Image loadImage;

    public IEnumerator FadeIn()
    {
        Color color = loadImage.color;

        color.a = 1;

        while (color.a >= 0.0f) {
            color.a -= Time.deltaTime;

            loadImage.color = color;

            yield return null;
        }
    }

    public IEnumerator AsyncLoad(int index)
    {
        AsyncOperation asyncOperation= SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        Color color = loadImage.color;

        color.a = 0;

        while(asyncOperation.isDone == false) { 
            color.a += Time.deltaTime;
            loadImage.color = color;

            if(asyncOperation.progress >= 0.9f)
            {
                color.a = Mathf.Lerp(color.a, 1f, Time.deltaTime);

                loadImage.color = color;

                if(color.a >= 1.0f)
                {
                    yield break;
                }
            }
            yield return null;
        }

        //bool allowSceneActivation : 장면이 준비되는 즉시 장면을 활성화시킬지 허용여부를 판단하는 함수

        //bool isDone : 해당 동작이 준비되었는지 확인하는 함수

        //float progress : 작업의 진행정도를 0과 1 사이의 값으로 확인하는 함수
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StartCoroutine(FadeIn());
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
