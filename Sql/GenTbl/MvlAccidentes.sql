/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : MvlAccidentes
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

print 'Tabla: MvlAccidentes'

if exists (select * from sysobjects where id = object_id('dbo.MvlAccidentes'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlAccidentes
end
go

print '   - Creando la nueva tabla'

create table MvlAccidentes
   (
      mva_ecd_patente tngs_codigo_e,
      mva_fyh_fecha tngs_fecyhor,
      mva_ede_localidad tngs_descripcion_e,
      mva_xde_direccion tngs_descripcion_x,
      mva_ede_motivo tngs_descripcion_e,
      mva_txt_detalle tngs_texto,
      mva_xde_dotacion tngs_descripcion_x,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlAccidentes_pk primary key clustered
      (
         mva_ecd_patente,
         mva_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlAccidentes to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlAccidentes
//--------------------------------------------------------------------------*/
