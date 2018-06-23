#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using Mrln;
#endregion

namespace Mrln.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 23/06/2018 19:12
    // Sistema                  : Mrln
    // Clase para Administrar   : Entidades Fijas
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    #region Entidad: RowHistorial
    /// <summary>
    /// Clase que representa la Entidad: RowHistorial
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class ERowHistorial : Entidad
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Permite agregar datos al XML de la entidad
        /// </summary>
        private void fAddXMLData(ref XmlDocument p_xdocData,
                                 ref XmlNode p_xndEntidad)
        {
        }

        /// <summary>
        /// Permite agregar datos a una entidad generada desde un XML
        /// </summary>
        private static void fNewFromXML(ref DataRow p_drTemp,
                                        XmlNode p_xndData)
        {
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion

    #region Lista-Entidad: RowsHistorial
    /// <summary>
    /// Clase que representa la Lista-Entidad: RowsHistorial
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LERowsHistorial : ListaEntidades
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados
        //---------------------------------------------------------------

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: RowsHistorial
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: RowsHistorial
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETRowsHistorial : LET<ERowHistorial>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados
        //---------------------------------------------------------------

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
    #endregion
}
