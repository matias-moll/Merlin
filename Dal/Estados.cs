#region Usings
using System;
using System.Data;
using System.Data.Common;
using TNGS.NetRoutines;
#endregion

namespace Mrln.Dal
{
    //----------------------------------------------------------------------------
    //                         TNG Software DAL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 23/06/2018 19:06
    // Sistema                  : Mrln
    // Clase para Administrar   : Estados de los Moviles
    // Basada en la Tabla       : Estados
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Modulo DAL de Acceso a la tabla: Estados
    /// </summary>
    public static class Estados
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
            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ESTADOS_UP",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el select de la tabla
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Verifica el número de versión de un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
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
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..ESTADOS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                   p_dbcAccess.MakeParam("@version", p_iFxdVersion)
                               },
                               ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el conteo
                p_smResult.DalError(l_expData);
            }
        }

        /// <summary>
        /// Busca el registro de una clave (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
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
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ESTADOS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Busca la clave máxima de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void GetMaxKey(DBConn p_dbcAccess,
                                     ref DataSet p_dsResult,
                                     string p_strTabla,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            try {
                // Recuperamos la clave mas alta de la tabla
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..ESTADOS_GETMAXKEY",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@dummy", "X")
                               },
                               ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search de la clave máxima
                p_smResult.DalError(l_expData);
            }
        }
        #endregion

        #region Metodos de Actualizacion

        /// <summary>
        /// Inserta un registro en la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_strDes">Estado</param>
        /// <param name="p_strTxtcontingencia">Texto de Contingencia</param>
        /// <param name="p_strOperativo">Operativo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 string p_strTxtcontingencia,
                                 string p_strOperativo,
                                 ref StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@est_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@est_txt_txtcontingencia", p_strTxtcontingencia),
                                       p_dbcAccess.MakeParam("@est_cd1_operativo", p_strOperativo),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el insert del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Actualiza un registro de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_strDes">Estado</param>
        /// <param name="p_strTxtcontingencia">Texto de Contingencia</param>
        /// <param name="p_strOperativo">Operativo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCod,
                                 string p_strDes,
                                 string p_strTxtcontingencia,
                                 string p_strOperativo,
                                 ref StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@est_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@est_txt_txtcontingencia", p_strTxtcontingencia),
                                       p_dbcAccess.MakeParam("@est_cd1_operativo", p_strOperativo),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra logicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strCod,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Recupera un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strCod,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update del registro
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra fisicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strCod,
                               ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@est_rcd_cod", p_strCod),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData);
                return -1;
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
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ESTADOS_PACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete del registro
                p_smResult.DalError(l_expData);
                return -1;
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
            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
                p_dtResult.Columns["est_rcd_cod"].Caption= "V1Codigo EstadoCN1";
                p_dtResult.Columns["est_des_des"].Caption= "V1EstadoCN1";
                p_dtResult.Columns["est_cd1_operativo"].Caption= "V1OperativoCN1";
                p_dtResult.Columns["est_txt_txtcontingencia"].Caption= "V1Texto de ContingenciaCN1";
                p_dtResult.Columns["deleted"].Caption= "V1Borrado2N2";
            }
            catch (Exception l_expData) {
                // Error en el armado de la grilla
                p_smResult.DalError(l_expData);
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
            // Llamamos al método base
            DataTable l_dtTemp= p_dsResult.Tables[p_strTabla];
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_lentResult">ListaEntidades donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref ListaEntidades p_lentResult,
                                            ref StatMsg p_smResult)
        {
            // Llamamos al método base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
        }
        #endregion
    }
}
