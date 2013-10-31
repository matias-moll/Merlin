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
    // Fecha                    : 31/10/2013 17:04
    // Sistema                  : Rivn
    // Clase para Administrar   : Controles de las reaparaciones
    // Basada en la Tabla       : ControlesReparations
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
    /// Modulo DAL de Acceso a la tabla: ControlesReparations
    /// </summary>
    public static class ControlesReparations
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
            p_smResult.DalReset("ControlesReparations", "Up");

            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..CONTROLESREPARATIONS_UP",
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strCodctl,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "ChkVersion");

            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Rivn..CONTROLESREPARATIONS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                   p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 string p_strCodctl,
                                 int p_iNroitem,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Search");

            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..CONTROLESREPARATIONS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                          p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
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

        /// <summary>
        /// Busca los registros de una clave foranea (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FSearch(DBConn p_dbcAccess,
                                  string p_strCodctl,
                                  bool p_bOnlyActive,
                                  ref DataSet p_dsResult,
                                  string p_strTabla,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "FSearch");

            try {
                // Recuperamos los registro de la clave foranea
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..CONTROLESREPARATIONS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search de los registros
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_strCodrep">codigoReparacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strCodctl,
                                 int p_iNroitem,
                                 string p_strCodrep,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Insert");

            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
                                       p_dbcAccess.MakeParam("@ctr_cd6_codrep", p_strCodrep),
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_strCodrep">codigoReparacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strCodctl,
                                 int p_iNroitem,
                                 string p_strCodrep,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Update");

            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
                                       p_dbcAccess.MakeParam("@ctr_cd6_codrep", p_strCodrep),
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strCodctl,
                                 int p_iNroitem,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Delete");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
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
        /// Borra logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDelete(DBConn p_dbcAccess,
                                  string p_strCodctl,
                                  DateTime p_dtInstante,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "FDelete");

            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strCodctl,
                                 int p_iNroitem,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Recall");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
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
        /// Recupera logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FRecall(DBConn p_dbcAccess,
                                  string p_strCodctl,
                                  DateTime p_dtInstante,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "FRecall");

            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
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
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strCodctl,
                               int p_iNroitem,
                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "Drop");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@ctr_nro_nroitem", p_iNroitem),
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
        /// Borra fisicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDrop(DBConn p_dbcAccess,
                                string p_strCodctl,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "FDrop");

            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
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
            p_smResult.DalReset("ControlesReparations", "Pack");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_PACK",
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

        /// <summary>
        /// Borra fisicamente los registros borrado lógicamente de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FPack(DBConn p_dbcAccess,
                                string p_strCodctl,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("ControlesReparations", "FPack");

            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..CONTROLESREPARATIONS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@ctr_cod_codctl", p_strCodctl),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
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
            p_smResult.DalReset("ControlesReparations", "MakeGridCaption");

            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
                p_dtResult.Columns["ctr_des_des"].Caption= "V1TitleSN1";
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
            p_smResult.DalReset("ControlesReparations", "MakeGridCaption");

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
            p_smResult.DalReset("ControlesReparations", "MakeGridCaption");

            // Llamamos al método base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
            p_smResult.DalExit();
        }
        #endregion
    }
}
