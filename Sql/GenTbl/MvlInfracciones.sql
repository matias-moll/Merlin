/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : MvlInfracciones
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

print 'Tabla: MvlInfracciones'

if exists (select * from sysobjects where id = object_id('dbo.MvlInfracciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlInfracciones
end
go

print '   - Creando la nueva tabla'

create table MvlInfracciones
   (
      mvi_ecd_patente tngs_codigo_e,
      mvi_fyh_fecha tngs_fecyhor,
      mvi_cod_codmotivo tngs_codigo,
      mvi_ede_lugar tngs_descripcion_e,
      mvi_cd1_pagada tngs_codigo_1,
      mvi_imp_importe tngs_importe,
      mvi_txt_comentario tngs_texto,
      mvi_cd1_anulada tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlInfracciones_pk primary key clustered
      (
         mvi_ecd_patente,
         mvi_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlInfracciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlInfracciones
//--------------------------------------------------------------------------*/
