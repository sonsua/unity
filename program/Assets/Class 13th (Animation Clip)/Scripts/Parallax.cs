using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{

    public Rect rect;
    public RawImage rawImage;

    public float speed = 0.25f;


    void Update()
    {
        rect = rawImage.uvRect;
        rect.x += speed * Time.deltaTime;

        rawImage.uvRect = rect;
    }
}
