using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TecladoNativo : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbreTeclado()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}
