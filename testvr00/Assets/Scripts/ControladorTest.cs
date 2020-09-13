using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    // Ir a la pregrunta siguiente
    public void PreguntaSig()
    {
        // incrementar numero de pregunta o ir a resultado
        if (numPregunta >= Globals.answers.Length - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            numPregunta++;

        // cambiar sprites de componente en al UI
        imgPregunta.GetComponent<Image>().sprite = imgPregunta.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];

        MarcarSeleccionado();
    }

    // Ir a la pregunta anterior
    public void PreguntaPrev()
    {
        // decrementar numero de pregunta si es posible
        if (numPregunta > 0)
            numPregunta--;

        // cambiar sprites de componente en al UI
        imgPregunta.GetComponent<Image>().sprite = imgPregunta.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
        btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];

        MarcarSeleccionado();
    }

    // Responder la pregunta actual
    public void Responder(int inciso)
    {
        // guardar respuesta en array global
        Globals.userAnswers[numPregunta] = inciso;

        string s = "";
        foreach(int i in Globals.userAnswers) s += i;
        Debug.Log(s);

        // avanzar a la pregunta siguiente
        PreguntaSig();
    }

    public void MarcarSeleccionado()
    {
        // marcar seleccionado
        // primero poner todos a blanco
        btnRespuestaA.GetComponent<Image>().color = Color.white;
        btnRespuestaB.GetComponent<Image>().color = Color.white;
        btnRespuestaC.GetComponent<Image>().color = Color.white;
        btnRespuestaD.GetComponent<Image>().color = Color.white;
        // luego marcar el botón seleccionado
        switch (Globals.userAnswers[numPregunta]) //obtener valor de respuesta
        {
            case 1: btnRespuestaA.GetComponent<Image>().color = Color.yellow; break;
            case 2: btnRespuestaB.GetComponent<Image>().color = Color.yellow; break;
            case 3: btnRespuestaC.GetComponent<Image>().color = Color.yellow; break;
            case 4: btnRespuestaD.GetComponent<Image>().color = Color.yellow; break;
        }
    }
}