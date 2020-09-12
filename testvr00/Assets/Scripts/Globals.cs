using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    // mail
    public static string defaultMail = "ejemplo@mail.com";
    public static string userMail = defaultMail;

    //respuestas
    //public static int[] respuestasCorrectas = new int[16];
    public static int[] answers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 8, 10, 11, 12, 13, 14, 15 };
    public static int[] userAnswers = new int[16];
}
