#region Usings
using System;
using System.IO;
using System.Web;
using System.Xml;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using TNGS.NetRoutines;
using Mrln.Bel;
using Mrln;
#endregion

namespace Mrln
{
    //----------------------------------------------------------------------------
    //                         TNG Software CLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 24/07/2018 10:18
    // Sistema                  : Mrln
    // Clase para Administrar   : Moviles
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
    /// Clase EnCll: Instancia los accesos a la CLL
    /// </summary>
    public static class EnCll
    {
        #region Miembros de la clase
            public static Cll.Def.Moviles Moviles {get; private set;}
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        static EnCll()
        {
            // Generamos las instancias con comportamiento DEFAULT
            Moviles= new Cll.Def.Moviles();

            // Cargamos la DLL
            LoadDll(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        /// <summary>
        /// Genera una instanacia de la clase indicada
        /// </summary>
        /// <param name="p_strPath">Path de carga</param>
        public static void LoadDll(string p_strPath)
        {
            // Obtenermos la lista de clases "Exportadas" por la CLL
            string l_strCll= Path.Combine(p_strPath, "Mrln.Cll.dll");
            if (!File.Exists(l_strCll)) return;

            Assembly l_asmCll = Assembly.LoadFile(l_strCll);
            Type[] l_tpClasess= l_asmCll.GetExportedTypes();

            foreach (Type l_tpClase in l_tpClasess.Where(unTipo => unTipo.Namespace == "Mrln.Cll")) {
                // Instanaciamos las que existan en la CLL
                switch (l_tpClase.Name) {
                    case "Moviles"             : {Moviles= (Cll.Def.Moviles) GetInstance(l_tpClase); break;}
                }
            }
        }

        /// <summary>
        /// Genera una instanacia de la clase indicada
        /// </summary>
        /// <param name="p_tpClase"></param>
        /// <returns>Instancia de la clase</returns>
        private static object GetInstance(Type p_tpClase)
        {
            return p_tpClase.GetConstructor(new Type[] { }).Invoke(null);
        }

    }
}
