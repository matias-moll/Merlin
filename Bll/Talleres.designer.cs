#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Mrln;
using Mrln.Bel;
#endregion

namespace Mrln.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 06/06/2018 03:56
    // Sistema                  : Mrln
    // Clase para Administrar   : Talleres y sus categorias
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
    /// Mantenimiento de: Talleres y sus categorias
    /// </summary>
    public static partial class Talleres
    {

        //**********************************************************
        //
        // Funciones para la Tabla: TallerCategoria
        // Usando ClaseDal        : TallerCategoria
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETalleresCategorias</returns>
        public static LETalleresCategorias TalCUpFull(bool p_bOnlyActive,
                                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return TalCUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve una entidad: ETallerCategoria
        /// </summary>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETallerCategoria</returns>
        public static ETallerCategoria TalCGet(string p_strCodigotaller,
                                               string p_strCodigocategoria,
                                               bool p_bOnlyActive,
                                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ETallerCategoria
                return TalCSrch(l_dbcAccess,
                                p_strCodigotaller,
                                p_strCodigocategoria,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve una lista-entidad: LETalleresCategorias
        /// asociada a una Foreing key de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LETalleresCategorias</returns>
        public static LETalleresCategorias TalCFGet(string p_strCodigotaller,
                                                    bool p_bOnlyActive,
                                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LETalleresCategorias
                return TalCFSch(l_dbcAccess,
                                p_strCodigotaller,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_entTallerCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TalCSave(ETallerCategoria p_entTallerCategoria,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ETallerCategoria
                TalCSSav(l_dbcAccess, p_entTallerCategoria, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TalCEnabled(bool p_bEnable,
                                       string p_strCodigotaller,
                                       string p_strCodigocategoria,
                                       int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TalCEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strCodigotaller,
                              p_strCodigocategoria,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                TalCVKey(l_dbcAccess,
                         p_strCodigotaller,
                         p_strCodigocategoria,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TallerCategoria) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TalCVVer(l_dbcAccess, 
                         p_strCodigotaller,
                         p_strCodigocategoria,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.TallerCategoria.Recall(l_dbcAccess,
                                               p_strCodigotaller,
                                               p_strCodigocategoria,
                                               ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.TallerCategoria.Delete(l_dbcAccess,
                                               p_strCodigotaller,
                                               p_strCodigocategoria,
                                               ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TalCRemove(string p_strCodigotaller,
                                      string p_strCodigocategoria,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                TalCRemove_f(l_dbcAccess,
                             p_strCodigotaller,
                             p_strCodigocategoria,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                TalCDrop(l_dbcAccess,
                         p_strCodigotaller,
                         p_strCodigocategoria,
                         p_iFxdVersion,
                         ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void TalCPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                TalCPack(l_dbcAccess,
                         ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: TallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTallerCategoria">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCTInt(DBConn p_dbcAccess,
                                      ETallerCategoria p_entTallerCategoria,
                                      ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            // ********
            // Validaciones de los campos con conexion
            // ********

            Talleres.VKey(p_dbcAccess,
                          p_entTallerCategoria.Codigotaller,
                          ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Codigo Taller] debe existir en la tabla [Talleres.]
                p_smResult.BllWarning("El dato [Codigo Taller] debe existir en la tabla [Talleres.]","");
                return;
            }

            Tablas.CatVKey(p_dbcAccess,
                           p_entTallerCategoria.Codigocategoria,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Codigo Categoria] debe existir en la tabla [Tablas.Cat]
                p_smResult.BllWarning("El dato [Codigo Categoria] debe existir en la tabla [Tablas.Cat]","");
                return;
            }

            // Verificamos la clave foranea
            Talleres.VKey(p_dbcAccess,
                          p_entTallerCategoria.Codigotaller,
                          ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Taller) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TalCTInt_f(p_dbcAccess, p_entTallerCategoria, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCVVer(DBConn p_dbcAccess,
                                      string p_strCodigotaller,
                                      string p_strCodigocategoria,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.TallerCategoria.ChkVersion(p_dbcAccess,
                                           p_strCodigotaller,
                                           p_strCodigocategoria,
                                           p_iFxdVersion,
                                           ref l_dsTemp,
                                           "Temporal",
                                           ref p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versión coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El número de versión no coincide
            StreamWriter l_swErrorFile= null;
            string l_strErrFName= String.Format("C:\\V{0:ddMMyyyyHHmmss}.Err",
                                                DateTime.Now);
            try {
                // Creamos el archivo del error
                l_swErrorFile= new StreamWriter(File.Create(l_strErrFName),
                                                System.Text.Encoding.ASCII);

                // Grabamos los datos del error
                l_swErrorFile.WriteLine("Instante    : {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                l_swErrorFile.WriteLine("Metodo      : {0}", p_smResult.Method);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.Message;
            }
            finally {
                // Si llegamos a abrir el archivo -> lo cerramos
                if (l_swErrorFile != null) {
                    l_swErrorFile.Close();
                    l_swErrorFile.Dispose();
                }
            }

            // El número de versión no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El número de versión del registro del ítem (TallerCategoria) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ETallerCategoria
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCVKey(DBConn p_dbcAccess,
                                      string p_strCodigotaller,
                                      string p_strCodigocategoria,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.TallerCategoria.Search(p_dbcAccess,
                                       p_strCodigotaller,
                                       p_strCodigocategoria,
                                       false,
                                       ref l_dsTemp,
                                       "Temporal",
                                       ref p_smResult);
            if (p_smResult.NOk) return;

            try {
                // Verificamos si vino algun registro
                p_smResult.BllICode(BllCodes.KeyDsntFound);
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) return;

                // Verificamos si el registro que vino esta habilitado
                p_smResult.BllICode(BllCodes.KeyDisabled);
                if ((decimal) l_dsTemp.Tables["Temporal"].Rows[0]["deleted"] == 1) return;

                // La clave existia y estaba habilitada
                p_smResult.BllICode(BllCodes.KeyExists);
            }
            finally {
                // Terminamos
                l_dsTemp.Dispose();
            }
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LETalleresCategorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETalleresCategorias</returns>
        internal static LETalleresCategorias TalCUpfl(DBConn p_dbcAccess,
                                                      bool p_bOnlyActive,
                                                      ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: TallerCategoria
                DataSet l_dsTemp= new DataSet();

                Dal.TallerCategoria.Up(p_dbcAccess, 
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.TallerCategoria.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LETalleresCategorias l_lentRet= new LETalleresCategorias(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una entidad: ETallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETallerCategoria</returns>
        internal static ETallerCategoria TalCSrch(DBConn p_dbcAccess,
                                                  string p_strCodigotaller,
                                                  string p_strCodigocategoria,
                                                  bool p_bOnlyActive,
                                                  ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: TallerCategoria
                DataSet l_dsTemp= new DataSet();

                Dal.TallerCategoria.Search(p_dbcAccess, 
                                           p_strCodigotaller,
                                           p_strCodigocategoria,
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ETallerCategoria l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ETallerCategoria(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una lista-entidad: LETalleresCategorias
        /// a partir de una clave foranea de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LETalleresCategorias TalCFSch(DBConn p_dbcAccess,
                                                      string p_strCodigotaller,
                                                      bool p_bOnlyActive,
                                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.TallerCategoria.FSearch(p_dbcAccess,
                                            p_strCodigotaller,
                                            p_bOnlyActive,
                                            ref l_dsTemp, "Temporal",
                                            ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.TallerCategoria.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LETalleresCategorias l_entRet= new LETalleresCategorias(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
                p_smResult.BllError(l_expData);
                return null;
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTallerCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCSSav(DBConn p_dbcAccess,
                                      ETallerCategoria p_entTallerCategoria,
                                      ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                TalCSave_f(p_dbcAccess, ref p_entTallerCategoria, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                TalCVKey(p_dbcAccess, 
                         p_entTallerCategoria.Codigotaller,
                         p_entTallerCategoria.Codigocategoria,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entTallerCategoria.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (TallerCategoria) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    TalCInsr(p_dbcAccess, p_entTallerCategoria, ref p_smResult);
                    return;
                }

                // Es un update. No hay campos de update. No hacemos nada
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ETallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTallerCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCInsr(DBConn p_dbcAccess,
                                      ETallerCategoria p_entTallerCategoria,
                                      ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TalCTInt(p_dbcAccess, p_entTallerCategoria, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: TallerCategoria
                Dal.TallerCategoria.Insert(p_dbcAccess,
                                           p_entTallerCategoria.Codigotaller,
                                           p_entTallerCategoria.Codigocategoria,
                                           ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: TallerCategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCDrop(DBConn p_dbcAccess,
                                      string p_strCodigotaller,
                                      string p_strCodigocategoria,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                TalCVKey(p_dbcAccess,
                         p_strCodigotaller,
                         p_strCodigocategoria,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (TallerCategoria) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                TalCVVer(p_dbcAccess, 
                         p_strCodigotaller,
                         p_strCodigocategoria,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.TallerCategoria.Drop(p_dbcAccess,
                                         p_strCodigotaller,
                                         p_strCodigocategoria,
                                         ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.TallerCategoria.Pack(p_dbcAccess,
                                         ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LETalleresCategorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_lentTalleresCategorias">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TalCSSav(DBConn p_dbcAccess,
                                      string p_strCodigotaller,
                                      LETalleresCategorias p_lentTalleresCategorias,
                                      ref StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.TallerCategoria.FDrop(p_dbcAccess,
                                          p_strCodigotaller,
                                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (ETallerCategoria l_entTallerCategoria in p_lentTalleresCategorias) {
                    // Forzamos la clave foranea
                    l_entTallerCategoria.Codigotaller= p_strCodigotaller;

                    // Verificamos si existe
                    TalCVKey(p_dbcAccess,
                             l_entTallerCategoria.Codigotaller,
                             l_entTallerCategoria.Codigocategoria,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        TalCInsr(p_dbcAccess, l_entTallerCategoria, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    TalCVVer(p_dbcAccess, 
                             l_entTallerCategoria.Codigotaller,
                             l_entTallerCategoria.Codigocategoria,
                             l_entTallerCategoria.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    /* TODO: que hacer en estos casos que no hay updt, creo que es porque solo tiene 2 campos que son primary key.
                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entTallerCategoria.EstaBorrada) {
                        TalCUpdt(p_dbcAccess, l_entTallerCategoria, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                    */
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Taller
        // Usando ClaseDal        : Taller
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Taller
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETalleres</returns>
        public static LETalleres UpFull(bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return Upfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve una entidad: ETaller
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETaller</returns>
        public static ETaller Get(string p_strCodigo,
                                  bool p_bOnlyActive,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= ETaller.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ETaller
                ETaller l_entTaller = Srch(l_dbcAccess,
                                           p_strCodigo,
                                           p_bOnlyActive,
                                           ref p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entTaller == null) return null;

                // Completamos la lista-entidad: LETalleresCategorias
                l_entTaller.TalleresCategorias= TalCFSch(l_dbcAccess,
                                                         p_strCodigo,
                                                         p_bOnlyActive,
                                                         ref p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entTaller;
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string NextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return GetNK(l_dbcAccess,
                             ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData);
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        #region Metodos publicos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Taller
        /// </summary>
        /// <param name="p_entTaller">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(ETaller p_entTaller,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ETaller
                SSav(l_dbcAccess, p_entTaller, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Taller
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   string p_strCodigo,
                                   int p_iFxdVersion,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= ETaller.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_strCodigo,
                          ref p_iFxdVersion,
                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_strCodigo,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Taller) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_strCodigo,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Taller.Recall(l_dbcAccess,
                                      p_strCodigo,
                                      ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Taller.Delete(l_dbcAccess,
                                      p_strCodigo,
                                      ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Taller
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(string p_strCodigo,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= ETaller.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Remove_f(l_dbcAccess,
                         p_strCodigo,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_strCodigo,
                     p_iFxdVersion,
                     ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Purge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                Pack(l_dbcAccess,
                     ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Taller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTaller">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  ETaller p_entTaller,
                                  ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entTaller.Codigo.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entTaller.Descripcion.Trim() == "") {
                // El campo [Descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripcion] no puede ser vacío","");
                return;
            }

            if (p_entTaller.Direccion.Trim() == "") {
                // El campo [Direccion] no puede ser vacío
                p_smResult.BllWarning("El dato [Direccion] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entTaller, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  string p_strCodigo,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Taller.ChkVersion(p_dbcAccess,
                                  p_strCodigo,
                                  p_iFxdVersion,
                                  ref l_dsTemp,
                                  "Temporal",
                                  ref p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versión coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El número de versión no coincide
            StreamWriter l_swErrorFile= null;
            string l_strErrFName= String.Format("C:\\V{0:ddMMyyyyHHmmss}.Err",
                                                DateTime.Now);
            try {
                // Creamos el archivo del error
                l_swErrorFile= new StreamWriter(File.Create(l_strErrFName),
                                                System.Text.Encoding.ASCII);

                // Grabamos los datos del error
                l_swErrorFile.WriteLine("Instante    : {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                l_swErrorFile.WriteLine("Metodo      : {0}", p_smResult.Method);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.Message;
            }
            finally {
                // Si llegamos a abrir el archivo -> lo cerramos
                if (l_swErrorFile != null) {
                    l_swErrorFile.Close();
                    l_swErrorFile.Dispose();
                }
            }

            // El número de versión no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El número de versión del registro del ítem (Taller) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ETaller
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  string p_strCodigo,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Taller.Search(p_dbcAccess,
                              p_strCodigo,
                              false,
                              ref l_dsTemp,
                              "Temporal",
                              ref p_smResult);
            if (p_smResult.NOk) return;

            try {
                // Verificamos si vino algun registro
                p_smResult.BllICode(BllCodes.KeyDsntFound);
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) return;

                // Verificamos si el registro que vino esta habilitado
                p_smResult.BllICode(BllCodes.KeyDisabled);
                if ((decimal) l_dsTemp.Tables["Temporal"].Rows[0]["deleted"] == 1) return;

                // La clave existia y estaba habilitada
                p_smResult.BllICode(BllCodes.KeyExists);
            }
            finally {
                // Terminamos
                l_dsTemp.Dispose();
            }
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LETalleres
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LETalleres</returns>
        internal static LETalleres Upfl(DBConn p_dbcAccess,
                                            bool p_bOnlyActive,
                                            ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Taller
                DataSet l_dsTemp= new DataSet();

                Dal.Taller.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Taller.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LETalleres l_lentRet= new LETalleres(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve una entidad: ETaller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ETaller</returns>
        internal static ETaller Srch(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     bool p_bOnlyActive,
                                     ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Taller
                DataSet l_dsTemp= new DataSet();

                Dal.Taller.Search(p_dbcAccess, 
                                  p_strCodigo,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ETaller l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ETaller(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string GetNK(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Taller.GetMaxKey(p_dbcAccess,
                                     ref l_dsTemp,
                                     "Temporal",
                                     ref p_smResult);
                if (p_smResult.NOk) return "";

                // Si no vino nada
                if (l_dsTemp.Tables["Temporal"].Rows.Count == 0) {
                    // Primera clave de la tabla
                    return "1";
                }

                // Convertimos la clave a numerica y le sumamos uno
                int l_iValue= Convert.ToInt32((string) l_dsTemp.Tables["Temporal"].Rows[0][0]) + 1;

                // Devolvemos la nueva clave
                return l_iValue.ToString("0");
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData);
                return "";
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ETaller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTaller">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  ETaller p_entTaller,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entTaller, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Taller
                Dal.Taller.Insert(p_dbcAccess,
                                  p_entTaller.Codigo,
                                  p_entTaller.Descripcion,
                                  p_entTaller.Direccion,
                                  p_entTaller.Telefono,
                                  p_entTaller.Contacto,
                                  ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ETaller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTaller">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  ETaller p_entTaller,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entTaller, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Taller
                Dal.Taller.Update(p_dbcAccess,
                                  p_entTaller.Codigo,
                                  p_entTaller.Descripcion,
                                  p_entTaller.Direccion,
                                  p_entTaller.Telefono,
                                  p_entTaller.Contacto,
                                  ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Taller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  string p_strCodigo,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_strCodigo,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Taller) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_strCodigo,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Taller.Drop(p_dbcAccess,
                                p_strCodigo,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Pack(DBConn p_dbcAccess,
                                  ref StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Taller.Pack(p_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Taller
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entTaller">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  ETaller p_entTaller,
                                  ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entTaller, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entTaller.Codigo,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entTaller.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Taller) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entTaller, ref p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (Taller) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entTaller.Codigo,
                         p_entTaller.FxdVersion,
                         ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entTaller, ref p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LETalleresCategorias
                TalCSSav(p_dbcAccess,
                         p_entTaller.Codigo,
                         p_entTaller.TalleresCategorias,
                         ref p_smResult);
                if (p_smResult.NOk) return;
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion
    }
}
