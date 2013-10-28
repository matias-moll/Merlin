/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlCombustible
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

print 'Tabla: MvlCombustible'

if exists (select * from sysobjects where id = object_id('dbo.MvlCombustible'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlCombustible
end
go

print '   - Creando la nueva tabla'

create table MvlCombustible
   (
      mco_ecd_patente tngs_codigo_e,
      mco_fyh_fecha tngs_fecyhor,
      mco_val_litros tngs_valor,
      mco_imp_importe tngs_importe,
      mco_rcd_codestacion tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlCombustible_pk primary key clustered
      (
         mco_ecd_patente,
         mco_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlCombustible to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
