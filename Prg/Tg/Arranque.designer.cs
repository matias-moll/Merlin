#region Usings
using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;
using TNGS.NetRoutines;
using TNGS.NetApp;
using Mrln;
using Mrln.Shr;
#endregion

namespace Mrln.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software PRG Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 14/08/2018 18:28
    // Sistema                  : Mrln
    // Programa                 : Tablas Generales
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
    /// Clase que contiene el Punto de arranque del sistema
    /// </summary>
    public sealed partial class Arranque
    {
        /// <summary>
        /// Punto de arranque del sistema
        /// </summary>
        [STAThread]
        static void Main() 
        {
            // Creamos el objeto de reporte de errores
            StatMsg l_smResult= new StatMsg();

            try {
                // Verificamos si ya esta ejecutándose
                if (App.EnEjecucion) {
                    // Mostramos un aviso y nos vamos
                    MessageBox.Show("Ya existe una versión del Tablas Generales en ejecución", "Atención");
                    return;
                }

                // Incializamos recursos
                ResourceManager l_rmApp= new ResourceManager(typeof(Arranque));

                // Habilitamos el estilo XP
                App.EnableXPStyle();

                // Definimos el skin
                TNGSSkin.ChangeSkin(FixedSkins.ModernUI);

                // Llamamos al PreInit del Shr y del Programa
                if (!SysRuts.PreInit()) return;
                if (!Arranque.PreInit()) return;

#if (!DEBUG)
                // Mostramos la ventana Splash (con la imagen interna del programa)
                App.ShowSplash((Bitmap)(l_rmApp.GetObject("AppSplash")), false, -1, null);
#endif

                // Inicializamos nuestra clase App
                App.Init("Mrln", "Tg",
                         FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location),
                         l_rmApp,
                         Application.StartupPath, 
                         ParOptions.LoadParameters,
                         LOGOptions.WithoutLOG,
                         ValidOptions.Validate,
                         ConStrOptions.Read,
                         true,
                         l_smResult);
            }
            catch (Exception l_expData) {
                // Se produjo un error no capturado
                l_smResult.BllError(l_expData);
            }

            if (l_smResult.NOk) {
                // Cerramos la ventana de Splash
                App.CloseSplash();

                // Errores de inicializacion. Mostramos el error
                MsgRuts.AnalizeError(null, l_smResult);
                return;
            }

            try {
                // Creamos la ventana MDI de la aplicacion
                MainFrame l_frmMain= new MainFrame(MFSizes.MF1024x768, 0, false, true);

                // Ejecutamos la funcion que arma la info de About
                PrgRuts.MakeAboutInfo();

                // Llamamos al PreRun del Shr y del Programa
                if (!SysRuts.PreRun()) return;
                if (!Arranque.PreRun()) return;

                // Inicializamos la ventana principal y agregamos el handler para
                // procesar los comandos del menu
                App.MnuCommands += new MnuCommandsEventHandler(Arranque_MnuCommandsMF);

                App.Run(LoginModes.Full,
                        IMenuOptions.MAll,
                        ExitModes.Confirm,
                        l_smResult);
            }
            catch (Exception l_expData) {
                // Se produjo un error no capturado
                l_smResult.BllError(l_expData);
            }

            MsgRuts.AnalizeError(null, l_smResult);
        }

        /// <summary>
        /// Handler de los comandos de Menu/Toolbar
        /// </summary>
        public static void Arranque_MnuCommandsMF(object sender, MFOptionEventArgs e)
        {
            // Bloqueamos el menu
            App.LockMenu(true);

            // Procesamos el código 
            switch (e.CmdCode) {
                // *************************************************
                // ** Ejecución automática al inicio del programa
                // **
                case "$$AUTOEXEC$$"  : {SysRuts.AutoExecIni(App.Programa.Codigo); PrgRuts.AutoExec(); SysRuts.AutoExecEnd(App.Programa.Codigo); return;}

                // *************************************************
                // ** Menu: Tablas Generales
                // **
                case "EQUI"          : {new Equipamientos().Show(); return;}
                // **
                case "MOD"           : {new Modelos().Show(); return;}
                // **
                case "MAR"           : {new Marcas().Show(); return;}
                // **
                case "ESTA"          : {new Estaciones().Show(); return;}
                // **
                case "ESTD"          : {new Estados().Show(); return;}
                // **
                case "MINF"          : {new MotivosInfracciones().Show(); return;}
                // **
                case "DEST"          : {new DestinatariosMails().Show(); return;}

                // *************************************************
                // ** Menu: Controles y Reparaciones
                // **
                case "CAT"           : {new Categorias().Show(); return;}
                // **
                case "REP"           : {new Reparaciones().Show(); return;}
                // **
                case "CNRE"          : {new ControlesRepa().Show(); return;}

                // *************************************************
                // ** Menu: Talleres y Categorias
                // **
                case "TALL"          : {new Talleres().Show(); return;}
                // **
                case "TALC"          : {new TalleresCategorias().Show(); return;}

                // *************************************************
                // ** Ejecución automática al final del programa
                // **
                case "$$ENDEXEC$$"   : {SysRuts.EndExecIni(App.Programa.Codigo); PrgRuts.EndExec(); SysRuts.EndExecEnd(App.Programa.Codigo); return;}
            }

            // Comando no identificado. Liberamos el menu
            App.LockMenu(false);
            App.HideMsg();
        }
    }
}
