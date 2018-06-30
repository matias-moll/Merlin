/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 29/06/2018 17:57
// Base de Datos      : TNGS_Mrln
// Objetivo           : Creación de los usuarios de la base
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Mrln
go

/*--------------------------------------------------------------------------*/
/* Creacion de los usuarios                                                 */
/*--------------------------------------------------------------------------*/

print 'Creando Usuario:  tngsmodulos'
print ' '

if not exists (select * from sysusers where name = 'tngsmodulos' and uid < 16382)
   EXEC sp_adduser 'tngsmodulos', 'tngsmodulos', 'public'
go

print 'Creando Usuario:  tngsqbe'
print ' '

if not exists (select * from sysusers where name = 'tngsqbe' and uid < 16382)
   EXEC sp_adduser 'tngsqbe', 'tngsqbe', 'public'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp01.sql                                             */
/*--------------------------------------------------------------------------*/
