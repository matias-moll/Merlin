#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Mrln;
using Mrln.Bel;
#endregion

namespace Mrln.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 30/08/2013 16:41
    // Sistema                  : Mrln
    // Clase para Administrar   : 
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************
    /// <summary>
    /// Rutinas de apoyo a la Bll
    /// </summary>
    internal static partial class BllRuts
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase 
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        // Metodos privados de la clase 
        //---------------------------------------------------------------

        #region Funciones de Captions

        /// <summary>
        /// Devuelve el caption standard de un campo
        /// </summary>
        /// <param name="p_strColumn">Nombre de la columna</param>
        private static string fGetColCaption(string p_strColumn)
        {
            // Devolvemos el caption según el campo
            //switch (p_strColumn) {
            //}

            // El campo es desconocido
            return "";
        }

        #endregion
    }
}
