/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : Modelos
//----------------------------------------------------------------------------
// � 1999-2019 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Mrln
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Modelos'

if exists (select * from sysobjects where id = object_id('dbo.Modelos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Modelos
end
go

print '   - Creando la nueva tabla'

create table Modelos
   (
      mds_rcd_cod tngs_codigo_r,
      mds_des_des tngs_descripcion,
      mds_rcd_codmarca tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Modelos_pk primary key clustered
      (
         mds_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Modelos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Modelos
//--------------------------------------------------------------------------*/
