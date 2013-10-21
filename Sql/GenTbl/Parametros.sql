/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 21/10/2013 16:24
// Base de Datos      : TNGS_Rivn
// Tabla              : Parametros
//----------------------------------------------------------------------------
// � 1999-2013 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Parametros'

if exists (select * from sysobjects where id = object_id('dbo.Parametros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parametros
end
go

print '   - Creando la nueva tabla'

create table Parametros
   (
      par_xcd_codigo tngs_codigo_x,
      par_des_descripcion tngs_descripcion,
      par_xde_valor tngs_descripcion_x,
      par_est_editable tngs_estado,
      par_est_sololectura tngs_estado,
      par_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parametros_pk primary key clustered
      (
         par_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parametros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parametros
//--------------------------------------------------------------------------*/
