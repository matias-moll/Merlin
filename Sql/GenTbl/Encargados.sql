/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 17/08/2015 10:49
// Base de Datos      : TNGS_Rivn
// Tabla              : Encargados
//----------------------------------------------------------------------------
// � 1999-2015 by TNG Software                                      Gndr 5.20
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

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Encargados'

if exists (select * from sysobjects where id = object_id('dbo.Encargados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Encargados
end
go

print '   - Creando la nueva tabla'

create table Encargados
   (
      enc_cod_cod tngs_codigo,
      enc_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Encargados_pk primary key clustered
      (
         enc_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Encargados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Encargados
//--------------------------------------------------------------------------*/
