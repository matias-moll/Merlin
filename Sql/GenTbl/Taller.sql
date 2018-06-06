/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 06/06/2018 01:17
// Base de Datos      : TNGS_Mrln
// Tabla              : Taller
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

print 'Tabla: Taller'

if exists (select * from sysobjects where id = object_id('dbo.Taller'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Taller
end
go

print '   - Creando la nueva tabla'

create table Taller
   (
      tll_cod_codigo tngs_codigo,
      tll_ede_descripcion tngs_descripcion_e,
      tll_xde_direccion tngs_descripcion_x,
      tll_tel_telefono tngs_telefono,
      tll_ede_contacto tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Taller_pk primary key clustered
      (
         tll_cod_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Taller to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Taller
//--------------------------------------------------------------------------*/
