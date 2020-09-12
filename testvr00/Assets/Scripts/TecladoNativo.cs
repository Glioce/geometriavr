using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TecladoNativo : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    private void Start()
    {
        GetComponentInChildren<Text>().text = Globals.defaultMail;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard != null)
        {
            Globals.userMail = keyboard.text;
            GetComponentInChildren<Text>().text = Globals.userMail;
            //GetComponentInChildren<Text>().text = keyboard.text;
        }
    }

    public void AbreTeclado()
    {
        keyboard = TouchScreenKeyboard.Open(Globals.userMail, TouchScreenKeyboardType.EmailAddress);
    }
}
