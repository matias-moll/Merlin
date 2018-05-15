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
    // Fecha                    : 15/05/2018 19:47
    // Sistema                  : Mrln
    // Clase para Administrar   : OrdenTrabajo Items
    // Basada en la Tabla       : OtItems
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
    /// Modulo DAL de Acceso a la tabla: OtItems
    /// </summary>
    public static class OtItems
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
                                      "TNGS_Mrln..OTITEMS_UP",
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
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      ref StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..OTITEMS_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                   p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                   p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
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
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 int p_iNroot,
                                 int p_iNroagrupador,
                                 int p_iNroitem,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 ref StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..OTITEMS_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                          p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                          p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
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
        /// Busca los registros de una clave foranea (Grilla)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FSearch(DBConn p_dbcAccess,
                                  int p_iNroot,
                                  bool p_bOnlyActive,
                                  ref DataSet p_dsResult,
                                  string p_strTabla,
                                  ref StatMsg p_smResult)
        {
            try {
                // Recuperamos los registro de la clave foranea
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..OTITEMS_FSEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                          p_dbcAccess.MakeParam("@onlyactive", (p_bOnlyActive ? 1 : 0))
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el search de los registros
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
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_strDesoperacion">Descripción de la operación.</param>
        /// <param name="p_strDestarea">Descripción de la tarea</param>
        /// <param name="p_strDescategoria">Descripción de la categoría.</param>
        /// <param name="p_dcImporte">Importe</param>
        /// <param name="p_strComentario">Comentario</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 int p_iNroot,
                                 int p_iNroagrupador,
                                 int p_iNroitem,
                                 string p_strDesoperacion,
                                 string p_strDestarea,
                                 string p_strDescategoria,
                                 decimal p_dcImporte,
                                 string p_strComentario,
                                 ref StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                       p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
                                       p_dbcAccess.MakeParam("@oti_des_desoperacion", p_strDesoperacion),
                                       p_dbcAccess.MakeParam("@oti_des_destarea", p_strDestarea),
                                       p_dbcAccess.MakeParam("@oti_des_descategoria", p_strDescategoria),
                                       p_dbcAccess.MakeParam("@oti_imp_importe", p_dcImporte),
                                       p_dbcAccess.MakeParam("@oti_ede_comentario", p_strComentario),
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
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_strDesoperacion">Descripción de la operación.</param>
        /// <param name="p_strDestarea">Descripción de la tarea</param>
        /// <param name="p_strDescategoria">Descripción de la categoría.</param>
        /// <param name="p_dcImporte">Importe</param>
        /// <param name="p_strComentario">Comentario</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 int p_iNroot,
                                 int p_iNroagrupador,
                                 int p_iNroitem,
                                 string p_strDesoperacion,
                                 string p_strDestarea,
                                 string p_strDescategoria,
                                 decimal p_dcImporte,
                                 string p_strComentario,
                                 ref StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                       p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
                                       p_dbcAccess.MakeParam("@oti_des_desoperacion", p_strDesoperacion),
                                       p_dbcAccess.MakeParam("@oti_des_destarea", p_strDestarea),
                                       p_dbcAccess.MakeParam("@oti_des_descategoria", p_strDescategoria),
                                       p_dbcAccess.MakeParam("@oti_imp_importe", p_dcImporte),
                                       p_dbcAccess.MakeParam("@oti_ede_comentario", p_strComentario),
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
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 int p_iNroot,
                                 int p_iNroagrupador,
                                 int p_iNroitem,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                       p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
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
        /// Borra logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDelete(DBConn p_dbcAccess,
                                  int p_iNroot,
                                  DateTime p_dtInstante,
                                  ref StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_FDELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Recupera un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 int p_iNroot,
                                 int p_iNroagrupador,
                                 int p_iNroitem,
                                 ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                       p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
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
        /// Recupera logicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_dtInstante">Instante del borrado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FRecall(DBConn p_dbcAccess,
                                  int p_iNroot,
                                  DateTime p_dtInstante,
                                  ref StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_FRECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@instante", p_dtInstante),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el update de los registros
                p_smResult.DalError(l_expData);
                return -1;
            }
        }

        /// <summary>
        /// Borra fisicamente un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               int p_iNroot,
                               int p_iNroagrupador,
                               int p_iNroitem,
                               ref StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@oti_nro_nroagrupador", p_iNroagrupador),
                                       p_dbcAccess.MakeParam("@oti_nro_nroitem", p_iNroitem),
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
        /// Borra fisicamente los registros de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FDrop(DBConn p_dbcAccess,
                                int p_iNroot,
                                ref StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_FDROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
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
                                   "TNGS_Mrln..OTITEMS_PACK",
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

        /// <summary>
        /// Borra fisicamente los registros borrado lógicamente de una clave foranea
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int FPack(DBConn p_dbcAccess,
                                int p_iNroot,
                                ref StatMsg p_smResult)
        {
            try {
                // Borramos los registro de la clave foranea
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..OTITEMS_FPACK",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@oti_nro_nroot", p_iNroot),
                                       p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                   }
                                  );
            }
            catch (Exception l_expData) {
                // Error en el delete de los registros
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
                p_dtResult.Columns["oti_ede_comentario"].Caption= "V1ComentarioCN1";
                p_dtResult.Columns["oti_des_desoperacion"].Caption= "V1Descripción de la operación.CN1";
                p_dtResult.Columns["oti_des_destarea"].Caption= "V1Descripción de la tareaCN1";
                p_dtResult.Columns["oti_imp_importe"].Caption= "V1Importe2N1";
                p_dtResult.Columns["oti_nro_nroagrupador"].Caption= "V1Numero de agrupadorNN1";
                p_dtResult.Columns["oti_nro_nroitem"].Caption= "V1Numero del itemNN1";
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
