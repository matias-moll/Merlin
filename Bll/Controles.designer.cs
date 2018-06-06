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
    // Clase para Administrar   : Controles con sus Reparaciones
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
    /// Mantenimiento de: Controles con sus Reparaciones
    /// </summary>
    public static partial class Controles
    {

        //**********************************************************
        //
        // Funciones para la Tabla: ControlesReparations
        // Usando ClaseDal        : ControlesReparations
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEControlesRepa</returns>
        public static LEControlesRepa CrepUpFull(bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return CrepUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EControlRepa
        /// </summary>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EControlRepa</returns>
        public static EControlRepa CrepGet(string p_strCodctl,
                                           int p_iNroitem,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EControlRepa
                return CrepSrch(l_dbcAccess,
                                p_strCodctl,
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
        /// Devuelve una lista-entidad: LEControlesRepa
        /// asociada a una Foreing key de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-Entidad: LEControlesRepa</returns>
        public static LEControlesRepa CrepFGet(string p_strCodctl,
                                               bool p_bOnlyActive,
                                               ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la lista-entidad: LEControlesRepa
                return CrepFSch(l_dbcAccess,
                                p_strCodctl,
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
        /// Agrega o modifica un registro de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_entControlRepa">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CrepSave(EControlRepa p_entControlRepa,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EControlRepa
                CrepSSav(l_dbcAccess, p_entControlRepa, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CrepEnabled(bool p_bEnable,
                                       string p_strCodctl,
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
                CrepEnabled_f(l_dbcAccess,
                              p_bEnable,
                              p_strCodctl,
                              p_iNroitem,
                              ref p_iFxdVersion,
                              ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                CrepVKey(l_dbcAccess,
                         p_strCodctl,
                         p_iNroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ControlRepa) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CrepVVer(l_dbcAccess, 
                         p_strCodctl,
                         p_iNroitem,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.ControlesReparations.Recall(l_dbcAccess,
                                                    p_strCodctl,
                                                    p_iNroitem,
                                                    ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.ControlesReparations.Delete(l_dbcAccess,
                                                    p_strCodctl,
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
        /// Borra físicamento un registro de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void CrepRemove(string p_strCodctl,
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
                CrepRemove_f(l_dbcAccess,
                             p_strCodctl,
                             p_iNroitem,
                             p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                CrepDrop(l_dbcAccess,
                         p_strCodctl,
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
        public static void CrepPurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                CrepPack(l_dbcAccess,
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
        /// Valida la integridad de una entidad: ControlRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepTInt(DBConn p_dbcAccess,
                                      EControlRepa p_entControlRepa,
                                      ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entControlRepa.Nroitem <= 0) {
                // El campo [Item] debe ser mayor a cero
                p_smResult.BllWarning("El dato [Item] debe ser mayor a cero","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            Controles.VKey(p_dbcAccess,
                           p_entControlRepa.Codctl,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Codigo Control] debe existir en la tabla [Controles.]
                p_smResult.BllWarning("El dato [Codigo Control] debe existir en la tabla [Controles.] y estar habilitado","");
                return;
            }

            Tablas.RepVKey(p_dbcAccess,
                           p_entControlRepa.Codrep,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                // El campo [Codigo de Reparacion] debe existir en la tabla [Tablas.Rep]
                p_smResult.BllWarning("El dato [Codigo de Reparacion] debe existir en la tabla [Tablas.Rep] y estar habilitado","");
                return;
            }

            // Verificamos la clave foranea
            Controles.VKey(p_dbcAccess,
                           p_entControlRepa.Codctl,
                           ref p_smResult);
            if (p_smResult.NOk) return;

            // El registro tiene que existir
            if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                // Error. La clave foranea no existe
                p_smResult.BllWarning("La clave (Control) foranea no existe en el sistema.","");
                return;
            }

            // Todas las validaciones fueron correctas

            // Llamamos a la funcion fija del usuario
            CrepTInt_f(p_dbcAccess, p_entControlRepa, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepVVer(DBConn p_dbcAccess,
                                      string p_strCodctl,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.ControlesReparations.ChkVersion(p_dbcAccess,
                                                p_strCodctl,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (ControlRepa) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EControlRepa
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepVKey(DBConn p_dbcAccess,
                                      string p_strCodctl,
                                      int p_iNroitem,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.ControlesReparations.Search(p_dbcAccess,
                                            p_strCodctl,
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
        /// Devuelve una Lista-entidad: LEControlesRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEControlesRepa</returns>
        internal static LEControlesRepa CrepUpfl(DBConn p_dbcAccess,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: ControlesReparations
                DataSet l_dsTemp= new DataSet();

                Dal.ControlesReparations.Up(p_dbcAccess, 
                                            p_bOnlyActive,
                                            ref l_dsTemp, "Temporal",
                                            ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.ControlesReparations.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEControlesRepa l_lentRet= new LEControlesRepa(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EControlRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EControlRepa</returns>
        internal static EControlRepa CrepSrch(DBConn p_dbcAccess,
                                              string p_strCodctl,
                                              int p_iNroitem,
                                              bool p_bOnlyActive,
                                              ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: ControlesReparations
                DataSet l_dsTemp= new DataSet();

                Dal.ControlesReparations.Search(p_dbcAccess, 
                                                p_strCodctl,
                                                p_iNroitem,
                                                p_bOnlyActive,
                                                ref l_dsTemp, "Temporal",
                                                ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EControlRepa l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EControlRepa(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Devuelve una lista-entidad: LEControlesRepa
        /// a partir de una clave foranea de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static LEControlesRepa CrepFSch(DBConn p_dbcAccess,
                                                 string p_strCodctl,
                                                 bool p_bOnlyActive,
                                                 ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            try {
                // Pedimos los registros de la tabla por Foreing Key
                Dal.ControlesReparations.FSearch(p_dbcAccess,
                                                 p_strCodctl,
                                                 p_bOnlyActive,
                                                 ref l_dsTemp, "Temporal",
                                                 ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.ControlesReparations.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos
                LEControlesRepa l_entRet= new LEControlesRepa(l_dsTemp.Tables["Temporal"]);
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
        /// Agrega o modifica un registro de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepSSav(DBConn p_dbcAccess,
                                      EControlRepa p_entControlRepa,
                                      ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                CrepSave_f(p_dbcAccess, ref p_entControlRepa, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                CrepVKey(p_dbcAccess, 
                         p_entControlRepa.Codctl,
                         p_entControlRepa.Nroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entControlRepa.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (ControlRepa) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    CrepInsr(p_dbcAccess, p_entControlRepa, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (ControlRepa) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                CrepVVer(p_dbcAccess, 
                         p_entControlRepa.Codctl,
                         p_entControlRepa.Nroitem,
                         p_entControlRepa.FxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                CrepUpdt(p_dbcAccess, p_entControlRepa, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EControlRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepInsr(DBConn p_dbcAccess,
                                      EControlRepa p_entControlRepa,
                                      ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CrepTInt(p_dbcAccess, p_entControlRepa, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: ControlesReparations
                Dal.ControlesReparations.Insert(p_dbcAccess,
                                                p_entControlRepa.Codctl,
                                                p_entControlRepa.Nroitem,
                                                p_entControlRepa.Codrep,
                                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EControlRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControlRepa">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepUpdt(DBConn p_dbcAccess,
                                      EControlRepa p_entControlRepa,
                                      ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                CrepTInt(p_dbcAccess, p_entControlRepa, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: ControlesReparations
                Dal.ControlesReparations.Update(p_dbcAccess,
                                                p_entControlRepa.Codctl,
                                                p_entControlRepa.Nroitem,
                                                p_entControlRepa.Codrep,
                                                ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: ControlesReparations
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_iNroitem">Item</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepDrop(DBConn p_dbcAccess,
                                      string p_strCodctl,
                                      int p_iNroitem,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                CrepVKey(p_dbcAccess,
                         p_strCodctl,
                         p_iNroitem,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (ControlRepa) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                CrepVVer(p_dbcAccess, 
                         p_strCodctl,
                         p_iNroitem,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.ControlesReparations.Drop(p_dbcAccess,
                                              p_strCodctl,
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
        internal static void CrepPack(DBConn p_dbcAccess,
                                      ref StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.ControlesReparations.Pack(p_dbcAccess,
                                              ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Realiza una actualización inteligente de la tabla a partir de una
        /// lista-entidad: LEControlesRepa
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCodctl">Codigo Control</param>
        /// <param name="p_lentControlesRepa">Lista-entidad a actualizar sobre la tabla</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CrepSSav(DBConn p_dbcAccess,
                                      string p_strCodctl,
                                      LEControlesRepa p_lentControlesRepa,
                                      ref StatMsg p_smResult)
        {
            try {
                // Deshabilitamos todas las entidades existentes
                Dal.ControlesReparations.FDrop(p_dbcAccess,
                                               p_strCodctl,
                                               ref p_smResult);
                if (p_smResult.NOk) return;

                // Recorremos la lista de entidades
                foreach (EControlRepa l_entControlRepa in p_lentControlesRepa) {
                    // Forzamos la clave foranea
                    l_entControlRepa.Codctl= p_strCodctl;

                    // Verificamos si existe
                    CrepVKey(p_dbcAccess,
                             l_entControlRepa.Codctl,
                             l_entControlRepa.Nroitem,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Si no existe
                    if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Hay que darla de alta
                        CrepInsr(p_dbcAccess, l_entControlRepa, ref p_smResult);
                        if (p_smResult.NOk) return;
                        continue;
                    }

                    // Existe. Debe coincidir el número de version
                    CrepVVer(p_dbcAccess, 
                             l_entControlRepa.Codctl,
                             l_entControlRepa.Nroitem,
                             l_entControlRepa.FxdVersion,
                             ref p_smResult);
                    if (p_smResult.NOk) return;

                    // El número coincide. La Actualizamos si no está borrada
                    if (!l_entControlRepa.EstaBorrada) {
                        CrepUpdt(p_dbcAccess, l_entControlRepa, ref p_smResult);
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
        #endregion


        //**********************************************************
        //
        // Funciones para la Tabla: Controles
        // Usando ClaseDal        : Controles
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Controles
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEControles</returns>
        public static LEControles UpFull(bool p_bOnlyActive,
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
        /// Devuelve una entidad: EControl
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EControl</returns>
        public static EControl Get(string p_strCod,
                                   bool p_bOnlyActive,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EControl.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EControl
                EControl l_entControl = Srch(l_dbcAccess,
                                             p_strCod,
                                             p_bOnlyActive,
                                             ref p_smResult);
                if (p_smResult.NOk) return null;
                if (l_entControl == null) return null;

                // Completamos la lista-entidad: LEControlesRepa
                l_entControl.ControlesRepa= CrepFSch(l_dbcAccess,
                                                     p_strCod,
                                                     p_bOnlyActive,
                                                     ref p_smResult);
                if (p_smResult.NOk) return null;

                // Devolvemos la entidad completa
                return l_entControl;
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
        /// Agrega o modifica un registro de la tabla: Controles
        /// </summary>
        /// <param name="p_entControl">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Save(EControl p_entControl,
                                ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EControl
                SSav(l_dbcAccess, p_entControl, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Controles
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Enabled(bool p_bEnable,
                                   string p_strCod,
                                   int p_iFxdVersion,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EControl.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Enabled_f(l_dbcAccess,
                          p_bEnable,
                          p_strCod,
                          ref p_iFxdVersion,
                          ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                VKey(l_dbcAccess,
                     p_strCod,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Control) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(l_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Controles.Recall(l_dbcAccess,
                                         p_strCod,
                                         ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Controles.Delete(l_dbcAccess,
                                         p_strCod,
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
        /// Borra físicamento un registro de la tabla: Controles
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void Remove(string p_strCod,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            // Ajustamos codigos alineados a derecha
            p_strCod= EControl.FrmtCod(p_strCod);

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Procesamos codigo fijo
                Remove_f(l_dbcAccess,
                         p_strCod,
                         p_iFxdVersion,
                         ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                Drop(l_dbcAccess,
                     p_strCod,
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
        /// Valida la integridad de una entidad: Control
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt(DBConn p_dbcAccess,
                                  EControl p_entControl,
                                  ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entControl.Cod.Trim() == "") {
                // El campo [Codigo] no puede ser vacío
                p_smResult.BllWarning("El dato [Codigo] no puede ser vacío","");
                return;
            }

            if (p_entControl.Des.Trim() == "") {
                // El campo [Control] no puede ser vacío
                p_smResult.BllWarning("El dato [Control] no puede ser vacío","");
                return;
            }

            if (p_entControl.Crit.Trim() != "") {
                if ((p_entControl.Crit != "S") &&
                    (p_entControl.Crit != "N")) {
                    // El campo [Critico] tiene opciones
                    p_smResult.BllWarning("El dato [Critico] sólo admite\r\n\r\n[S]- SI\r\n[N]- NO\r\n","");
                    return;
                }
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            TInt_f(p_dbcAccess, p_entControl, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VVer(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Controles.ChkVersion(p_dbcAccess,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Control) no coincide.\r\nOperación cancelada.","");
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EControl
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void VKey(DBConn p_dbcAccess,
                                  string p_strCod,
                                  ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Controles.Search(p_dbcAccess,
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
            }
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEControles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEControles</returns>
        internal static LEControles Upfl(DBConn p_dbcAccess,
                                             bool p_bOnlyActive,
                                             ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Controles
                DataSet l_dsTemp= new DataSet();

                Dal.Controles.Up(p_dbcAccess, 
                                 p_bOnlyActive,
                                 ref l_dsTemp, "Temporal",
                                 ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Controles.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEControles l_lentRet= new LEControles(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EControl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EControl</returns>
        internal static EControl Srch(DBConn p_dbcAccess,
                                      string p_strCod,
                                      bool p_bOnlyActive,
                                      ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Controles
                DataSet l_dsTemp= new DataSet();

                Dal.Controles.Search(p_dbcAccess, 
                                     p_strCod,
                                     p_bOnlyActive,
                                     ref l_dsTemp, "Temporal",
                                     ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EControl l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EControl(l_dsTemp.Tables["Temporal"].Rows[0]);

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

                Dal.Controles.GetMaxKey(p_dbcAccess,
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
        /// Agrega un registro a la tabla a partir de una entidad: EControl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Insr(DBConn p_dbcAccess,
                                  EControl p_entControl,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entControl, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Controles
                Dal.Controles.Insert(p_dbcAccess,
                                     p_entControl.Cod,
                                     p_entControl.Des,
                                     p_entControl.Crit,
                                     ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EControl
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Updt(DBConn p_dbcAccess,
                                  EControl p_entControl,
                                  ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                TInt(p_dbcAccess, p_entControl, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Controles
                Dal.Controles.Update(p_dbcAccess,
                                     p_entControl.Cod,
                                     p_entControl.Des,
                                     p_entControl.Crit,
                                     ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Controles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Drop(DBConn p_dbcAccess,
                                  string p_strCod,
                                  int p_iFxdVersion,
                                  ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                VKey(p_dbcAccess,
                     p_strCod,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Control) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                VVer(p_dbcAccess, 
                     p_strCod,
                     p_iFxdVersion,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Controles.Drop(p_dbcAccess,
                                   p_strCod,
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
                Dal.Controles.Pack(p_dbcAccess,
                                   ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Controles
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entControl">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void SSav(DBConn p_dbcAccess,
                                  EControl p_entControl,
                                  ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                Save_f(p_dbcAccess, ref p_entControl, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                VKey(p_dbcAccess, 
                     p_entControl.Cod,
                     ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entControl.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Control) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    Insr(p_dbcAccess, p_entControl, ref p_smResult);
                }
                else {
                    // Es un update. La clave debe existir y estar habilitada
                    if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                        // Error. La clave no existe o no está habilitada
                        p_smResult.BllWarning("El ítem (Control) que intenta modificar no existe en el sistema o no está habilitado.","");
                        return;
                    }

                    // Debe coincidir el número de version
                    VVer(p_dbcAccess, 
                         p_entControl.Cod,
                         p_entControl.FxdVersion,
                         ref p_smResult);
                    if (p_smResult.NOk) return;

                    // Actualizamos el registro
                    Updt(p_dbcAccess, p_entControl, ref p_smResult);
                }
                if (p_smResult.NOk) return;

                // Grabamos la lista-entidad: LEControlesRepa
                CrepSSav(p_dbcAccess,
                         p_entControl.Cod,
                         p_entControl.ControlesRepa,
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
