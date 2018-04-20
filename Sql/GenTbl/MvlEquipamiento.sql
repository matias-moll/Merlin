/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 20/04/2018 19:32
// Base de Datos      : TNGS_Mrln
// Tabla              : MvlEquipamiento
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

print 'Tabla: MvlEquipamiento'

if exists (select * from sysobjects where id = object_id('dbo.MvlEquipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEquipamiento
end
go

print '   - Creando la nueva tabla'

create table MvlEquipamiento
   (
      meq_ecd_patente tngs_codigo_e,
      meq_cod_codequip tngs_codigo,
      meq_cd1_esfijo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEquipamiento_pk primary key clustered
      (
         meq_ecd_patente,
         meq_cod_codequip
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEquipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
