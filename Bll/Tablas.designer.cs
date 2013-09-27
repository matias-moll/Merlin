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
    // Fecha                    : 20/09/2013 15:14
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
        /// <returns>Lista-entidad: LEEquipamiento</returns>
        public static LEEquipamiento EqiUpFull(bool p_bOnlyActive,
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
        /// Devuelve una Lista-entidad: LEEquipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEquipamiento</returns>
        internal static LEEquipamiento EqiUpfl(DBConn p_dbcAccess,
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
                LEEquipamiento l_lentRet= new LEEquipamiento(l_dsTemp.Tables["Temporal"]);
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

    }
}
