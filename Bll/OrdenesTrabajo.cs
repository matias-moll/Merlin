#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Rivn;
using Rivn.Bel;
#endregion

namespace Rivn.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 21/10/2013 15:04
    // Sistema                  : Rivn
    // Clase para Administrar   : Ordenes de Trabajo y sus Items
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Ordenes de Trabajo y sus Items
    /// </summary>
    public static partial class OrdenesTrabajo
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: OrdenesTrabajo
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OrtaSave_f(DBConn p_dbcAccess,
                                        ref EOrdenTrabajo p_entOrdenTrabajo,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OrtaSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: OrdenesTrabajo
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">nro</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OrtaEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           int p_iNro,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OrtaEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: OrdenesTrabajo
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">nro</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OrtaRemove_f(DBConn p_dbcAccess,
                                          int p_iNro,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OrtaRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: OrdenTrabajo
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OrtaTInt_f(DBConn p_dbcAccess,
                                        EOrdenTrabajo p_entOrdenTrabajo,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OrtaTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: OtItems
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitSave_f(DBConn p_dbcAccess,
                                        ref EOTItem p_entOTItem,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: OtItems
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           int p_iNroot,
                                           int p_iNroagrupador,
                                           int p_iNroitem,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: OtItems
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitRemove_f(DBConn p_dbcAccess,
                                          int p_iNroot,
                                          int p_iNroagrupador,
                                          int p_iNroitem,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: OTItem
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitTInt_f(DBConn p_dbcAccess,
                                        EOTItem p_entOTItem,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
