#region Usings
using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Rivn;
using Rivn.Shr;
#endregion

namespace Rivn.Tg
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        #endregion

        //--------------------------------------------------------------------
        // Metodos públicos de la clase
        //--------------------------------------------------------------------

        #region Incio/Fin del programa

        /// <summary>
        /// Metodo de arranque del programa
        /// </summary>
        public static void AutoExec()
        {
            // Creamos el DockManager
            ((MainFrame) App.GetMainWindow()).CreateDockManager();

            //Justo Abajo de la creacion del dockManager isntanciamos el primer dockeable
            //Intanciamos el Dockeable principal.
            Estados l_dcAltaMovil = new Estados();
            Equipamientos l_dcEquipamiento = new Equipamientos();
            Estaciones l_dcEstaciones = new Estaciones();
            Marcas l_dcMarcas= new Marcas();
            Modelos l_dcModelos = new Modelos();
            Reparaciones l_dcReparaciones = new Reparaciones();
            Categorias l_dcCategorias = new Categorias();
            ControlesRepa l_dcCOntroles = new ControlesRepa();
            Controles controles = new Controles();

            // Liberamos el menu
            App.LockMenu(false);
            App.HideMsg();
        }

        /// <summary>
        /// Metodo de fin del programa
        /// </summary>
        public static void EndExec()
        {
        }

        #endregion

        #region Información del About

        /// <summary>
        /// Registramos la informacion del ABOUT
        /// </summary>
        public static void MakeAboutInfo()
        {
            // Fijamos la información del About
            App.AboutInfo= SysRuts.MakeAboutInfo("<TODO>:Descripcion del programa",
                                                 (Bitmap) App.Imagen("AppEEgg"));
        }

        #endregion

        //--------------------------------------------------------------------
        // Metodos privados de la clase
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        // Propiedades de la clase
        //--------------------------------------------------------------------

    }
}
