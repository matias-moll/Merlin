/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 18/10/2013 15:51
// Base de Datos      : TNGS_Rivn
// Tabla              : Equipamiento
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

print 'Tabla: Equipamiento'

if exists (select * from sysobjects where id = object_id('dbo.Equipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Equipamiento
end
go

print '   - Creando la nueva tabla'

create table Equipamiento
   (
      eqi_cod_cod tngs_codigo,
      eqi_des_des tngs_descripcion,
      eqi_imp_valor tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Equipamiento_pk primary key clustered
      (
         eqi_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Equipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
