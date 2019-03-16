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
    // Clase para Administrar   : Moviles del Sistema
    // Basada en la Tabla       : Moviles
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
    /// Modulo DAL de Acceso a la tabla: Moviles
    /// </summary>
    public static class Moviles
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
                                      "TNGS_Mrln..MOVILES_UP",
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Número de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      StatMsg p_smResult)
        {
            try {
                // Verificamos el número de versión
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Mrln..MOVILES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Search(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 bool p_bOnlyActive,
                                 ref DataSet p_dsResult,
                                 string p_strTabla,
                                 StatMsg p_smResult)
        {
            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..MOVILES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">Año de fabricación</param>
        /// <param name="p_strPropio">Propio o no</param>
        /// <param name="p_strNroploteado">Numero Ploteado</param>
        /// <param name="p_strTipodemovil">Tipo de Móvil</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Insert(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 string p_strDes,
                                 string p_strAnot,
                                 string p_strNrochasis,
                                 string p_strNromotor,
                                 string p_strModelo,
                                 int p_iAniofabric,
                                 string p_strPropio,
                                 string p_strNroploteado,
                                 string p_strTipodemovil,
                                 StatMsg p_smResult)
        {
            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..MOVILES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@mov_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@mov_txt_anot", p_strAnot),
                                       p_dbcAccess.MakeParam("@mov_des_nrochasis", p_strNrochasis),
                                       p_dbcAccess.MakeParam("@mov_des_nromotor", p_strNromotor),
                                       p_dbcAccess.MakeParam("@mov_rcd_modelo", p_strModelo),
                                       p_dbcAccess.MakeParam("@mov_nro_aniofabric", p_iAniofabric),
                                       p_dbcAccess.MakeParam("@mov_cd1_propio", p_strPropio),
                                       p_dbcAccess.MakeParam("@mov_ecd_nroploteado", p_strNroploteado),
                                       p_dbcAccess.MakeParam("@mov_des_tipodemovil", p_strTipodemovil),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">Año de fabricación</param>
        /// <param name="p_strPropio">Propio o no</param>
        /// <param name="p_strNroploteado">Numero Ploteado</param>
        /// <param name="p_strTipodemovil">Tipo de Móvil</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Update(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 string p_strDes,
                                 string p_strAnot,
                                 string p_strNrochasis,
                                 string p_strNromotor,
                                 string p_strModelo,
                                 int p_iAniofabric,
                                 string p_strPropio,
                                 string p_strNroploteado,
                                 string p_strTipodemovil,
                                 StatMsg p_smResult)
        {
            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..MOVILES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@mov_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@mov_txt_anot", p_strAnot),
                                       p_dbcAccess.MakeParam("@mov_des_nrochasis", p_strNrochasis),
                                       p_dbcAccess.MakeParam("@mov_des_nromotor", p_strNromotor),
                                       p_dbcAccess.MakeParam("@mov_rcd_modelo", p_strModelo),
                                       p_dbcAccess.MakeParam("@mov_nro_aniofabric", p_iAniofabric),
                                       p_dbcAccess.MakeParam("@mov_cd1_propio", p_strPropio),
                                       p_dbcAccess.MakeParam("@mov_ecd_nroploteado", p_strNroploteado),
                                       p_dbcAccess.MakeParam("@mov_des_tipodemovil", p_strTipodemovil),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..MOVILES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..MOVILES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strPatente,
                               StatMsg p_smResult)
        {
            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Mrln..MOVILES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
                                   "TNGS_Mrln..MOVILES_PACK",
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
        /// Método Fijo: GetHistorialFull
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strPatente">Patente Movil</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetHistorialFull(DBConn p_dbcAccess,
                                           string p_strPatente,
                                           ref DataSet p_dsResult,
                                           string p_strTabla,
                                           StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..MOVILES_GETHISTORIALFULL",
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
        /// Método Fijo: GetMovilesTree
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int GetMovilesTree(DBConn p_dbcAccess,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..MOVILES_GETMOVILESTREE",
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

        /// <summary>
        /// Método Fijo: ZCostosPorMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_dtFechaini">Fecha Inicial</param>
        /// <param name= "p_dtFechafin">Fecha Final</param>
        /// <param name= "p_strPatenteini">Patente Ini</param>
        /// <param name= "p_strPatentefin">Patente Fin</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZCostosPorMovil(DBConn p_dbcAccess,
                                          DateTime p_dtFechaini,
                                          DateTime p_dtFechafin,
                                          string p_strPatenteini,
                                          string p_strPatentefin,
                                          ref DataSet p_dsResult,
                                          string p_strTabla,
                                          StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..MOVILES_ZCOSTOSPORMOVIL",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParamF("@fechaini", p_dtFechaini),
                                          p_dbcAccess.MakeParamF("@fechafin", p_dtFechafin),
                                          p_dbcAccess.MakeParam("@patenteini", p_strPatenteini),
                                          p_dbcAccess.MakeParam("@patentefin", p_strPatentefin),
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
        /// Método Fijo: ZMovilesPorEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= "p_strEstadoini">Estado Inicial</param>
        /// <param name= "p_strEstadofin">Estado Final</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int ZMovilesPorEstado(DBConn p_dbcAccess,
                                            string p_strEstadoini,
                                            string p_strEstadofin,
                                            ref DataSet p_dsResult,
                                            string p_strTabla,
                                            StatMsg p_smResult)
        {
            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Mrln..MOVILES_ZMOVILESPORESTADO",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@estadoini", p_strEstadoini),
                                          p_dbcAccess.MakeParam("@estadofin", p_strEstadofin),
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
