/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : Reparaciones
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

print 'Tabla: Reparaciones'

if exists (select * from sysobjects where id = object_id('dbo.Reparaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Reparaciones
end
go

print '   - Creando la nueva tabla'

create table Reparaciones
   (
      rep_cd6_cod tngs_codigo_6,
      rep_xde_des tngs_descripcion_x,
      rep_rcd_codcat tngs_codigo_r,
      rep_cd1_solicitadetalle tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Reparaciones_pk primary key clustered
      (
         rep_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Reparaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
