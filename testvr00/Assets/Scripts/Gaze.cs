using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.EventSystems;

public class Gaze : MonoBehaviour
{
    public Image circulo; //objeto que muestra un sprite circular
    public float totalTime = 0.6f; //tiempo que se debe hacer hover para activar clic

    //public AudioClip audioBoton; //este scrip reproduce el efecto de sonido del boton

    bool gvrStatus; //status de conteo
    float gvrTimer; //incrementa su valor cuando se hace hover
    public Button button;
    //public UnityEvent gvrClick;
    //public GvrReticlePointer pointer;

    private void Start()
    {
        circulo.fillAmount = 0;
    }

    // Update is called once per frame
    // Revisar status y actualizar timer
    void Update()
    {
        if(gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circulo.fillAmount = gvrTimer / totalTime;

            if (gvrTimer >= totalTime)
            {
                //pointer.OnPointerClickDown();
                //GvrPointerInputModule.Pointer.TriggerDown();
                //gvrClick.Invoke();
                button.onClick.Invoke();
                gvrStatus = false;
            }
        }  
    }

    public void On()
    {
        gvrStatus = true;
        gvrTimer = 0;
        circulo.fillAmount = 0;
    }

    public void Off()
    {
        gvrStatus = false;
        gvrTimer = 0;
        circulo.fillAmount = 0;
    }

    public void setButton(Button b)
    {
        button = b;
    }
}
