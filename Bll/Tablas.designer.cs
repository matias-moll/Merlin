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
    // Fecha                    : 07/02/2019 03:30
    // Sistema                  : Mrln
    // Clase para Administrar   : Tablas Generales
    //----------------------------------------------------------------------------
    // � 1996-2019 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma autom�tica. Cualquier
    //    modificaci�n que se realize sobre ella se perder� en la pr�xima
    //    regeneraci�n.
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Tablas Generales
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
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Categorias
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LECategorias</returns>
        public static LECategorias CatUpFull(bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CatUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: ECategoria
        /// </summary>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoria</returns>
        public static ECategoria CatGet(string p_strCod,
                                        bool p_bOnlyActive,
                                        StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoria.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: ECategoria
                return CatSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string CatNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return CatGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatSave(ECategoria p_entCategoria,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: ECategoria
                CatSSav(l_dbcAccess, p_entCategoria, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoria.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CatEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CatVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Categoria) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                CatVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Categorias.Recall(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Categorias.Delete(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= ECategoria.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                CatRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CatDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CatPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CatPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getByDesc
        /// </summary>
        /// <param name= p_strDesc>.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades CatgetByDesc(string p_strDesc,
                                                  StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return CatgetByDesc(l_dbcAccess,
                                    p_strDesc,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Si abrimos una conexion -> la cerramos
                if (l_dbcAccess != null) l_dbcAccess.Close();
            }
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entCategoria.Cod.Trim() == "") {
                // El campo [Cod Categoria] no puede ser vac�o
                p_smResult.BllWarning("El dato [Cod Categoria] no puede ser vac�o","");
                return;
            }

            if (p_entCategoria.Des.Trim() == "") {
                // El campo [Categoria] no puede ser vac�o
                p_smResult.BllWarning("El dato [Categoria] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            CatTInt_f(p_dbcAccess, p_entCategoria, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: ECategoria
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Categorias.Search(p_dbcAccess,
                                  p_strCod,
                                  false,
                                  ref l_dsTemp,
                                  "Temporal",
                                  p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Categorias.ChkVersion(p_dbcAccess,
                                      p_strCod,
                                      p_iFxdVersion,
                                      ref l_dsTemp,
                                      "Temporal",
                                      p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Categoria) no coincide.\r\nOperaci�n cancelada.","");
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
                                              StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Categorias
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Categorias.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LECategorias l_lentRet= new LECategorias(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: ECategoria
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: ECategoria</returns>
        internal static ECategoria CatSrch(DBConn p_dbcAccess,
                                           string p_strCod,
                                           bool p_bOnlyActive,
                                           StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Categorias
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.Search(p_dbcAccess, 
                                      p_strCod,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string CatGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.GetMaxKey(p_dbcAccess,
                                         ref l_dsTemp,
                                         "Temporal",
                                         p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Categorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatSSav(DBConn p_dbcAccess,
                                     ECategoria p_entCategoria,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CatSave_f(p_dbcAccess, ref p_entCategoria, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CatVKey(p_dbcAccess, 
                        p_entCategoria.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entCategoria.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Categoria) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CatInsr(p_dbcAccess, p_entCategoria, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Categoria) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                CatVVer(p_dbcAccess, 
                        p_entCategoria.Cod,
                        p_entCategoria.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CatUpdt(p_dbcAccess, p_entCategoria, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CatTInt(p_dbcAccess, p_entCategoria, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Categorias
                Dal.Categorias.Insert(p_dbcAccess,
                                      p_entCategoria.Cod,
                                      p_entCategoria.Des,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CatTInt(p_dbcAccess, p_entCategoria, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Categorias
                Dal.Categorias.Update(p_dbcAccess,
                                      p_entCategoria.Cod,
                                      p_entCategoria.Des,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Categorias
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CatVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Categoria) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                CatVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Categorias.Drop(p_dbcAccess,
                                    p_strCod,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Categorias.Pack(p_dbcAccess,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getByDesc
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strDesc>.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades CatgetByDesc(DBConn p_dbcAccess,
                                                    string p_strDesc,
                                                    StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Categorias.getByDesc(p_dbcAccess,
                                         p_strDesc,
                                         ref l_dsTemp,
                                         "Temporal",
                                         p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: DestinatariosMails
        // Usando ClaseDal        : DestinatariosMails
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEDestinatariosMails</returns>
        public static LEDestinatariosMails DemUpFull(bool p_bOnlyActive,
                                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return DemUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EDestinatariosMail
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EDestinatariosMail</returns>
        public static EDestinatariosMail DemGet(string p_strCodigo,
                                                bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EDestinatariosMail.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EDestinatariosMail
                return DemSrch(l_dbcAccess,
                               p_strCodigo,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string DemNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return DemGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_entDestinatariosMail">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void DemSave(EDestinatariosMail p_entDestinatariosMail,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EDestinatariosMail
                DemSSav(l_dbcAccess, p_entDestinatariosMail, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void DemEnabled(bool p_bEnable,
                                      string p_strCodigo,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EDestinatariosMail.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                DemEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodigo,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                DemVKey(l_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (DestinatariosMail) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                DemVVer(l_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.DestinatariosMails.Recall(l_dbcAccess,
                                                  p_strCodigo,
                                                  p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.DestinatariosMails.Delete(l_dbcAccess,
                                                  p_strCodigo,
                                                  p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void DemRemove(string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EDestinatariosMail.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                DemRemove_f(l_dbcAccess,
                            p_strCodigo,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                DemDrop(l_dbcAccess,
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void DemPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                DemPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: DestinatariosMail
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDestinatariosMail">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemTInt(DBConn p_dbcAccess,
                                     EDestinatariosMail p_entDestinatariosMail,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entDestinatariosMail.Codigo.Trim() == "") {
                // El campo [C�digo] no puede ser vac�o
                p_smResult.BllWarning("El dato [C�digo] no puede ser vac�o","");
                return;
            }

            if (p_entDestinatariosMail.Descripcion.Trim() == "") {
                // El campo [Descripci�n] no puede ser vac�o
                p_smResult.BllWarning("El dato [Descripci�n] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            DemTInt_f(p_dbcAccess, p_entDestinatariosMail, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EDestinatariosMail
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemVKey(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.DestinatariosMails.Search(p_dbcAccess,
                                          p_strCodigo,
                                          false,
                                          ref l_dsTemp,
                                          "Temporal",
                                          p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemVVer(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.DestinatariosMails.ChkVersion(p_dbcAccess,
                                              p_strCodigo,
                                              p_iFxdVersion,
                                              ref l_dsTemp,
                                              "Temporal",
                                              p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (DestinatariosMail) no coincide.\r\nOperaci�n cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEDestinatariosMails
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEDestinatariosMails</returns>
        internal static LEDestinatariosMails DemUpfl(DBConn p_dbcAccess,
                                                      bool p_bOnlyActive,
                                                      StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: DestinatariosMails
                DataSet l_dsTemp= new DataSet();

                Dal.DestinatariosMails.Up(p_dbcAccess, 
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.DestinatariosMails.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEDestinatariosMails l_lentRet= new LEDestinatariosMails(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EDestinatariosMail
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EDestinatariosMail</returns>
        internal static EDestinatariosMail DemSrch(DBConn p_dbcAccess,
                                                   string p_strCodigo,
                                                   bool p_bOnlyActive,
                                                   StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: DestinatariosMails
                DataSet l_dsTemp= new DataSet();

                Dal.DestinatariosMails.Search(p_dbcAccess, 
                                              p_strCodigo,
                                              p_bOnlyActive,
                                              ref l_dsTemp, "Temporal",
                                              p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EDestinatariosMail l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EDestinatariosMail(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string DemGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.DestinatariosMails.GetMaxKey(p_dbcAccess,
                                                 ref l_dsTemp,
                                                 "Temporal",
                                                 p_smResult);
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
        /// Agrega o modifica un registro de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDestinatariosMail">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemSSav(DBConn p_dbcAccess,
                                     EDestinatariosMail p_entDestinatariosMail,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                DemSave_f(p_dbcAccess, ref p_entDestinatariosMail, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                DemVKey(p_dbcAccess, 
                        p_entDestinatariosMail.Codigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entDestinatariosMail.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (DestinatariosMail) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    DemInsr(p_dbcAccess, p_entDestinatariosMail, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (DestinatariosMail) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                DemVVer(p_dbcAccess, 
                        p_entDestinatariosMail.Codigo,
                        p_entDestinatariosMail.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                DemUpdt(p_dbcAccess, p_entDestinatariosMail, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EDestinatariosMail
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDestinatariosMail">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemInsr(DBConn p_dbcAccess,
                                     EDestinatariosMail p_entDestinatariosMail,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                DemTInt(p_dbcAccess, p_entDestinatariosMail, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: DestinatariosMails
                Dal.DestinatariosMails.Insert(p_dbcAccess,
                                              p_entDestinatariosMail.Codigo,
                                              p_entDestinatariosMail.Descripcion,
                                              p_entDestinatariosMail.Destinatarios,
                                              p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EDestinatariosMail
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entDestinatariosMail">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemUpdt(DBConn p_dbcAccess,
                                     EDestinatariosMail p_entDestinatariosMail,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                DemTInt(p_dbcAccess, p_entDestinatariosMail, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: DestinatariosMails
                Dal.DestinatariosMails.Update(p_dbcAccess,
                                              p_entDestinatariosMail.Codigo,
                                              p_entDestinatariosMail.Descripcion,
                                              p_entDestinatariosMail.Destinatarios,
                                              p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemDrop(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                DemVKey(p_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (DestinatariosMail) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                DemVVer(p_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.DestinatariosMails.Drop(p_dbcAccess,
                                            p_strCodigo,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void DemPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.DestinatariosMails.Pack(p_dbcAccess,
                                            p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Equipamiento
        // Usando ClaseDal        : Equipamiento
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEquipamientos</returns>
        public static LEEquipamientos EqiUpFull(bool p_bOnlyActive,
                                                StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EqiUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EEquipamento
        /// </summary>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEquipamento</returns>
        public static EEquipamento EqiGet(string p_strCod,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EEquipamento.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEquipamento
                return EqiSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string EqiNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return EqiGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiSave(EEquipamento p_entEquipamento,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEquipamento
                EqiSSav(l_dbcAccess, p_entEquipamento, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EqiVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Equipamento) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EqiVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Equipamiento.Recall(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Equipamiento.Delete(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EqiDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EqiPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EqiPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEquipamento.Cod.Trim() == "") {
                // El campo [Codigo Equipamiento] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Equipamiento] no puede ser vac�o","");
                return;
            }

            if (p_entEquipamento.Des.Trim() == "") {
                // El campo [Equipamiento] no puede ser vac�o
                p_smResult.BllWarning("El dato [Equipamiento] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EqiTInt_f(p_dbcAccess, p_entEquipamento, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEquipamento
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Equipamiento.Search(p_dbcAccess,
                                    p_strCod,
                                    false,
                                    ref l_dsTemp,
                                    "Temporal",
                                    p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Equipamiento.ChkVersion(p_dbcAccess,
                                        p_strCod,
                                        p_iFxdVersion,
                                        ref l_dsTemp,
                                        "Temporal",
                                        p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Equipamento) no coincide.\r\nOperaci�n cancelada.","");
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
                                                 StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Equipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Equipamiento.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEquipamientos l_lentRet= new LEEquipamientos(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EEquipamento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEquipamento</returns>
        internal static EEquipamento EqiSrch(DBConn p_dbcAccess,
                                             string p_strCod,
                                             bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Equipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.Search(p_dbcAccess, 
                                        p_strCod,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string EqiGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Equipamiento.GetMaxKey(p_dbcAccess,
                                           ref l_dsTemp,
                                           "Temporal",
                                           p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiSSav(DBConn p_dbcAccess,
                                     EEquipamento p_entEquipamento,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                EqiSave_f(p_dbcAccess, ref p_entEquipamento, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EqiVKey(p_dbcAccess, 
                        p_entEquipamento.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEquipamento.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Equipamento) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EqiInsr(p_dbcAccess, p_entEquipamento, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Equipamento) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EqiVVer(p_dbcAccess, 
                        p_entEquipamento.Cod,
                        p_entEquipamento.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EqiUpdt(p_dbcAccess, p_entEquipamento, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EqiTInt(p_dbcAccess, p_entEquipamento, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Equipamiento
                Dal.Equipamiento.Insert(p_dbcAccess,
                                        p_entEquipamento.Cod,
                                        p_entEquipamento.Des,
                                        p_entEquipamento.Valor,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EqiTInt(p_dbcAccess, p_entEquipamento, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Equipamiento
                Dal.Equipamiento.Update(p_dbcAccess,
                                        p_entEquipamento.Cod,
                                        p_entEquipamento.Des,
                                        p_entEquipamento.Valor,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Equipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                EqiVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Equipamento) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EqiVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Equipamiento.Drop(p_dbcAccess,
                                      p_strCod,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Equipamiento.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Estaciones
        // Usando ClaseDal        : Estaciones
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Estaciones
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstaciones</returns>
        public static LEEstaciones EstUpFull(bool p_bOnlyActive,
                                             StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EstUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EEstacion
        /// </summary>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstacion</returns>
        public static EEstacion EstGet(string p_strCod,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEstacion
                return EstSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string EstNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return EstGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstSave(EEstacion p_entEstacion,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEstacion
                EstSSav(l_dbcAccess, p_entEstacion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EstVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Estacion) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EstVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Estaciones.Recall(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Estaciones.Delete(l_dbcAccess,
                                          p_strCod,
                                          p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EstDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EstPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EstPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEstacion.Cod.Trim() == "") {
                // El campo [Codigo Estacion] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Estacion] no puede ser vac�o","");
                return;
            }

            if (p_entEstacion.Des.Trim() == "") {
                // El campo [Estacion] no puede ser vac�o
                p_smResult.BllWarning("El dato [Estacion] no puede ser vac�o","");
                return;
            }

            if (p_entEstacion.Contacto.Trim() == "") {
                // El campo [Contacto] no puede ser vac�o
                p_smResult.BllWarning("El dato [Contacto] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EstTInt_f(p_dbcAccess, p_entEstacion, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEstacion
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Estaciones.Search(p_dbcAccess,
                                  p_strCod,
                                  false,
                                  ref l_dsTemp,
                                  "Temporal",
                                  p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Estaciones.ChkVersion(p_dbcAccess,
                                      p_strCod,
                                      p_iFxdVersion,
                                      ref l_dsTemp,
                                      "Temporal",
                                      p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Estacion) no coincide.\r\nOperaci�n cancelada.","");
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
                                              StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Estaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Estaciones.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEstaciones l_lentRet= new LEEstaciones(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EEstacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstacion</returns>
        internal static EEstacion EstSrch(DBConn p_dbcAccess,
                                          string p_strCod,
                                          bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Estaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.Search(p_dbcAccess, 
                                      p_strCod,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string EstGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Estaciones.GetMaxKey(p_dbcAccess,
                                         ref l_dsTemp,
                                         "Temporal",
                                         p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Estaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstSSav(DBConn p_dbcAccess,
                                     EEstacion p_entEstacion,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                EstSave_f(p_dbcAccess, ref p_entEstacion, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EstVKey(p_dbcAccess, 
                        p_entEstacion.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEstacion.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Estacion) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EstInsr(p_dbcAccess, p_entEstacion, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Estacion) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EstVVer(p_dbcAccess, 
                        p_entEstacion.Cod,
                        p_entEstacion.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EstUpdt(p_dbcAccess, p_entEstacion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EstTInt(p_dbcAccess, p_entEstacion, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Estaciones
                Dal.Estaciones.Insert(p_dbcAccess,
                                      p_entEstacion.Cod,
                                      p_entEstacion.Des,
                                      p_entEstacion.Domicilio,
                                      p_entEstacion.Contacto,
                                      p_entEstacion.Telefono,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EstTInt(p_dbcAccess, p_entEstacion, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Estaciones
                Dal.Estaciones.Update(p_dbcAccess,
                                      p_entEstacion.Cod,
                                      p_entEstacion.Des,
                                      p_entEstacion.Domicilio,
                                      p_entEstacion.Contacto,
                                      p_entEstacion.Telefono,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Estaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                EstVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Estacion) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EstVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Estaciones.Drop(p_dbcAccess,
                                    p_strCod,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EstPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Estaciones.Pack(p_dbcAccess,
                                    p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Estados
        // Usando ClaseDal        : Estados
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Estados
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEEstados</returns>
        public static LEEstados EdsUpFull(bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return EdsUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EEstado
        /// </summary>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstado</returns>
        public static EEstado EdsGet(string p_strCod,
                                     bool p_bOnlyActive,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EEstado.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EEstado
                return EdsSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string EdsNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return EdsGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsSave(EEstado p_entEstado,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EEstado
                EdsSSav(l_dbcAccess, p_entEstado, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                EdsVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Estado) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EdsVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Estados.Recall(l_dbcAccess,
                                       p_strCod,
                                       p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Estados.Delete(l_dbcAccess,
                                       p_strCod,
                                       p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                EdsDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void EdsPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                EdsPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entEstado.Cod.Trim() == "") {
                // El campo [Codigo Estado] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Estado] no puede ser vac�o","");
                return;
            }

            if (p_entEstado.Des.Trim() == "") {
                // El campo [Estado] no puede ser vac�o
                p_smResult.BllWarning("El dato [Estado] no puede ser vac�o","");
                return;
            }

            if (p_entEstado.Operativo.Trim() != "") {
                if ((p_entEstado.Operativo != "S") &&
                    (p_entEstado.Operativo != "N")) {
                    // El campo [Operativo] tiene opciones
                    p_smResult.BllWarning("El dato [Operativo] s�lo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            EdsTInt_f(p_dbcAccess, p_entEstado, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EEstado
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Estados.Search(p_dbcAccess,
                               p_strCod,
                               false,
                               ref l_dsTemp,
                               "Temporal",
                               p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Estados.ChkVersion(p_dbcAccess,
                                   p_strCod,
                                   p_iFxdVersion,
                                   ref l_dsTemp,
                                   "Temporal",
                                   p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Estado) no coincide.\r\nOperaci�n cancelada.","");
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
                                           StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Estados
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Estados.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEEstados l_lentRet= new LEEstados(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EEstado</returns>
        internal static EEstado EdsSrch(DBConn p_dbcAccess,
                                        string p_strCod,
                                        bool p_bOnlyActive,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Estados
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.Search(p_dbcAccess, 
                                   p_strCod,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string EdsGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Estados.GetMaxKey(p_dbcAccess,
                                      ref l_dsTemp,
                                      "Temporal",
                                      p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Estados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsSSav(DBConn p_dbcAccess,
                                     EEstado p_entEstado,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                EdsSave_f(p_dbcAccess, ref p_entEstado, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                EdsVKey(p_dbcAccess, 
                        p_entEstado.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entEstado.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Estado) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    EdsInsr(p_dbcAccess, p_entEstado, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Estado) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EdsVVer(p_dbcAccess, 
                        p_entEstado.Cod,
                        p_entEstado.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                EdsUpdt(p_dbcAccess, p_entEstado, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EdsTInt(p_dbcAccess, p_entEstado, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Estados
                Dal.Estados.Insert(p_dbcAccess,
                                   p_entEstado.Cod,
                                   p_entEstado.Des,
                                   p_entEstado.Txtcontingencia,
                                   p_entEstado.Operativo,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                EdsTInt(p_dbcAccess, p_entEstado, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Estados
                Dal.Estados.Update(p_dbcAccess,
                                   p_entEstado.Cod,
                                   p_entEstado.Des,
                                   p_entEstado.Txtcontingencia,
                                   p_entEstado.Operativo,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Estados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                EdsVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Estado) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                EdsVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Estados.Drop(p_dbcAccess,
                                 p_strCod,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EdsPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Estados.Pack(p_dbcAccess,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Marcas
        // Usando ClaseDal        : Marcas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Marcas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMarcas</returns>
        public static LEMarcas MrcUpFull(bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MrcUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        public static EMarca MrcGet(string p_strCodigo,
                                    bool p_bOnlyActive,
                                    StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMarca.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMarca
                return MrcSrch(l_dbcAccess,
                               p_strCodigo,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string MrcNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return MrcGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcSave(EMarca p_entMarca,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMarca
                MrcSSav(l_dbcAccess, p_entMarca, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcEnabled(bool p_bEnable,
                                      string p_strCodigo,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MrcVKey(l_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Marca) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MrcVVer(l_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Marcas.Recall(l_dbcAccess,
                                      p_strCodigo,
                                      p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Marcas.Delete(l_dbcAccess,
                                      p_strCodigo,
                                      p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcRemove(string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MrcDrop(l_dbcAccess,
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MrcPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MrcPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMarca.Codigo.Trim() == "") {
                // El campo [Codigo Marca] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Marca] no puede ser vac�o","");
                return;
            }

            if (p_entMarca.Descripcion.Trim() == "") {
                // El campo [Marca] no puede ser vac�o
                p_smResult.BllWarning("El dato [Marca] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            MrcTInt_f(p_dbcAccess, p_entMarca, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMarca
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVKey(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Marcas.Search(p_dbcAccess,
                              p_strCodigo,
                              false,
                              ref l_dsTemp,
                              "Temporal",
                              p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcVVer(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Marcas.ChkVersion(p_dbcAccess,
                                  p_strCodigo,
                                  p_iFxdVersion,
                                  ref l_dsTemp,
                                  "Temporal",
                                  p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Marca) no coincide.\r\nOperaci�n cancelada.","");
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
                                          StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Up(p_dbcAccess, 
                              p_bOnlyActive,
                              ref l_dsTemp, "Temporal",
                              p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Marcas.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMarcas l_lentRet= new LEMarcas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMarca
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMarca</returns>
        internal static EMarca MrcSrch(DBConn p_dbcAccess,
                                       string p_strCodigo,
                                       bool p_bOnlyActive,
                                       StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Marcas
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.Search(p_dbcAccess, 
                                  p_strCodigo,
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string MrcGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Marcas.GetMaxKey(p_dbcAccess,
                                     ref l_dsTemp,
                                     "Temporal",
                                     p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMarca">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcSSav(DBConn p_dbcAccess,
                                     EMarca p_entMarca,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                MrcSave_f(p_dbcAccess, ref p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MrcVKey(p_dbcAccess, 
                        p_entMarca.Codigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMarca.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Marca) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MrcInsr(p_dbcAccess, p_entMarca, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Marca) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MrcVVer(p_dbcAccess, 
                        p_entMarca.Codigo,
                        p_entMarca.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MrcUpdt(p_dbcAccess, p_entMarca, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Marcas
                Dal.Marcas.Insert(p_dbcAccess,
                                  p_entMarca.Codigo,
                                  p_entMarca.Descripcion,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MrcTInt(p_dbcAccess, p_entMarca, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Marcas
                Dal.Marcas.Update(p_dbcAccess,
                                  p_entMarca.Codigo,
                                  p_entMarca.Descripcion,
                                  p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Marcas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcDrop(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                MrcVKey(p_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Marca) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MrcVVer(p_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Marcas.Drop(p_dbcAccess,
                                p_strCodigo,
                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MrcPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Marcas.Pack(p_dbcAccess,
                                p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Modelos
        // Usando ClaseDal        : Modelos
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Modelos
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEModelos</returns>
        public static LEModelos ModUpFull(bool p_bOnlyActive,
                                          StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return ModUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EModelo
        /// </summary>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EModelo</returns>
        public static EModelo ModGet(string p_strCod,
                                     bool p_bOnlyActive,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EModelo.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EModelo
                return ModSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string ModNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return ModGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModSave(EModelo p_entModelo,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EModelo
                ModSSav(l_dbcAccess, p_entModelo, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                ModVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Modelo) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                ModVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Modelos.Recall(l_dbcAccess,
                                       p_strCod,
                                       p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Modelos.Delete(l_dbcAccess,
                                       p_strCod,
                                       p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

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
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                ModDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void ModPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                ModPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entModelo.Cod.Trim() == "") {
                // El campo [Codigo Modelo] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Modelo] no puede ser vac�o","");
                return;
            }

            if (p_entModelo.Des.Trim() == "") {
                // El campo [Modelo] no puede ser vac�o
                p_smResult.BllWarning("El dato [Modelo] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.MrcVKey(p_dbcAccess,
                           p_entModelo.Codmarca,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Codigo de la marca] debe existir en la tabla [Tablas.Mrc]
                p_smResult.BllWarning("El dato [Codigo de la marca] debe existir en la tabla [Tablas.Mrc]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            ModTInt_f(p_dbcAccess, p_entModelo, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EModelo
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Modelos.Search(p_dbcAccess,
                               p_strCod,
                               false,
                               ref l_dsTemp,
                               "Temporal",
                               p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Modelos.ChkVersion(p_dbcAccess,
                                   p_strCod,
                                   p_iFxdVersion,
                                   ref l_dsTemp,
                                   "Temporal",
                                   p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Modelo) no coincide.\r\nOperaci�n cancelada.","");
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
                                           StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Modelos
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Modelos.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEModelos l_lentRet= new LEModelos(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EModelo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EModelo</returns>
        internal static EModelo ModSrch(DBConn p_dbcAccess,
                                        string p_strCod,
                                        bool p_bOnlyActive,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Modelos
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.Search(p_dbcAccess, 
                                   p_strCod,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string ModGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Modelos.GetMaxKey(p_dbcAccess,
                                      ref l_dsTemp,
                                      "Temporal",
                                      p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Modelos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entModelo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModSSav(DBConn p_dbcAccess,
                                     EModelo p_entModelo,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                ModSave_f(p_dbcAccess, ref p_entModelo, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                ModVKey(p_dbcAccess, 
                        p_entModelo.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entModelo.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Modelo) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    ModInsr(p_dbcAccess, p_entModelo, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Modelo) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                ModVVer(p_dbcAccess, 
                        p_entModelo.Cod,
                        p_entModelo.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                ModUpdt(p_dbcAccess, p_entModelo, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ModTInt(p_dbcAccess, p_entModelo, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Modelos
                Dal.Modelos.Insert(p_dbcAccess,
                                   p_entModelo.Cod,
                                   p_entModelo.Des,
                                   p_entModelo.Codmarca,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                ModTInt(p_dbcAccess, p_entModelo, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Modelos
                Dal.Modelos.Update(p_dbcAccess,
                                   p_entModelo.Cod,
                                   p_entModelo.Des,
                                   p_entModelo.Codmarca,
                                   p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Modelos
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                ModVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Modelo) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                ModVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Modelos.Drop(p_dbcAccess,
                                 p_strCod,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void ModPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Modelos.Pack(p_dbcAccess,
                                 p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: MotivosInfracciones
        // Usando ClaseDal        : MotivosInfracciones
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMotivosInfracciones</returns>
        public static LEMotivosInfracciones MtiUpFull(bool p_bOnlyActive,
                                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MtiUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EMotivoInfraccion
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMotivoInfraccion</returns>
        public static EMotivoInfraccion MtiGet(string p_strCodigo,
                                               bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMotivoInfraccion.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMotivoInfraccion
                return MtiSrch(l_dbcAccess,
                               p_strCodigo,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string MtiNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return MtiGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_entMotivoInfraccion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtiSave(EMotivoInfraccion p_entMotivoInfraccion,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMotivoInfraccion
                MtiSSav(l_dbcAccess, p_entMotivoInfraccion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtiEnabled(bool p_bEnable,
                                      string p_strCodigo,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMotivoInfraccion.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MtiEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCodigo,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MtiVKey(l_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (MotivoInfraccion) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MtiVVer(l_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MotivosInfracciones.Recall(l_dbcAccess,
                                                   p_strCodigo,
                                                   p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MotivosInfracciones.Delete(l_dbcAccess,
                                                   p_strCodigo,
                                                   p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtiRemove(string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCodigo= EMotivoInfraccion.FrmtCodigo(p_strCodigo);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MtiRemove_f(l_dbcAccess,
                            p_strCodigo,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MtiDrop(l_dbcAccess,
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MtiPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MtiPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: MotivoInfraccion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivoInfraccion">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiTInt(DBConn p_dbcAccess,
                                     EMotivoInfraccion p_entMotivoInfraccion,
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMotivoInfraccion.Codigo.Trim() == "") {
                // El campo [C�digo] no puede ser vac�o
                p_smResult.BllWarning("El dato [C�digo] no puede ser vac�o","");
                return;
            }

            if (p_entMotivoInfraccion.Descripcion.Trim() == "") {
                // El campo [Descripci�n] no puede ser vac�o
                p_smResult.BllWarning("El dato [Descripci�n] no puede ser vac�o","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            MtiTInt_f(p_dbcAccess, p_entMotivoInfraccion, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMotivoInfraccion
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiVKey(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.MotivosInfracciones.Search(p_dbcAccess,
                                           p_strCodigo,
                                           false,
                                           ref l_dsTemp,
                                           "Temporal",
                                           p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiVVer(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.MotivosInfracciones.ChkVersion(p_dbcAccess,
                                               p_strCodigo,
                                               p_iFxdVersion,
                                               ref l_dsTemp,
                                               "Temporal",
                                               p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (MotivoInfraccion) no coincide.\r\nOperaci�n cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMotivosInfracciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMotivosInfracciones</returns>
        internal static LEMotivosInfracciones MtiUpfl(DBConn p_dbcAccess,
                                                       bool p_bOnlyActive,
                                                       StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: MotivosInfracciones
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosInfracciones.Up(p_dbcAccess, 
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MotivosInfracciones.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMotivosInfracciones l_lentRet= new LEMotivosInfracciones(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMotivoInfraccion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMotivoInfraccion</returns>
        internal static EMotivoInfraccion MtiSrch(DBConn p_dbcAccess,
                                                  string p_strCodigo,
                                                  bool p_bOnlyActive,
                                                  StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: MotivosInfracciones
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosInfracciones.Search(p_dbcAccess, 
                                               p_strCodigo,
                                               p_bOnlyActive,
                                               ref l_dsTemp, "Temporal",
                                               p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMotivoInfraccion l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMotivoInfraccion(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string MtiGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.MotivosInfracciones.GetMaxKey(p_dbcAccess,
                                                  ref l_dsTemp,
                                                  "Temporal",
                                                  p_smResult);
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
        /// Agrega o modifica un registro de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivoInfraccion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiSSav(DBConn p_dbcAccess,
                                     EMotivoInfraccion p_entMotivoInfraccion,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                MtiSave_f(p_dbcAccess, ref p_entMotivoInfraccion, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MtiVKey(p_dbcAccess, 
                        p_entMotivoInfraccion.Codigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMotivoInfraccion.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (MotivoInfraccion) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MtiInsr(p_dbcAccess, p_entMotivoInfraccion, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (MotivoInfraccion) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MtiVVer(p_dbcAccess, 
                        p_entMotivoInfraccion.Codigo,
                        p_entMotivoInfraccion.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MtiUpdt(p_dbcAccess, p_entMotivoInfraccion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EMotivoInfraccion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivoInfraccion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiInsr(DBConn p_dbcAccess,
                                     EMotivoInfraccion p_entMotivoInfraccion,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MtiTInt(p_dbcAccess, p_entMotivoInfraccion, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MotivosInfracciones
                Dal.MotivosInfracciones.Insert(p_dbcAccess,
                                               p_entMotivoInfraccion.Codigo,
                                               p_entMotivoInfraccion.Descripcion,
                                               p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMotivoInfraccion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMotivoInfraccion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiUpdt(DBConn p_dbcAccess,
                                     EMotivoInfraccion p_entMotivoInfraccion,
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                MtiTInt(p_dbcAccess, p_entMotivoInfraccion, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MotivosInfracciones
                Dal.MotivosInfracciones.Update(p_dbcAccess,
                                               p_entMotivoInfraccion.Codigo,
                                               p_entMotivoInfraccion.Descripcion,
                                               p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiDrop(DBConn p_dbcAccess,
                                     string p_strCodigo,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                MtiVKey(p_dbcAccess,
                        p_strCodigo,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (MotivoInfraccion) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                MtiVVer(p_dbcAccess, 
                        p_strCodigo,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.MotivosInfracciones.Drop(p_dbcAccess,
                                             p_strCodigo,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MtiPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.MotivosInfracciones.Pack(p_dbcAccess,
                                             p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Reparaciones
        // Usando ClaseDal        : Reparaciones
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEReparaciones</returns>
        public static LEReparaciones RepUpFull(bool p_bOnlyActive,
                                               StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return RepUpfl(l_dbcAccess, p_bOnlyActive, p_smResult);
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
        /// Devuelve una entidad: EReparacion
        /// </summary>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EReparacion</returns>
        public static EReparacion RepGet(string p_strCod,
                                         bool p_bOnlyActive,
                                         StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EReparacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EReparacion
                return RepSrch(l_dbcAccess,
                               p_strCod,
                               p_bOnlyActive,
                               p_smResult);
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
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        public static string RepNextKey(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la clave m�xima
                return RepGetNK(l_dbcAccess,
                                p_smResult);
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

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepSave(EReparacion p_entReparacion,
                                   StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EReparacion
                RepSSav(l_dbcAccess, p_entReparacion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Save
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepEnabled(bool p_bEnable,
                                      string p_strCod,
                                      int p_iFxdVersion,
                                      StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EReparacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RepEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_strCod,
                             ref p_iFxdVersion,
                             p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                RepVKey(l_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Reparacion) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                RepVVer(l_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Reparaciones.Recall(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Reparaciones.Delete(l_dbcAccess,
                                            p_strCod,
                                            p_smResult);
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepRemove(string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EReparacion.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                RepRemove_f(l_dbcAccess,
                            p_strCod,
                            p_iFxdVersion,
                            p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                RepDrop(l_dbcAccess,
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }

        /// <summary>
        /// Compacta una tabla borrando los registros deshabilitados
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void RepPurge(StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                RepPack(l_dbcAccess,
                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Enabled
                p_smResult.BllError(l_expData);
            }
            finally {
                // Si pude abrir la conexion
                if (l_dbcAccess != null) {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario
        #endregion

        //---------------------------------------------------------------
        // Metodos p�blicos de la clase (no visibles para la UIL)
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
                                     StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entReparacion.Cod.Trim() == "") {
                // El campo [Codigo Reparacion] no puede ser vac�o
                p_smResult.BllWarning("El dato [Codigo Reparacion] no puede ser vac�o","");
                return;
            }

            if (p_entReparacion.Des.Trim() == "") {
                // El campo [Reparacion] no puede ser vac�o
                p_smResult.BllWarning("El dato [Reparacion] no puede ser vac�o","");
                return;
            }

            if (p_entReparacion.Solicitadetalle.Trim() != "") {
                if ((p_entReparacion.Solicitadetalle != "S") &&
                    (p_entReparacion.Solicitadetalle != " N")) {
                    // El campo [Se Solicita Detalle] tiene opciones
                    p_smResult.BllWarning("El dato [Se Solicita Detalle] s�lo admite\r\n\r\n[S]- SI\r\n[ N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.CatVKey(p_dbcAccess,
                           p_entReparacion.Codcat,
                           p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Categoria] debe existir en la tabla [Tablas.Cat]
                p_smResult.BllWarning("El dato [Categoria] debe existir en la tabla [Tablas.Cat]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            RepTInt_f(p_dbcAccess, p_entReparacion, p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EReparacion
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave est� deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepVKey(DBConn p_dbcAccess,
                                     string p_strCod,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Reparaciones.Search(p_dbcAccess,
                                    p_strCod,
                                    false,
                                    ref l_dsTemp,
                                    "Temporal",
                                    p_smResult);
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

        /// <summary>
        /// Verifica el n�mero de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_iFxdVersion">N�mero de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepVVer(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el n�mero de versi�n
            Dal.Reparaciones.ChkVersion(p_dbcAccess,
                                        p_strCod,
                                        p_iFxdVersion,
                                        ref l_dsTemp,
                                        "Temporal",
                                        p_smResult);
            if (p_smResult.NOk) return;

            // Verificamos el resultado que vino
            if (l_dsTemp.Tables["Temporal"].Rows.Count != 0) {
                // Verificamos si la cantidad es 1
                if ((int) l_dsTemp.Tables["Temporal"].Rows[0]["cantidad"] == 1) {
                    // La versi�n coincide
                    l_dsTemp.Dispose();
                    return;
                }
            }

            // El n�mero de versi�n no coincide
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

            // El n�mero de versi�n no coincide
            l_dsTemp.Dispose();
            p_smResult.BllWarning("El n�mero de versi�n del registro del �tem (Reparacion) no coincide.\r\nOperaci�n cancelada.","");
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
                                                StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Reparaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Up(p_dbcAccess, 
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Reparaciones.MakeGridCaptions(ref l_dsTemp, "Temporal", p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEReparaciones l_lentRet= new LEReparaciones(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EReparacion
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EReparacion</returns>
        internal static EReparacion RepSrch(DBConn p_dbcAccess,
                                            string p_strCod,
                                            bool p_bOnlyActive,
                                            StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Reparaciones
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Search(p_dbcAccess, 
                                        p_strCod,
                                        p_bOnlyActive,
                                        ref l_dsTemp, "Temporal",
                                        p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
        }

        /// <summary>
        /// Devuelve la pr�xima clave de la entidad
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Pr�xima clave</returns>
        internal static string RepGetNK(DBConn p_dbcAccess,
                                        StatMsg p_smResult)
        {
            try {
                // Pedimos la clave m�xima
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.GetMaxKey(p_dbcAccess,
                                           ref l_dsTemp,
                                           "Temporal",
                                           p_smResult);
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
        /// Agrega o modifica un registro de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entReparacion">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepSSav(DBConn p_dbcAccess,
                                     EReparacion p_entReparacion,
                                     StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                RepSave_f(p_dbcAccess, ref p_entReparacion, p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                RepVKey(p_dbcAccess, 
                        p_entReparacion.Cod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entReparacion.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El �tem (Reparacion) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    RepInsr(p_dbcAccess, p_entReparacion, p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no est� habilitada
                    p_smResult.BllWarning("El �tem (Reparacion) que intenta modificar no existe en el sistema o no est� habilitado.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                RepVVer(p_dbcAccess, 
                        p_entReparacion.Cod,
                        p_entReparacion.FxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                RepUpdt(p_dbcAccess, p_entReparacion, p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RepTInt(p_dbcAccess, p_entReparacion, p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Reparaciones
                Dal.Reparaciones.Insert(p_dbcAccess,
                                        p_entReparacion.Cod,
                                        p_entReparacion.Des,
                                        p_entReparacion.Codcat,
                                        p_entReparacion.Solicitadetalle,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
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
                                     StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                RepTInt(p_dbcAccess, p_entReparacion, p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Reparaciones
                Dal.Reparaciones.Update(p_dbcAccess,
                                        p_entReparacion.Cod,
                                        p_entReparacion.Des,
                                        p_entReparacion.Codcat,
                                        p_entReparacion.Solicitadetalle,
                                        p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra f�sicamente un registro de a tabla: Reparaciones
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepDrop(DBConn p_dbcAccess,
                                     string p_strCod,
                                     int p_iFxdVersion,
                                     StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                RepVKey(p_dbcAccess,
                        p_strCod,
                        p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El �tem (Reparacion) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el n�mero de version
                RepVVer(p_dbcAccess, 
                        p_strCod,
                        p_iFxdVersion,
                        p_smResult);
                if (p_smResult.NOk) return;

                // Borramos f�sicamente el registro
                Dal.Reparaciones.Drop(p_dbcAccess,
                                      p_strCod,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Remove
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra los registros borrados l�gicamente de la tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void RepPack(DBConn p_dbcAccess,
                                     StatMsg p_smResult)
        {
            try {
                // Borramos los borrados l�gicamente
                Dal.Reparaciones.Pack(p_dbcAccess,
                                      p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para m�todos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: Getbydesc
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strDes>Levanta descripciones de las reparaciones.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades RepGetbydesc(DBConn p_dbcAccess,
                                                    string p_strDes,
                                                    StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Reparaciones.Getbydesc(p_dbcAccess,
                                           p_strDes,
                                           ref l_dsTemp,
                                           "Temporal",
                                           p_smResult);
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
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }
        #endregion

    }
}
