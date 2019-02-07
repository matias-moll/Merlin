#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using TNGS.NetControls;
using Mrln.Bll;
#endregion

namespace Mrln.Shr
{
    //----------------------------------------------------------------------------
    //                         TNG Software SHR Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 07/02/2019 03:30
    // Sistema                  : Mrln
    // Clase para Administrar   : Shr
    //----------------------------------------------------------------------------
    // © 1996-2019 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Clase para acceso directo a los Parametros RO
    /// </summary>
    public static partial class ROParam
    {
        //---------------------------------------------------------------
        // Propiedades de la clase 
        //---------------------------------------------------------------

        #region Propiedades con los parametros
        /// <summary>
        /// Parametro: connCEDI
        /// </summary>
        public static EParametro Conncedi
        {
            get {return LEParametrosRO.Datos["CONNCEDI"];}
        }

        /// <summary>
        /// Parametro: dirSMTP
        /// </summary>
        public static EParametro Dirsmtp
        {
            get {return LEParametrosRO.Datos["DIRSMTP"];}
        }

        /// <summary>
        /// Parametro: empresa
        /// </summary>
        public static EParametro Empresa
        {
            get {return LEParametrosRO.Datos["EMPRESA"];}
        }

        /// <summary>
        /// Parametro: estadoDef
        /// </summary>
        public static EParametro Estadodef
        {
            get {return LEParametrosRO.Datos["ESTADODEF"];}
        }

        /// <summary>
        /// Parametro: mailCreden
        /// </summary>
        public static EParametro Mailcreden
        {
            get {return LEParametrosRO.Datos["MAILCREDEN"];}
        }

        /// <summary>
        /// Parametro: mailRemit
        /// </summary>
        public static EParametro Mailremit
        {
            get {return LEParametrosRO.Datos["MAILREMIT"];}
        }

        /// <summary>
        /// Parametro: passCreden
        /// </summary>
        public static EParametro Passcreden
        {
            get {return LEParametrosRO.Datos["PASSCREDEN"];}
        }

        /// <summary>
        /// Parametro: puertoSMTP
        /// </summary>
        public static EParametro Puertosmtp
        {
            get {return LEParametrosRO.Datos["PUERTOSMTP"];}
        }

        /// <summary>
        /// Parametro: safeMail
        /// </summary>
        public static EParametro Safemail
        {
            get {return LEParametrosRO.Datos["SAFEMAIL"];}
        }

        #endregion
    }
}
