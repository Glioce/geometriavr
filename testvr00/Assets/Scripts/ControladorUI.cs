using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorUI : MonoBehaviour
{
    // Scrip asignado al objeto ControladorUI
    // Guarda respuestas, asigna texto y valores de resultados
    // Se realiza navegación como menú

    private int[] respuestas = new int[16];

    public GameObject preguntas;
    public GameObject portada;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        for (int i = 0; i < respuestas.Length; i++)
            respuestas[i] = -1; //-1 indica respuesta no seleccionada

        portada.SetActive(false);
        preguntas.SetActive(true);
    }
}
