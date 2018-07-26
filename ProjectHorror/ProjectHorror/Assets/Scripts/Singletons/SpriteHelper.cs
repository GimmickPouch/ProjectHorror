using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHelper : MonoBehaviour
{
    private void Awake()
    {
        SingletonManager.RegisterSingleton(this);
    }

    public void GetSpriteFromUrl (string url, Action<Sprite> callback)
    {
        StartCoroutine(UrlToSprite(url, callback));
    }

    public IEnumerator UrlToSprite (string url, Action<Sprite> callback)
    {
        WWW www = new WWW(url);
        yield return www;
        var sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        callback(sprite);
    }
}
