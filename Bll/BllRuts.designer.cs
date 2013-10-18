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
    // Fecha                    : 18/10/2013 16:01
    // Sistema                  : Rivn
    // Clase para Administrar   : 
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
    /// Rutinas de apoyo a la Bll
    /// </summary>
    internal static partial class BllRuts
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase 
        //---------------------------------------------------------------

        #region Funciones Generales

        /// <summary>
        /// Devuelve la fecha del server (con Hora)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Fecha del server</returns>
        public static DateTime GetDBNow(DBConn p_dbcAccess,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("BllRuts", "GetDBNow");

            // Llamamos al metodo basico
            DateTime l_dtRet= GetDBNow(p_dbcAccess, false, ref p_smResult);
            if (p_smResult.NOk) return DateTimeRuts.Empty;

            // Terminamos
            p_smResult.BllPop();
            return l_dtRet;
        }

        /// <summary>
        /// Devuelve la fecha del server (con opcion para devolver solo la fecha)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bOnlyDate">Solo devolver la fecha</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        /// <returns>Fecha del server</returns>
        public static DateTime GetDBNow(DBConn p_dbcAccess,
                                        bool p_bOnlyDate,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("BllRuts", "GetDBNow");

            try {
                // Recuperamos la fecha del server
                return AppRuts.GetDBNow(p_dbcAccess, p_bOnlyDate, ref p_smResult);
            }
            catch (Exception l_expData) {
                // Error en la operacion
                p_smResult.BllError(l_expData.ToString());
                return DateTimeRuts.Empty;
            }
            finally {
                // Terminamos
                p_smResult.BllPop();
            }
        }

        #endregion

        #region Funciones de Captions

        /// <summary>
        /// Completa los captions de las columnas standard
        /// </summary>
        /// <param name="p_lentDatos">ListaEntidad a completar</param>
        public static void FillStdCaptions(ref ListaEntidades p_lentDatos)
        {
            // Limpiamos los captions
            p_lentDatos.ClearCaptions();

            // Cambiamos el caption de cada columna
            foreach (DataColumn l_dcInfo in p_lentDatos.InternalData.Table.Columns)
                p_lentDatos.ChangeCaption(l_dcInfo.ColumnName, GetColCaption(l_dcInfo.ColumnName));
        }

        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase 
        //---------------------------------------------------------------

        #region Funciones de Captions

        /// <summary>
        /// Devuelve el caption standard de un campo
        /// </summary>
        /// <param name="p_strColumn">Nombre de la columna</param>
        private static string GetColCaption(string p_strColumn)
        {
            // Vemos si el codigo fijo lo resuelve
            string l_strCaption= fGetColCaption(p_strColumn);
            if (l_strCaption.Length != 0) return l_strCaption;

            // Devolvemos el caption según el campo
            switch (p_strColumn) {
                // ****************************************
                // Tabla: Categorias          
                case "cat_rcd_cod"                     : {return "V1codigoCN1";}
                case "cat_des_des"                     : {return "V1descripcionCN1";}

                // ****************************************
                // Tabla: Controles           
                case "ctl_cod_cod"                     : {return "V1CodigoCN1";}
                case "ctl_des_des"                     : {return "V1DescripcionCN1";}
                case "ctl_cd1_crit"                    : {return "V1CriticoCN2";}

                // ****************************************
                // Tabla: ControlesReparations
                case "ctr_cod_codctl"                  : {return "V1codigoControlCN1";}
                case "ctr_nro_nroitem"                 : {return "V1itemNN3";}
                case "ctr_cd6_codrep"                  : {return "V1codigoReparacionCN1";}
                case "ctr_des_des"                     : {return "V1TitleSN1";}

                // ****************************************
                // Tabla: Equipamiento        
                case "eqi_cod_cod"                     : {return "V1codCN1";}
                case "eqi_des_des"                     : {return "V1desCN1";}
                case "eqi_imp_valor"                   : {return "V1valor2N3";}

                // ****************************************
                // Tabla: Estados             
                case "est_rcd_cod"                     : {return "V1codCN1";}
                case "est_des_des"                     : {return "V1desCN1";}
                case "est_txt_txtcontingencia"         : {return "V1Texto de ContingenciaCN1";}
                case "est_cd1_operativo"               : {return "V1OperativoCN2";}

                // ****************************************
                // Tabla: Marcas              
                case "mrc_rcd_codigo"                  : {return "V1codCN1";}
                case "mrc_des_descripcion"             : {return "V1desCN1";}

                // ****************************************
                // Tabla: Modelos             
                case "mds_rcd_cod"                     : {return "V1CodigoCN1";}
                case "mds_des_des"                     : {return "V1descripcionCN1";}
                case "mds_rcd_codmarca"                : {return "V1Codigo de la marcaCN1";}

                // ****************************************
                // Tabla: Moviles             
                case "mov_ecd_patente"                 : {return "V1Patente de la AmbulanciaCN1";}
                case "mov_des_des"                     : {return "V1desCN1";}
                case "mov_rcd_estado"                  : {return "V1estadoCN1";}
                case "mov_nro_kms"                     : {return "V1KilometrosNN3";}
                case "mov_txt_anot"                    : {return "V1AnotacionesCN1";}
                case "mov_des_nrochasis"               : {return "V1Nro ChasisCN1";}
                case "mov_des_nromotor"                : {return "V1Nro MotorCN1";}
                case "mov_rcd_modelo"                  : {return "V1ModeloCN1";}
                case "mov_nro_aniofabric"              : {return "V1Año de fabricaciónNN3";}
                case "mov_cd1_propio"                  : {return "V1Propio o noCN2";}

                // ****************************************
                // Tabla: MvlEquipamiento     
                case "meq_ecd_patente"                 : {return "V1PatenteCN1";}
                case "meq_cod_codequip"                : {return "V1Codigo del Equipamento.CN1";}
                case "meq_cd1_esfijo"                  : {return "V1Es fijo o no.CN2";}

                // ****************************************
                // Tabla: MvlEstados          
                case "mve_ecd_patente"                 : {return "V1PatenteCN1";}
                case "mve_fyh_fecha"                   : {return "V1Fecha y HoraDN2";}
                case "mve_rcd_codestado"               : {return "V1Codigo del estado.CN1";}
                case "mve_nro_km"                      : {return "V1KilometrajeNN3";}

                // ****************************************
                // Tabla: OrdenesTrabajo      
                case "odt_nro_nro"                     : {return "V1nroNN3";}
                case "odt_ecd_patente"                 : {return "V1PatenteCN1";}
                case "odt_fyh_fecapertura"             : {return "V1Fecha de aperturaDN2";}
                case "odt_nom_operador"                : {return "V1OperadorCN1";}
                case "odt_fyh_feccierre"               : {return "V1Fecha de cierre.DN2";}

                // ****************************************
                // Tabla: OtItems             
                case "oti_nro_nro"                     : {return "V1nroNN3";}
                case "oti_nro_nroagrupador"            : {return "V1Numero de agrupadorNN3";}
                case "oti_nro_nroitem"                 : {return "V1Numero del itemNN3";}
                case "oti_des_desoperacion"            : {return "V1Descripción de la operación.CN1";}
                case "oti_des_destarea"                : {return "V1Descripción de la tareaCN1";}
                case "oti_des_descategoria"            : {return "V1Descripción de la categoría.CN1";}
                case "oti_imp_importe"                 : {return "V1Importe2N3";}
                case "oti_ede_comentario"              : {return "V1ComentarioCN1";}

                // ****************************************
                // Tabla: Parametros          
                case "par_xcd_codigo"                  : {return "V1CódigoCN1";}
                case "par_des_descripcion"             : {return "V1DescripciónCN1";}
                case "par_xde_valor"                   : {return "V1ValorCN1";}
                case "par_est_editable"                : {return "V1EditableCN2";}
                case "par_est_sololectura"             : {return "V1Sólo lecturaCN2";}
                case "par_rob_detalle"                 : {return "V1DetalleCN1";}

                // ****************************************
                // Tabla: Reparaciones        
                case "rep_cd6_cod"                     : {return "V1codigoCN1";}
                case "rep_xde_des"                     : {return "V1descripcionCN1";}
                case "rep_rcd_cat"                     : {return "V1categoriaCN1";}
                case "rep_des_des"                     : {return "V1TitleSN1";}

                // ****************************************
                // Tabla: Talonarios          
                case "tal_xcd_codigo"                  : {return "V1CódigoCN1";}
                case "tal_des_descripcion"             : {return "V1DescripciónCN1";}
                case "tal_cd1_tipo"                    : {return "V1TipoCN2";}
                case "tal_nro_valor"                   : {return "V1NúmeroNN3";}
                case "tal_fyh_referencia"              : {return "V1ReferenciaDN2";}
                case "tal_rob_detalle"                 : {return "V1DetalleCN1";}

                // ****************************************
                // Captions Fijos
            }

            // El campo es desconocido
            return "";
        }

        #endregion
    }
}
