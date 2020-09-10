using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
//using Gvr.Internal;

public class MenuPrincipal : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadDevice("cardboard", false));
    }

    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = enable;
    }

    public void Jugar()
    {
        //XRSettings.enabled = true;
        StartCoroutine(LoadDevice("cardboard", true));
        SceneManager.LoadScene("Test00");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Salir!!");
        Application.Quit();
    }
}
