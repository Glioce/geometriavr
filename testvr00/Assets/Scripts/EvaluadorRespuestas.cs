using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class EvaluadorRespuestas : MonoBehaviour
{
    public GameObject txtTiempo;

    // Start is called before the first frame update
    void Start()
    {
        // numero de respuestas
        int n = Globals.answers.Length;
        // suma de respuestas correctas
        int suma = 0;
        // cadena para guardar la calificacion de forma detallada
        string calif = "Nombre: "+ Globals.userName + "\nCorreo: " + Globals.userMail + "\n\nNumero Respuesta Calificacion\n";
        // respuesta en forma de cadena
        string res;
        // nombre o rango obtenido en la escala de puntaje
        string rangoObtenido = "";

        // comparar respuestas del usuario/jugador con respuestas correctas
        for (int i=0; i<n; i++)
        {
            // asignar res. Puede ser A, B, C, D o SIN CONTESTAR
            if (Globals.userAnswers[i] == 0)
                res = "SIN CONTESTAR";
            else
                res = Char.ToString((char)(64 + Globals.userAnswers[i]));

            // guardar cada respuesta en calif
            calif += (i + 1) + ". " + res;

            // comparar respuesta de usuario con respuesta correcta y calificar (Bien o Mal)
            if (Globals.userAnswers[i] == Globals.answers[i])
            {
                calif += " Bien \n";
                suma++;
            }
            else calif += " Mal \n";
        }//termina for

        // asignar rango en la escala de puntaje
        for (int i = 0; i < Globals.nombresPuntaje.Length; i++)
        {
            if (suma >= Globals.valoresPuntaje[i])
                rangoObtenido = Globals.nombresPuntaje[i];
        }//termina for

        // Mostrar rango obtenido en VR
        GetComponent<Text>().text = "Test finalizado. Has conseguido el rango \n" + rangoObtenido;

        // Agregar rango obtenido a calif
        calif += "\nRespuestas correctas: " + suma + " de " + n;
        calif += "\nRango obtenido: " + rangoObtenido;
        Debug.Log(calif);

        //SendMail(Globals.recoMail, calif);
        //SendMail(Globals.userMail, "Rango obtenido: " + rangoObtenido);

        // Mostar tiempo restante
        if (Globals.tiempoRestante > 0) txtTiempo.GetComponent<Text>().text = "Tiempo restante: " + FormatoReloj(Globals.tiempoRestante);
        else txtTiempo.GetComponent<Text>().text = "¡Se acabó el tiempo!";
    }

    // Update is called once per frame
    //void Update()

    public void SendMail(string dir, string msj)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(Globals.adminMail);
        mail.To.Add(dir);
        mail.Subject = "Resultado del Test Habilidad Espacial VR";
        mail.Body = msj;
        // you can use others too.
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential(Globals.adminMail, Globals.adminPw) as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
        delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        { return true; };
        smtpServer.Send(mail);
        Debug.Log("Correo enviado");
    }

    // recibe el valor de segundos y lo presenta en formato minutos:segundos (ejemplo 19:10)
    public string FormatoReloj(float segundos)
    {
        int minutos = (int)(segundos / 60);
        segundos = (int)(segundos % 60);
        string reloj = minutos + ":" + segundos;
        return reloj;
    }
}
