#region Usings
using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Rivn;
using Rivn.Shr;
#endregion

namespace Rivn.Ot
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        #endregion

        //--------------------------------------------------------------------
        // Metodos públicos de la clase
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        // Metodos privados de la clase
        //--------------------------------------------------------------------

        #region Persistencia de Datos

        /// <summary>
        /// Registramos la persistencia de datos en la Registry desde Shr
        /// </summary>
        public static void RegisterPersistency()
        {
            // Fijamos el usuario en Shr
            SysRuts.Usuario= App.Usuario;

            // Registramos el evento del Shared
            SysRuts.ShrLog += new BllReportEventHandler(Process_ShrLog);
            SysRuts.ShrReport += new BllReportEventHandler(Process_ShrReport);
            SysRuts.LdSvConfig += new LdSvConfigEventHandler(Persistency_LdSvConfig);
        }

        /// <summary>
        /// Procesa la Generacion de Logs del Shr
        /// </summary>
        private static void Process_ShrLog(object sender,
                                           BllReportEventArgs e)
        {
            if (e.Mensaje != "") {
                // Generamos el registro de log
                string[] l_astrData= new ItemsString(e.Mensaje).StringArray;
                if (l_astrData.Length != 4) return;

                switch (l_astrData[0]) {
                    case "C" : {App.MakeNewSubLOGFile(l_astrData[1]); break;}
                    case "L" : {App.CloseSubLOGFile(l_astrData[1]); break;}
                    case "M" : {App.AddLOGMsg(l_astrData[1], l_astrData[2], l_astrData[3]); break;}
                    case "E" : {App.AddLOGErr(l_astrData[1], l_astrData[2], l_astrData[3]); break;}
                }
            }
        }

        /// <summary>
        /// Procesa los Reportes del Shr
        /// </summary>
        private static void Process_ShrReport(object sender,
                                              BllReportEventArgs e)
        {
            // Analizamos el mensaje
            string l_strCmd= "", l_strMsg= e.Mensaje, l_strImage= "None";

            if (e.Mensaje != "") l_strCmd= e.Mensaje.Substring(0,1);
            if ("*+&".IndexOf(l_strCmd) != -1) l_strMsg= l_strMsg.Substring(1);

            // Divisor
            int l_iPos= l_strMsg.IndexOf("@#@");
            if (l_iPos != -1) {
                // Dividimos
                l_strMsg= l_strMsg.Substring(0, l_iPos);
                l_strImage= l_strMsg.Substring(l_iPos+3);
            }

            // Lo procesamos 
            switch (l_strCmd) {
                case "*"    : {if (l_strMsg != "") App.ShowMsg(l_strMsg); else App.HideMsg(); break;}
                case "+"    : {if (l_strMsg != "") App.InitAdvance(l_strMsg); else App.EndAdvance(); break;}
                case "&"    : {if (l_strMsg != "") App.InitWaitAdvance(l_strMsg, l_strImage); else App.EndWaitAdvance(); break;}
                default     : {if (l_strMsg != "") App.WaitAdvance(l_strMsg, e.Percent); else App.Advance(e.Percent); break;}
           }
        }

        /// <summary>
        /// Persiste informacion en la Registry
        /// </summary>
        private static void Persistency_LdSvConfig(object sender,
                                                   LdSvConfigEventArgs e)
        {
            // Segun el tipo de datos
            if (e.IsString) {
                // Procesamos el comando: Tipo String
                if (e.IsLoad) {
                    // Vemos de donde hay que leerlo
                    if (e.Clave == null)
                        e.SValor= App.GetIniParam(e.Codigo, e.SValor);
                    else
                        e.SValor= App.GetStrURegistry(e.IsSystem, e.Clave, e.Codigo, e.SValor);
                }
                else {
                    // Grabamos el parámetro
                    App.SetStrURegistry(e.IsSystem, e.Clave, e.Codigo, e.SValor);
                }
            }
            else {
                // Procesamos el comando: Tipo Integer
                if (e.IsLoad) {
                    // Vemos de donde hay que leerlo
                    if (e.Clave == null)
                        e.IValor= App.GetIniParam(e.Codigo, e.IValor);
                    else
                        e.IValor= App.GetIntURegistry(e.IsSystem, e.Clave, e.Codigo, e.IValor);
                }
                else {
                    // Grabamos el parámetro
                    App.SetIntURegistry(e.IsSystem, e.Clave, e.Codigo, e.IValor);
                }
            }
        }

        #endregion

        //--------------------------------------------------------------------
        // Propiedades de la clase
        //--------------------------------------------------------------------

    }
}
