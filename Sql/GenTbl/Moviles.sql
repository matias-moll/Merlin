/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 17:40
// Base de Datos      : TNGS_Rivn
// Tabla              : Moviles
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
      mov_nro_kms tngs_numero,
      mov_txt_anot tngs_texto,
      mov_des_nrochasis tngs_descripcion,
      mov_des_nromotor tngs_descripcion,
      mov_rcd_modelo tngs_codigo_r,
      mov_nro_aniofabric tngs_numero,
      mov_cd1_propio tngs_codigo_1,
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
