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
    // Fecha                    : 21/10/2013 16:24
    // Sistema                  : Rivn
    // Clase para Administrar   : Moviles y Tablas Hijas
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Moviles y Tablas Hijas
    /// </summary>
    public static partial class Moviles
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase

        /// <summary>
        /// Agrega un ROOT a un tree
        /// </summary>
        /// <param name="p_lentData">ListaEntidad de datos</param>
        /// <param name="p_strDescripcion">Descripcion del Root</param>
        /// <param name="p_iNroImagen">Indice de la imagen</param>
        private static void fAgregarRoot(ListaEntidades p_lentData,
                                         string p_strDescripcion,
                                         int p_iNroImagen)
        {
            DataRow l_drTemp = p_lentData.InternalData.Table.NewRow();

            // Agregamos el root
            l_drTemp["Codigo"] = 0;
            l_drTemp["Descripcion"] = p_strDescripcion;
            l_drTemp["Mensaje"] = "";
            l_drTemp["Nivel"] = 1;
            l_drTemp["Imagen"] = p_iNroImagen;

            p_lentData.InternalData.Table.Rows.Add(l_drTemp);
            p_lentData.Sort("Codigo");
        }

        /// <summary>
        /// Arma Tree de Moviles
        /// </summary>
        /// <param name="p_lentData">ListaEntidad de datos</param>
        /// <param name="p_strDescripcion">Descripcion del Root</param>
        /// <param name="p_iNroImagen">Indice de la imagen</param>
        private static void fArmarTree(ListaEntidades p_lentData, bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Moviles", "MveqUpFull");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                p_lentData =  Bll.Moviles.getMovilesTree(l_dbcAccess, ref p_smResult);
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            fAgregarRoot(p_lentData, "Moviles", 1);

        }

        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Moviles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref EMovil p_entMovil,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Save_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Moviles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Enabled_f(DBConn p_dbcAccess,
                                       bool p_bEnable,
                                       string p_strPatente,
                                       ref int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Enabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Moviles
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Remove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Movil
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    EMovil p_entMovil,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "TInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlCombustible
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoSave_f(DBConn p_dbcAccess,
                                        ref EMovilCombus p_entMovilCombus,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlCombustible
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strPatente,
                                           DateTime p_dtFecha,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MvlCombustible
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoRemove_f(DBConn p_dbcAccess,
                                          string p_strPatente,
                                          DateTime p_dtFecha,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilCombus
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoTInt_f(DBConn p_dbcAccess,
                                        EMovilCombus p_entMovilCombus,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlEquipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqSave_f(DBConn p_dbcAccess,
                                        ref EMovilEquip p_entMovilEquip,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlEquipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strPatente,
                                           string p_strCodequip,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MvlEquipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqRemove_f(DBConn p_dbcAccess,
                                          string p_strPatente,
                                          string p_strCodequip,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilEquip
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqTInt_f(DBConn p_dbcAccess,
                                        EMovilEquip p_entMovilEquip,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlEstados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesSave_f(DBConn p_dbcAccess,
                                        ref EMovilEstado p_entMovilEstado,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlEstados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strPatente,
                                           DateTime p_dtFecha,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MvlEstados
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesRemove_f(DBConn p_dbcAccess,
                                          string p_strPatente,
                                          DateTime p_dtFecha,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilEstado
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesTInt_f(DBConn p_dbcAccess,
                                        EMovilEstado p_entMovilEstado,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlKilometros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmSave_f(DBConn p_dbcAccess,
                                        ref EMovilKms p_entMovilKms,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlKilometros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           string p_strPatente,
                                           DateTime p_dtFecha,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: MvlKilometros
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmRemove_f(DBConn p_dbcAccess,
                                          string p_strPatente,
                                          DateTime p_dtFecha,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilKms
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmTInt_f(DBConn p_dbcAccess,
                                        EMovilKms p_entMovilKms,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmTInt_f");

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
