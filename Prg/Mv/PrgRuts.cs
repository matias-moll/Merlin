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
using Mrln;
using Mrln.Shr;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Mrln.Mv
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        private static Moviles m_dcEstados;
        private static Alertas m_dcAlertas;

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

            //Intanciamos el Dockeable principal.
            m_dcEstados = new Moviles();
            m_dcAlertas = new Alertas();

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
