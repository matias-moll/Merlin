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
    // � 1996-2013 by TNG Software                                      Gndr 5.20
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
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------
        #region Metodos publicos de la clase

        /// <summary>
        /// Me devuelve un Array con las listas entidades de los ultimos 5 combustibles, estados, kms y eq
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive"></param>
        /// <param name="p_smResult"></param>
        /// <returns></returns>
        public static List<ListaEntidades> fGetLastFiveTodos(string p_strPatente,
                                                bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            List<ListaEntidades> l_lstLEListaListaEntidades = new List<ListaEntidades>();
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Estados", "fGetLastFiveMvlCombus");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                l_lstLEListaListaEntidades.Add(Bll.Moviles.MvcogetLastFiveMvlCombus(l_dbcAccess, p_strPatente, ref p_smResult));
                l_lstLEListaListaEntidades.Add(Bll.Moviles.MvkmgetLastFiveMvlKm(l_dbcAccess, p_strPatente, ref p_smResult));
                l_lstLEListaListaEntidades.Add(Bll.Moviles.MvesgetLastFiveMvlEstads(l_dbcAccess, p_strPatente, ref p_smResult));
                l_lstLEListaListaEntidades.Add(Bll.Moviles.MveqFGet(p_strPatente, true, ref p_smResult));
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            return l_lstLEListaListaEntidades;



        }

        /// <summary>
        /// Me devuelve una listaEntidad con los 5 ultimos Combustibles de un movil
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive"></param>
        /// <param name="p_smResult"></param>
        /// <returns></returns>
        public static ListaEntidades fGetLastFiveMvlCombus(string p_strPatente,
                                                bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            ListaEntidades l_lentData;
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Estados", "fGetLastFiveMvlCombus");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                l_lentData = Bll.Moviles.MvcogetLastFiveMvlCombus(l_dbcAccess,p_strPatente, ref p_smResult);
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            return l_lentData;

 
        
        }

        /// <summary>
        /// Me devuelve los ultimos 5 kms de un movil
        /// </summary>
        /// <param name="p_strPatente"></param>
        /// <param name="p_bOnlyActive"></param>
        /// <param name="p_smResult"></param>
        /// <returns></returns>
        public static ListaEntidades fGetLastFiveMvlKms(string p_strPatente,
                                  bool p_bOnlyActive,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            ListaEntidades l_lentData;
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Estados", "fGetLastFiveMvlKms");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                l_lentData = Bll.Moviles.MvkmgetLastFiveMvlKm(l_dbcAccess, p_strPatente, ref p_smResult);
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            return l_lentData;



        }


        /// <summary>
        /// Devuelve los 5 ultimos estados de un movil
        /// </summary>
        /// <param name="p_strPatente"></param>
        /// <param name="p_bOnlyActive"></param>
        /// <param name="p_smResult"></param>
        /// <returns></returns>
        public static ListaEntidades fGetLastFiveMvlEstados(string p_strPatente,
                                          bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            ListaEntidades l_lentData;
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Estados", "fGetLastFiveMvlEstados");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                l_lentData = Bll.Moviles.MvesgetLastFiveMvlEstads(l_dbcAccess, p_strPatente, ref p_smResult);
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            return l_lentData;



        }


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
            l_drTemp["mov_ecd_patente"] = 0;
            l_drTemp["mov_des_des"] = p_strDescripcion;
            l_drTemp["Orden"] = 1;
            l_drTemp["Nivel"] = 1;
            l_drTemp["Imagen"] = p_iNroImagen;

            p_lentData.InternalData.Table.Rows.Add(l_drTemp);
            p_lentData.Sort("mov_ecd_patente");
        }

        /// <summary>
        /// Arma Tree de Moviles
        /// </summary>
        /// <param name="p_lentData">ListaEntidad de datos</param>
        /// <param name="p_strDescripcion">Descripcion del Root</param>
        /// <param name="p_iNroImagen">Indice de la imagen</param>
        public static ListaEntidades fArmarTree( bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            ListaEntidades l_lentData;
            DBConn l_dbcAccess = null;
            p_smResult.BllReset("Estados", "fArmarTree");

            try
            {
                // Obtenemos una conexion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                l_lentData =  Bll.Moviles.getMovilesTree(l_dbcAccess, ref p_smResult);
            }
            catch (Exception l_expData)
            {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally
            {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }

            fAgregarRoot(l_lentData, "Moviles", 1);

            return l_lentData;

        }


        public static void CambiarEquipamientoYGrabarMovil(EMovil p_entMovil,
                                                           LEMovilesEquip p_leNuevosEquipamientos,
                                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSave");
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();
                DataSet l_dsTemp = new DataSet();

                // Borramos todo el equimamiento que tiene el movil
                MveqEliminarEquipamiento(l_dbcAccess, p_entMovil.Patente, ref p_smResult);
                if (p_smResult.NOk) return;

                // Le asignamos al movil los nuevo equipamientos
                p_entMovil.MovilesEquip = p_leNuevosEquipamientos;

                // Y grabamos los equipamientos
                foreach(Bel.EMovilEquip item in p_leNuevosEquipamientos){
                    Moviles.MveqInsr(l_dbcAccess, item, ref p_smResult);
                    if (p_smResult.NOk) return;
                }

                //grabamos el movil con sus modificaciones
                Moviles.Updt(l_dbcAccess, p_entMovil, ref p_smResult);
                if (p_smResult.NOk) return;

            }
            catch (Exception l_expData)
            {
                // Error 
                p_smResult.BllError(l_expData.ToString());
            }
            finally
            {
                // Si pude abrir la conexion
                if (l_dbcAccess != null)
                {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }


        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Moviles
        /// (C�digo Fijo)
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Moviles
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Moviles
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Remove_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Movil
        /// (C�digo Fijo)
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
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlCombustible
        /// (C�digo Fijo)
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlCombustible
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MvlCombustible
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilCombus
        /// (C�digo Fijo)
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
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlEquipamiento
        /// (C�digo Fijo)
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlEquipamiento
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MvlEquipamiento
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilEquip
        /// (C�digo Fijo)
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
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlEstados
        /// (C�digo Fijo)
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlEstados
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MvlEstados
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilEstado
        /// (C�digo Fijo)
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
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MvlKilometros
        /// (C�digo Fijo)
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MvlKilometros
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MvlKilometros
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
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
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: MovilKms
        /// (C�digo Fijo)
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
            // Agregar ac� las validaciones adicionales
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
