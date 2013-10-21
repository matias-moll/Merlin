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
    // Fecha                    : 21/10/2013 14:59
    // Sistema                  : Rivn
    // Clase para Administrar   : Controles con sus Reparaciones
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Controles con sus Reparaciones
    /// </summary>
    public static partial class Controles
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
        /// Agrega o modifica un registro de la tabla: Controles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtrlSave_f(DBConn p_dbcAccess,
                                        ref EControl p_entControl,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CtrlSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Controles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtrlEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strCod,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CtrlEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Controles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtrlRemove_f(DBConn p_dbcAccess,
                                          string p_strCod,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CtrlRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Control
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CtrlTInt_f(DBConn p_dbcAccess,
                                        EControl p_entControl,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CtrlTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: ControlesReparations
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepSave_f(DBConn p_dbcAccess,
                                        ref EControlRepa p_entControlRepa,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CrepSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: ControlesReparations
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strCodctl,
                                           int p_iNroitem,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CrepEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: ControlesReparations
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepRemove_f(DBConn p_dbcAccess,
                                          string p_strCodctl,
                                          int p_iNroitem,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CrepRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: ControlRepa
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepTInt_f(DBConn p_dbcAccess,
                                        EControlRepa p_entControlRepa,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Controles", "CrepTInt_f");

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
