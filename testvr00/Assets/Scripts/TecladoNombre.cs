using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Mail;
using System;
using UnityEngine.SceneManagement;

public class TecladoNombre : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;
    public GameObject panelError;

    private void Start()
    {
        GetComponentInChildren<Text>().text = Globals.defaultName;
    }

    // Update is called once per frame
    void Update()
    {
        if ((keyboard != null) && (Globals.campoSeleccionado == Globals.CAMPO_NOMBRE))
        {
            Globals.userName = keyboard.text;
            GetComponentInChildren<Text>().text = Globals.userName;
            //GetComponentInChildren<Text>().text = keyboard.text;
        }
    }

    public void AbreTeclado()
    {
        Globals.campoSeleccionado = Globals.CAMPO_NOMBRE;
        keyboard = TouchScreenKeyboard.Open(Globals.userName, TouchScreenKeyboardType.Default);
    }
}
