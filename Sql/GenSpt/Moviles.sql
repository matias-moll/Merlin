/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Moviles
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
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where deleted = 0
          order by mov_ecd_patente
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          order by mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_CHKVERSION
(
@mov_ecd_patente tngs_codigo_e,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_SEARCH
(
@mov_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
            and deleted = 0
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">des</param>
--- <param name="@mov_rcd_estado">estado</param>
--- <param name="@mov_nro_kms">Kilometros</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_INSERT
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_rcd_estado tngs_codigo_r,
@mov_nro_kms tngs_numero,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Moviles
   values (
           @mov_ecd_patente,
           @mov_des_des,
           @mov_rcd_estado,
           @mov_nro_kms,
           @mov_txt_anot,
           @mov_des_nrochasis,
           @mov_des_nromotor,
           @mov_rcd_modelo,
           @mov_nro_aniofabric,
           @mov_cd1_propio,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">des</param>
--- <param name="@mov_rcd_estado">estado</param>
--- <param name="@mov_nro_kms">Kilometros</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UPDATE
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_rcd_estado tngs_codigo_r,
@mov_nro_kms tngs_numero,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set mov_des_des= @mov_des_des,
          mov_rcd_estado= @mov_rcd_estado,
          mov_nro_kms= @mov_nro_kms,
          mov_txt_anot= @mov_txt_anot,
          mov_des_nrochasis= @mov_des_nrochasis,
          mov_des_nromotor= @mov_des_nromotor,
          mov_rcd_modelo= @mov_rcd_modelo,
          mov_nro_aniofabric= @mov_nro_aniofabric,
          mov_cd1_propio= @mov_cd1_propio,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DELETE
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_RECALL
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DROP
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Moviles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Moviles
//--------------------------------------------------------------------------*/
