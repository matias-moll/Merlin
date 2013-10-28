/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Categorias
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

print 'Tabla: Categorias'

if exists (select * from sysobjects where id = object_id('dbo.Categorias'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Categorias
end
go

print '   - Creando la nueva tabla'

create table Categorias
   (
      cat_rcd_cod tngs_codigo_r,
      cat_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Categorias_pk primary key clustered
      (
         cat_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Categorias to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Categorias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Controles
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

print 'Tabla: Controles'

if exists (select * from sysobjects where id = object_id('dbo.Controles'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Controles
end
go

print '   - Creando la nueva tabla'

create table Controles
   (
      ctl_cod_cod tngs_codigo,
      ctl_des_des tngs_descripcion,
      ctl_cd1_crit tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Controles_pk primary key clustered
      (
         ctl_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Controles to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Controles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : ControlesReparations
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

print 'Tabla: ControlesReparations'

if exists (select * from sysobjects where id = object_id('dbo.ControlesReparations'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ControlesReparations
end
go

print '   - Creando la nueva tabla'

create table ControlesReparations
   (
      ctr_cod_codctl tngs_codigo,
      ctr_nro_nroitem tngs_numero,
      ctr_cd6_codrep tngs_codigo_6,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ControlesReparations_pk primary key clustered
      (
         ctr_cod_codctl,
         ctr_nro_nroitem
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ControlesReparations to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Equipamiento
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

print 'Tabla: Equipamiento'

if exists (select * from sysobjects where id = object_id('dbo.Equipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Equipamiento
end
go

print '   - Creando la nueva tabla'

create table Equipamiento
   (
      eqi_cod_cod tngs_codigo,
      eqi_des_des tngs_descripcion,
      eqi_imp_valor tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Equipamiento_pk primary key clustered
      (
         eqi_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Equipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Estaciones
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

print 'Tabla: Estaciones'

if exists (select * from sysobjects where id = object_id('dbo.Estaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estaciones
end
go

print '   - Creando la nueva tabla'

create table Estaciones
   (
      ets_rcd_cod tngs_codigo_r,
      ets_des_des tngs_descripcion,
      ets_ede_domicilio tngs_descripcion_e,
      ets_des_contacto tngs_descripcion,
      ets_ete_telefono tngs_telefono_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estaciones_pk primary key clustered
      (
         ets_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Estados
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

print 'Tabla: Estados'

if exists (select * from sysobjects where id = object_id('dbo.Estados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estados
end
go

print '   - Creando la nueva tabla'

create table Estados
   (
      est_rcd_cod tngs_codigo_r,
      est_des_des tngs_descripcion,
      est_txt_txtcontingencia tngs_texto,
      est_cd1_operativo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estados_pk primary key clustered
      (
         est_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Marcas
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

print 'Tabla: Marcas'

if exists (select * from sysobjects where id = object_id('dbo.Marcas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Marcas
end
go

print '   - Creando la nueva tabla'

create table Marcas
   (
      mrc_rcd_codigo tngs_codigo_r,
      mrc_des_descripcion tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Marcas_pk primary key clustered
      (
         mrc_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Marcas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Modelos
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Moviles
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
      mov_des_des tngs_descripcion,
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlCombustible
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

print 'Tabla: MvlCombustible'

if exists (select * from sysobjects where id = object_id('dbo.MvlCombustible'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlCombustible
end
go

print '   - Creando la nueva tabla'

create table MvlCombustible
   (
      mco_ecd_patente tngs_codigo_e,
      mco_fyh_fecha tngs_fecyhor,
      mco_val_litros tngs_valor,
      mco_imp_importe tngs_importe,
      mco_rcd_codestacion tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlCombustible_pk primary key clustered
      (
         mco_ecd_patente,
         mco_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlCombustible to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlEquipamiento
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

print 'Tabla: MvlEquipamiento'

if exists (select * from sysobjects where id = object_id('dbo.MvlEquipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEquipamiento
end
go

print '   - Creando la nueva tabla'

create table MvlEquipamiento
   (
      meq_ecd_patente tngs_codigo_e,
      meq_cod_codequip tngs_codigo,
      meq_cd1_esfijo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEquipamiento_pk primary key clustered
      (
         meq_ecd_patente,
         meq_cod_codequip
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEquipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlEstados
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

print 'Tabla: MvlEstados'

if exists (select * from sysobjects where id = object_id('dbo.MvlEstados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEstados
end
go

print '   - Creando la nueva tabla'

create table MvlEstados
   (
      mve_ecd_patente tngs_codigo_e,
      mve_fyh_fecha tngs_fecyhor,
      mve_rcd_codestado tngs_codigo_r,
      mve_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEstados_pk primary key clustered
      (
         mve_ecd_patente,
         mve_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEstados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlKilometros
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

print 'Tabla: MvlKilometros'

if exists (select * from sysobjects where id = object_id('dbo.MvlKilometros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlKilometros
end
go

print '   - Creando la nueva tabla'

create table MvlKilometros
   (
      mkm_ecd_patente tngs_codigo_e,
      mkm_fyh_fecha tngs_fecyhor,
      mkm_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlKilometros_pk primary key clustered
      (
         mkm_ecd_patente,
         mkm_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlKilometros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : OrdenesTrabajo
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Parametros
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
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
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

print 'Tabla: Reparaciones'

if exists (select * from sysobjects where id = object_id('dbo.Reparaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Reparaciones
end
go

print '   - Creando la nueva tabla'

create table Reparaciones
   (
      rep_cd6_cod tngs_codigo_6,
      rep_xde_des tngs_descripcion_x,
      rep_rcd_codcat tngs_codigo_r,
      rep_cd1_solicitadetalle tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Reparaciones_pk primary key clustered
      (
         rep_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Reparaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Talonarios
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

print 'Tabla: Talonarios'

if exists (select * from sysobjects where id = object_id('dbo.Talonarios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Talonarios
end
go

print '   - Creando la nueva tabla'

create table Talonarios
   (
      tal_xcd_codigo tngs_codigo_x,
      tal_des_descripcion tngs_descripcion,
      tal_cd1_tipo tngs_codigo_1,
      tal_nro_valor tngs_numero,
      tal_fyh_referencia tngs_fecyhor,
      tal_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Talonarios_pk primary key clustered
      (
         tal_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Talonarios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Talonarios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 28/10/2013 18:04
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: Reparaciones_is1'

print '    - Creando el nuevo indice'

create index Reparaciones_is1 on Reparaciones
   (
       rep_xde_des
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
