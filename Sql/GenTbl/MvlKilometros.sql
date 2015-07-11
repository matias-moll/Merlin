/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlKilometros
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlKilometros'

if exists (select * from sysobjects where id = object_id('dbo.MvlKilometros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlKilometros
end
go

print '   - Creando la nueva tabla'

create table MvlKilometros
   (
      mkm_ecd_patente tngs_codigo_e,
      mkm_fyh_fecha tngs_fecyhor,
      mkm_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlKilometros_pk primary key clustered
      (
         mkm_ecd_patente,
         mkm_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlKilometros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
