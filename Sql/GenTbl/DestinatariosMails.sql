/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : DestinatariosMails
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

print 'Tabla: DestinatariosMails'

if exists (select * from sysobjects where id = object_id('dbo.DestinatariosMails'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.DestinatariosMails
end
go

print '   - Creando la nueva tabla'

create table DestinatariosMails
   (
      dem_cod_codigo tngs_codigo,
      dem_des_descripcion tngs_descripcion,
      dem_txt_destinatarios tngs_texto,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint DestinatariosMails_pk primary key clustered
      (
         dem_cod_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on DestinatariosMails to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: DestinatariosMails
//--------------------------------------------------------------------------*/
