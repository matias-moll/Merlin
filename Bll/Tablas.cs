#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Rivn.Bel;

#endregion

namespace Rivn.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 09/09/2013 16:27
    // Sistema                  : Rivn
    // Clase para Administrar   : Tablas de Rivn.
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Tablas de Rivn.
    /// </summary>
    public static partial class Tablas
    {
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase
        /// <summary>
        /// Inserta 10 descripciones, 
        /// respetando el máximo del código de la tabla (PK).
        /// </summary>
        /// <param name="p_asArray"></param>
        /// <param name="p_smStatMsg"></param>
        public static void fAddArray(string[] p_asArray, ref StatMsg p_smStatMsg) // TRANSFORMAR EN METODO BLL.
        {
            p_smStatMsg.BllReset("Tablas", "fAddArray");
            DBConn p_dbcAccess = null;
            try
            {
                p_dbcAccess = DBRuts.GetConection(Connections.Dat, "sa", CriptoRuts.DESHide("tommy65536"));
                ECategoria l_eCat = null;
                foreach (string a in p_asArray)
                {
                    l_eCat = ECategoria.NewEmpty();
                    l_eCat.Des = a;
                    //Esto debería estar en otra capa (UIL, tal vez?)
                    CatSSav(p_dbcAccess, l_eCat,ref p_smStatMsg);
                    if (p_smStatMsg.NOk) return;
                }
            }
            catch (Exception e)
            {
                p_smStatMsg.BllError(e.ToString());
                return;
            }
            finally
            {
                p_smStatMsg.BllPop();
                if (p_dbcAccess != null)
                    p_dbcAccess.Close();
            }
                                    
        }

        private static void obtenerMaxCodigo(DBConn p_dbcAccess, ECategoria p_entCategoria, ref StatMsg p_smResult)
        {
            if (!p_entCategoria.EsNueva) return;
            LECategorias l_lista = Bll.Tablas.CatUpfl(p_dbcAccess, false, ref p_smResult);
            if (p_smResult.NOk) return;
            int max = -1;
            foreach (ECategoria v in l_lista)
            {
                int a = Ruts.MakeInteger(v.Cod.ToString(), 0);
                if (a >= max)
                    max = a;
            }
            p_entCategoria.Cod = (++max).ToString();
            return;
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: Categorias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatSave_f(DBConn p_dbcAccess,
                                       ref ECategoria p_entCategoria,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            obtenerMaxCodigo(p_dbcAccess, p_entCategoria, ref p_smResult);
            
           

            // Finalizamos
            p_smResult.BllPop();
        }

        

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Categorias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Categorias
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Categoria
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entCategoria">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void CatTInt_f(DBConn p_dbcAccess,
                                       ECategoria p_entCategoria,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "CatTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }


        /// <summary>
        /// Agrega o modifica un registro de la tabla: Equipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiSave_f(DBConn p_dbcAccess,
                                       ref EEquipamento p_entEquipamento,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiSave_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: Equipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiEnabled_f(DBConn p_dbcAccess,
                                          bool p_bEnable,
                                          string p_strCod,
                                          ref int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiEnabled_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra físicamento un registro de la tabla: Equipamiento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_iFxdVersion">Versión del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiRemove_f(DBConn p_dbcAccess,
                                         string p_strCod,
                                         int p_iFxdVersion,
                                         ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiRemove_f");

            // *********
            // Agregar acá los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: Equipamento
        /// (Código Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entEquipamento">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void EqiTInt_f(DBConn p_dbcAccess,
                                       EEquipamento p_entEquipamento,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Tablas", "EqiTInt_f");

            // *********
            // Agregar acá las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
