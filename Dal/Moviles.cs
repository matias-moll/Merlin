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
    // Fecha                    : 05/11/2013 00:10
    // Sistema                  : Rivn
    // Clase para Administrar   : Moviles del Sistema
    // Basada en la Tabla       : Moviles
    //----------------------------------------------------------------------------
    // � 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma autom�tica. Cualquier
    //    modificaci�n que se realize sobre ella se perder� en la pr�xima
    //    regeneraci�n.
    //****************************************************************************

    /// <summary>
    /// Modulo DAL de Acceso a la tabla: Moviles
    /// </summary>
    public static class Moviles
    {
        //---------------------------------------------------------------
        // M�todos p�blicos est�ticos de la clase para realizar
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
            p_smResult.DalReset("Moviles", "Up");

            try {
                // Recuperamos todos los registros
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..MOVILES_UP",
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
        /// Verifica el n�mero de versi�n de un registro
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">N�mero de version a verificar</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ChkVersion(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      int p_iFxdVersion,
                                      ref DataSet p_dsResult,
                                      string p_strTabla,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "ChkVersion");

            try {
                // Verificamos el n�mero de versi�n
                DBRuts.Exec_DS(p_dbcAccess,
                               "TNGS_Rivn..MOVILES_CHKVERSION",
                               new DbParameter[] {
                                   p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Search");

            try {
                // Recuperamos el registro de la clave
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..MOVILES_SEARCH",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">A�o de fabricaci�n</param>
        /// <param name="p_strPropio">Propio o no</param>
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
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Insert");

            try {
                // Insertamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_INSERT",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@mov_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@mov_txt_anot", p_strAnot),
                                       p_dbcAccess.MakeParam("@mov_des_nrochasis", p_strNrochasis),
                                       p_dbcAccess.MakeParam("@mov_des_nromotor", p_strNromotor),
                                       p_dbcAccess.MakeParam("@mov_rcd_modelo", p_strModelo),
                                       p_dbcAccess.MakeParam("@mov_nro_aniofabric", p_iAniofabric),
                                       p_dbcAccess.MakeParam("@mov_cd1_propio", p_strPropio),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">A�o de fabricaci�n</param>
        /// <param name="p_strPropio">Propio o no</param>
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
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Update");

            try {
                // Modificamos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_UPDATE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
                                       p_dbcAccess.MakeParam("@mov_des_des", p_strDes),
                                       p_dbcAccess.MakeParam("@mov_txt_anot", p_strAnot),
                                       p_dbcAccess.MakeParam("@mov_des_nrochasis", p_strNrochasis),
                                       p_dbcAccess.MakeParam("@mov_des_nromotor", p_strNromotor),
                                       p_dbcAccess.MakeParam("@mov_rcd_modelo", p_strModelo),
                                       p_dbcAccess.MakeParam("@mov_nro_aniofabric", p_iAniofabric),
                                       p_dbcAccess.MakeParam("@mov_cd1_propio", p_strPropio),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Delete(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Delete");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_DELETE",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Recall(DBConn p_dbcAccess,
                                 string p_strPatente,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Recall");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_RECALL",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int Drop(DBConn p_dbcAccess,
                               string p_strPatente,
                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "Drop");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_DROP",
                                   new DbParameter[] {
                                       p_dbcAccess.MakeParam("@mov_ecd_patente", p_strPatente),
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
            p_smResult.DalReset("Moviles", "Pack");

            try {
                // Borramos el registro
                return DBRuts.Exec(p_dbcAccess,
                                   "TNGS_Rivn..MOVILES_PACK",
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

        /// <summary>
        /// M�todo Fijo: getMovilesTree
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_dsResult">DataSet donde devolver el registro</param>
        /// <param name="p_strTabla">Nombre de la tabla a llenar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static int getMovilesTree(DBConn p_dbcAccess,
                                         ref DataSet p_dsResult,
                                         string p_strTabla,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.DalReset("Moviles", "getMovilesTree");

            try {
                return DBRuts.Exec_DS(p_dbcAccess,
                                      "TNGS_Rivn..MOVILES_GETMOVILESTREE",
                                      new DbParameter[] {
                                          p_dbcAccess.MakeParam("@usuario", DBConn.Usuario)
                                      },
                                      ref p_dsResult, p_strTabla);
            }
            catch (Exception l_expData) {
                // Error en el m�todo fijo
                p_smResult.DalError(l_expData.ToString());
                return -1;
            }
            finally {
                // Resteamos el StatMsg
                p_smResult.DalExit();
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
            // No hay errores aun
            p_smResult.DalReset("Moviles", "MakeGridCaption");

            try {
                // Quitamos los captions existentes
                DBRuts.ClearDTCaptions(ref p_dtResult);

                // Fijamos los nuevos captions de la grilla
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
            p_smResult.DalReset("Moviles", "MakeGridCaption");

            // Llamamos al m�todo base
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
            p_smResult.DalReset("Moviles", "MakeGridCaption");

            // Llamamos al m�todo base
            DataTable l_dtTemp= p_lentResult.InternalData.Table;
            MakeGridCaptions(ref l_dtTemp, ref p_smResult);
            p_smResult.DalExit();
        }
        #endregion
    }
}
