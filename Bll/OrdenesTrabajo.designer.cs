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
    // Fecha                    : 14/08/2018 18:04
    // Sistema                  : Mrln
    // Clase para Administrar   : Ordenes de Trabajo y sus Items
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
    /// Mantenimiento de: Ordenes de Trabajo y sus Items
    /// </summary>
    public static partial class OrdenesTrabajo
    {

        //**********************************************************
        //
        // Funciones para la Tabla: OtItems
        // Usando ClaseDal        : OtItems
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: OtItems
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEOTItems</returns>
        public static LEOTItems OtitUpFull(bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return OtitUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EOTItem
        /// </summary>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EOTItem</returns>
        public static EOTItem OtitGet(int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
                                      bool p_bOnlyActive,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EOTItem
                return OtitSrch(l_dbcAccess,
                                p_iNroot,
                                p_iNroagrupador,
                                p_iNroitem,
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
        /// Devuelve una lista-entidad: LEOTItems
        /// asociada a una Foreing key de la tabla: OtItems
        /// </summary>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEOTItems</returns>
        public static LEOTItems OtitFGet(int p_iNroot,
                                         bool p_bOnlyActive,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEOTItems
                return OtitFSch(l_dbcAccess,
                                p_iNroot,
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
        /// Agrega o modifica un registro de la tabla: OtItems
        /// </summary>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void OtitSave(EOTItem p_entOTItem,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EOTItem
                OtitSSav(l_dbcAccess, p_entOTItem, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: OtItems
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void OtitEnabled(bool p_bEnable,
                                       int p_iNroot,
                                       int p_iNroagrupador,
                                       int p_iNroitem,
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
                OtitEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_iNroot,
                              p_iNroagrupador,
                              p_iNroitem,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                OtitVKey(l_dbcAccess,
                         p_iNroot,
                         p_iNroagrupador,
                         p_iNroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (OTItem) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                OtitVVer(l_dbcAccess, 
                         p_iNroot,
                         p_iNroagrupador,
                         p_iNroitem,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.OtItems.Recall(l_dbcAccess,
                                       p_iNroot,
                                       p_iNroagrupador,
                                       p_iNroitem,
                                       ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.OtItems.Delete(l_dbcAccess,
                                       p_iNroot,
                                       p_iNroagrupador,
                                       p_iNroitem,
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
        /// Borra físicamento un registro de la tabla: OtItems
        /// </summary>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void OtitRemove(int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
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
                OtitRemove_f(l_dbcAccess,
                             p_iNroot,
                             p_iNroagrupador,
                             p_iNroitem,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                OtitDrop(l_dbcAccess,
                         p_iNroot,
                         p_iNroagrupador,
                         p_iNroitem,
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
        public static void OtitPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                OtitPack(l_dbcAccess,
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetRealizadosMvl
        /// </summary>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LEOTItems OtitGetRealizadosMvl(string p_strPatente,
                                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return OtitGetRealizadosMvl(l_dbcAccess,
                                            p_strPatente,
                                            ref p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZPendientes
        /// </summary>
        /// <param name= p_strInipatente>Inicio Patentes</param>
        /// <param name= p_strFinpatente>Fin Patentes</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades OtitZPendientes(string p_strInipatente,
                                                     string p_strFinpatente,
                                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return OtitZPendientes(l_dbcAccess,
                                       p_strInipatente,
                                       p_strFinpatente,
                                       ref p_smResult);
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
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: OTItem
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitTInt(DBConn p_dbcAccess,
                                      EOTItem p_entOTItem,
                                      ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entOTItem.Nroot < 0) {
                // El campo [nroOt] no puede menor a cero
                p_smResult.BllWarning("El dato [nroOt] no puede ser negativo","");
                return;
            }

            if (p_entOTItem.Nroagrupador < 0) {
                // El campo [Numero de agrupador] no puede menor a cero
                p_smResult.BllWarning("El dato [Numero de agrupador] no puede ser negativo","");
                return;
            }

            if (p_entOTItem.Nroitem < 0) {
                // El campo [Numero del item] no puede menor a cero
                p_smResult.BllWarning("El dato [Numero del item] no puede ser negativo","");
                return;
            }

            if (p_entOTItem.Desoperacion.Trim() == "") {
                // El campo [Descripción de la operación] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción de la operación] no puede ser vacío","");
                return;
            }

            if (p_entOTItem.Destarea.Trim() == "") {
                // El campo [Descripción de la tarea] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción de la tarea] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            if (p_entOTItem.Codcategoria.Trim() != "") {
                Tablas.CatVKey(p_dbcAccess,
                               p_entOTItem.Codcategoria,
                               ref p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Categoría] debe existir en la tabla [Tablas.Cat]
                    p_smResult.BllWarning("El dato [Categoría] debe existir en la tabla [Tablas.Cat]","");
                    return;
                }
            }

            Tablas.RepVKey(p_dbcAccess,
                           p_entOTItem.Codreparacion,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // El campo [Codigo Reparacion] debe existir en la tabla [Tablas.Rep]
                p_smResult.BllWarning("El dato [Codigo Reparacion] debe existir en la tabla [Tablas.Rep]","");
                return;
            }

            // Verificamos la clave foranea
            OrdenesTrabajo.VKey(p_dbcAccess,
                                p_entOTItem.Nroot,
                                ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (OrdenTrabajo) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            OtitTInt_f(p_dbcAccess, p_entOTItem, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitVVer(DBConn p_dbcAccess,
                                      int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.OtItems.ChkVersion(p_dbcAccess,
                                   p_iNroot,
                                   p_iNroagrupador,
                                   p_iNroitem,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (OTItem) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EOTItem
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitVKey(DBConn p_dbcAccess,
                                      int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.OtItems.Search(p_dbcAccess,
                               p_iNroot,
                               p_iNroagrupador,
                               p_iNroitem,
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
        /// Devuelve una Lista-entidad: LEOTItems
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEOTItems</returns>
        internal static LEOTItems OtitUpfl(DBConn p_dbcAccess,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: OtItems
                DataSet l_dsTemp= new DataSet();

                Dal.OtItems.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.OtItems.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEOTItems l_lentRet= new LEOTItems(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EOTItem
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EOTItem</returns>
        internal static EOTItem OtitSrch(DBConn p_dbcAccess,
                                         int p_iNroot,
                                         int p_iNroagrupador,
                                         int p_iNroitem,
                                         bool p_bOnlyActive,
                                         ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: OtItems
                DataSet l_dsTemp= new DataSet();

                Dal.OtItems.Search(p_dbcAccess, 
                                   p_iNroot,
                                   p_iNroagrupador,
                                   p_iNroitem,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EOTItem l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EOTItem(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEOTItems
        /// a partir de una clave foranea de la tabla: OtItems
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEOTItems OtitFSch(DBConn p_dbcAccess,
                                           int p_iNroot,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.OtItems.FSearch(p_dbcAccess,
                                    p_iNroot,
                                    p_bOnlyActive,
                                    ref l_dsTemp, "Temporal",
                                    ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.OtItems.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEOTItems l_entRet= new LEOTItems(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: OtItems
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitSSav(DBConn p_dbcAccess,
                                      EOTItem p_entOTItem,
                                      ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                OtitSave_f(p_dbcAccess, ref p_entOTItem, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                OtitVKey(p_dbcAccess, 
                         p_entOTItem.Nroot,
                         p_entOTItem.Nroagrupador,
                         p_entOTItem.Nroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entOTItem.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (OTItem) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    OtitInsr(p_dbcAccess, p_entOTItem, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (OTItem) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                OtitVVer(p_dbcAccess, 
                         p_entOTItem.Nroot,
                         p_entOTItem.Nroagrupador,
                         p_entOTItem.Nroitem,
                         p_entOTItem.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                OtitUpdt(p_dbcAccess, p_entOTItem, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EOTItem
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitInsr(DBConn p_dbcAccess,
                                      EOTItem p_entOTItem,
                                      ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                OtitTInt(p_dbcAccess, p_entOTItem, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: OtItems
                Dal.OtItems.Insert(p_dbcAccess,
                                   p_entOTItem.Nroot,
                                   p_entOTItem.Nroagrupador,
                                   p_entOTItem.Nroitem,
                                   p_entOTItem.Desoperacion,
                                   p_entOTItem.Destarea,
                                   p_entOTItem.Codcategoria,
                                   p_entOTItem.Importe,
                                   p_entOTItem.Comentario,
                                   p_entOTItem.Estado,
                                   p_entOTItem.Importecierre,
                                   p_entOTItem.Comentariocierre,
                                   p_entOTItem.Codreparacion,
                                   ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EOTItem
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitUpdt(DBConn p_dbcAccess,
                                      EOTItem p_entOTItem,
                                      ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                OtitTInt(p_dbcAccess, p_entOTItem, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: OtItems
                Dal.OtItems.Update(p_dbcAccess,
                                   p_entOTItem.Nroot,
                                   p_entOTItem.Nroagrupador,
                                   p_entOTItem.Nroitem,
                                   p_entOTItem.Desoperacion,
                                   p_entOTItem.Destarea,
                                   p_entOTItem.Codcategoria,
                                   p_entOTItem.Importe,
                                   p_entOTItem.Comentario,
                                   p_entOTItem.Estado,
                                   p_entOTItem.Importecierre,
                                   p_entOTItem.Comentariocierre,
                                   p_entOTItem.Codreparacion,
                                   ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: OtItems
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitDrop(DBConn p_dbcAccess,
                                      int p_iNroot,
                                      int p_iNroagrupador,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                OtitVKey(p_dbcAccess,
                         p_iNroot,
                         p_iNroagrupador,
                         p_iNroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (OTItem) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                OtitVVer(p_dbcAccess, 
                         p_iNroot,
                         p_iNroagrupador,
                         p_iNroitem,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.OtItems.Drop(p_dbcAccess,
                                 p_iNroot,
                                 p_iNroagrupador,
                                 p_iNroitem,
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
        internal static void OtitPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.OtItems.Pack(p_dbcAccess,
                                 ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEOTItems
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_lentOTItems">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitSSav(DBConn p_dbcAccess,
                                      int p_iNroot,
                                      LEOTItems p_lentOTItems,
                                      ref StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.OtItems.FDrop(p_dbcAccess,
                                  p_iNroot,
                                  ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EOTItem l_entOTItem in p_lentOTItems) {
                    // Forzamos la clave foranea
                    l_entOTItem.Nroot= p_iNroot;

                    // Verificamos si existe
                    OtitVKey(p_dbcAccess,
                             l_entOTItem.Nroot,
                             l_entOTItem.Nroagrupador,
                             l_entOTItem.Nroitem,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        OtitInsr(p_dbcAccess, l_entOTItem, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    OtitVVer(p_dbcAccess, 
                             l_entOTItem.Nroot,
                             l_entOTItem.Nroagrupador,
                             l_entOTItem.Nroitem,
                             l_entOTItem.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entOTItem.EstaBorrada) {
                        OtitUpdt(p_dbcAccess, l_entOTItem, ref p_smResult);
                        if (p_smResult.NOk) return;
                    }
                }
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetRealizadosMvl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEOTItems OtitGetRealizadosMvl(DBConn p_dbcAccess,
                                                       string p_strPatente,
                                                       ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.OtItems.GetRealizadosMvl(p_dbcAccess,
                                             p_strPatente,
                                             ref l_dsTemp,
                                             "Temporal",
                                             ref p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.OtItems.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEOTItems l_lentRet= new LEOTItems(l_dsTemp.Tables["Temporal"]);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZPendientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strInipatente>Inicio Patentes</param>
        /// <param name= p_strFinpatente>Fin Patentes</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades OtitZPendientes(DBConn p_dbcAccess,
                                                       string p_strInipatente,
                                                       string p_strFinpatente,
                                                       ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.OtItems.ZPendientes(p_dbcAccess,
                                        p_strInipatente,
                                        p_strFinpatente,
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
        // Funciones para la Tabla: OrdenesTrabajo
        // Usando ClaseDal        : OrdenesTrabajo
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEOrdenesTrabajo</returns>
        public static LEOrdenesTrabajo UpFull(bool p_bOnlyActive,
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
        /// Devuelve una entidad: EOrdenTrabajo
        /// </summary>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EOrdenTrabajo</returns>
        public static EOrdenTrabajo Get(int p_iNro,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EOrdenTrabajo
                EOrdenTrabajo l_entOrdenTrabajo = Srch(l_dbcAccess,
                                                       p_iNro,
                                                       p_bOnlyActive,
                                                       ref p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entOrdenTrabajo == null) return null;

                // Completamos la lista-entidad: LEOTItems
                l_entOrdenTrabajo.OTItems= OtitFSch(l_dbcAccess,
                                                    p_iNro,
                                                    p_bOnlyActive,
                                                    ref p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entOrdenTrabajo;
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
        #endregion

        #region Metodos publicos de modificacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(EOrdenTrabajo p_entOrdenTrabajo,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EOrdenTrabajo
                SSav(l_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   int p_iNro,
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
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_iNro,
                          ref p_iFxdVersion,
                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_iNro,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (OrdenTrabajo) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_iNro,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.OrdenesTrabajo.Recall(l_dbcAccess,
                                              p_iNro,
                                              ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.OrdenesTrabajo.Delete(l_dbcAccess,
                                              p_iNro,
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
        /// Borra físicamento un registro de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(int p_iNro,
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
                Remove_f(l_dbcAccess,
                         p_iNro,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_iNro,
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZFinalizadas
        /// </summary>
        /// <param name= p_dtFechaini>Fecha inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strPatenteini>Patente Inicio</param>
        /// <param name= p_strPatentefin>Patente Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static ListaEntidades ZFinalizadas(DateTime p_dtFechaini,
                                                  DateTime p_dtFechafin,
                                                  string p_strPatenteini,
                                                  string p_strPatentefin,
                                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return ZFinalizadas(l_dbcAccess,
                                    p_dtFechaini,
                                    p_dtFechafin,
                                    p_strPatenteini,
                                    p_strPatentefin,
                                    ref p_smResult);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getPendientes
        /// </summary>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LEOrdenesTrabajo getPendientes(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return getPendientes(l_dbcAccess,
                                     ref p_smResult);
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
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: OrdenTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  EOrdenTrabajo p_entOrdenTrabajo,
                                  ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entOrdenTrabajo.Nro < 0) {
                // El campo [Número OT] no puede menor a cero
                p_smResult.BllWarning("El dato [Número OT] no puede ser negativo","");
                return;
            }

            if (p_entOrdenTrabajo.Patente.Trim() == "") {
                // El campo [Patente] no puede ser vacío
                p_smResult.BllWarning("El dato [Patente] no puede ser vacío","");
                return;
            }

            if (p_entOrdenTrabajo.Fecapertura.Year == 1900) {
                // El campo [Fecha de apertura] no puede ser vacío
                p_smResult.BllWarning("El dato [Fecha de apertura] no puede ser vacío","");
                return;
            }

            if (p_entOrdenTrabajo.Estado.Trim() == "") {
                // El campo [Estado] no puede ser vacío
                p_smResult.BllWarning("El dato [Estado] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            if (p_entOrdenTrabajo.Codtaller.Trim() != "") {
                Talleres.VKey(p_dbcAccess,
                              p_entOrdenTrabajo.Codtaller,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // El campo [Taller] debe existir en la tabla [Talleres.]
                    p_smResult.BllWarning("El dato [Taller] debe existir en la tabla [Talleres.]","");
                    return;
                }
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  int p_iNro,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.OrdenesTrabajo.ChkVersion(p_dbcAccess,
                                          p_iNro,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (OrdenTrabajo) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EOrdenTrabajo
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  int p_iNro,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.OrdenesTrabajo.Search(p_dbcAccess,
                                      p_iNro,
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
        /// Devuelve una Lista-entidad: LEOrdenesTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEOrdenesTrabajo</returns>
        internal static LEOrdenesTrabajo Upfl(DBConn p_dbcAccess,
                                                  bool p_bOnlyActive,
                                                  ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: OrdenesTrabajo
                DataSet l_dsTemp= new DataSet();

                Dal.OrdenesTrabajo.Up(p_dbcAccess, 
                                      p_bOnlyActive,
                                      ref l_dsTemp, "Temporal",
                                      ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.OrdenesTrabajo.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEOrdenesTrabajo l_lentRet= new LEOrdenesTrabajo(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EOrdenTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EOrdenTrabajo</returns>
        internal static EOrdenTrabajo Srch(DBConn p_dbcAccess,
                                           int p_iNro,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: OrdenesTrabajo
                DataSet l_dsTemp= new DataSet();

                Dal.OrdenesTrabajo.Search(p_dbcAccess, 
                                          p_iNro,
                                          p_bOnlyActive,
                                          ref l_dsTemp, "Temporal",
                                          ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EOrdenTrabajo l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EOrdenTrabajo(l_dsTemp.Tables["Temporal"].Rows[0]);

                l_dsTemp.Dispose();
                return l_entRet;
            }
            catch (Exception l_expData) {
                // Error en la operacion Srch
                p_smResult.BllError(l_expData);
                return null;
            }
        }
        #endregion

        #region Metodos internos de modificacion

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EOrdenTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  EOrdenTrabajo p_entOrdenTrabajo,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: OrdenesTrabajo
                Dal.OrdenesTrabajo.Insert(p_dbcAccess,
                                          p_entOrdenTrabajo.Nro,
                                          p_entOrdenTrabajo.Patente,
                                          p_entOrdenTrabajo.Fecapertura,
                                          p_entOrdenTrabajo.Operador,
                                          p_entOrdenTrabajo.Feccierre,
                                          p_entOrdenTrabajo.Codtaller,
                                          p_entOrdenTrabajo.Estado,
                                          p_entOrdenTrabajo.Kmsactuales,
                                          ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EOrdenTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  EOrdenTrabajo p_entOrdenTrabajo,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: OrdenesTrabajo
                Dal.OrdenesTrabajo.Update(p_dbcAccess,
                                          p_entOrdenTrabajo.Nro,
                                          p_entOrdenTrabajo.Patente,
                                          p_entOrdenTrabajo.Fecapertura,
                                          p_entOrdenTrabajo.Operador,
                                          p_entOrdenTrabajo.Feccierre,
                                          p_entOrdenTrabajo.Codtaller,
                                          p_entOrdenTrabajo.Estado,
                                          p_entOrdenTrabajo.Kmsactuales,
                                          ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  int p_iNro,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_iNro,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (OrdenTrabajo) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_iNro,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.OrdenesTrabajo.Drop(p_dbcAccess,
                                        p_iNro,
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
                Dal.OrdenesTrabajo.Pack(p_dbcAccess,
                                        ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  EOrdenTrabajo p_entOrdenTrabajo,
                                  ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entOrdenTrabajo, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entOrdenTrabajo.Nro,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entOrdenTrabajo.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (OrdenTrabajo) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (OrdenTrabajo) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entOrdenTrabajo.Nro,
                         p_entOrdenTrabajo.FxdVersion,
                         ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entOrdenTrabajo, ref p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEOTItems
                OtitSSav(p_dbcAccess,
                         p_entOrdenTrabajo.Nro,
                         p_entOrdenTrabajo.OTItems,
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: ZFinalizadas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_dtFechaini>Fecha inicio</param>
        /// <param name= p_dtFechafin>Fecha Fin</param>
        /// <param name= p_strPatenteini>Patente Inicio</param>
        /// <param name= p_strPatentefin>Patente Fin</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static ListaEntidades ZFinalizadas(DBConn p_dbcAccess,
                                                    DateTime p_dtFechaini,
                                                    DateTime p_dtFechafin,
                                                    string p_strPatenteini,
                                                    string p_strPatentefin,
                                                    ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.OrdenesTrabajo.ZFinalizadas(p_dbcAccess,
                                                p_dtFechaini,
                                                p_dtFechafin,
                                                p_strPatenteini,
                                                p_strPatentefin,
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
                p_smResult.BllError(l_expData);
                return null;
            }
            finally {
                // Terminamos
            }
        }

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getPendByPatente
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>patente de un movil</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEOrdenesTrabajo getPendByPatente(DBConn p_dbcAccess,
                                                          string p_strPatente,
                                                          ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.OrdenesTrabajo.getPendByPatente(p_dbcAccess,
                                                    p_strPatente,
                                                    ref l_dsTemp,
                                                    "Temporal",
                                                    ref p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.OrdenesTrabajo.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEOrdenesTrabajo l_lentRet= new LEOrdenesTrabajo(l_dsTemp.Tables["Temporal"]);
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

        /// <summary>
        /// Ejecuta el SP definido por el usuario: getPendientes
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEOrdenesTrabajo getPendientes(DBConn p_dbcAccess,
                                                       ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.OrdenesTrabajo.getPendientes(p_dbcAccess,
                                                 ref l_dsTemp,
                                                 "Temporal",
                                                 ref p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.OrdenesTrabajo.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEOrdenesTrabajo l_lentRet= new LEOrdenesTrabajo(l_dsTemp.Tables["Temporal"]);
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
