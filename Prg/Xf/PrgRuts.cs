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
#endregion

namespace Mrln.Xf
{
    /// <summary>
    /// Rutinas generales del programa
    /// </summary>
    public partial class PrgRuts
    {
        #region Miembros estaticos de la clase
        #endregion

        //--------------------------------------------------------------------
        // Metodos p�blicos de la clase
        //--------------------------------------------------------------------

        #region Incio/Fin del programa

        /// <summary>
        /// Metodo de arranque del programa
        /// </summary>
        public static void AutoExec()
        {
            // Creamos el DockManager
            ((MainFrame) App.GetMainWindow()).CreateDockManager();

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

        internal static void MakeMainFrame()
        {
            throw new NotImplementedException();
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
