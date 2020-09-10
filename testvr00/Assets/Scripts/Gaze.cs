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
    public GvrReticlePointer pointer;
    bool status; //status de conteo
    float timer; //incrementa su valor cuando se hace hover

    private void Start()
    {
        circulo.fillAmount = 0;
    }

    // Update is called once per frame
    // Revisar status y actualizar timer
    void Update()
    {
        if(status == true)
        {
            timer += Time.deltaTime;
            circulo.fillAmount = timer / totalTime;
        }
        
        if (timer >= totalTime)
        {
            //pointer.OnPointerClickDown();
            //GvrPointerInputModule.Pointer.TriggerDown();
        }
    }

    public void On()
    {
        status = true;
    }

    public void Off()
    {
        status = false;
        timer = 0;
        circulo.fillAmount = 0;
    }
}
