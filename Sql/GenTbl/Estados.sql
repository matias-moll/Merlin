/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 17:40
// Base de Datos      : TNGS_Rivn
// Tabla              : Estados
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

print 'Tabla: Estados'

if exists (select * from sysobjects where id = object_id('dbo.Estados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estados
end
go

print '   - Creando la nueva tabla'

create table Estados
   (
      est_rcd_cod tngs_codigo_r,
      est_des_des tngs_descripcion,
      est_txt_txtcontingencia tngs_texto,
      est_cd1_operativo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estados_pk primary key clustered
      (
         est_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estados
//--------------------------------------------------------------------------*/
