using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Mail;
using System;
using UnityEngine.SceneManagement;

public class TecladoCorreo : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;
    public GameObject panelError;

    private void Start()
    {
        GetComponentInChildren<Text>().text = Globals.defaultMail;
    }

    // Update is called once per frame
    void Update()
    {
        if ((keyboard != null) && (Globals.campoSeleccionado == Globals.CAMPO_CORREO))
        {
            Globals.userMail = keyboard.text;
            GetComponentInChildren<Text>().text = Globals.userMail;
            //GetComponentInChildren<Text>().text = keyboard.text;
        }
    }

    public void AbreTeclado()
    {
        Globals.campoSeleccionado = Globals.CAMPO_CORREO;
        keyboard = TouchScreenKeyboard.Open(Globals.userMail, TouchScreenKeyboardType.EmailAddress);
    }

    public void ValidaMail()
    {
        //if (IsValid(Globals.userMail)) 
        //SceneManager.LoadScene("Instrucciones00");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //else
        //panelError.SetActive(true);
    }

    public bool IsValid(string emailaddress)
    {
        try
        {
            MailAddress m = new MailAddress(emailaddress);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
