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
    // Fecha                    : 15/03/2019 22:44
    // Sistema                  : Mrln
    // Clase para Administrar   : Alertas
    // Basada en la Tabla       : Alertas
    //----------------------------------------------------------------------------
    // © 1996-2019 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    /// <summary>
    /// Modulo DAL de Acceso a la tabla: Alertas
    /// </summary>
    public static class Alertas
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
                             StatMsg p_smResult)
        {
            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ALERTAS_UP",
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNroconfig,
                                      int p_iNroalerta,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..ALERTAS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                   p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNroconfig,
                                 int p_iNroalerta,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ALERTAS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                          p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_strDescripcion">Descripción</param>
        /// <param name="p_strDetalle">Detalle</param>
        /// <param name="p_strImportancia">Importancia</param>
        /// <param name="p_dtFechadisparada">Fecha Disparada</param>
        /// <param name="p_dtFechavista">Fecha Vista</param>
        /// <param name="p_strUsuariovista">Usuario Vista</param>
        /// <param name="p_iRepetirendias">Repetir en Dias</param>
        /// <param name="p_strFinalizada">Finalizada</param>
        /// <param name="p_strMailsenviados">Mails Enviados</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNroconfig,
                                 int p_iNroalerta,
                                 string p_strDescripcion,
                                 string p_strDetalle,
                                 string p_strImportancia,
                                 DateTime p_dtFechadisparada,
                                 DateTime p_dtFechavista,
                                 string p_strUsuariovista,
                                 int p_iRepetirendias,
                                 string p_strFinalizada,
                                 string p_strMailsenviados,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                       p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
                                       p_dbcAccess.MakeParam("@alr_des_descripcion", p_strDescripcion),
                                       p_dbcAccess.MakeParam("@alr_d2x_detalle", p_strDetalle),
                                       p_dbcAccess.MakeParam("@alr_cd1_importancia", p_strImportancia),
                                       p_dbcAccess.MakeParam("@alr_fyh_fechadisparada", p_dtFechadisparada),
                                       p_dbcAccess.MakeParam("@alr_fyh_fechavista", p_dtFechavista),
                                       p_dbcAccess.MakeParam("@alr_nom_usuariovista", p_strUsuariovista),
                                       p_dbcAccess.MakeParam("@alr_nro_repetirendias", p_iRepetirendias),
                                       p_dbcAccess.MakeParam("@alr_cd1_finalizada", p_strFinalizada),
                                       p_dbcAccess.MakeParam("@alr_cd1_mailsenviados", p_strMailsenviados),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_strDescripcion">Descripción</param>
        /// <param name="p_strDetalle">Detalle</param>
        /// <param name="p_strImportancia">Importancia</param>
        /// <param name="p_dtFechadisparada">Fecha Disparada</param>
        /// <param name="p_dtFechavista">Fecha Vista</param>
        /// <param name="p_strUsuariovista">Usuario Vista</param>
        /// <param name="p_iRepetirendias">Repetir en Dias</param>
        /// <param name="p_strFinalizada">Finalizada</param>
        /// <param name="p_strMailsenviados">Mails Enviados</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNroconfig,
                                 int p_iNroalerta,
                                 string p_strDescripcion,
                                 string p_strDetalle,
                                 string p_strImportancia,
                                 DateTime p_dtFechadisparada,
                                 DateTime p_dtFechavista,
                                 string p_strUsuariovista,
                                 int p_iRepetirendias,
                                 string p_strFinalizada,
                                 string p_strMailsenviados,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                       p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
                                       p_dbcAccess.MakeParam("@alr_des_descripcion", p_strDescripcion),
                                       p_dbcAccess.MakeParam("@alr_d2x_detalle", p_strDetalle),
                                       p_dbcAccess.MakeParam("@alr_cd1_importancia", p_strImportancia),
                                       p_dbcAccess.MakeParam("@alr_fyh_fechadisparada", p_dtFechadisparada),
                                       p_dbcAccess.MakeParam("@alr_fyh_fechavista", p_dtFechavista),
                                       p_dbcAccess.MakeParam("@alr_nom_usuariovista", p_strUsuariovista),
                                       p_dbcAccess.MakeParam("@alr_nro_repetirendias", p_iRepetirendias),
                                       p_dbcAccess.MakeParam("@alr_cd1_finalizada", p_strFinalizada),
                                       p_dbcAccess.MakeParam("@alr_cd1_mailsenviados", p_strMailsenviados),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNroconfig,
                                 int p_iNroalerta,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                       p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNroconfig,
                                 int p_iNroalerta,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                       p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
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
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNroconfig,
                               int p_iNroalerta,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@alr_nro_nroconfig", p_iNroconfig),
                                       p_dbcAccess.MakeParam("@alr_nro_nroalerta", p_iNroalerta),
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
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..ALERTAS_PACK",
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
        /// Método Fijo: GetAlertasFromMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strPatente">Patente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetAlertasFromMovil(DBConn p_dbcAccess,
                                              string p_strPatente,
                                              ref DataSet p_dsResult,
                                              string p_strTabla,
                                              StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ALERTAS_GETALERTASFROMMOVIL",
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
        /// Método Fijo: GetPendientesFromMov
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strPatente">Patente</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetPendientesFromMov(DBConn p_dbcAccess,
                                               string p_strPatente,
                                               ref DataSet p_dsResult,
                                               string p_strTabla,
                                               StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..ALERTAS_GETPENDIENTESFROMMOV",
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
        #endregion

        #region Grillas Definidas

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_dtResult">Tabla donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref DataTable p_dtResult,
                                            StatMsg p_smResult)
        {
            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
                p_dtResult.Columns["alr_des_descripcion"].Caption= "V1DescripciónCN1";
                p_dtResult.Columns["alr_fyh_fechadisparada"].Caption= "V1Fecha DisparadaDN1";
                p_dtResult.Columns["alr_fyh_fechavista"].Caption= "V1Fecha VistaDN1";
                p_dtResult.Columns["alr_cd1_finalizada"].Caption= "V1FinalizadaCN1";
                p_dtResult.Columns["alr_nro_nroalerta"].Caption= "V1Nro AlertaNN1";
                p_dtResult.Columns["alr_nro_repetirendias"].Caption= "V1Repetir en DiasNN1";
                p_dtResult.Columns["alr_nom_usuariovista"].Caption= "V1Usuario VistaCN1";
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
                                            StatMsg p_smResult)
        {
            // Llamamos al método base
            DataTable l_dtTemp= p_dsResult.Tables[p_strTabla];
            MakeGridCaptions(ref l_dtTemp, p_smResult);
        }

        /// <summary>
        /// Genera los Captions para la grilla default
        /// </summary>
        /// <param name="p_lentResult">ListaEntidades donde completar los captions</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MakeGridCaptions(ref ListaEntidades p_lentResult,
                                            StatMsg p_smResult)
        {
            // Llamamos al método base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, p_smResult);
        }
        #endregion
    }
}
