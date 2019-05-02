/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : MvlEstados
//----------------------------------------------------------------------------
// © 1999-2019 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlEstados'

if exists (select * from sysobjects where id = object_id('dbo.MvlEstados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEstados
end
go

print '   - Creando la nueva tabla'

create table MvlEstados
   (
      mve_ecd_patente tngs_codigo_e,
      mve_fyh_fecha tngs_fecyhor,
      mve_rcd_codestado tngs_codigo_r,
      mve_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEstados_pk primary key clustered
      (
         mve_ecd_patente,
         mve_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEstados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
