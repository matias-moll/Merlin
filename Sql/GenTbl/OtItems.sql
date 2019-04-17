/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : OtItems
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

print 'Tabla: OtItems'

if exists (select * from sysobjects where id = object_id('dbo.OtItems'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.OtItems
end
go

print '   - Creando la nueva tabla'

create table OtItems
   (
      oti_nro_nroot tngs_numero,
      oti_nro_nroagrupador tngs_numero,
      oti_nro_nroitem tngs_numero,
      oti_des_desoperacion tngs_descripcion,
      oti_des_destarea tngs_descripcion,
      oti_rcd_codcategoria tngs_codigo_r,
      oti_imp_importe tngs_importe,
      oti_ede_comentario tngs_descripcion_e,
      oti_d20_estado tngs_descripcion_20,
      oti_imp_importecierre tngs_importe,
      oti_ede_comentariocierre tngs_descripcion_e,
      oti_cd6_codreparacion tngs_codigo_6,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint OtItems_pk primary key clustered
      (
         oti_nro_nroot,
         oti_nro_nroagrupador,
         oti_nro_nroitem
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on OtItems to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: OtItems
//--------------------------------------------------------------------------*/
