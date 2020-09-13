using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanzaClic : MonoBehaviour
{
    bool hover = false;
    public GameObject barraDeCarga;
    public Button button;
    

    // Update is called once per frame
    void Update()
    {
        if (hover)
        {
            button.onClick.Invoke();
        }
    }

    public void SetHover(bool h)
    {
        hover = h;
    }
}
