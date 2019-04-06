using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Mrln.Shr
{
    static class MailSender
    {
        static string mailRemitente, direccionSMTP, mailCredential, passCredential, safeMail;
        static int puertoSMTP;

        public static void enviarMail(List<string> destinatarios, string titulo, string textoMail, StatMsg p_smResult)
        {
            try
            {
                cargarParametros(p_smResult);

                // Creamos el objeto mensaje de mail.
                MailMessage msg = new MailMessage();

                // Agregamos todos los destinatarios del mail.
                foreach (string destinatario in destinatarios)
                    msg.To.Add(new MailAddress(destinatario));

                // Cargamos el emisor
                msg.From = new MailAddress(MailSender.mailRemitente);

                // Cargamos el subject del mail y el cuerpo, sacados de la pantalla.
                msg.Subject = titulo;
                msg.Body = textoMail;
                msg.IsBodyHtml = true;

                // Recuperamos a partir de los aprametros el servidor a utilizar.
                string servidorCorreo = MailSender.direccionSMTP;
                int puerto = MailSender.puertoSMTP;
                SmtpClient client = new SmtpClient(servidorCorreo, puerto);

                client.EnableSsl = (MailSender.safeMail == "S");
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                NetworkCredential credentials = new NetworkCredential(MailSender.mailCredential, MailSender.passCredential, "");
                client.Credentials = credentials;

                client.Send(msg);
            }
            catch (Exception e)
            {
                p_smResult.BllWarning(e.ToString());
            }
        }

        private static void cargarParametros(StatMsg p_smResult)
        {
            EParametro paramMailRemit = ROParam.Mailremit;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            mailRemitente = paramMailRemit.VStr;

            EParametro paramDireccionSMTP = ROParam.Dirsmtp;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            direccionSMTP = paramDireccionSMTP.VStr;

            EParametro paramMailCredential = ROParam.Mailcreden;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            mailCredential = paramMailCredential.VStr;

            EParametro paramPassCredential = ROParam.Passcreden;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            passCredential = paramPassCredential.VStr;

            EParametro paramSafeMail = ROParam.Safemail;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            safeMail = paramSafeMail.VStr;

            EParametro paramPuertoSMTP = ROParam.Puertosmtp;
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            puertoSMTP = paramPuertoSMTP.VInt;
        }
    }
}
