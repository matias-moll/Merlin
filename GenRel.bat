@echo off

if exist "XX - Release" goto NoCreate

md "XX - Release"
md "XX - Release\Img"
md "XX - Release\Prg"

:NoCreate


rem **
rem ** Copiamos las Imágenes
rem **
copy Img\*.jpg                                                                     "XX - Release\Img"

rem **
rem ** Copiamos los elementos TNGS
rem **
copy "T:\Ambiente0520\DNet0520\Release_Uil\Bohman.MonthCalendar.520.dll"         "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\MikeHankey.XPControlLib.520.dll"      "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\MS.TabStripControlLibrary.520.dll"    "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\netchartdir.dll"                      "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\PS.TaskDialog.520.dll"                "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\WeifenLuo.WinFormsUI.Docking.520.dll" "XX - Release\Prg"

copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetApp.520.dll"                  "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetAppBll.520.dll"               "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetControls.520.dll"             "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetIPlugin.520.dll"              "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetOffice.520.dll"               "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetRoutines.520.dll"             "XX - Release\Prg"
copy "T:\Ambiente0520\DNet0520\Release_Uil\TNGS.NetSocket.520.dll"               "XX - Release\Prg"
copy "T:\Mrln0200\ExternalLibraries\Bunifu_UI_v1.52.dll"                         "XX - Release\Prg"

rem **
rem ** Copiamos los elementos del Proyecto: Merlin
rem **
REM copy Pin\<TODO>\bin\Release\Rivn.<TODO>.Plugin.dll                                         "XX - Release\Plg"

copy Dal\bin\Release\Mrln.Dal.dll                                                  "XX - Release\Prg"
copy Bel\bin\Release\Mrln.Bel.dll                                                  "XX - Release\Prg"
copy Bll\bin\Release\Mrln.Bll.dll                                                  "XX - Release\Prg"
copy Shr\bin\Release\Mrln.Shr.dll                                                  "XX - Release\Prg"

copy Prg\ControlesCustom\bin\Release\ControlesCustom.dll                           "XX - Release\Prg"

copy Prg\Mv\bin\Release\Mrln.Mv.exe                                                "XX - Release\Prg"
copy Prg\Ot\bin\Release\Mrln.Ot.exe                                                "XX - Release\Prg"
copy Prg\Rp\bin\Release\Mrln.Rp.exe                                                "XX - Release\Prg"
copy Prg\Tg\bin\Release\Mrln.Tg.exe                                                "XX - Release\Prg"

rem ** Armamos la distribucion final para los servidores
xcopy "Acf" /s /y                                                                "XX - Release\Acf"
copy "Sql\Install\Mrln SProcs.sql"                                               "XX - Release"

REM echo .
REM echo .
REM cd ..
REM cd ..

pause

