/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 17:40
// Base de Datos      : TNGS_Rivn
// Tabla              : OtItems
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
      oti_des_descategoria tngs_descripcion,
      oti_imp_importe tngs_importe,
      oti_ede_comentario tngs_descripcion_e,
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
