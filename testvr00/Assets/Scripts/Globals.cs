using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    // mail
    // la siguiente direccion aparece al inicio del juego cuando el usuario no ha escrito su propio correo
    public static string defaultMail = "ralarconhz@gmail.com";
    public static string defaultName = "Rafa";
    // la siguiente direccion se sobreescribe con la direccion del usuario/jugador
    public static string userMail = defaultMail;
    public static string userName = defaultName;
    // la siguiente direccion se usa para enviar correos a los usuarios/jugadores y a un correo recolector
    public static string adminMail = "minibrazorobot@gmail.com";
    public static string adminPw = "sistema789";
    // direccion del recolector
    public static string recoMail = "docente.gibran@gmail.com";

    //respuestas
    //public static int[] respuestasCorrectas = new int[16];
    // esta es la lista de respuestas correctas, al final debe contener 20 valores
    // los incisos son letras de A a D, pero se guardan numeros de 1 a 4
    //                            0 1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16
    public static int[] answers = { 4, 2, 1, 3, 1, 1, 3, 2, 1, 1, 2, 2, 4, 1, 3, 2 };
    // el siguiente array inicia con todos lo valores = 0, guarda las repuestas del usuario/jugador
    public static int[] userAnswers = new int[16];

    // escala de puntaje
    // dependiendo del numero de respuestas correctas se muestra una nombre
    public static string[] nombresPuntaje = { "Tlamanih", "Guerrero Cuextecatl", "Guerrero Papalotl", "Guerrero Águila" };
    // los nombres se muestran cuando se alcanza un puntaje de la siguiente lista
    public static int[] valoresPuntaje = { 0, 8, 10, 14 };
}
