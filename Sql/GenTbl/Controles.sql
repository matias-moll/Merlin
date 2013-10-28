/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 17:40
// Base de Datos      : TNGS_Rivn
// Tabla              : Controles
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
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

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Controles'

if exists (select * from sysobjects where id = object_id('dbo.Controles'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Controles
end
go

print '   - Creando la nueva tabla'

create table Controles
   (
      ctl_cod_cod tngs_codigo,
      ctl_des_des tngs_descripcion,
      ctl_cd1_crit tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Controles_pk primary key clustered
      (
         ctl_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Controles to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Controles
//--------------------------------------------------------------------------*/
