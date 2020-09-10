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
    

    private int[] respuestas = new int[16];
    private int numInstruccion = 0;

    public GameObject preguntas;
    public GameObject portada;
    public GameObject textobjetivo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()

    // Al hacer clic revisamos aparece otro mensaje
    public void InstruccionSiguiente ()
    {
        numInstruccion++;

        
        textobjetivo.GetComponent<Text>().text = @"Este instrumento se divide de la siguiente manera:

Plegado mental - 5 Reactivos 1 al 5 tipo DAT 5

Dibujo Técnico - 5 Reactivos 6 al 10 Vistas e Isométrico

Especiales Prehispánicos - 3 Reactivos 11 al 13 ejercicios sugeridos por el autor

Giro mental 3 Reactivos - 14 al 16 ejercicios tipo MRT Y PSVT

Estandarizados Nacionales - 4 Reactivos 17 al 20 tipo ENLACE Y PLANEA.";
    }

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
