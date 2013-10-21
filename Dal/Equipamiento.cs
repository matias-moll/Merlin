#region Usings
using System;
using System.Data;
using System.Data.Common;
using TNGS.NetRoutines;
#endregion

namespace Rivn.Dal
{
    //----------------------------------------------------------------------------
    //                         TNG Software DAL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 21/10/2013 16:46
    // Sistema                  : Rivn
    // Clase para Administrar   : Equipamiento de los móviles
    // Basada en la Tabla       : Equipamiento
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Modulo DAL de Acceso a la tabla: Equipamiento
    /// </summary>
    public static class Equipamiento
    {
        //---------------------------------------------------------------
        // Métodos públicos estáticos de la clase para realizar
        // operaciones sobre la Tabla
        //---------------------------------------------------------------

        #region Metodos de Recupero

        /// <summary>
        /// Recupera la lista completa de registros (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver los datos</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Up(DBConn p_dbcAccess,
                             bool p_bOnlyActive,
                             ref DataSet p_dsResult,
                             string p_strTabla,
                             ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Up");

            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..EQUIPAMIENTO_UP",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el select de la tabla
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Verifica el número de versión de un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "ChkVersion");

            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Rivn..EQUIPAMIENTO_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                   p_dbcAccess.MakeParam("@version", p_iFxdVersion)
                               },
                               ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el conteo
                p_smResult.DalError(l_expData.ToString());
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Busca el registro de una clave (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 string p_strCod,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Search");

            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..EQUIPAMIENTO_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }
        #endregion

        #region Metodos de Actualizacion

        /// <summary>
        /// Inserta un registro en la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_strDes">des</param>
        /// <param name="p_dcValor">valor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 decimal p_dcValor,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Insert");

            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@eqi_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@eqi_imp_valor", p_dcValor),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el insert del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Actualiza un registro de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_strDes">des</param>
        /// <param name="p_dcValor">valor</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 decimal p_dcValor,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Update");

            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@eqi_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@eqi_imp_valor", p_dcValor),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Borra logicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strCod,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Delete");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Recupera un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strCod,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Recall");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Borra fisicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strCod,
                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Drop");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@eqi_cod_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Borra fisicamente los registros borrados logicamente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Pack(DBConn p_dbcAccess,
                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "Pack");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..EQUIPAMIENTO_PACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }
        #endregion

        #region Metodos del Usuario
        #endregion

        #region Grillas Definidas

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_dtResult">Tabla donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref DataTable p_dtResult,
                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "MakeGridCaption");

            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
                p_dtResult.Columns["eqi_cod_cod"].Caption= "V1codCN1";
                p_dtResult.Columns["eqi_des_des"].Caption= "V1desCN1";
                p_dtResult.Columns["deleted"].Caption= "V1Borrado2N2";
            }
            catch (Exception l_expData) {
                // Error en el armado de la grilla
                p_smResult.DalError(l_expData.ToString());
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
            }
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_dsResult">DataSet donde completar los captions</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref DataSet p_dsResult,
                                            string p_strTabla,
                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "MakeGridCaption");

            // Llamamos al método base
            DataTable l_dtTemp= p_dsResult.Tables[p_strTabla];
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
            p_smResult.DalExit();
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_lentResult">ListaEntidades donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref ListaEntidades p_lentResult,
                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Equipamiento", "MakeGridCaption");

            // Llamamos al método base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
            p_smResult.DalExit();
        }
        #endregion
    }
}
