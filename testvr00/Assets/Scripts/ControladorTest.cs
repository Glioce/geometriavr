using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Este script está asignado al objeto "ControladorTest"
// Guarda respuestas, controla la visibilidad de varios elementos en la interfaz
// ¿Debe controlar la navegación entre preguntas?

// Secuencia
// 1. Muestra instrucciones generales del primer grupo de preguntas
// 2. Quita las instrucciones y aparece la imagen pregunta y los incisos

public class ControladorTest : MonoBehaviour
{
    public GameObject imgPregunta;
    public GameObject btnRespuestaA;
    public GameObject btnRespuestaB;
    public GameObject btnRespuestaC;
    public GameObject btnRespuestaD;

    int numPregunta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SigPregunta()
    {
        numPregunta++;
        imgPregunta.GetComponent<Image>().sprite   = imgPregunta.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];
    }
}