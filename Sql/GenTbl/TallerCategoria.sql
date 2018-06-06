/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 06/06/2018 01:17
// Base de Datos      : TNGS_Mrln
// Tabla              : TallerCategoria
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

print 'Tabla: TallerCategoria'

if exists (select * from sysobjects where id = object_id('dbo.TallerCategoria'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.TallerCategoria
end
go

print '   - Creando la nueva tabla'

create table TallerCategoria
   (
      tct_cod_codigotaller tngs_codigo,
      tct_rcd_codigocategoria tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint TallerCategoria_pk primary key clustered
      (
         tct_cod_codigotaller,
         tct_rcd_codigocategoria
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on TallerCategoria to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: TallerCategoria
//--------------------------------------------------------------------------*/
