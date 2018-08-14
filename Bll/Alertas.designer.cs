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
    // Clase para Administrar   : Alertas
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
    /// Mantenimiento de: Alertas
    /// </summary>
    public static partial class Alertas
    {

        //**********************************************************
        //
        // Funciones para la Tabla: Alertas
        // Usando ClaseDal        : Alertas
        //
        //**********************************************************

        //---------------------------------------------------------------
        // Metodos públicos de la clase (visibles para la UIL)
        //---------------------------------------------------------------
        #region Metodos publicos de recupero

        /// <summary>
        /// Devuelve la grilla de la tabla: Alertas
        /// </summary>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEAlertas</returns>
        public static LEAlertas AleUpFull(bool p_bOnlyActive,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos los registros de la tabla
                return AleUpfl(l_dbcAccess, p_bOnlyActive, ref p_smResult);
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
        /// Devuelve una entidad: EAlerta
        /// </summary>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EAlerta</returns>
        public static EAlerta AleGet(int p_iNroconfig,
                                     int p_iNroalerta,
                                     bool p_bOnlyActive,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Pedimos la entidad: EAlerta
                return AleSrch(l_dbcAccess,
                               p_iNroconfig,
                               p_iNroalerta,
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
        #endregion

        #region Metodos publicos de grabacion

        /// <summary>
        /// Agrega o modifica un registro de la tabla: Alertas
        /// </summary>
        /// <param name="p_entAlerta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void AleSave(EAlerta p_entAlerta,
                                   ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Grabamos la entidad: EAlerta
                AleSSav(l_dbcAccess, p_entAlerta, ref p_smResult);
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
        /// Habilita/Deshabilita un registro de la tabla: Alertas
        /// </summary>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void AleEnabled(bool p_bEnable,
                                      int p_iNroconfig,
                                      int p_iNroalerta,
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
                AleEnabled_f(l_dbcAccess,
                             p_bEnable,
                             p_iNroconfig,
                             p_iNroalerta,
                             ref p_iFxdVersion,
                             ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a modificar
                AleVKey(l_dbcAccess,
                        p_iNroconfig,
                        p_iNroalerta,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Alerta) que intenta modificar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                AleVVer(l_dbcAccess, 
                        p_iNroconfig,
                        p_iNroalerta,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Segun el modo
                if (p_bEnable) {
                    // Hay que habilitar el registro
                    Dal.Alertas.Recall(l_dbcAccess,
                                       p_iNroconfig,
                                       p_iNroalerta,
                                       ref p_smResult);
                }
                else {
                    // Hay que deshabilitar el registro
                    Dal.Alertas.Delete(l_dbcAccess,
                                       p_iNroconfig,
                                       p_iNroalerta,
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
        /// Borra físicamento un registro de la tabla: Alertas
        /// </summary>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        public static void AleRemove(int p_iNroconfig,
                                     int p_iNroalerta,
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
                AleRemove_f(l_dbcAccess,
                            p_iNroconfig,
                            p_iNroalerta,
                            p_iFxdVersion,
                            ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos el registro solicitado
                AleDrop(l_dbcAccess,
                        p_iNroconfig,
                        p_iNroalerta,
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
        public static void AlePurge(ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;
            try {
                // Obtenemos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Realizamos el borrado
                AlePack(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetAlertasFromMovil
        /// </summary>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LEAlertas AleGetAlertasFromMovil(string p_strPatente,
                                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return AleGetAlertasFromMovil(l_dbcAccess,
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
        /// Ejecuta el SP definido por el usuario: GetPendientesFromMov
        /// </summary>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        public static LEAlertas AleGetPendientesFromMov(string p_strPatente,
                                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            DBConn l_dbcAccess= null;

            try {
                // Abrimos una conexion
                l_dbcAccess= DBRuts.GetConection(Connections.Dat);

                // Llamamos al metodo interno
                return AleGetPendientesFromMov(l_dbcAccess,
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
        #endregion

        //---------------------------------------------------------------
        // Metodos públicos de la clase (no visibles para la UIL)
        //---------------------------------------------------------------

        #region Metodos internos de validacion

        /// <summary>
        /// Valida la integridad de una entidad: Alerta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleTInt(DBConn p_dbcAccess,
                                     EAlerta p_entAlerta,
                                     ref StatMsg p_smResult)
        {
            // ********
            // Validaciones de los campos sin conexion
            // ********

            if (p_entAlerta.Descripcion.Trim() == "") {
                // El campo [Descripción] no puede ser vacío
                p_smResult.BllWarning("El dato [Descripción] no puede ser vacío","");
                return;
            }

            // ********
            // Validaciones de los campos con conexion
            // ********

            // Llamamos a la funcion fija del usuario
            AleTInt_f(p_dbcAccess, p_entAlerta, ref p_smResult);
            if (p_smResult.NOk) return;
        }

        /// <summary>
        /// Verifica si existe en la tabla una entidad: EAlerta
        ///      Retorno: p_smResult.Stat= BllAvisos.KeyExists   - La clave existe
        ///               p_smResult.Stat= BllAvisos.KeyNotFound - La clave no existe
        ///               p_smResult.Stat= BllAvisos.KeyDisabled - La clave está deshabilitada
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleVKey(DBConn p_dbcAccess,
                                     int p_iNroconfig,
                                     int p_iNroalerta,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            Dal.Alertas.Search(p_dbcAccess,
                               p_iNroconfig,
                               p_iNroalerta,
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

        /// <summary>
        /// Verifica el número de version de una tabla
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Número de version</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleVVer(DBConn p_dbcAccess,
                                     int p_iNroconfig,
                                     int p_iNroalerta,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            // No hay errores aun
            DataSet l_dsTemp= new DataSet();

            // Verificamos el número de versión
            Dal.Alertas.ChkVersion(p_dbcAccess,
                                   p_iNroconfig,
                                   p_iNroalerta,
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
            p_smResult.BllWarning("El número de versión del registro del ítem (Alerta) no coincide.\r\nOperación cancelada.","");
        }
        #endregion

        #region Metodos internos de recupero

        /// <summary>
        /// Devuelve una Lista-entidad: LEAlertas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Lista-entidad: LEAlertas</returns>
        internal static LEAlertas AleUpfl(DBConn p_dbcAccess,
                                           bool p_bOnlyActive,
                                           ref StatMsg p_smResult)
        {
            try {
                // Pedimos los registros de la tabla: Alertas
                DataSet l_dsTemp= new DataSet();

                Dal.Alertas.Up(p_dbcAccess, 
                               p_bOnlyActive,
                               ref l_dsTemp, "Temporal",
                               ref p_smResult);
                if (p_smResult.NOk) return null;

                // Fijamos los captions de la grilla
                Dal.Alertas.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);

                // Contruimos la lista-entidad y la devolvemos (si vino algun registro)
                LEAlertas l_lentRet= new LEAlertas(l_dsTemp.Tables["Temporal"]);
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
        /// Devuelve una entidad: EAlerta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_bOnlyActive">Indica si solo se analizan los registros activos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Entidad: EAlerta</returns>
        internal static EAlerta AleSrch(DBConn p_dbcAccess,
                                        int p_iNroconfig,
                                        int p_iNroalerta,
                                        bool p_bOnlyActive,
                                        ref StatMsg p_smResult)
        {
            try {
                // Pedimos el registro de la tabla: Alertas
                DataSet l_dsTemp= new DataSet();

                Dal.Alertas.Search(p_dbcAccess, 
                                   p_iNroconfig,
                                   p_iNroalerta,
                                   p_bOnlyActive,
                                   ref l_dsTemp, "Temporal",
                                   ref p_smResult);
                if (p_smResult.NOk) return null;

                // Constuimos la entidad y la devolvemos (si vino un registro)
                EAlerta l_entRet= null;

                if (l_dsTemp.Tables["Temporal"].Rows.Count == 1)
                    l_entRet= new EAlerta(l_dsTemp.Tables["Temporal"].Rows[0]);

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
        /// Agrega o modifica un registro de la tabla: Alertas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleSSav(DBConn p_dbcAccess,
                                     EAlerta p_entAlerta,
                                     ref StatMsg p_smResult)
        {
            try {
                // Procesamos codigo fijo
                AleSave_f(p_dbcAccess, ref p_entAlerta, ref p_smResult);
                if (p_smResult.NOk) return;

                // Verificamos la clave a grabar
                AleVKey(p_dbcAccess, 
                        p_entAlerta.Nroconfig,
                        p_entAlerta.Nroalerta,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Si es una entidad nueva
                if (p_entAlerta.EsNueva) {
                    // Es un alta. La clave no debe existir
                    if (!p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                        // Error. La clave ya existe
                        p_smResult.BllWarning("El ítem (Alerta) que intenta agregar ya existe en el sistema.","");
                        return;
                    }

                    // Agregamos el registro
                    AleInsr(p_dbcAccess, p_entAlerta, ref p_smResult);
                    return;
                }

                // Es un update. La clave debe existir y estar habilitada
                if (!p_smResult.ICodeEs(BllCodes.KeyExists)) {
                    // Error. La clave no existe o no está habilitada
                    p_smResult.BllWarning("El ítem (Alerta) que intenta modificar no existe en el sistema o no está habilitado.","");
                    return;
                }

                // Debe coincidir el número de version
                AleVVer(p_dbcAccess, 
                        p_entAlerta.Nroconfig,
                        p_entAlerta.Nroalerta,
                        p_entAlerta.FxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos el registro
                AleUpdt(p_dbcAccess, p_entAlerta, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion SSav
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Agrega un registro a la tabla a partir de una entidad: EAlerta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleInsr(DBConn p_dbcAccess,
                                     EAlerta p_entAlerta,
                                     ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                AleTInt(p_dbcAccess, p_entAlerta, ref p_smResult);
                if (p_smResult.NOk) return;

                // Creamos un nuevo registro de la tabla: Alertas
                Dal.Alertas.Insert(p_dbcAccess,
                                   p_entAlerta.Nroconfig,
                                   p_entAlerta.Nroalerta,
                                   p_entAlerta.Descripcion,
                                   p_entAlerta.Detalle,
                                   p_entAlerta.Importancia,
                                   p_entAlerta.Fechadisparada,
                                   p_entAlerta.Fechavista,
                                   p_entAlerta.Usuariovista,
                                   p_entAlerta.Repetirendias,
                                   p_entAlerta.Finalizada,
                                   ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Insr
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Actualiza un registro a la tabla a partir de una entidad: EAlerta
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entAlerta">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleUpdt(DBConn p_dbcAccess,
                                     EAlerta p_entAlerta,
                                     ref StatMsg p_smResult)
        {
            try {
                // Validamos la integridad de la entidad
                AleTInt(p_dbcAccess, p_entAlerta, ref p_smResult);
                if (p_smResult.NOk) return;

                // Actualizamos un registro de la tabla: Alertas
                Dal.Alertas.Update(p_dbcAccess,
                                   p_entAlerta.Nroconfig,
                                   p_entAlerta.Nroalerta,
                                   p_entAlerta.Descripcion,
                                   p_entAlerta.Detalle,
                                   p_entAlerta.Importancia,
                                   p_entAlerta.Fechadisparada,
                                   p_entAlerta.Fechavista,
                                   p_entAlerta.Usuariovista,
                                   p_entAlerta.Repetirendias,
                                   p_entAlerta.Finalizada,
                                   ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }

        /// <summary>
        /// Borra físicamente un registro de a tabla: Alertas
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void AleDrop(DBConn p_dbcAccess,
                                     int p_iNroconfig,
                                     int p_iNroalerta,
                                     int p_iFxdVersion,
                                     ref StatMsg p_smResult)
        {
            try {
                // Verificamos la clave a borrar
                AleVKey(p_dbcAccess,
                        p_iNroconfig,
                        p_iNroalerta,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // El registro tiene que existir
                if (p_smResult.ICodeEs(BllCodes.KeyDsntFound)) {
                    // Error. La clave no existe
                    p_smResult.BllWarning("El ítem (Alerta) que intenta borrar no existe en el sistema.","");
                    return;
                }

                // Debe coincidir el número de version
                AleVVer(p_dbcAccess, 
                        p_iNroconfig,
                        p_iNroalerta,
                        p_iFxdVersion,
                        ref p_smResult);
                if (p_smResult.NOk) return;

                // Borramos físicamente el registro
                Dal.Alertas.Drop(p_dbcAccess,
                                 p_iNroconfig,
                                 p_iNroalerta,
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
        internal static void AlePack(DBConn p_dbcAccess,
                                     ref StatMsg p_smResult)
        {
            try {
                // Borramos los borrados lógicamente
                Dal.Alertas.Pack(p_dbcAccess,
                                 ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion Updt
                p_smResult.BllError(l_expData);
            }
        }
        #endregion

        #region Metodos para métodos DAL definidos por el usuario

        /// <summary>
        /// Ejecuta el SP definido por el usuario: GetAlertasFromMovil
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEAlertas AleGetAlertasFromMovil(DBConn p_dbcAccess,
                                                         string p_strPatente,
                                                         ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Alertas.GetAlertasFromMovil(p_dbcAccess,
                                                p_strPatente,
                                                ref l_dsTemp,
                                                "Temporal",
                                                ref p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Alertas.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEAlertas l_lentRet= new LEAlertas(l_dsTemp.Tables["Temporal"]);
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
        /// Ejecuta el SP definido por el usuario: GetPendientesFromMov
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name= p_strPatente>Patente</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>ListaEntidad con los datos solicitados</returns>
        internal static LEAlertas AleGetPendientesFromMov(DBConn p_dbcAccess,
                                                          string p_strPatente,
                                                          ref StatMsg p_smResult)
        {
            try {
                // Llamamos al metodo definido por el usuario
                DataSet l_dsTemp= new DataSet();

                Dal.Alertas.GetPendientesFromMov(p_dbcAccess,
                                                 p_strPatente,
                                                 ref l_dsTemp,
                                                 "Temporal",
                                                 ref p_smResult);
                if (p_smResult.NOk) return null;

                // Captionamos el resultado
                Dal.Alertas.MakeGridCaptions(ref l_dsTemp, "Temporal", ref p_smResult);
                if (p_smResult.NOk) return null;

                // Creamos la ListaEntidad y la devolvemos
                LEAlertas l_lentRet= new LEAlertas(l_dsTemp.Tables["Temporal"]);
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
