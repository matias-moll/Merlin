using Mrln.Bel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TNGS.NetApp;
using TNGS.NetRoutines;

namespace Mrln.Shr
{
    public static class AlertHelper
    {
        public static void CheckForAlertsAndProcess(EMovil p_entMovil, StatMsg p_smResult, bool esProcesoBackgroundSinVentana = false)
        {
            Bll.Alertas.fCheckCreacionAlertas(p_entMovil, p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            LEAlertas alertasAMostrar = Bll.Alertas.AleGetPendientesFromMov(p_entMovil.Patente, p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            if (alertasAMostrar.Count == 0)
                return;

            List<EAlerta> listaAlertas = alertasAMostrar.ToList().Where(alerta => alerta.Repetirendias == 0 || pasaronDiasYDebeRepetirse(alerta)).ToList();
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            List<EAlerta> listaAlertasCopy = new List<EAlerta>(listaAlertas);

            if (listaAlertas.Count != 0)
            {
                if(!esProcesoBackgroundSinVentana)
                {
                    ShowAlertas ventanaAlertas = new ShowAlertas(listaAlertasCopy, p_entMovil.Patente);
                    ventanaAlertas.ShowDialog(App.GetMainWindow());
                }
                
                listaAlertas.ForEach(alerta => mandarMailsSiCorresponde(alerta, p_entMovil, p_smResult));
                if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            }
        }

        private static void mandarMailsSiCorresponde(EAlerta alerta, EMovil movil, StatMsg p_smResult)
        {
            if(!alerta.MailsEnviados)
            {
                EMovilAlerta movilAlerta = Bll.Moviles.MvalGet(movil.Patente, alerta.Nroconfig, true, p_smResult);
                if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

                EDestinatariosMail destinatariosMail = Bll.Tablas.DemGet(movilAlerta.Coddestinatarios, true, p_smResult);
                if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

                List<string> destinatarios = destinatariosMail.Destinatarios.Split(',').ToList();

                MailSender.enviarMail(destinatarios, "Alerta Automatica Sistema Móviles", getDetalleMail(alerta, movil), p_smResult);
                if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

                alerta.Mailsenviados = "S";
                Bll.Alertas.AleSave(alerta, p_smResult);
                if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;
            }
                
        }

        private static string getDetalleMail(EAlerta alerta, EMovil movil)
        {
            return $"Movil: {movil.Patente} {Environment.NewLine} {Environment.NewLine} Descripción: {alerta.Descripcion} {Environment.NewLine} {Environment.NewLine} Detalle: {alerta.Detalle}";
        }

        private static bool pasaronDiasYDebeRepetirse(EAlerta alerta)
        {
            // No puedo pasarle el statmsg por usarse en una lambda, si falla tiramos exception.
            StatMsg l_smResult = new StatMsg();
            DateTime fechaActual = Bll.Moviles.fGetDate(l_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), l_smResult)) throw new Exception(l_smResult.Msg);

            return (fechaActual > alerta.Fechavista.AddDays(alerta.Repetirendias));
        }
    }
}
