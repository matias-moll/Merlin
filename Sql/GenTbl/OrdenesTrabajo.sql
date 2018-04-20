/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 20/04/2018 19:32
// Base de Datos      : TNGS_Mrln
// Tabla              : OrdenesTrabajo
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

print 'Tabla: OrdenesTrabajo'

if exists (select * from sysobjects where id = object_id('dbo.OrdenesTrabajo'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.OrdenesTrabajo
end
go

print '   - Creando la nueva tabla'

create table OrdenesTrabajo
   (
      odt_nro_nro tngs_numero,
      odt_ecd_patente tngs_codigo_e,
      odt_fyh_fecapertura tngs_fecyhor,
      odt_nom_operador tngs_nombre,
      odt_fyh_feccierre tngs_fecyhor,
      odt_cod_encargado tngs_codigo,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint OrdenesTrabajo_pk primary key clustered
      (
         odt_nro_nro
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on OrdenesTrabajo to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
