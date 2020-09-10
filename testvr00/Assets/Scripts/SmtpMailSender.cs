using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


public class SmtpMailSender : MonoBehaviour
{
    public void SendMail()
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("myaddress@gmail.com");
        mail.To.Add("dest@gmail.com");
        mail.Subject = "Test Smtp Mail";
        mail.Body = "Testing SMTP mail from GMAIL";
        // you can use others too.
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("myaddress@gmail.com", "asdf") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
        delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        { return true; };
        smtpServer.Send(mail);
        Debug.Log("Enviado");
    }
}
