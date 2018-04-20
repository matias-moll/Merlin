#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Mrln;
#endregion

namespace Mrln.Shr
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 16/09/2013 17:37
    // Sistema                  : Mrln
    // Clase para Administrar   : Shr
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************
    /// <summary>
    /// Clase con las rutinas del sistema
    /// </summary>
    public static partial class SysRuts
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase 
        //---------------------------------------------------------------

        #region Ventana About
        /// <summary>
        /// Arma la información de la ventana de "Acerca de"
        /// </summary>
        /// <param name="p_strTitle">Titulo del programa</param>
        /// <param name="p_bmpEEgg">Imagen Eastern Egg</param>
        public static AboutInfo MakeAboutInfo(string p_strTitle,
                                              Bitmap p_bmpEEgg)
        {
            // Llenamos la información de la ventana About...
            AboutInfo l_aiData = new AboutInfo();

            l_aiData.FrmColor = Color.FromArgb(3);
            l_aiData.ConIcono = true;
            l_aiData.ConLogo = true;
            l_aiData.Copyright = String.Format("© Copyright 2003-{0:yy} by TNGS\r\n" +
                                              "www.tngs.com.ar    email: info@\r\n\r\n" +
                                              "Programa de distribución <TODO> como parte de <TODO>.",
                                              DateTime.Now);
            l_aiData.ConScroll = true;
            l_aiData.ScrollColor = Color.FromArgb(3);
            l_aiData.ScrollTxt = "[C][O][3]" + p_strTitle +
                                "[C][F][3]<TODO>\r\n\r\n" +
                                "[I][N][2]Programadores:\r\n" +
                                "[F][1][C]<TODO>\r\n" +
                                "<TODO>\r\n\r\n" +
                                "[N][2][I]Diseño:\r\n" +
                                "[F][1][C]<TODO>\r\n\r\n" +
                                "[I]" +
                                AboutInfo.AboutCopyright +       // No Remover!!. Son los copyrights de los elementos licenciados
                                "<TODO: Copyrights adicionales>\r\n\r\n" +
                                "Advertencia: Los códigos fuentes de este programa están protegidos por las leyes de derecho de autor para todo el territorio argentino.\r\n\r\n" +
                                "El módulo ejecutable es de distribución <TODO> como parte de <TODO>";
            l_aiData.EECode = "<TODO: Secuncia del EEgg>"; //"Menu, Alt\tT, Alt\tN, Alt\tG, Alt\tS, Alt\tY\tA\t";
            l_aiData.EEImage = p_bmpEEgg;
            return l_aiData;
        }
        #endregion

        #region Incio/Fin del programa

        /// <summary>
        /// Metodo que se ejecuta antes del App.Init
        /// </summary>
        /// <returns>T- Todo OK / F- Cancelar el programa</returns>
        public static bool PreInit()
        {
            // Todo ok
            return true;
        }

        /// <summary>
        /// Metodo que se ejecuta antes del App.Run
        /// </summary>
        /// <returns>T- Todo OK / F- Cancelar el programa</returns>
        public static bool PreRun()
        {
            // Todo ok
            return true;
        }

        /// <summary>
        /// Metodo de arranque del programa (llamado inicial)
        /// </summary>
        public static void AutoExecIni(string p_strPrgCode)
        {
        }



        /// <summary>
        /// Metodo de arranque del programa (llamado final)
        /// </summary>
        public static void AutoExecEnd(string p_strPrgCode)
        {
        }

        /// <summary>
        /// Metodo de fin del programa (llamado inicial)
        /// </summary>
        public static void EndExecIni(string p_strPrgCode)
        {
        }

        /// <summary>
        /// Metodo de fin del programa (llamado final)
        /// </summary>
        public static void EndExecEnd(string p_strPrgCode)
        {
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase 
        //---------------------------------------------------------------

    }
}
