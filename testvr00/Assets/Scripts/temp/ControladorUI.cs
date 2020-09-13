using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Este script está asignado al objeto "ControladorUI"
// Scrip asignado al objeto ControladorUI
// Guarda respuestas, asigna texto y valores de resultados
// Se realiza navegación como menú

// Secuencia
// 1. Mensaje con objetivo del test
// 2. 

public class ControladorUI : MonoBehaviour
{
    public GameObject imgPregunta;
    public GameObject btnRespuestaA;
    public GameObject btnRespuestaB;
    public GameObject btnRespuestaC;
    public GameObject btnRespuestaD;
    private int numPregunta = 0;

    public GameObject preguntas;
    public GameObject portada;
    public GameObject textobjetivo;

    // Start is called before the first frame update
    //void Start()

    // Update is called once per frame
    //void Update()

    // Cuando se presiona el botón Comenzar en la portada del test
    // Grupo portada se desactiva
    // Grupo pregunta se activa
    // Inicia cuenta regresiva
    // Array de respuestas se llena con -1
    // Se muestran instrucciones de reactivo 1
    // Se muestran instrucciones de preguntas tipo 1 (plegado) [Implementar después]
    // (Opcional) Botones de navegación se habilitan
    public void Comenzar()
    {
        portada.SetActive(false);
        preguntas.SetActive(true);
    }

    // Mostrar siguiente pregunta
    // Entre grupos de preguntas hay mensajes especiales
    public void SigPregunta()
    {
        numPregunta++;
    }
}
