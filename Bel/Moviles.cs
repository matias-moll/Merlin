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
    // Clase para Administrar   : Moviles y Tablas Hijas
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    #region Entidad: MovilAccidente
    /// <summary>
    /// Clase que representa la Entidad: MovilAccidente
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilAccidente : Entidad
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
        private void fNewFromXML(ref DataRow p_drTemp,
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

    #region Lista-Entidad: MovilesAccidentes
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesAccidentes
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesAccidentes : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesAccidentes
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesAccidentes
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesAccidentes : LET<EMovilAccidente>
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

    #region Entidad: MovilAlerta
    /// <summary>
    /// Clase que representa la Entidad: MovilAlerta
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilAlerta : Entidad
    {


        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------



        public bool CumpleCondicion(EMovil p_entMovil, LEAlertas alertasDelMovil, LEOTItems reparacionesDelMovil, DateTime fechaActual)
        {
            // TODO ASAP : Revisar esta logica de alertas del movil, aca las trato como todas las alertas
            // del movil dado pero en los cumple condicion las uso como alertas de esta config en particular. puede haber error de logica.

            // Filtramos las alertas para que sean del movil pero adeams solo de esta configuracion de alerta.
            alertasDelMovil.Filter(String.Format("{0} = {1}", EAlerta.NroconfigCmp, this.Nroconfigalerta));

            // Si es alerta de tipo periodica post reparacion.
            if (this.esDeReparacion)
                return this.CumpleCondicionReparacionPeriodica(p_entMovil, alertasDelMovil, reparacionesDelMovil);
            else if (this.esDeFecha)
                return this.CumpleCondicionFecha(fechaActual, alertasDelMovil);
            else 
                return this.CumpleCondicionKilometros(p_entMovil, alertasDelMovil);
        }

        private bool CumpleCondicionFecha(DateTime fechaActual, LEAlertas alertasDeEstaConfiguracion)
        {
            // Si se paso la fecha de configuracion y aun no se creo alerta de esta config -> cumple la condicion de creacion de alerta.
            return this.Fecha <= fechaActual && (alertasDeEstaConfiguracion.Count == 0));
        }

        private bool CumpleCondicionKilometros(EMovil p_entMovil, LEAlertas alertasDeEstaConfiguracion)
        {
            // Si se superaron los kilometros indicados y aun no se creo alerta de esta config -> cumple la condicion de creacion de alerta.
            if ((p_entMovil.KmsActuales > this.Kilometros) && (alertasDeEstaConfiguracion.Count == 0))
                return true;
            else
                return false;
        }

        private bool CumpleCondicionReparacionPeriodica(EMovil p_entMovil, LEAlertas alertasDeEstaConfiguracion, LEOTItems reparacionesDelMovil)
        {
            reparacionesDelMovil.Filter(String.Format("{0} = {1}", EOTItem.CodreparacionCmp, this.Codreparacion));

            // Si ya hay tantas alertas de esta config creadas como reparaciones que indica la misma entonces no hay que crear nada.
            if (alertasDeEstaConfiguracion.Count == reparacionesDelMovil.Count)
                return false;
            else
            {
                // Ordenamos las reparaciones para que quede la que pertenece a una OT mas nueva arriba de todo.
                reparacionesDelMovil.Sort(Bel.EOTItem.NrootCmp + " desc");

                // Obtenemos el kilometraje al momento de realizada por ultima vez la reparacion en cuestion.
                int kilometrajeAlMomentoDeLaUltimaReparacion = reparacionesDelMovil[0].Oti_kilometraje;

                // Si se hicieron los kilometros indicados por la config desde la ultima reparacion -> cumple condicion.
                if (p_entMovil.KmsActuales >= kilometrajeAlMomentoDeLaUltimaReparacion + this.Kilometros)
                    return true;
                else
                    return false;
            }
        }

        public EAlerta crearAlerta(int p_iNroAlerta, DateTime p_dtFechaActual)
        {
            Bel.EAlerta nuevaAlerta = Bel.EAlerta.NewEmpty();
            nuevaAlerta.Nroconfig = this.Nroconfigalerta;
            nuevaAlerta.Nroalerta = p_iNroAlerta;
            nuevaAlerta.Fechadisparada = p_dtFechaActual;
            nuevaAlerta.Importancia = "R";
            nuevaAlerta.Descripcion = String.Format("Control: {0}", this.Mal_control);
            nuevaAlerta.Finalizada = "N";

            if (this.esDeKilometraje)
                nuevaAlerta.Detalle = String.Format("El móvil pasó los {0} kilómetros, debe realizar el control {1}", this.Kilometros, this.Mal_control);
            else
                nuevaAlerta.Detalle = String.Format("El móvil pasó los {0} kilómetros desde la última reparación de {1}, debe realizar: {1}", 
                                                    this.Kilometros, this.Mal_reparacion, this.Mal_control);

            return nuevaAlerta;
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
        private void fNewFromXML(ref DataRow p_drTemp,
                                 XmlNode p_xndData)
        {
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        // Modificar si algun dia hay otro tipo de config alerta.
        public bool esDeReparacion { get { return this.Codreparacion.Trim() != ""; } }

        public bool esDeKilometraje { get { return !this.esDeReparacion && !this.esDeFecha} }

        public bool esDeFecha {  get { return this.Fecha.Year != 1900; } }

        #endregion
    }
    #endregion

    #region Lista-Entidad: MovilesAlertas
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesAlertas
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesAlertas : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesAlertas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesAlertas
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesAlertas : LET<EMovilAlerta>
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

    #region Entidad: MovilCombus
    /// <summary>
    /// Clase que representa la Entidad: MovilCombus
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilCombus : Entidad
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

    #region Lista-Entidad: MovilesCombus
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesCombus
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesCombus : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesCombus
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesCombus
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesCombus : LET<EMovilCombus>
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

    #region Entidad: MovilEquip
    /// <summary>
    /// Clase que representa la Entidad: MovilEquip
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilEquip : Entidad
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

    #region Lista-Entidad: MovilesEquip
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesEquip
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesEquip : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesEquip
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesEquip
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesEquip : LET<EMovilEquip>
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

    #region Entidad: MovilEstado
    /// <summary>
    /// Clase que representa la Entidad: MovilEstado
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilEstado : Entidad
    {
        public static string EstadoEnMantenimiento {  get { return " 3"; } }

        public static string EstadoDisponible { get { return " 1"; } }

        public bool EstaEnEstadoMantenimiento {  get { return this.Codestado == EstadoEnMantenimiento; } }

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

    #region Lista-Entidad: MovilesEstado
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesEstado
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesEstado : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesEstado
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesEstado
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesEstado : LET<EMovilEstado>
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

    #region Entidad: MovilInfraccion
    /// <summary>
    /// Clase que representa la Entidad: MovilInfraccion
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilInfraccion : Entidad
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
        private void fNewFromXML(ref DataRow p_drTemp,
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

    #region Lista-Entidad: MovilesInfracciones
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesInfracciones
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesInfracciones : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesInfracciones
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesInfracciones
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesInfracciones : LET<EMovilInfraccion>
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

    #region Entidad: MovilKms
    /// <summary>
    /// Clase que representa la Entidad: MovilKms
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovilKms : Entidad
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

    #region Lista-Entidad: MovilesKms
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesKms
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMovilesKms : ListaEntidades
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

    #region Lista-Entidad-Tipada: MovilesKms
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesKms
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMovilesKms : LET<EMovilKms>
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

    #region Entidad: Movil
    /// <summary>
    /// Clase que representa la Entidad: Movil
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class EMovil : Entidad
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
        public int KmsActuales
        {
            get
            {
                if (this.MovilesKms == null || this.MovilesKms.Count == 0)
                    return 0;

                this.MovilesKms.Sort(EMovilKms.KmCmp + " desc");
                return this.MovilesKms[0].Km;
            }
        }

        #endregion
    }
    #endregion

    #region Lista-Entidad: Moviles
    /// <summary>
    /// Clase que representa la Lista-Entidad: Moviles
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LEMoviles : ListaEntidades
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

    #region Lista-Entidad-Tipada: Moviles
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Moviles
    ///   - Elementos no producidos por el Generador
    /// </summary>
    public sealed partial class LETMoviles : LET<EMovil>
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
