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
    // Fecha                    : 31/10/2013 16:27
    // Sistema                  : Mrln
    // Clase para Administrar   : Ordenes de Trabajo y sus Items
    //----------------------------------------------------------------------------
    // � 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    #region Entidad: OTItem
    /// <summary>
    /// Clase que representa la Entidad: OTItem
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EOTItem : Entidad
    {
        public enum Estados { Pendiente, Realizado, Cancelado };

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        public void Pendiente()
        {
            this.Estado = Estados.Pendiente.ToString();
        }

        public void Realizado()
        {
            this.Estado = Estados.Realizado.ToString();
        }
        public void Cancelado()
        {
            this.Estado = Estados.Cancelado.ToString();
        }


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

        public bool tieneEstadoCargado
        {
            get { return this.estaPendiente || this.fueCancelado || this.fueRealizado; }
        }

        public bool estaPendiente
        {
            get { return this.Estado == Estados.Pendiente.ToString(); }
        }

        public bool fueRealizado
        {
            get { return this.Estado == Estados.Realizado.ToString(); }
        }

        public bool fueCancelado
        {
            get { return this.Estado == Estados.Cancelado.ToString(); }
        }

        #endregion
    }
    #endregion

    #region Lista-Entidad: OTItems
    /// <summary>
    /// Clase que representa la Lista-Entidad: OTItems
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEOTItems : ListaEntidades
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

    #region Lista-Entidad-Tipada: OTItems
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: OTItems
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETOTItems : LET<EOTItem>
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

    #region Entidad: OrdenTrabajo
    /// <summary>
    /// Clase que representa la Entidad: OrdenTrabajo
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EOrdenTrabajo : Entidad
    {
        public enum Estados { Pendiente, Finalizada, Cancelada, EnProgreso };

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        public void Finalizada()
        {
            this.CambiarEstado(Estados.Finalizada);
        }

        public void Cancelada()
        {
            this.CambiarEstado(Estados.Cancelada);
        }

        public void Pendiente()
        {
            this.CambiarEstado(Estados.Pendiente);
        }

        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        private void CambiarEstado(Estados estado)
        {
            this.Estado = estado.ToString();
        }

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

        public string CRPatente
        {
            get { return this.Patente; }
        }

        public bool EstaEnProgreso
        {
            get { return this.Estado == Estados.EnProgreso.ToString(); }
        }

        #endregion
    }
    #endregion

    #region Lista-Entidad: OrdenesTrabajo
    /// <summary>
    /// Clase que representa la Lista-Entidad: OrdenesTrabajo
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEOrdenesTrabajo : ListaEntidades
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

    #region Lista-Entidad-Tipada: OrdenesTrabajo
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: OrdenesTrabajo
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETOrdenesTrabajo : LET<EOrdenTrabajo>
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
