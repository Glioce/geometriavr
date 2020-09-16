using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

// Este script está asignado al objeto "ControladorTest"
// Guarda respuestas, controla la visibilidad de varios elementos en la interfaz
// ¿Debe controlar la navegación entre preguntas?

// Secuencia
// 1. Muestra instrucciones generales del primer grupo de preguntas
// 2. Quita las instrucciones y aparece la imagen pregunta y los incisos

public class ControladorTest : MonoBehaviour
{
    public GameObject imgPregunta; //preguntas 1 a 16
    public GameObject imgPregunta17; //solo pregunta 17
    public GameObject imgPregunta18; //de pregunta 18 a 20
    public GameObject btnRespuestaA; //respuestas 1 a 17
    public GameObject btnRespuestaB;
    public GameObject btnRespuestaC;
    public GameObject btnRespuestaD;
    public GameObject imgTemplo;
    public GameObject btnRespuestaA18; //respuestas 18 a 20
    public GameObject btnRespuestaB18;
    public GameObject btnRespuestaC18;
    public GameObject txtTiempo; //muestra el tiempo restante
    public GameObject txtInstru_1_5; //instrucciones
    public GameObject txtInstru_6_11;
    public GameObject txtInstru_12;
    public GameObject txtInstru_13;
    public GameObject txtInstru_14_16;
    public GameObject txtInstru_17;
    public GameObject txtInstru_18_20;
    public GameObject txtReactivo;
    public GameObject imgGiro;

    int numPregunta = 0; //index

    // Start is called before the first frame update
    void Start()
    {
        Globals.tiempoRestante = Globals.tiempoMax; //segundos
    }

    // Update is called once per frame
    void Update()
    {
        Globals.tiempoRestante -= Time.deltaTime; //segundos

        if (Globals.tiempoRestante <= 0)
        {
            Globals.tiempoRestante = 0; //evitar que sea negativo
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //ir al resultado
        }

        txtTiempo.GetComponent<Text>().text = "Tiempo restante:\n" + FormatoReloj(Globals.tiempoRestante);
    }

