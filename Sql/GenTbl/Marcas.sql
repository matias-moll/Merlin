/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 31/07/2018 21:45
// Base de Datos      : TNGS_Mrln
// Tabla              : Marcas
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Mrln
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Marcas'

if exists (select * from sysobjects where id = object_id('dbo.Marcas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Marcas
end
go

print '   - Creando la nueva tabla'

create table Marcas
   (
      mrc_rcd_codigo tngs_codigo_r,
      mrc_des_descripcion tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Marcas_pk primary key clustered
      (
         mrc_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Marcas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Marcas
//--------------------------------------------------------------------------*/
