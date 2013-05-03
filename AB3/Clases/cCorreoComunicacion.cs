using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace AB3.Clases
{
    public class cCorreoComunicacion
    {
        public String SendMail(String from, String to, String subject, String body)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("jeragones@hotmail.com","Administrador");
            msg.To.Add(new MailAddress("jeragones@gmail.com"));
            msg.Subject = "Prueba";
            msg.Body = "Hola";
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            smtp.Host = "localhost";
            smtp.Port = 25;

            smtp.Credentials = new NetworkCredential("jeragones@gmail.com","Contraseña");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(msg);
                return ("funciona");
            }
            catch (Exception ex)
            {
                return ("no funciona");
                //Label1.Text = ex.ToString();
            }
        }
        /*
        public void SendMail(String p_correo)
        {
            // Gmail Address from where you send the mail
            var fromAddress = "jeragones@gmail.com";
            // any address where the email will be sending
            var toAddress = p_correo.ToString();
            //Password of your gmail address
            const string fromPassword = "Password";
            // Passing the values and make a email formate to display
            //string subject = YourSubject.Text.ToString();
            String subject = "Autentificación";
            string body = "From: " + "Administrador" + "\n";
            body += "Email: " + fromAddress.ToString() + "\n";
            body += "Subject: " + "Hola pura vida" + "\n";
            body += "Question: \n" + "desea autentificar su cuenta" + "\n";
            // smtp settings
            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;//587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;
            }
            // Passing values to smtp object
            smtp.Send(fromAddress, toAddress, subject, body);
        }
        */
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //here on button click what will done 
                /*SendMail();
                DisplayMessage.Text = "Your Comments after sending the mail";
                DisplayMessage.Visible = true;
                YourSubject.Text = "";
                YourEmail.Text = "";
                YourName.Text = "";
                Comments.Text = "";*/
            }
            catch (Exception) { }
        }
    }
}