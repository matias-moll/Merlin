#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using TNGS.NetAppBll;
using Rivn;
using Rivn.Bel;
#endregion

namespace Rivn.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 11/11/2013 16:20
    // Sistema                  : Rivn
    // Clase para Administrar   : Tablas de Rivn.
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
    /// Mantenimiento de: Tablas de Rivn.
    /// </summary>
    public static partial class Tablas
    {

        //**********************************************************
        //
        // Funciones para la Tabla: Categorias
        // Usando ClaseDal        : Categorias
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Categorias
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECategorias</returns>
        public static LECategorias CatUpFull(bool p_bOnlyActive,
                                             ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "CatUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CatUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: ECategoria
        /// </summary>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoria</returns>
        public static ECategoria CatGet(string p_strCod,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "CatGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECategoria
                return CatSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatSave(ECategoria p_entCategoria,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECategoria
                CatSSav(l_dbcAccess, p_entCategoria, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "CatEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CatEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CatVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Categoria) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CatVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Categorias.Recall(l_dbcAccess,
                                          p_strCod,
                                          ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Categorias.Delete(l_dbcAccess,
                                          p_strCod,
                                          ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "CatRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CatRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CatDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "CatPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CatPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getByDesc
        /// </summary>
        /// <param name= p_strDesc>.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CatgetByDesc(string p_strDesc,
                                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatgetByDesc");
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CatgetByDesc(l_dbcAccess,
                                    p_strDesc,
                                    ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Categoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatTInt(DBConn p_dbcAccess,
                                     ECategoria p_entCategoria,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCategoria.Cod.Trim() == "") {
                // El campo [codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [codigo] no puede ser vacío","");
                return;
            }

            if (p_entCategoria.Des.Trim() == "") {
                // El campo [descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [descripcion] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            CatTInt_f(p_dbcAccess, p_entCategoria, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECategoria
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Categorias.Search(p_dbcAccess,
                                  p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Categorias.ChkVersion(p_dbcAccess,
                                      p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Categoria) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LECategorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECategorias</returns>
        internal static LECategorias CatUpfl(DBConn p_dbcAccess,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatUpfl");

            try {
                // Pedimos los registros de la tabla: Categorias
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Categorias.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECategorias l_lentRet= new LECategorias(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: ECategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoria</returns>
        internal static ECategoria CatSrch(DBConn p_dbcAccess,
                                           string p_strCod,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatSrch");

            try {
                // Pedimos el registro de la tabla: Categorias
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.Search(p_dbcAccess, 
                                      p_strCod,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                ECategoria l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new ECategoria(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatSSav(DBConn p_dbcAccess,
                                     ECategoria p_entCategoria,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatSave");

            try {
                // Procesamos codigo fijo
                CatSave_f(p_dbcAccess, ref p_entCategoria, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CatVKey(p_dbcAccess, 
                        p_entCategoria.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCategoria.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Categoria) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CatInsr(p_dbcAccess, p_entCategoria, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Categoria) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CatVVer(p_dbcAccess, 
                        p_entCategoria.Cod,
                        p_entCategoria.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CatUpdt(p_dbcAccess, p_entCategoria, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: ECategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatInsr(DBConn p_dbcAccess,
                                     ECategoria p_entCategoria,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatInsr");

            try {
                // Validamos la integridad de la entidad
                CatTInt(p_dbcAccess, p_entCategoria, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Categorias
                Dal.Categorias.Insert(p_dbcAccess,
                                      p_entCategoria.Cod,
                                      p_entCategoria.Des,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: ECategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatUpdt(DBConn p_dbcAccess,
                                     ECategoria p_entCategoria,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatUpdt");

            try {
                // Validamos la integridad de la entidad
                CatTInt(p_dbcAccess, p_entCategoria, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Categorias
                Dal.Categorias.Update(p_dbcAccess,
                                      p_entCategoria.Cod,
                                      p_entCategoria.Des,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Categorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatDrop");

            try {
                // Verificamos la clave a borrar
                CatVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Categoria) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CatVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Categorias.Drop(p_dbcAccess,
                                    p_strCod,
                                    ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Categorias.Pack(p_dbcAccess,
                                    ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getByDesc
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strDesc>.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CatgetByDesc(DBConn p_dbcAccess,
                                                    string p_strDesc,
                                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatgetByDesc");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.getByDesc(p_dbcAccess,
                                         p_strDesc,
                                         ref l_dsTemp,
                                         "Temporal",
                                         ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Equipamiento
        // Usando ClaseDal        : Equipamiento
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEquipamientos</returns>
        public static LEEquipamientos EqiUpFull(bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EqiUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEquipamento
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEquipamento</returns>
        public static EEquipamento EqiGet(string p_strCod,
                                          bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiGet");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEquipamento.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEquipamento
                return EqiSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string EqiNextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiNextKey");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return EqiGetNK(l_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiSave(EEquipamento p_entEquipamento,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEquipamento
                EqiSSav(l_dbcAccess, p_entEquipamento, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiEnabled");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEquipamento.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EqiEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EqiVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Equipamento) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EqiVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Equipamiento.Recall(l_dbcAccess,
                                            p_strCod,
                                            ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Equipamiento.Delete(l_dbcAccess,
                                            p_strCod,
                                            ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiRemove");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEquipamento.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EqiRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EqiDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EqiPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EqiPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Equipamento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiTInt(DBConn p_dbcAccess,
                                     EEquipamento p_entEquipamento,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEquipamento.Cod.Trim() == "") {
                // El campo [cod] no puede ser vacío
                p_smResult.BllWarning("El dato [cod] no puede ser vacío","");
                return;
            }

            if (p_entEquipamento.Des.Trim() == "") {
                // El campo [des] no puede ser vacío
                p_smResult.BllWarning("El dato [des] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EqiTInt_f(p_dbcAccess, p_entEquipamento, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEquipamento
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Equipamiento.Search(p_dbcAccess,
                                    p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Equipamiento.ChkVersion(p_dbcAccess,
                                        p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Equipamento) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEEquipamientos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEquipamientos</returns>
        internal static LEEquipamientos EqiUpfl(DBConn p_dbcAccess,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiUpfl");

            try {
                // Pedimos los registros de la tabla: Equipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Equipamiento.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEquipamientos l_lentRet= new LEEquipamientos(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEquipamento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEquipamento</returns>
        internal static EEquipamento EqiSrch(DBConn p_dbcAccess,
                                             string p_strCod,
                                             bool p_bOnlyActive,
                                             ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiSrch");

            try {
                // Pedimos el registro de la tabla: Equipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.Search(p_dbcAccess, 
                                        p_strCod,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EEquipamento l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EEquipamento(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string EqiGetNK(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiGetNK");

            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.GetMaxKey(p_dbcAccess,
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
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiSSav(DBConn p_dbcAccess,
                                     EEquipamento p_entEquipamento,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiSave");

            try {
                // Procesamos codigo fijo
                EqiSave_f(p_dbcAccess, ref p_entEquipamento, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EqiVKey(p_dbcAccess, 
                        p_entEquipamento.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEquipamento.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Equipamento) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EqiInsr(p_dbcAccess, p_entEquipamento, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Equipamento) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                EqiVVer(p_dbcAccess, 
                        p_entEquipamento.Cod,
                        p_entEquipamento.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EqiUpdt(p_dbcAccess, p_entEquipamento, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EEquipamento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiInsr(DBConn p_dbcAccess,
                                     EEquipamento p_entEquipamento,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiInsr");

            try {
                // Validamos la integridad de la entidad
                EqiTInt(p_dbcAccess, p_entEquipamento, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Equipamiento
                Dal.Equipamiento.Insert(p_dbcAccess,
                                        p_entEquipamento.Cod,
                                        p_entEquipamento.Des,
                                        p_entEquipamento.Valor,
                                        ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EEquipamento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiUpdt(DBConn p_dbcAccess,
                                     EEquipamento p_entEquipamento,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiUpdt");

            try {
                // Validamos la integridad de la entidad
                EqiTInt(p_dbcAccess, p_entEquipamento, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Equipamiento
                Dal.Equipamiento.Update(p_dbcAccess,
                                        p_entEquipamento.Cod,
                                        p_entEquipamento.Des,
                                        p_entEquipamento.Valor,
                                        ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Equipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiDrop");

            try {
                // Verificamos la clave a borrar
                EqiVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Equipamento) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EqiVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Equipamiento.Drop(p_dbcAccess,
                                      p_strCod,
                                      ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Equipamiento.Pack(p_dbcAccess,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Estaciones
        // Usando ClaseDal        : Estaciones
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Estaciones
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstaciones</returns>
        public static LEEstaciones EstUpFull(bool p_bOnlyActive,
                                             ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EstUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEstacion
        /// </summary>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstacion</returns>
        public static EEstacion EstGet(string p_strCod,
                                       bool p_bOnlyActive,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstGet");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEstacion
                return EstSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string EstNextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstNextKey");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return EstGetNK(l_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstSave(EEstacion p_entEstacion,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEstacion
                EstSSav(l_dbcAccess, p_entEstacion, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstEnabled");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EstEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EstVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Estacion) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EstVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Estaciones.Recall(l_dbcAccess,
                                          p_strCod,
                                          ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Estaciones.Delete(l_dbcAccess,
                                          p_strCod,
                                          ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstRemove");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EstRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EstDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EstPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EstPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Estacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstacion">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstTInt(DBConn p_dbcAccess,
                                     EEstacion p_entEstacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEstacion.Cod.Trim() == "") {
                // El campo [CodigoEstacion] no puede ser vacío
                p_smResult.BllWarning("El dato [CodigoEstacion] no puede ser vacío","");
                return;
            }

            if (p_entEstacion.Des.Trim() == "") {
                // El campo [descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [descripcion] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EstTInt_f(p_dbcAccess, p_entEstacion, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEstacion
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Estaciones.Search(p_dbcAccess,
                                  p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Estaciones.ChkVersion(p_dbcAccess,
                                      p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Estacion) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEEstaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstaciones</returns>
        internal static LEEstaciones EstUpfl(DBConn p_dbcAccess,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstUpfl");

            try {
                // Pedimos los registros de la tabla: Estaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Estaciones.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEstaciones l_lentRet= new LEEstaciones(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEstacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstacion</returns>
        internal static EEstacion EstSrch(DBConn p_dbcAccess,
                                          string p_strCod,
                                          bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstSrch");

            try {
                // Pedimos el registro de la tabla: Estaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.Search(p_dbcAccess, 
                                      p_strCod,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EEstacion l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EEstacion(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string EstGetNK(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstGetNK");

            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.GetMaxKey(p_dbcAccess,
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
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstSSav(DBConn p_dbcAccess,
                                     EEstacion p_entEstacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstSave");

            try {
                // Procesamos codigo fijo
                EstSave_f(p_dbcAccess, ref p_entEstacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EstVKey(p_dbcAccess, 
                        p_entEstacion.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEstacion.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Estacion) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EstInsr(p_dbcAccess, p_entEstacion, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Estacion) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                EstVVer(p_dbcAccess, 
                        p_entEstacion.Cod,
                        p_entEstacion.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EstUpdt(p_dbcAccess, p_entEstacion, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EEstacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstInsr(DBConn p_dbcAccess,
                                     EEstacion p_entEstacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstInsr");

            try {
                // Validamos la integridad de la entidad
                EstTInt(p_dbcAccess, p_entEstacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Estaciones
                Dal.Estaciones.Insert(p_dbcAccess,
                                      p_entEstacion.Cod,
                                      p_entEstacion.Des,
                                      p_entEstacion.Domicilio,
                                      p_entEstacion.Contacto,
                                      p_entEstacion.Telefono,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EEstacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstUpdt(DBConn p_dbcAccess,
                                     EEstacion p_entEstacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstUpdt");

            try {
                // Validamos la integridad de la entidad
                EstTInt(p_dbcAccess, p_entEstacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Estaciones
                Dal.Estaciones.Update(p_dbcAccess,
                                      p_entEstacion.Cod,
                                      p_entEstacion.Des,
                                      p_entEstacion.Domicilio,
                                      p_entEstacion.Contacto,
                                      p_entEstacion.Telefono,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Estaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">CodigoEstacion</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstDrop");

            try {
                // Verificamos la clave a borrar
                EstVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Estacion) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EstVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Estaciones.Drop(p_dbcAccess,
                                    p_strCod,
                                    ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EstPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Estaciones.Pack(p_dbcAccess,
                                    ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Estados
        // Usando ClaseDal        : Estados
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Estados
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstados</returns>
        public static LEEstados EdsUpFull(bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EdsUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEstado
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstado</returns>
        public static EEstado EdsGet(string p_strCod,
                                     bool p_bOnlyActive,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsGet");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstado.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEstado
                return EdsSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string EdsNextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsNextKey");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return EdsGetNK(l_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsSave(EEstado p_entEstado,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEstado
                EdsSSav(l_dbcAccess, p_entEstado, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsEnabled");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstado.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EdsEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EdsVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Estado) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EdsVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Estados.Recall(l_dbcAccess,
                                       p_strCod,
                                       ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Estados.Delete(l_dbcAccess,
                                       p_strCod,
                                       ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsRemove");

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstado.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                EdsRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EdsDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "EdsPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EdsPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Estado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstado">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsTInt(DBConn p_dbcAccess,
                                     EEstado p_entEstado,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEstado.Cod.Trim() == "") {
                // El campo [cod] no puede ser vacío
                p_smResult.BllWarning("El dato [cod] no puede ser vacío","");
                return;
            }

            if (p_entEstado.Des.Trim() == "") {
                // El campo [des] no puede ser vacío
                p_smResult.BllWarning("El dato [des] no puede ser vacío","");
                return;
            }

            if (p_entEstado.Operativo.Trim() != "") {
                if ((p_entEstado.Operativo != "S") &&
                    (p_entEstado.Operativo != "N")) {
                    // El campo [Operativo] tiene opciones
                    p_smResult.BllWarning("El dato [Operativo] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EdsTInt_f(p_dbcAccess, p_entEstado, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEstado
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Estados.Search(p_dbcAccess,
                               p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Estados.ChkVersion(p_dbcAccess,
                                   p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Estado) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEEstados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstados</returns>
        internal static LEEstados EdsUpfl(DBConn p_dbcAccess,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsUpfl");

            try {
                // Pedimos los registros de la tabla: Estados
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Estados.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEstados l_lentRet= new LEEstados(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstado</returns>
        internal static EEstado EdsSrch(DBConn p_dbcAccess,
                                        string p_strCod,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsSrch");

            try {
                // Pedimos el registro de la tabla: Estados
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.Search(p_dbcAccess, 
                                   p_strCod,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EEstado l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EEstado(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string EdsGetNK(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsGetNK");

            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.GetMaxKey(p_dbcAccess,
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
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsSSav(DBConn p_dbcAccess,
                                     EEstado p_entEstado,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsSave");

            try {
                // Procesamos codigo fijo
                EdsSave_f(p_dbcAccess, ref p_entEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EdsVKey(p_dbcAccess, 
                        p_entEstado.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEstado.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Estado) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EdsInsr(p_dbcAccess, p_entEstado, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Estado) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                EdsVVer(p_dbcAccess, 
                        p_entEstado.Cod,
                        p_entEstado.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EdsUpdt(p_dbcAccess, p_entEstado, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsInsr(DBConn p_dbcAccess,
                                     EEstado p_entEstado,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsInsr");

            try {
                // Validamos la integridad de la entidad
                EdsTInt(p_dbcAccess, p_entEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Estados
                Dal.Estados.Insert(p_dbcAccess,
                                   p_entEstado.Cod,
                                   p_entEstado.Des,
                                   p_entEstado.Txtcontingencia,
                                   p_entEstado.Operativo,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsUpdt(DBConn p_dbcAccess,
                                     EEstado p_entEstado,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsUpdt");

            try {
                // Validamos la integridad de la entidad
                EdsTInt(p_dbcAccess, p_entEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Estados
                Dal.Estados.Update(p_dbcAccess,
                                   p_entEstado.Cod,
                                   p_entEstado.Des,
                                   p_entEstado.Txtcontingencia,
                                   p_entEstado.Operativo,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Estados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsDrop");

            try {
                // Verificamos la clave a borrar
                EdsVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Estado) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                EdsVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Estados.Drop(p_dbcAccess,
                                 p_strCod,
                                 ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EdsPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Estados.Pack(p_dbcAccess,
                                 ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Marcas
        // Usando ClaseDal        : Marcas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Marcas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMarcas</returns>
        public static LEMarcas MrcUpFull(bool p_bOnlyActive,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MrcUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        public static EMarca MrcGet(string p_strCodigo,
                                    bool p_bOnlyActive,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcGet");

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMarca.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMarca
                return MrcSrch(l_dbcAccess,
                               p_strCodigo,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string MrcNextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcNextKey");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return MrcGetNK(l_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcSave(EMarca p_entMarca,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMarca
                MrcSSav(l_dbcAccess, p_entMarca, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcEnabled(bool p_bEnable,
                                      string p_strCodigo,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcEnabled");

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMarca.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MrcEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodigo,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MrcVKey(l_dbcAccess,
                        p_strCodigo,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Marca) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(l_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Marcas.Recall(l_dbcAccess,
                                      p_strCodigo,
                                      ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Marcas.Delete(l_dbcAccess,
                                      p_strCodigo,
                                      ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcRemove(string p_strCodigo,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcRemove");

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMarca.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MrcRemove_f(l_dbcAccess,
                            p_strCodigo,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MrcDrop(l_dbcAccess,
                        p_strCodigo,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "MrcPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MrcPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Marca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcTInt(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMarca.Codigo.Trim() == "") {
                // El campo [cod] no puede ser vacío
                p_smResult.BllWarning("El dato [cod] no puede ser vacío","");
                return;
            }

            if (p_entMarca.Descripcion.Trim() == "") {
                // El campo [des] no puede ser vacío
                p_smResult.BllWarning("El dato [des] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            MrcTInt_f(p_dbcAccess, p_entMarca, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMarca
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVKey(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Marcas.Search(p_dbcAccess,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVVer(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Marcas.ChkVersion(p_dbcAccess,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Marca) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMarcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMarcas</returns>
        internal static LEMarcas MrcUpfl(DBConn p_dbcAccess,
                                          bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcUpfl");

            try {
                // Pedimos los registros de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Marcas.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMarcas l_lentRet= new LEMarcas(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        internal static EMarca MrcSrch(DBConn p_dbcAccess,
                                       string p_strCodigo,
                                       bool p_bOnlyActive,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcSrch");

            try {
                // Pedimos el registro de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Search(p_dbcAccess, 
                                  p_strCodigo,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMarca l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMarca(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string MrcGetNK(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcGetNK");

            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.GetMaxKey(p_dbcAccess,
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
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcSSav(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcSave");

            try {
                // Procesamos codigo fijo
                MrcSave_f(p_dbcAccess, ref p_entMarca, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MrcVKey(p_dbcAccess, 
                        p_entMarca.Codigo,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMarca.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Marca) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MrcInsr(p_dbcAccess, p_entMarca, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Marca) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(p_dbcAccess, 
                        p_entMarca.Codigo,
                        p_entMarca.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MrcUpdt(p_dbcAccess, p_entMarca, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcInsr(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcInsr");

            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Marcas
                Dal.Marcas.Insert(p_dbcAccess,
                                  p_entMarca.Codigo,
                                  p_entMarca.Descripcion,
                                  ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcUpdt(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcUpdt");

            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Marcas
                Dal.Marcas.Update(p_dbcAccess,
                                  p_entMarca.Codigo,
                                  p_entMarca.Descripcion,
                                  ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcDrop(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcDrop");

            try {
                // Verificamos la clave a borrar
                MrcVKey(p_dbcAccess,
                        p_strCodigo,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Marca) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MrcVVer(p_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Marcas.Drop(p_dbcAccess,
                                p_strCodigo,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "MrcPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Marcas.Pack(p_dbcAccess,
                                ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Modelos
        // Usando ClaseDal        : Modelos
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Modelos
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEModelos</returns>
        public static LEModelos ModUpFull(bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ModUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EModelo
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EModelo</returns>
        public static EModelo ModGet(string p_strCod,
                                     bool p_bOnlyActive,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModGet");

            // Ajustamos codigos alineados a derecha
            p_strCod= EModelo.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EModelo
                return ModSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        public static string ModNextKey(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModNextKey");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave máxima
                return ModGetNK(l_dbcAccess,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion NextKey
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModSave(EModelo p_entModelo,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EModelo
                ModSSav(l_dbcAccess, p_entModelo, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModEnabled");

            // Ajustamos codigos alineados a derecha
            p_strCod= EModelo.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ModEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ModVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Modelo) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ModVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Modelos.Recall(l_dbcAccess,
                                       p_strCod,
                                       ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Modelos.Delete(l_dbcAccess,
                                       p_strCod,
                                       ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModRemove");

            // Ajustamos codigos alineados a derecha
            p_strCod= EModelo.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                ModRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ModDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "ModPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ModPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Modelo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModelo">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModTInt(DBConn p_dbcAccess,
                                     EModelo p_entModelo,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entModelo.Cod.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entModelo.Des.Trim() == "") {
                // El campo [descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [descripcion] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.MrcVKey(p_dbcAccess,
                           p_entModelo.Codmarca,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Codigo de la marca] debe existir en la tabla [Tablas.Mrc]
                p_smResult.BllWarning("El dato [Codigo de la marca] debe existir en la tabla [Tablas.Mrc]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            ModTInt_f(p_dbcAccess, p_entModelo, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EModelo
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Modelos.Search(p_dbcAccess,
                               p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Modelos.ChkVersion(p_dbcAccess,
                                   p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Modelo) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEModelos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEModelos</returns>
        internal static LEModelos ModUpfl(DBConn p_dbcAccess,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModUpfl");

            try {
                // Pedimos los registros de la tabla: Modelos
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Modelos.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEModelos l_lentRet= new LEModelos(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EModelo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EModelo</returns>
        internal static EModelo ModSrch(DBConn p_dbcAccess,
                                        string p_strCod,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModSrch");

            try {
                // Pedimos el registro de la tabla: Modelos
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.Search(p_dbcAccess, 
                                   p_strCod,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EModelo l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EModelo(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve la próxima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Próxima clave</returns>
        internal static string ModGetNK(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModGetNK");

            try {
                // Pedimos la clave máxima
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.GetMaxKey(p_dbcAccess,
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
                p_smResult.BllError(l_expData.ToString());
                return "";
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModSSav(DBConn p_dbcAccess,
                                     EModelo p_entModelo,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModSave");

            try {
                // Procesamos codigo fijo
                ModSave_f(p_dbcAccess, ref p_entModelo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ModVKey(p_dbcAccess, 
                        p_entModelo.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entModelo.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Modelo) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ModInsr(p_dbcAccess, p_entModelo, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Modelo) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                ModVVer(p_dbcAccess, 
                        p_entModelo.Cod,
                        p_entModelo.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ModUpdt(p_dbcAccess, p_entModelo, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EModelo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModInsr(DBConn p_dbcAccess,
                                     EModelo p_entModelo,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModInsr");

            try {
                // Validamos la integridad de la entidad
                ModTInt(p_dbcAccess, p_entModelo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Modelos
                Dal.Modelos.Insert(p_dbcAccess,
                                   p_entModelo.Cod,
                                   p_entModelo.Des,
                                   p_entModelo.Codmarca,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EModelo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModUpdt(DBConn p_dbcAccess,
                                     EModelo p_entModelo,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModUpdt");

            try {
                // Validamos la integridad de la entidad
                ModTInt(p_dbcAccess, p_entModelo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Modelos
                Dal.Modelos.Update(p_dbcAccess,
                                   p_entModelo.Cod,
                                   p_entModelo.Des,
                                   p_entModelo.Codmarca,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Modelos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModDrop");

            try {
                // Verificamos la clave a borrar
                ModVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Modelo) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                ModVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Modelos.Drop(p_dbcAccess,
                                 p_strCod,
                                 ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "ModPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Modelos.Pack(p_dbcAccess,
                                 ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Reparaciones
        // Usando ClaseDal        : Reparaciones
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEReparaciones</returns>
        public static LEReparaciones RepUpFull(bool p_bOnlyActive,
                                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "RepUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return RepUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion UpFull
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EReparacion
        /// </summary>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EReparacion</returns>
        public static EReparacion RepGet(string p_strCod,
                                         bool p_bOnlyActive,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "RepGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EReparacion
                return RepSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Get
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Si pude abrir la conexion -> la cierro
                if (l_dbcAccess != null) l_dbcAccess.Close();
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepSave(EReparacion p_entReparacion,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EReparacion
                RepSSav(l_dbcAccess, p_entReparacion, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "RepEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RepEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                RepVKey(l_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Reparacion) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RepVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Reparaciones.Recall(l_dbcAccess,
                                            p_strCod,
                                            ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Reparaciones.Delete(l_dbcAccess,
                                            p_strCod,
                                            ref p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "RepRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RepRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                RepDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Tablas", "RepPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                RepPack(l_dbcAccess,
                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacción y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
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
        /// Valida la integridad de una entidad: Reparacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entReparacion">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepTInt(DBConn p_dbcAccess,
                                     EReparacion p_entReparacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entReparacion.Cod.Trim() == "") {
                // El campo [codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [codigo] no puede ser vacío","");
                return;
            }

            if (p_entReparacion.Des.Trim() == "") {
                // El campo [descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [descripcion] no puede ser vacío","");
                return;
            }

            if (p_entReparacion.Solicitadetalle.Trim() != "") {
                if ((p_entReparacion.Solicitadetalle != "S") &&
                    (p_entReparacion.Solicitadetalle != " N")) {
                    // El campo [Se Solicita Detalle] tiene opciones
                    p_smResult.BllWarning("El dato [Se Solicita Detalle] sólo admite\r\n\r\n[S]- SI\r\n[ N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.CatVKey(p_dbcAccess,
                           p_entReparacion.Codcat,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [categoria] debe existir en la tabla [Tablas.Cat]
                p_smResult.BllWarning("El dato [categoria] debe existir en la tabla [Tablas.Cat]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            RepTInt_f(p_dbcAccess, p_entReparacion, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EReparacion
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Reparaciones.Search(p_dbcAccess,
                                    p_strCod,
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
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Reparaciones.ChkVersion(p_dbcAccess,
                                        p_strCod,
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
                    p_smResult.BllPop();
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
                l_swErrorFile.WriteLine("Uil         : {0}", p_smResult.Uil);
                l_swErrorFile.WriteLine("Bll         : {0}", p_smResult.Bll);
                l_swErrorFile.WriteLine("Dal         : {0}", p_smResult.Dal);
                l_swErrorFile.WriteLine("Message     : No coincide el numero de version");
            }
            catch (Exception l_expData) {
                // Error en el acceso al archivo.
                string l_strLinea= l_expData.ToString();
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Reparacion) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEReparaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEReparaciones</returns>
        internal static LEReparaciones RepUpfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepUpfl");

            try {
                // Pedimos los registros de la tabla: Reparaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Reparaciones.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEReparaciones l_lentRet= new LEReparaciones(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Upfl
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Devuelve una entidad: EReparacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EReparacion</returns>
        internal static EReparacion RepSrch(DBConn p_dbcAccess,
                                            string p_strCod,
                                            bool p_bOnlyActive,
                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepSrch");

            try {
                // Pedimos el registro de la tabla: Reparaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Search(p_dbcAccess, 
                                        p_strCod,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EReparacion l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EReparacion(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepSSav(DBConn p_dbcAccess,
                                     EReparacion p_entReparacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepSave");

            try {
                // Procesamos codigo fijo
                RepSave_f(p_dbcAccess, ref p_entReparacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                RepVKey(p_dbcAccess, 
                        p_entReparacion.Cod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entReparacion.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Reparacion) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    RepInsr(p_dbcAccess, p_entReparacion, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Reparacion) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                RepVVer(p_dbcAccess, 
                        p_entReparacion.Cod,
                        p_entReparacion.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                RepUpdt(p_dbcAccess, p_entReparacion, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EReparacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepInsr(DBConn p_dbcAccess,
                                     EReparacion p_entReparacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepInsr");

            try {
                // Validamos la integridad de la entidad
                RepTInt(p_dbcAccess, p_entReparacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Reparaciones
                Dal.Reparaciones.Insert(p_dbcAccess,
                                        p_entReparacion.Cod,
                                        p_entReparacion.Des,
                                        p_entReparacion.Codcat,
                                        p_entReparacion.Solicitadetalle,
                                        ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EReparacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepUpdt(DBConn p_dbcAccess,
                                     EReparacion p_entReparacion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepUpdt");

            try {
                // Validamos la integridad de la entidad
                RepTInt(p_dbcAccess, p_entReparacion, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Reparaciones
                Dal.Reparaciones.Update(p_dbcAccess,
                                        p_entReparacion.Cod,
                                        p_entReparacion.Des,
                                        p_entReparacion.Codcat,
                                        p_entReparacion.Solicitadetalle,
                                        ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Reparaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepDrop");

            try {
                // Verificamos la clave a borrar
                RepVKey(p_dbcAccess,
                        p_strCod,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Reparacion) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                RepVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Reparaciones.Drop(p_dbcAccess,
                                      p_strCod,
                                      ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData.ToString());
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        /// <summary>
        /// Borra los registros borrados lógicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepPack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepPack");

            try {
                // Borramos los borrados lógicamente
                Dal.Reparaciones.Pack(p_dbcAccess,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: Getbydesc
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strDes>Levanta descripciones de las reparaciones.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades RepGetbydesc(DBConn p_dbcAccess,
                                                    string p_strDes,
                                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "RepGetbydesc");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Getbydesc(p_dbcAccess,
                                           p_strDes,
                                           ref l_dsTemp,
                                           "Temporal",
                                           ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la LE y Captionamos
                ListaEntidades l_lentRet= new ListaEntidades(l_dsTemp.Tables["Temporal"]);
                BllRuts.FillStdCaptions(ref l_lentRet);

                // Devolvemos la LE
                l_dsTemp.Dispose();
                return l_lentRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return null;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }
        #endregion

    }
}
