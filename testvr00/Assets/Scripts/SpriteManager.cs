using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        //SpriteRenderer.sprite = sprites[0];
        //GetComponent<SpriteRenderer>().sprite = sprites[0];
        //GetComponent<Image>() = sprites[0];
        GetComponent<Image>().sprite = sprites[1];
        //GetComponent<Image>().overrideSprite = sprites[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
