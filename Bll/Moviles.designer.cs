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
    // Fecha                    : 05/11/2013 00:10
    // Sistema                  : Rivn
    // Clase para Administrar   : Moviles y Tablas Hijas
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
    /// Mantenimiento de: Moviles y Tablas Hijas
    /// </summary>
    public static partial class Moviles
    {

        //**********************************************************
        //
        // Funciones para la Tabla: MvlCombustible
        // Usando ClaseDal        : MvlCombustible
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesCombus</returns>
        public static LEMovilesCombus MvcoUpFull(bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MvcoUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EMovilCombus
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilCombus</returns>
        public static EMovilCombus MvcoGet(string p_strPatente,
                                           DateTime p_dtFecha,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMovilCombus
                return MvcoSrch(l_dbcAccess,
                                p_strPatente,
                                p_dtFecha,
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
        /// Devuelve una lista-entidad: LEMovilesCombus
        /// asociada a una Foreing key de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEMovilesCombus</returns>
        public static LEMovilesCombus MvcoFGet(string p_strPatente,
                                               bool p_bOnlyActive,
                                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoFGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEMovilesCombus
                return MvcoFSch(l_dbcAccess,
                                p_strPatente,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
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
        /// Agrega o modifica un registro de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_entMovilCombus">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvcoSave(EMovilCombus p_entMovilCombus,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMovilCombus
                MvcoSSav(l_dbcAccess, p_entMovilCombus, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvcoEnabled(bool p_bEnable,
                                       string p_strPatente,
                                       DateTime p_dtFecha,
                                       int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvcoEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strPatente,
                              p_dtFecha,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MvcoVKey(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilCombus) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvcoVVer(l_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MvlCombustible.Recall(l_dbcAccess,
                                              p_strPatente,
                                              p_dtFecha,
                                              ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MvlCombustible.Delete(l_dbcAccess,
                                              p_strPatente,
                                              p_dtFecha,
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
        /// Borra físicamento un registro de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvcoRemove(string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvcoRemove_f(l_dbcAccess,
                             p_strPatente,
                             p_dtFecha,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MvcoDrop(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
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
        public static void MvcoPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvcoPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MvcoPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: MovilCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoTInt(DBConn p_dbcAccess,
                                      EMovilCombus p_entMovilCombus,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMovilCombus.Patente.Trim() == "") {
                // El campo [Patente] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente] no puede ser vacío","");
                return;
            }

            if (p_entMovilCombus.Fecha.Year == 1900) {
                // El campo [Fecha] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha] no puede ser vacío","");
                return;
            }

            if (p_entMovilCombus.Litros < 0) {
                // El campo [Litros Cargados] no puede menor a cero
                p_smResult.BllWarning("El dato [Litros Cargados] no puede ser negativo","");
                return;
            }

            if (p_entMovilCombus.Importe < 0) {
                // El campo [Importe] no puede menor a cero
                p_smResult.BllWarning("El dato [Importe] no puede ser negativo","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            if (p_entMovilCombus.Codestacion.Trim() != "") {
                VKey(p_dbcAccess,
                     p_entMovilCombus.Codestacion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Codigo estacion] debe existir en la tabla []
                    p_smResult.BllWarning("El dato [Codigo estacion] debe existir en la tabla []","");
                    return;
                }
                }

            // Verificamos la clave foranea
            Moviles.VKey(p_dbcAccess,
                         p_entMovilCombus.Patente,
                         ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Movil) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            MvcoTInt_f(p_dbcAccess, p_entMovilCombus, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoVVer(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.MvlCombustible.ChkVersion(p_dbcAccess,
                                          p_strPatente,
                                          p_dtFecha,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (MovilCombus) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMovilCombus
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoVKey(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.MvlCombustible.Search(p_dbcAccess,
                                      p_strPatente,
                                      p_dtFecha,
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
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMovilesCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesCombus</returns>
        internal static LEMovilesCombus MvcoUpfl(DBConn p_dbcAccess,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoUpfl");

            try {
                // Pedimos los registros de la tabla: MvlCombustible
                DataSet l_dsTemp= new DataSet();

                Dal.MvlCombustible.Up(p_dbcAccess, 
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlCombustible.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMovilesCombus l_lentRet= new LEMovilesCombus(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMovilCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilCombus</returns>
        internal static EMovilCombus MvcoSrch(DBConn p_dbcAccess,
                                              string p_strPatente,
                                              DateTime p_dtFecha,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSrch");

            try {
                // Pedimos el registro de la tabla: MvlCombustible
                DataSet l_dsTemp= new DataSet();

                Dal.MvlCombustible.Search(p_dbcAccess, 
                                          p_strPatente,
                                          p_dtFecha,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMovilCombus l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMovilCombus(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEMovilesCombus
        /// a partir de una clave foranea de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEMovilesCombus MvcoFSch(DBConn p_dbcAccess,
                                                 string p_strPatente,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoFSch");
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.MvlCombustible.FSearch(p_dbcAccess,
                                           p_strPatente,
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlCombustible.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEMovilesCombus l_entRet= new LEMovilesCombus(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
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
        /// Agrega o modifica un registro de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoSSav(DBConn p_dbcAccess,
                                      EMovilCombus p_entMovilCombus,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSave");

            try {
                // Procesamos codigo fijo
                MvcoSave_f(p_dbcAccess, ref p_entMovilCombus, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MvcoVKey(p_dbcAccess, 
                         p_entMovilCombus.Patente,
                         p_entMovilCombus.Fecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMovilCombus.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (MovilCombus) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MvcoInsr(p_dbcAccess, p_entMovilCombus, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (MovilCombus) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MvcoVVer(p_dbcAccess, 
                         p_entMovilCombus.Patente,
                         p_entMovilCombus.Fecha,
                         p_entMovilCombus.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MvcoUpdt(p_dbcAccess, p_entMovilCombus, ref p_smResult);
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
        /// Agrega un registro a la tabla a partir de una entidad: EMovilCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoInsr(DBConn p_dbcAccess,
                                      EMovilCombus p_entMovilCombus,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoInsr");

            try {
                // Validamos la integridad de la entidad
                MvcoTInt(p_dbcAccess, p_entMovilCombus, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MvlCombustible
                Dal.MvlCombustible.Insert(p_dbcAccess,
                                          p_entMovilCombus.Patente,
                                          p_entMovilCombus.Fecha,
                                          p_entMovilCombus.Litros,
                                          p_entMovilCombus.Importe,
                                          p_entMovilCombus.Codestacion,
                                          ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMovilCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilCombus">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoUpdt(DBConn p_dbcAccess,
                                      EMovilCombus p_entMovilCombus,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoUpdt");

            try {
                // Validamos la integridad de la entidad
                MvcoTInt(p_dbcAccess, p_entMovilCombus, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MvlCombustible
                Dal.MvlCombustible.Update(p_dbcAccess,
                                          p_entMovilCombus.Patente,
                                          p_entMovilCombus.Fecha,
                                          p_entMovilCombus.Litros,
                                          p_entMovilCombus.Importe,
                                          p_entMovilCombus.Codestacion,
                                          ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: MvlCombustible
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoDrop(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoDrop");

            try {
                // Verificamos la clave a borrar
                MvcoVKey(p_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilCombus) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvcoVVer(p_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.MvlCombustible.Drop(p_dbcAccess,
                                        p_strPatente,
                                        p_dtFecha,
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
        internal static void MvcoPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoPack");

            try {
                // Borramos los borrados lógicamente
                Dal.MvlCombustible.Pack(p_dbcAccess,
                                        ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEMovilesCombus
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_lentMovilesCombus">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvcoSSav(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      LEMovilesCombus p_lentMovilesCombus,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSSav");

            try {
                // Deshabilitamos todas las entidades existentes
                Dal.MvlCombustible.FDrop(p_dbcAccess,
                                         p_strPatente,
                                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EMovilCombus l_entMovilCombus in p_lentMovilesCombus) {
                    // Forzamos la clave foranea
                    l_entMovilCombus.Patente= p_strPatente;

                    // Verificamos si existe
                    MvcoVKey(p_dbcAccess,
                             l_entMovilCombus.Patente,
                             l_entMovilCombus.Fecha,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        MvcoInsr(p_dbcAccess, l_entMovilCombus, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    MvcoVVer(p_dbcAccess, 
                             l_entMovilCombus.Patente,
                             l_entMovilCombus.Fecha,
                             l_entMovilCombus.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entMovilCombus.EstaBorrada) {
                        MvcoUpdt(p_dbcAccess, l_entMovilCombus, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }

                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: MvlEquipamiento
        // Usando ClaseDal        : MvlEquipamiento
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesEquip</returns>
        public static LEMovilesEquip MveqUpFull(bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MveqUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EMovilEquip
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilEquip</returns>
        public static EMovilEquip MveqGet(string p_strPatente,
                                          string p_strCodequip,
                                          bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMovilEquip
                return MveqSrch(l_dbcAccess,
                                p_strPatente,
                                p_strCodequip,
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
        /// Devuelve una lista-entidad: LEMovilesEquip
        /// asociada a una Foreing key de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEMovilesEquip</returns>
        public static LEMovilesEquip MveqFGet(string p_strPatente,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqFGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEMovilesEquip
                return MveqFSch(l_dbcAccess,
                                p_strPatente,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
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
        /// Agrega o modifica un registro de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_entMovilEquip">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MveqSave(EMovilEquip p_entMovilEquip,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMovilEquip
                MveqSSav(l_dbcAccess, p_entMovilEquip, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MveqEnabled(bool p_bEnable,
                                       string p_strPatente,
                                       string p_strCodequip,
                                       int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MveqEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strPatente,
                              p_strCodequip,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MveqVKey(l_dbcAccess,
                         p_strPatente,
                         p_strCodequip,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilEquip) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MveqVVer(l_dbcAccess, 
                         p_strPatente,
                         p_strCodequip,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MvlEquipamiento.Recall(l_dbcAccess,
                                               p_strPatente,
                                               p_strCodequip,
                                               ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MvlEquipamiento.Delete(l_dbcAccess,
                                               p_strPatente,
                                               p_strCodequip,
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
        /// Borra físicamento un registro de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MveqRemove(string p_strPatente,
                                      string p_strCodequip,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MveqRemove_f(l_dbcAccess,
                             p_strPatente,
                             p_strCodequip,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MveqDrop(l_dbcAccess,
                         p_strPatente,
                         p_strCodequip,
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
        public static void MveqPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MveqPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MveqPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: MovilEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqTInt(DBConn p_dbcAccess,
                                      EMovilEquip p_entMovilEquip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMovilEquip.Patente.Trim() == "") {
                // El campo [Patente] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente] no puede ser vacío","");
                return;
            }

            if (p_entMovilEquip.Codequip.Trim() == "") {
                // El campo [Codigo del Equipamento.] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo del Equipamento.] no puede ser vacío","");
                return;
            }

            if (p_entMovilEquip.Esfijo.Trim() != "") {
                if ((p_entMovilEquip.Esfijo != "S ") &&
                    (p_entMovilEquip.Esfijo != " N ")) {
                    // El campo [equipamiento es fijo] tiene opciones
                    p_smResult.BllWarning("El dato [equipamiento es fijo] sólo admite\r\n\r\n[S ]-  SI\r\n[ N ]-  NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Moviles.VKey(p_dbcAccess,
                         p_entMovilEquip.Patente,
                         ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Movil) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            MveqTInt_f(p_dbcAccess, p_entMovilEquip, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqVVer(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      string p_strCodequip,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.MvlEquipamiento.ChkVersion(p_dbcAccess,
                                           p_strPatente,
                                           p_strCodequip,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (MovilEquip) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMovilEquip
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqVKey(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      string p_strCodequip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.MvlEquipamiento.Search(p_dbcAccess,
                                       p_strPatente,
                                       p_strCodequip,
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
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMovilesEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesEquip</returns>
        internal static LEMovilesEquip MveqUpfl(DBConn p_dbcAccess,
                                                bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqUpfl");

            try {
                // Pedimos los registros de la tabla: MvlEquipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEquipamiento.Up(p_dbcAccess, 
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlEquipamiento.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMovilesEquip l_lentRet= new LEMovilesEquip(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMovilEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilEquip</returns>
        internal static EMovilEquip MveqSrch(DBConn p_dbcAccess,
                                             string p_strPatente,
                                             string p_strCodequip,
                                             bool p_bOnlyActive,
                                             ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqSrch");

            try {
                // Pedimos el registro de la tabla: MvlEquipamiento
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEquipamiento.Search(p_dbcAccess, 
                                           p_strPatente,
                                           p_strCodequip,
                                           p_bOnlyActive,
                                           ref l_dsTemp, "Temporal",
                                           ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMovilEquip l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMovilEquip(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEMovilesEquip
        /// a partir de una clave foranea de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEMovilesEquip MveqFSch(DBConn p_dbcAccess,
                                                string p_strPatente,
                                                bool p_bOnlyActive,
                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqFSch");
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.MvlEquipamiento.FSearch(p_dbcAccess,
                                            p_strPatente,
                                            p_bOnlyActive,
                                            ref l_dsTemp, "Temporal",
                                            ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlEquipamiento.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEMovilesEquip l_entRet= new LEMovilesEquip(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
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
        /// Agrega o modifica un registro de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqSSav(DBConn p_dbcAccess,
                                      EMovilEquip p_entMovilEquip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqSave");

            try {
                // Procesamos codigo fijo
                MveqSave_f(p_dbcAccess, ref p_entMovilEquip, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MveqVKey(p_dbcAccess, 
                         p_entMovilEquip.Patente,
                         p_entMovilEquip.Codequip,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMovilEquip.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (MovilEquip) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MveqInsr(p_dbcAccess, p_entMovilEquip, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (MovilEquip) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MveqVVer(p_dbcAccess, 
                         p_entMovilEquip.Patente,
                         p_entMovilEquip.Codequip,
                         p_entMovilEquip.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MveqUpdt(p_dbcAccess, p_entMovilEquip, ref p_smResult);
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
        /// Agrega un registro a la tabla a partir de una entidad: EMovilEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqInsr(DBConn p_dbcAccess,
                                      EMovilEquip p_entMovilEquip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqInsr");

            try {
                // Validamos la integridad de la entidad
                MveqTInt(p_dbcAccess, p_entMovilEquip, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MvlEquipamiento
                Dal.MvlEquipamiento.Insert(p_dbcAccess,
                                           p_entMovilEquip.Patente,
                                           p_entMovilEquip.Codequip,
                                           p_entMovilEquip.Esfijo,
                                           ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMovilEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEquip">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqUpdt(DBConn p_dbcAccess,
                                      EMovilEquip p_entMovilEquip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqUpdt");

            try {
                // Validamos la integridad de la entidad
                MveqTInt(p_dbcAccess, p_entMovilEquip, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MvlEquipamiento
                Dal.MvlEquipamiento.Update(p_dbcAccess,
                                           p_entMovilEquip.Patente,
                                           p_entMovilEquip.Codequip,
                                           p_entMovilEquip.Esfijo,
                                           ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqDrop(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      string p_strCodequip,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqDrop");

            try {
                // Verificamos la clave a borrar
                MveqVKey(p_dbcAccess,
                         p_strPatente,
                         p_strCodequip,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilEquip) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MveqVVer(p_dbcAccess, 
                         p_strPatente,
                         p_strCodequip,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.MvlEquipamiento.Drop(p_dbcAccess,
                                         p_strPatente,
                                         p_strCodequip,
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
        internal static void MveqPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqPack");

            try {
                // Borramos los borrados lógicamente
                Dal.MvlEquipamiento.Pack(p_dbcAccess,
                                         ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEMovilesEquip
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_lentMovilesEquip">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MveqSSav(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      LEMovilesEquip p_lentMovilesEquip,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqSSav");

            try {
                // Deshabilitamos todas las entidades existentes
                Dal.MvlEquipamiento.FDrop(p_dbcAccess,
                                          p_strPatente,
                                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EMovilEquip l_entMovilEquip in p_lentMovilesEquip) {
                    // Forzamos la clave foranea
                    l_entMovilEquip.Patente= p_strPatente;

                    // Verificamos si existe
                    MveqVKey(p_dbcAccess,
                             l_entMovilEquip.Patente,
                             l_entMovilEquip.Codequip,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        MveqInsr(p_dbcAccess, l_entMovilEquip, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    MveqVVer(p_dbcAccess, 
                             l_entMovilEquip.Patente,
                             l_entMovilEquip.Codequip,
                             l_entMovilEquip.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entMovilEquip.EstaBorrada) {
                        MveqUpdt(p_dbcAccess, l_entMovilEquip, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }

                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: EliminarEquipamiento
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>patente del movil</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades MveqEliminarEquipamiento(DBConn p_dbcAccess,
                                                                string p_strPatente,
                                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MveqEliminarEquipamiento");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEquipamiento.EliminarEquipamiento(p_dbcAccess,
                                                         p_strPatente,
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
        // Funciones para la Tabla: MvlEstados
        // Usando ClaseDal        : MvlEstados
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesEstado</returns>
        public static LEMovilesEstado MvesUpFull(bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MvesUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EMovilEstado
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilEstado</returns>
        public static EMovilEstado MvesGet(string p_strPatente,
                                           DateTime p_dtFecha,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMovilEstado
                return MvesSrch(l_dbcAccess,
                                p_strPatente,
                                p_dtFecha,
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
        /// Devuelve una lista-entidad: LEMovilesEstado
        /// asociada a una Foreing key de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEMovilesEstado</returns>
        public static LEMovilesEstado MvesFGet(string p_strPatente,
                                               bool p_bOnlyActive,
                                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesFGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEMovilesEstado
                return MvesFSch(l_dbcAccess,
                                p_strPatente,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
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
        /// Agrega o modifica un registro de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_entMovilEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvesSave(EMovilEstado p_entMovilEstado,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMovilEstado
                MvesSSav(l_dbcAccess, p_entMovilEstado, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvesEnabled(bool p_bEnable,
                                       string p_strPatente,
                                       DateTime p_dtFecha,
                                       int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvesEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strPatente,
                              p_dtFecha,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MvesVKey(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilEstado) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvesVVer(l_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MvlEstados.Recall(l_dbcAccess,
                                          p_strPatente,
                                          p_dtFecha,
                                          ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MvlEstados.Delete(l_dbcAccess,
                                          p_strPatente,
                                          p_dtFecha,
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
        /// Borra físicamento un registro de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvesRemove(string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvesRemove_f(l_dbcAccess,
                             p_strPatente,
                             p_dtFecha,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MvesDrop(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
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
        public static void MvesPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvesPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MvesPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: MovilEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesTInt(DBConn p_dbcAccess,
                                      EMovilEstado p_entMovilEstado,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMovilEstado.Patente.Trim() == "") {
                // El campo [Patente] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente] no puede ser vacío","");
                return;
            }

            if (p_entMovilEstado.Fecha.Year == 1900) {
                // El campo [Fecha y Hora] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha y Hora] no puede ser vacío","");
                return;
            }

            if (p_entMovilEstado.Codestado.Trim() == "") {
                // El campo [Codigo del estado.] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo del estado.] no puede ser vacío","");
                return;
            }

            if (p_entMovilEstado.Km < 0) {
                // El campo [Kilometraje] no puede menor a cero
                p_smResult.BllWarning("El dato [Kilometraje] no puede ser negativo","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Moviles.VKey(p_dbcAccess,
                         p_entMovilEstado.Patente,
                         ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Movil) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            MvesTInt_f(p_dbcAccess, p_entMovilEstado, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesVVer(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.MvlEstados.ChkVersion(p_dbcAccess,
                                      p_strPatente,
                                      p_dtFecha,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (MovilEstado) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMovilEstado
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesVKey(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.MvlEstados.Search(p_dbcAccess,
                                  p_strPatente,
                                  p_dtFecha,
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
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMovilesEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesEstado</returns>
        internal static LEMovilesEstado MvesUpfl(DBConn p_dbcAccess,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesUpfl");

            try {
                // Pedimos los registros de la tabla: MvlEstados
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEstados.Up(p_dbcAccess, 
                                  p_bOnlyActive,
                                  ref l_dsTemp, "Temporal",
                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlEstados.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMovilesEstado l_lentRet= new LEMovilesEstado(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMovilEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilEstado</returns>
        internal static EMovilEstado MvesSrch(DBConn p_dbcAccess,
                                              string p_strPatente,
                                              DateTime p_dtFecha,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesSrch");

            try {
                // Pedimos el registro de la tabla: MvlEstados
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEstados.Search(p_dbcAccess, 
                                      p_strPatente,
                                      p_dtFecha,
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMovilEstado l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMovilEstado(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEMovilesEstado
        /// a partir de una clave foranea de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEMovilesEstado MvesFSch(DBConn p_dbcAccess,
                                                 string p_strPatente,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesFSch");
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.MvlEstados.FSearch(p_dbcAccess,
                                       p_strPatente,
                                       p_bOnlyActive,
                                       ref l_dsTemp, "Temporal",
                                       ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlEstados.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEMovilesEstado l_entRet= new LEMovilesEstado(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
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
        /// Agrega o modifica un registro de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesSSav(DBConn p_dbcAccess,
                                      EMovilEstado p_entMovilEstado,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesSave");

            try {
                // Procesamos codigo fijo
                MvesSave_f(p_dbcAccess, ref p_entMovilEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MvesVKey(p_dbcAccess, 
                         p_entMovilEstado.Patente,
                         p_entMovilEstado.Fecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMovilEstado.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (MovilEstado) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MvesInsr(p_dbcAccess, p_entMovilEstado, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (MovilEstado) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MvesVVer(p_dbcAccess, 
                         p_entMovilEstado.Patente,
                         p_entMovilEstado.Fecha,
                         p_entMovilEstado.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MvesUpdt(p_dbcAccess, p_entMovilEstado, ref p_smResult);
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
        /// Agrega un registro a la tabla a partir de una entidad: EMovilEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesInsr(DBConn p_dbcAccess,
                                      EMovilEstado p_entMovilEstado,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesInsr");

            try {
                // Validamos la integridad de la entidad
                MvesTInt(p_dbcAccess, p_entMovilEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MvlEstados
                Dal.MvlEstados.Insert(p_dbcAccess,
                                      p_entMovilEstado.Patente,
                                      p_entMovilEstado.Fecha,
                                      p_entMovilEstado.Codestado,
                                      p_entMovilEstado.Km,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMovilEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilEstado">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesUpdt(DBConn p_dbcAccess,
                                      EMovilEstado p_entMovilEstado,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesUpdt");

            try {
                // Validamos la integridad de la entidad
                MvesTInt(p_dbcAccess, p_entMovilEstado, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MvlEstados
                Dal.MvlEstados.Update(p_dbcAccess,
                                      p_entMovilEstado.Patente,
                                      p_entMovilEstado.Fecha,
                                      p_entMovilEstado.Codestado,
                                      p_entMovilEstado.Km,
                                      ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: MvlEstados
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesDrop(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesDrop");

            try {
                // Verificamos la clave a borrar
                MvesVKey(p_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilEstado) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvesVVer(p_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.MvlEstados.Drop(p_dbcAccess,
                                    p_strPatente,
                                    p_dtFecha,
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
        internal static void MvesPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesPack");

            try {
                // Borramos los borrados lógicamente
                Dal.MvlEstados.Pack(p_dbcAccess,
                                    ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEMovilesEstado
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_lentMovilesEstado">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvesSSav(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      LEMovilesEstado p_lentMovilesEstado,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesSSav");

            try {
                // Deshabilitamos todas las entidades existentes
                Dal.MvlEstados.FDrop(p_dbcAccess,
                                     p_strPatente,
                                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EMovilEstado l_entMovilEstado in p_lentMovilesEstado) {
                    // Forzamos la clave foranea
                    l_entMovilEstado.Patente= p_strPatente;

                    // Verificamos si existe
                    MvesVKey(p_dbcAccess,
                             l_entMovilEstado.Patente,
                             l_entMovilEstado.Fecha,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        MvesInsr(p_dbcAccess, l_entMovilEstado, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    MvesVVer(p_dbcAccess, 
                             l_entMovilEstado.Patente,
                             l_entMovilEstado.Fecha,
                             l_entMovilEstado.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entMovilEstado.EstaBorrada) {
                        MvesUpdt(p_dbcAccess, l_entMovilEstado, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }

                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getLastFiveMvlEstads
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>patente del movil</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades MvesgetLastFiveMvlEstads(DBConn p_dbcAccess,
                                                                string p_strPatente,
                                                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvesgetLastFiveMvlEstads");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.MvlEstados.getLastFiveMvlEstads(p_dbcAccess,
                                                    p_strPatente,
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
        // Funciones para la Tabla: MvlKilometros
        // Usando ClaseDal        : MvlKilometros
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesKms</returns>
        public static LEMovilesKms MvkmUpFull(bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmUpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return MvkmUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EMovilKms
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilKms</returns>
        public static EMovilKms MvkmGet(string p_strPatente,
                                        DateTime p_dtFecha,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMovilKms
                return MvkmSrch(l_dbcAccess,
                                p_strPatente,
                                p_dtFecha,
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
        /// Devuelve una lista-entidad: LEMovilesKms
        /// asociada a una Foreing key de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEMovilesKms</returns>
        public static LEMovilesKms MvkmFGet(string p_strPatente,
                                            bool p_bOnlyActive,
                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmFGet");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEMovilesKms
                return MvkmFSch(l_dbcAccess,
                                p_strPatente,
                                p_bOnlyActive,
                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion FGet
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
        /// Agrega o modifica un registro de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_entMovilKms">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvkmSave(EMovilKms p_entMovilKms,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmSave");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMovilKms
                MvkmSSav(l_dbcAccess, p_entMovilKms, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvkmEnabled(bool p_bEnable,
                                       string p_strPatente,
                                       DateTime p_dtFecha,
                                       int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmEnabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvkmEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strPatente,
                              p_dtFecha,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                MvkmVKey(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilKms) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvkmVVer(l_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.MvlKilometros.Recall(l_dbcAccess,
                                             p_strPatente,
                                             p_dtFecha,
                                             ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.MvlKilometros.Delete(l_dbcAccess,
                                             p_strPatente,
                                             p_dtFecha,
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
        /// Borra físicamento un registro de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void MvkmRemove(string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmRemove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                MvkmRemove_f(l_dbcAccess,
                             p_strPatente,
                             p_dtFecha,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                MvkmDrop(l_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
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
        public static void MvkmPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "MvkmPurge");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                MvkmPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: MovilKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmTInt(DBConn p_dbcAccess,
                                      EMovilKms p_entMovilKms,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmTInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMovilKms.Patente.Trim() == "") {
                // El campo [Patente] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente] no puede ser vacío","");
                return;
            }

            if (p_entMovilKms.Fecha.Year == 1900) {
                // El campo [Fecha] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha] no puede ser vacío","");
                return;
            }

            if (p_entMovilKms.Km < 0) {
                // El campo [Kilometros] no puede menor a cero
                p_smResult.BllWarning("El dato [Kilometros] no puede ser negativo","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Verificamos la clave foranea
            Moviles.VKey(p_dbcAccess,
                         p_entMovilKms.Patente,
                         ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Movil) foranea no existe en el sistema.","");
                return;
            }

            // Llamamos a la funcion fija del usuario
            MvkmTInt_f(p_dbcAccess, p_entMovilKms, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmVVer(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmVVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.MvlKilometros.ChkVersion(p_dbcAccess,
                                         p_strPatente,
                                         p_dtFecha,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (MovilKms) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMovilKms
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmVKey(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmVKey");
            DataSet l_dsTemp= new DataSet();

            Dal.MvlKilometros.Search(p_dbcAccess,
                                     p_strPatente,
                                     p_dtFecha,
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
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMovilesKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMovilesKms</returns>
        internal static LEMovilesKms MvkmUpfl(DBConn p_dbcAccess,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmUpfl");

            try {
                // Pedimos los registros de la tabla: MvlKilometros
                DataSet l_dsTemp= new DataSet();

                Dal.MvlKilometros.Up(p_dbcAccess, 
                                     p_bOnlyActive,
                                     ref l_dsTemp, "Temporal",
                                     ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlKilometros.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMovilesKms l_lentRet= new LEMovilesKms(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMovilKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovilKms</returns>
        internal static EMovilKms MvkmSrch(DBConn p_dbcAccess,
                                           string p_strPatente,
                                           DateTime p_dtFecha,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmSrch");

            try {
                // Pedimos el registro de la tabla: MvlKilometros
                DataSet l_dsTemp= new DataSet();

                Dal.MvlKilometros.Search(p_dbcAccess, 
                                         p_strPatente,
                                         p_dtFecha,
                                         p_bOnlyActive,
                                         ref l_dsTemp, "Temporal",
                                         ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMovilKms l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMovilKms(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEMovilesKms
        /// a partir de una clave foranea de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEMovilesKms MvkmFSch(DBConn p_dbcAccess,
                                              string p_strPatente,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmFSch");
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.MvlKilometros.FSearch(p_dbcAccess,
                                          p_strPatente,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.MvlKilometros.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEMovilesKms l_entRet= new LEMovilesKms(l_dsTemp.Tables["Temporal"]);
                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion FSch
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
        /// Agrega o modifica un registro de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmSSav(DBConn p_dbcAccess,
                                      EMovilKms p_entMovilKms,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmSave");

            try {
                // Procesamos codigo fijo
                MvkmSave_f(p_dbcAccess, ref p_entMovilKms, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                MvkmVKey(p_dbcAccess, 
                         p_entMovilKms.Patente,
                         p_entMovilKms.Fecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMovilKms.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (MovilKms) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    MvkmInsr(p_dbcAccess, p_entMovilKms, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (MovilKms) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                MvkmVVer(p_dbcAccess, 
                         p_entMovilKms.Patente,
                         p_entMovilKms.Fecha,
                         p_entMovilKms.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                MvkmUpdt(p_dbcAccess, p_entMovilKms, ref p_smResult);
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
        /// Agrega un registro a la tabla a partir de una entidad: EMovilKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmInsr(DBConn p_dbcAccess,
                                      EMovilKms p_entMovilKms,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmInsr");

            try {
                // Validamos la integridad de la entidad
                MvkmTInt(p_dbcAccess, p_entMovilKms, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: MvlKilometros
                Dal.MvlKilometros.Insert(p_dbcAccess,
                                         p_entMovilKms.Patente,
                                         p_entMovilKms.Fecha,
                                         p_entMovilKms.Km,
                                         ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMovilKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovilKms">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmUpdt(DBConn p_dbcAccess,
                                      EMovilKms p_entMovilKms,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmUpdt");

            try {
                // Validamos la integridad de la entidad
                MvkmTInt(p_dbcAccess, p_entMovilKms, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: MvlKilometros
                Dal.MvlKilometros.Update(p_dbcAccess,
                                         p_entMovilKms.Patente,
                                         p_entMovilKms.Fecha,
                                         p_entMovilKms.Km,
                                         ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: MvlKilometros
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmDrop(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      DateTime p_dtFecha,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmDrop");

            try {
                // Verificamos la clave a borrar
                MvkmVKey(p_dbcAccess,
                         p_strPatente,
                         p_dtFecha,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (MovilKms) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                MvkmVVer(p_dbcAccess, 
                         p_strPatente,
                         p_dtFecha,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.MvlKilometros.Drop(p_dbcAccess,
                                       p_strPatente,
                                       p_dtFecha,
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
        internal static void MvkmPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmPack");

            try {
                // Borramos los borrados lógicamente
                Dal.MvlKilometros.Pack(p_dbcAccess,
                                       ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEMovilesKms
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_lentMovilesKms">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void MvkmSSav(DBConn p_dbcAccess,
                                      string p_strPatente,
                                      LEMovilesKms p_lentMovilesKms,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmSSav");

            try {
                // Deshabilitamos todas las entidades existentes
                Dal.MvlKilometros.FDrop(p_dbcAccess,
                                        p_strPatente,
                                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EMovilKms l_entMovilKms in p_lentMovilesKms) {
                    // Forzamos la clave foranea
                    l_entMovilKms.Patente= p_strPatente;

                    // Verificamos si existe
                    MvkmVKey(p_dbcAccess,
                             l_entMovilKms.Patente,
                             l_entMovilKms.Fecha,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        MvkmInsr(p_dbcAccess, l_entMovilKms, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    MvkmVVer(p_dbcAccess, 
                             l_entMovilKms.Patente,
                             l_entMovilKms.Fecha,
                             l_entMovilKms.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entMovilKms.EstaBorrada) {
                        MvkmUpdt(p_dbcAccess, l_entMovilKms, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }

                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: RemoveAllPatente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades MvkmRemoveAllPatente(DBConn p_dbcAccess,
                                                            ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvkmRemoveAllPatente");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.MvlKilometros.RemoveAllPatente(p_dbcAccess,
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
        // Funciones para la Tabla: Moviles
        // Usando ClaseDal        : Moviles
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Moviles
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMoviles</returns>
        public static LEMoviles UpFull(bool p_bOnlyActive,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "UpFull");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return Upfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EMovil
        /// </summary>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovil</returns>
        public static EMovil Get(string p_strPatente,
                                 bool p_bOnlyActive,
                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "Get");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EMovil
                EMovil l_entMovil = Srch(l_dbcAccess,
                                         p_strPatente,
                                         p_bOnlyActive,
                                         ref p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entMovil == null) return null;

                // Completamos la lista-entidad: LEMovilesCombus
                l_entMovil.MovilesCombus= MvcoFSch(l_dbcAccess,
                                                   p_strPatente,
                                                   p_bOnlyActive,
                                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LEMovilesEquip
                l_entMovil.MovilesEquip= MveqFSch(l_dbcAccess,
                                                  p_strPatente,
                                                  p_bOnlyActive,
                                                  ref p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LEMovilesEstado
                l_entMovil.MovilesEstado= MvesFSch(l_dbcAccess,
                                                   p_strPatente,
                                                   p_bOnlyActive,
                                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Completamos la lista-entidad: LEMovilesKms
                l_entMovil.MovilesKms= MvkmFSch(l_dbcAccess,
                                                p_strPatente,
                                                p_bOnlyActive,
                                                ref p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entMovil;
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

        #region Metodos publicos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Moviles
        /// </summary>
        /// <param name="p_entMovil">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(EMovil p_entMovil,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Save");
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EMovil
                SSav(l_dbcAccess, p_entMovil, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Moviles
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   string p_strPatente,
                                   int p_iFxdVersion,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "Enabled");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_strPatente,
                          ref p_iFxdVersion,
                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_strPatente,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Movil) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_strPatente,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Moviles.Recall(l_dbcAccess,
                                       p_strPatente,
                                       ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Moviles.Delete(l_dbcAccess,
                                       p_strPatente,
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
        /// Borra físicamento un registro de la tabla: Moviles
        /// </summary>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(string p_strPatente,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "Remove");

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Remove_f(l_dbcAccess,
                         p_strPatente,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_strPatente,
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
        public static void Purge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            p_smResult.BllReset("Moviles", "Purge");

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
        /// Valida la integridad de una entidad: Movil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  EMovil p_entMovil,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "TInt");

            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entMovil.Patente.Trim() == "") {
                // El campo [Patente de la Ambulancia] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente de la Ambulancia] no puede ser vacío","");
                return;
            }

            if (p_entMovil.Des.Trim() == "") {
                // El campo [Descripcion] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripcion] no puede ser vacío","");
                return;
            }

            if (p_entMovil.Nrochasis.Trim() == "") {
                // El campo [Nro Chasis] no puede ser vacío
                p_smResult.BllWarning("El dato [Nro Chasis] no puede ser vacío","");
                return;
            }

            if (p_entMovil.Nromotor.Trim() == "") {
                // El campo [Nro Motor] no puede ser vacío
                p_smResult.BllWarning("El dato [Nro Motor] no puede ser vacío","");
                return;
            }

            if (p_entMovil.Aniofabric <= 0) {
                // El campo [Año de fabricación] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Año de fabricación] debe ser mayor a cero","");
                return;
            }

            if ((p_entMovil.Propio != "S") &&
                (p_entMovil.Propio != "N")) {
                // El campo [Propio o no] tiene opciones
                p_smResult.BllWarning("El dato [Propio o no] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Tablas.ModVKey(p_dbcAccess,
                           p_entMovil.Modelo,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Modelo] debe existir en la tabla [Tablas.Mod]
                p_smResult.BllWarning("El dato [Modelo] debe existir en la tabla [Tablas.Mod]","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entMovil, ref p_smResult);
            if (p_smResult.NOk) return;

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  string p_strPatente,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "VVer");
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Moviles.ChkVersion(p_dbcAccess,
                                   p_strPatente,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Movil) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EMovil
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  string p_strPatente,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "VKey");
            DataSet l_dsTemp= new DataSet();

            Dal.Moviles.Search(p_dbcAccess,
                               p_strPatente,
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
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEMoviles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEMoviles</returns>
        internal static LEMoviles Upfl(DBConn p_dbcAccess,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Upfl");

            try {
                // Pedimos los registros de la tabla: Moviles
                DataSet l_dsTemp= new DataSet();

                Dal.Moviles.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Moviles.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEMoviles l_lentRet= new LEMoviles(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EMovil</returns>
        internal static EMovil Srch(DBConn p_dbcAccess,
                                    string p_strPatente,
                                    bool p_bOnlyActive,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Srch");

            try {
                // Pedimos el registro de la tabla: Moviles
                DataSet l_dsTemp= new DataSet();

                Dal.Moviles.Search(p_dbcAccess, 
                                   p_strPatente,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EMovil l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EMovil(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega un registro a la tabla a partir de una entidad: EMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  EMovil p_entMovil,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Insr");

            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entMovil, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Moviles
                Dal.Moviles.Insert(p_dbcAccess,
                                   p_entMovil.Patente,
                                   p_entMovil.Des,
                                   p_entMovil.Anot,
                                   p_entMovil.Nrochasis,
                                   p_entMovil.Nromotor,
                                   p_entMovil.Modelo,
                                   p_entMovil.Aniofabric,
                                   p_entMovil.Propio,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  EMovil p_entMovil,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Updt");

            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entMovil, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Moviles
                Dal.Moviles.Update(p_dbcAccess,
                                   p_entMovil.Patente,
                                   p_entMovil.Des,
                                   p_entMovil.Anot,
                                   p_entMovil.Nrochasis,
                                   p_entMovil.Nromotor,
                                   p_entMovil.Modelo,
                                   p_entMovil.Aniofabric,
                                   p_entMovil.Propio,
                                   ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Moviles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  string p_strPatente,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Drop");

            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_strPatente,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Movil) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_strPatente,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Moviles.Drop(p_dbcAccess,
                                 p_strPatente,
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
        internal static void Pack(DBConn p_dbcAccess,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "Pack");

            try {
                // Borramos los borrados lógicamente
                Dal.Moviles.Pack(p_dbcAccess,
                                 ref p_smResult);
                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData.ToString());
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Moviles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entMovil">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  EMovil p_entMovil,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "SSav");

            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entMovil, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entMovil.Patente,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entMovil.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Movil) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entMovil, ref p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (Movil) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entMovil.Patente,
                         p_entMovil.FxdVersion,
                         ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entMovil, ref p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEMovilesCombus
                MvcoSSav(p_dbcAccess,
                         p_entMovil.Patente,
                         p_entMovil.MovilesCombus,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEMovilesEquip
                MveqSSav(p_dbcAccess,
                         p_entMovil.Patente,
                         p_entMovil.MovilesEquip,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEMovilesEstado
                MvesSSav(p_dbcAccess,
                         p_entMovil.Patente,
                         p_entMovil.MovilesEstado,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEMovilesKms
                MvkmSSav(p_dbcAccess,
                         p_entMovil.Patente,
                         p_entMovil.MovilesKms,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                p_smResult.BllPop();
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData.ToString());
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getMovilesTree
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades getMovilesTree(DBConn p_dbcAccess,
                                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "getMovilesTree");

            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Moviles.getMovilesTree(p_dbcAccess,
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
