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



        public static void CheckForAlertsAndProcess(EMovil p_entMovil, ref StatMsg p_smResult, bool esProcesoBackgroundSinVentana = false)
        {
            Bll.Alertas.fCheckCreacionAlertas(p_entMovil, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            LEAlertas alertasAMostrar = Bll.Alertas.AleGetPendientesFromMov(p_entMovil.Patente, ref p_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            if (alertasAMostrar.Count == 0)
                return;

            List<EAlerta> listaAlertas = alertasAMostrar.ToList().Where(alerta => alerta.Repetirendias == 0 || pasaronDiasYDebeRepetirse(alerta)).ToList();
            if (MsgRuts.AnalizeError(App.GetMainWindow(), p_smResult)) return;

            if (listaAlertas.Count != 0)
            {
                if(!esProcesoBackgroundSinVentana)
                {
                    ShowAlertas ventanaAlertas = new ShowAlertas(listaAlertas);
                    ventanaAlertas.ShowDialog(App.GetMainWindow());
                }
                
                listaAlertas.ForEach(alerta => mandarMailsSiCorresponde(alerta));
            }
        }

        private static void mandarMailsSiCorresponde(EAlerta alerta)
        {
            if(!alerta.MailsEnviados)
            {
                // Debo recuperar el MvlAlerta para tener el codigo de destinatario. Recuperar los destinatarios y armar lista de strings y llamar
                // Al mailsender con eso.
            }
                
        }

        private static bool pasaronDiasYDebeRepetirse(EAlerta alerta)
        {
            // No puedo pasarle el statmsg por usarse en una lambda, si falla tiramos exception.
            StatMsg l_smResult = new StatMsg();
            DateTime fechaActual = Bll.Moviles.fGetDate(ref l_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), l_smResult)) throw new Exception(l_smResult.Msg);

            return (fechaActual > alerta.Fechavista.AddDays(alerta.Repetirendias));
        }
    }
}
