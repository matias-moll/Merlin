/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/06/2018 17:05
// Base de Datos      : TNGS_Mrln
// Tabla              : Alertas
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

print 'Tabla: Alertas'

if exists (select * from sysobjects where id = object_id('dbo.Alertas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Alertas
end
go

print '   - Creando la nueva tabla'

create table Alertas
   (
      alr_nro_nroconfig tngs_numero,
      alr_nro_nroalerta tngs_numero,
      alr_des_descripcion tngs_descripcion,
      alr_xde_detalle tngs_descripcion_x,
      alr_cd1_importancia tngs_codigo_1,
      alr_fyh_fechadisparada tngs_fecyhor,
      alr_fyh_fechavista tngs_fecyhor,
      alr_nom_usuariovista tngs_nombre,
      alr_nro_repetirendias tngs_numero,
      alr_cd1_finalizada tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Alertas_pk primary key clustered
      (
         alr_nro_nroconfig,
         alr_nro_nroalerta
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Alertas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Alertas
//--------------------------------------------------------------------------*/
