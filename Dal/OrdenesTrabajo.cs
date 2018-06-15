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
    // Fecha                    : 15/06/2018 19:16
    // Sistema                  : Mrln
    // Clase para Administrar   : Ordenes De Trabajo
    // Basada en la Tabla       : OrdenesTrabajo
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
    /// Modulo DAL de Acceso a la tabla: OrdenesTrabajo
    /// </summary>
    public static class OrdenesTrabajo
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
                                      "TNGS_Mrln..ORDENESTRABAJO_UP",
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNro,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      ref StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..ORDENESTRABAJO_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNro,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 ref StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ORDENESTRABAJO_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
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
        #endregion

        #region Metodos de Actualizacion

        /// <summary>
        /// Inserta un registro en la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">nro</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecapertura">Fecha de apertura</param>
        /// <param name="p_strOperador">Operador</param>
        /// <param name="p_dtFeccierre">Fecha de cierre.</param>
        /// <param name="p_strEncargado">Encargado</param>
        /// <param name="p_strCodtaller">Taller</param>
        /// <param name="p_strEstado">Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNro,
                                 string p_strPatente,
                                 DateTime p_dtFecapertura,
                                 string p_strOperador,
                                 DateTime p_dtFeccierre,
                                 string p_strEncargado,
                                 string p_strCodtaller,
                                 string p_strEstado,
                                 ref StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ORDENESTRABAJO_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
                                       p_dbcAccess.MakeParam("@odt_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@odt_fyh_fecapertura", p_dtFecapertura),
                                       p_dbcAccess.MakeParam("@odt_nom_operador", p_strOperador),
                                       p_dbcAccess.MakeParam("@odt_fyh_feccierre", p_dtFeccierre),
                                       p_dbcAccess.MakeParam("@odt_cod_encargado", p_strEncargado),
                                       p_dbcAccess.MakeParam("@odt_cod_codtaller", p_strCodtaller),
                                       p_dbcAccess.MakeParam("@odt_d20_estado", p_strEstado),
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecapertura">Fecha de apertura</param>
        /// <param name="p_strOperador">Operador</param>
        /// <param name="p_dtFeccierre">Fecha de cierre.</param>
        /// <param name="p_strEncargado">Encargado</param>
        /// <param name="p_strCodtaller">Taller</param>
        /// <param name="p_strEstado">Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNro,
                                 string p_strPatente,
                                 DateTime p_dtFecapertura,
                                 string p_strOperador,
                                 DateTime p_dtFeccierre,
                                 string p_strEncargado,
                                 string p_strCodtaller,
                                 string p_strEstado,
                                 ref StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ORDENESTRABAJO_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
                                       p_dbcAccess.MakeParam("@odt_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@odt_fyh_fecapertura", p_dtFecapertura),
                                       p_dbcAccess.MakeParam("@odt_nom_operador", p_strOperador),
                                       p_dbcAccess.MakeParam("@odt_fyh_feccierre", p_dtFeccierre),
                                       p_dbcAccess.MakeParam("@odt_cod_encargado", p_strEncargado),
                                       p_dbcAccess.MakeParam("@odt_cod_codtaller", p_strCodtaller),
                                       p_dbcAccess.MakeParam("@odt_d20_estado", p_strEstado),
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNro,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ORDENESTRABAJO_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNro,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ORDENESTRABAJO_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
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
        /// <param name="p_iNro">nro</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNro,
                               ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ORDENESTRABAJO_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@odt_nro_nro", p_iNro),
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
                                   "TNGS_Mrln..ORDENESTRABAJO_PACK",
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

        /// <summary>
        /// Método Fijo: getPendByPatente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strPatente">patente de un movil</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int getPendByPatente(DBConn p_dbcAccess,
                                           string p_strPatente,
                                           ref DataSet p_dsResult,
                                           string p_strTabla,
                                           ref StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ORDENESTRABAJO_GETPENDBYPATENTE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@patente", p_strPatente),
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Método Fijo: getPendientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int getPendientes(DBConn p_dbcAccess,
                                        ref DataSet p_dsResult,
                                        string p_strTabla,
                                        ref StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ORDENESTRABAJO_GETPENDIENTES",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el método fijo
                p_smResult.DalError(l_expData);
                return -1;
            }
        }
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
                p_dtResult.Columns["ot_taller"].Caption= "V1TallerCN1";
                p_dtResult.Columns["odt_fyh_fecapertura"].Caption= "V1Fecha de aperturaDN1";
                p_dtResult.Columns["odt_fyh_feccierre"].Caption= "V1Fecha de cierre.DN1";
                p_dtResult.Columns["odt_nro_nro"].Caption= "V1nroNN1";
                p_dtResult.Columns["odt_nom_operador"].Caption= "V1OperadorCN1";
                p_dtResult.Columns["odt_ecd_patente"].Caption= "V1PatenteCN1";
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
