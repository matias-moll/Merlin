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

        public static void enviarMail(List<string> destinatarios, string titulo, string textoMail, int nroCliente, 
                                      string nombreArchivoAdjunto, decimal precio, ref StatMsg p_smResult)
        {
            try
            {
                cargarParametros(ref p_smResult);

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

                NetworkCredential credentials = new NetworkCredential(MailSender.mailCredential, MailSender.passCredential, "");
                client.Credentials = credentials;

                // Si hay archivo adjunto => lo adjuntamos
                if (nombreArchivoAdjunto != "")
                {
                    Attachment attachment = new Attachment(nombreArchivoAdjunto, MediaTypeNames.Application.Octet);
                    ContentDisposition disposition = attachment.ContentDisposition;
                    disposition.CreationDate = File.GetCreationTime(nombreArchivoAdjunto);
                    disposition.ModificationDate = File.GetLastWriteTime(nombreArchivoAdjunto);
                    disposition.ReadDate = File.GetLastAccessTime(nombreArchivoAdjunto);
                    disposition.FileName = Path.GetFileName(nombreArchivoAdjunto);
                    disposition.Size = new FileInfo(nombreArchivoAdjunto).Length;
                    disposition.DispositionType = DispositionTypeNames.Attachment;
                    msg.Attachments.Add(attachment);

                    msg.Body = "Ante cualquier duda, ya sea comercial u operativa, nos encontramos a su disposición.";
                }

                client.Send(msg);
            }
            catch (Exception e)
            {
                p_smResult.BllWarning(e.ToString());
            }
        }

        private static void cargarParametros(ref StatMsg p_smResult)
        {
            EParametro paramMailRemit = App.ParaGet("mailRemit", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            mailRemitente = paramMailRemit.VStr;

            EParametro paramDireccionSMTP = App.ParaGet("direccionSMTP", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            direccionSMTP = paramDireccionSMTP.VStr;

            EParametro paramMailCredential = App.ParaGet("mailCredential", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            mailCredential = paramMailCredential.VStr;

            EParametro paramPassCredential = App.ParaGet("passCredential", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            passCredential = paramPassCredential.VStr;

            EParametro paramSafeMail = App.ParaGet("safeMail", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            safeMail = paramSafeMail.VStr;

            EParametro paramPuertoSMTP = App.ParaGet("puertoSMTP", true, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            puertoSMTP = paramPuertoSMTP.VInt;
        }
    }
}
