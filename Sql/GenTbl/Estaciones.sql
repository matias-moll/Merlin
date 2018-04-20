/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 20/04/2018 19:32
// Base de Datos      : TNGS_Mrln
// Tabla              : Estaciones
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

print 'Tabla: Estaciones'

if exists (select * from sysobjects where id = object_id('dbo.Estaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estaciones
end
go

print '   - Creando la nueva tabla'

create table Estaciones
   (
      ets_rcd_cod tngs_codigo_r,
      ets_des_des tngs_descripcion,
      ets_ede_domicilio tngs_descripcion_e,
      ets_des_contacto tngs_descripcion,
      ets_ete_telefono tngs_telefono_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estaciones_pk primary key clustered
      (
         ets_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estaciones
//--------------------------------------------------------------------------*/
