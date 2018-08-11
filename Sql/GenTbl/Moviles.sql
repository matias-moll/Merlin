/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 31/07/2018 21:45
// Base de Datos      : TNGS_Mrln
// Tabla              : Moviles
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

print 'Tabla: Moviles'

if exists (select * from sysobjects where id = object_id('dbo.Moviles'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Moviles
end
go

print '   - Creando la nueva tabla'

create table Moviles
   (
      mov_ecd_patente tngs_codigo_e,
      mov_des_des tngs_descripcion,
      mov_txt_anot tngs_texto,
      mov_des_nrochasis tngs_descripcion,
      mov_des_nromotor tngs_descripcion,
      mov_rcd_modelo tngs_codigo_r,
      mov_nro_aniofabric tngs_numero,
      mov_cd1_propio tngs_codigo_1,
      mov_ecd_nroploteado tngs_codigo_e,
      mov_des_tipodemovil tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Moviles_pk primary key clustered
      (
         mov_ecd_patente
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Moviles to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Moviles
//--------------------------------------------------------------------------*/
