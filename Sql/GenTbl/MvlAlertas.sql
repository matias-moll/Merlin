/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : MvlAlertas
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

print 'Tabla: MvlAlertas'

if exists (select * from sysobjects where id = object_id('dbo.MvlAlertas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlAlertas
end
go

print '   - Creando la nueva tabla'

create table MvlAlertas
   (
      mal_ecd_patente tngs_codigo_e,
      mal_nro_nroconfigalerta tngs_numero,
      mal_nro_kilometros tngs_numero,
      mal_cd6_codreparacion tngs_codigo_6,
      mal_cod_codcontrol tngs_codigo,
      mal_cod_coddestinatarios tngs_codigo,
      mal_fec_fecha tngs_fecha,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlAlertas_pk primary key clustered
      (
         mal_ecd_patente,
         mal_nro_nroconfigalerta
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlAlertas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlAlertas
//--------------------------------------------------------------------------*/
