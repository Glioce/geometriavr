using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    //tiempo restante antes de que se termine el tiempo
    public static float tiempoMax = 20 * 60; //segundos
    public static float tiempoRestante = tiempoMax; //segundos

    // marcar campo en el que se va a escribir
    public static int CAMPO_NOMBRE = 0;
    public static int CAMPO_CORREO = 1;
    public static int campoSeleccionado = CAMPO_NOMBRE;
    
    // mail
    // la siguiente direccion aparece al inicio del juego cuando el usuario no ha escrito su propio correo
    public static string defaultMail = "ralarconhz@gmail.com";
    public static string defaultName = "Jugador";
    // la siguiente direccion se sobreescribe con la direccion del usuario/jugador
    public static string userMail = defaultMail;
    public static string userName = defaultName;
    // la siguiente direccion se usa para enviar correos a los usuarios/jugadores y a un correo recolector
    public static string adminMail = "docente.gibran@gmail.com";
    public static string adminPw = "6161AmordeLocos";
    // direccion del recolector
    public static string recoMail = "docente.gibran@gmail.com";

    //respuestas
    //public static int[] respuestasCorrectas = new int[16];
    // esta es la lista de respuestas correctas, al final debe contener 20 valores
    // los incisos son letras de A a D, pero se guardan numeros de 1 a 4
    //                            0 1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20
    public static int[] answers = { 4, 2, 1, 3, 1, 1, 3, 2, 1, 1, 2, 2, 4, 1, 3, 2, 4, 1, 3, 2 };
    // el siguiente array inicia con todos lo valores = 0, guarda las repuestas del usuario/jugador
    public static int[] userAnswers = new int[20];

    // escala de puntaje
    // dependiendo del numero de respuestas correctas se muestra una nombre
    public static string[] nombresPuntaje = { "Tlamanih", "Guerrero Cuextecatl", "Guerrero Papalotl", "Guerrero Águila" };
    // los nombres se muestran cuando se alcanza un puntaje de la siguiente lista
    public static int[] valoresPuntaje = { 0, 8, 10, 14 };
}