    // Ir a la pregrunta siguiente
    public void PreguntaSig()
    {
        // incrementar numero de pregunta o ir a resultado
        if (numPregunta >= Globals.answers.Length - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            numPregunta++;


        // Cambiar texto de instrucciones
        if (numPregunta == 5) //pregunta 6 (index 5)
        {
            txtInstru_1_5.SetActive(false); //oculto
            txtInstru_6_11.SetActive(true); //visible
        }
        else if (numPregunta == 11) //pregunta 12 (index 11)
        {
            txtInstru_6_11.SetActive(false); //oculto
            txtInstru_12.SetActive(true); //visible
        }
        else if (numPregunta == 12) //pregunta 13 (index 12)
        {
            txtInstru_12.SetActive(false); //oculto
            txtInstru_13.SetActive(true); //visible
        }
        else if (numPregunta == 13) //pregunta 14 (index 13)
        {
            txtInstru_13.SetActive(false); //oculto
            txtInstru_14_16.SetActive(true); //visible
        }
        else if (numPregunta == 16) //pregunta 17 (index 16)
        {
            txtInstru_14_16.SetActive(false); //oculto
            txtInstru_17.SetActive(true); //visible
        }
        else if (numPregunta == 17) //pregunta 18 (index 17)
        {
            txtInstru_17.SetActive(false); //oculto
            txtInstru_18_20.SetActive(true); //visible
        }

        // Cambiar apariencia de preguntas
        // en la pregunta 14 (index 13) se muestran instrucciones de giro mental
        if (numPregunta == 13)
        {
            imgGiro.SetActive(true);
        }
        if (numPregunta == 14)
        {
            imgGiro.SetActive(false);
        }

        // al llegar a la pregunta 17 (index 16) cambia la apariencia
        if (numPregunta == 16)
        {
            imgPregunta.SetActive(false); //ocultar imagen usada en preguntas 1 a 16
            imgPregunta17.SetActive(true); //esta imagen se hace visible

            btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];
        }
        // al llegar a la pregunta 18 (index 17) la apariencia cambia otra vez
        else if (numPregunta == 17) //pregunta 18
        {
            imgPregunta17.SetActive(false); //ocultar
            imgPregunta18.SetActive(true); //hacer visible
            imgPregunta18.GetComponent<Image>().sprite = imgPregunta18.GetComponent<SpriteManager>().sprites[numPregunta];

            //btnRespuestaA. pointerExit

            btnRespuestaA.SetActive(false); //ocultar botones
            btnRespuestaB.SetActive(false);
            btnRespuestaC.SetActive(false);
            btnRespuestaD.SetActive(false);

            imgTemplo.SetActive(true);
            btnRespuestaA18.SetActive(true); //hacer visibles otros botones
            btnRespuestaB18.SetActive(true);
            btnRespuestaC18.SetActive(true);
        }
        else if (numPregunta > 17)
        {
            // cambiar sprite de pregunta
            imgPregunta18.GetComponent<Image>().sprite = imgPregunta18.GetComponent<SpriteManager>().sprites[numPregunta];
        }
        // en las otras preguntas solo cambiar sprite
        else
        {
            // cambiar sprites de componente en al UI
            imgPregunta.GetComponent<Image>().sprite = imgPregunta.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];

            MarcarSeleccionado();
        }
        txtReactivo.GetComponent<Text>().text = "Reactivo " + (numPregunta + 1);
    }

    // Ir a la pregunta anterior
    public void PreguntaPrev()
    {
        // decrementar numero de pregunta si es posible
        if (numPregunta > 0)
            numPregunta--;

        // Cambiar texto de instruccione
        if (numPregunta == 4) //pregunta 5 (index 4)
        {
            txtInstru_1_5.SetActive(true);
            txtInstru_6_11.SetActive(false);
        }
        else if (numPregunta == 10) //pregunta 11 (index 10)
        {
            txtInstru_6_11.SetActive(true);
            txtInstru_12.SetActive(false);
        }
        else if (numPregunta == 11) //pregunta 12 (index 11)
        {
            txtInstru_12.SetActive(true);
            txtInstru_13.SetActive(false);
        }
        else if (numPregunta == 12) //pregunta 13 (index 12)
        {
            txtInstru_13.SetActive(true);
            txtInstru_14_16.SetActive(false);
        }
        else if (numPregunta == 15) //pregunta 16 (index 15)
        {
            txtInstru_14_16.SetActive(true);
            txtInstru_17.SetActive(false);
        }
        else if (numPregunta == 16) //pregunta 17 (index 16)
        {
            txtInstru_17.SetActive(true);
            txtInstru_18_20.SetActive(false);
        }

        // si regresa a pregunta 13 (index 12) se quitan instrucciones de giro mental
        if (numPregunta == 12)
        {
            imgGiro.SetActive(false);
        }
        if (numPregunta == 13)
        {
            imgGiro.SetActive(true);
        }

        //si regresa a pregunta 16 (index 15)
        if (numPregunta == 15)
        {
            imgPregunta.SetActive(true); //hacer visible imagen usada en preguntas 1 a 16
            imgPregunta17.SetActive(false); //esta imagen se oculta
        }
        // si regresa a pregunta 17 (index 16)
        else if (numPregunta == 16)
        {
            imgPregunta17.SetActive(true); //visible
            imgPregunta18.SetActive(false); //oculto

            btnRespuestaA.SetActive(true); //visible
            btnRespuestaB.SetActive(true);
            btnRespuestaC.SetActive(true);
            btnRespuestaD.SetActive(true);

            imgTemplo.SetActive(false);
            btnRespuestaA18.SetActive(false); //oculto
            btnRespuestaB18.SetActive(false);
            btnRespuestaC18.SetActive(false);
        }
        else if (numPregunta >= 17)
        {
            // cambiar sprite de pregunta
            imgPregunta18.GetComponent<Image>().sprite = imgPregunta18.GetComponent<SpriteManager>().sprites[numPregunta];
        }
        // en las otras preguntas solo cambiar el sprite
        else
        {
            // cambiar sprites de componente en al UI
            imgPregunta.GetComponent<Image>().sprite = imgPregunta.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaA.GetComponent<Image>().sprite = btnRespuestaA.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaB.GetComponent<Image>().sprite = btnRespuestaB.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaC.GetComponent<Image>().sprite = btnRespuestaC.GetComponent<SpriteManager>().sprites[numPregunta];
            btnRespuestaD.GetComponent<Image>().sprite = btnRespuestaD.GetComponent<SpriteManager>().sprites[numPregunta];

            MarcarSeleccionado();
        }
        txtReactivo.GetComponent<Text>().text = "Reactivo " + (numPregunta + 1);
    }

    // Responder la pregunta actual
    public void Responder(int inciso)
    {
        // guardar respuesta en array global
        Debug.Log("Respondiendo "+ numPregunta);
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

    public string FormatoReloj(float segundos)
    {
        int minutos = (int)(segundos / 60);
        segundos = (int)(segundos % 60);
        string reloj = minutos + ":" + segundos;
        return reloj;
    }
}