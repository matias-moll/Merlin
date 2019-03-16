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
    // Fecha                    : 28/06/2018 17:06
    // Sistema                  : Mrln
    // Clase para Administrar   : Alertas
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Alertas
    /// </summary>
    public static partial class Alertas
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase


        public static void fCheckCreacionAlertas(EMovil p_entMovil, StatMsg p_smResult)
        {
            DBConn l_dbcAccess = null;

            try{
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                Bel.LEMovilesAlertas configAlertas = Moviles.MvalFSch(l_dbcAccess, p_entMovil.Patente, true, p_smResult);
                if (p_smResult.NOk) return;

                if (configAlertas.Count == 0)
                    return;

                p_entMovil.MovilesKms = Moviles.MvkmFSch(l_dbcAccess, p_entMovil.Patente, true, p_smResult);
                if (p_smResult.NOk) return;

                LEAlertas alertasDelMovil = Alertas.AleGetAlertasFromMovil(p_entMovil.Patente, p_smResult);
                if (p_smResult.NOk) return;

                LEOTItems reparacionesDelMovil = OrdenesTrabajo.OtitGetRealizadosMvl(p_entMovil.Patente, p_smResult);
                if (p_smResult.NOk) return;

                DateTime fechaActual = BllRuts.GetDBNow(l_dbcAccess, p_smResult);
                if (p_smResult.NOk) return;

                // Iteramos por todas las config alertas y si alguna cumple condicion creamos la nueva alerta.
                foreach (EMovilAlerta configAlerta in configAlertas)
                {
                    if(configAlerta.CumpleCondicion(p_entMovil, alertasDelMovil,  reparacionesDelMovil, fechaActual))
                    {
                        ETalonario nroAlerta = AppRuts.TaloGet(l_dbcAccess, "ConfAlerta", p_smResult);
                        if (p_smResult.NOk) return;

                        Bel.EAlerta nuevaAlerta = configAlerta.crearAlerta(nroAlerta.Valor, fechaActual);
                        Alertas.AleSave(nuevaAlerta, p_smResult);
                        if (p_smResult.NOk) return;

                    }
                }

            }
            catch (Exception l_expData){
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
            }
            finally{
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }

            
        }

        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Alertas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleSave_f(DBConn p_dbcAccess,
                                       ref EAlerta p_entAlerta,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Alertas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          int p_iNroconfig,
                                          int p_iNroalerta,
                                          ref int p_iFxdVersion,
                                          StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Alertas
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleRemove_f(DBConn p_dbcAccess,
                                         int p_iNroconfig,
                                         int p_iNroalerta,
                                         int p_iFxdVersion,
                                         StatMsg p_smResult)
        {
            // *********
            // Agregar acá los procesos adicionales
            // *********
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Alerta
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleTInt_f(DBConn p_dbcAccess,
                                       EAlerta p_entAlerta,
                                       StatMsg p_smResult)
        {
            // *********
            // Agregar acá las validaciones adicionales
            // *********
        }



        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
