/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 31/07/2018 21:45
// Base de Datos      : TNGS_Mrln
// Tabla              : MotivosInfracciones
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

print 'Tabla: MotivosInfracciones'

if exists (select * from sysobjects where id = object_id('dbo.MotivosInfracciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MotivosInfracciones
end
go

print '   - Creando la nueva tabla'

create table MotivosInfracciones
   (
      mti_cod_codigo tngs_codigo,
      mti_ede_descripcion tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MotivosInfracciones_pk primary key clustered
      (
         mti_cod_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MotivosInfracciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MotivosInfracciones
//--------------------------------------------------------------------------*/
