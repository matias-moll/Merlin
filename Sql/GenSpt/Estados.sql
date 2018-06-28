/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 27/06/2018 19:52
// Sistema     : Mrln
// Tabla       : Estados
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
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          where deleted = 0
          order by est_rcd_cod
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          order by est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_CHKVERSION
(
@est_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Estados
    where est_rcd_cod = @est_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_SEARCH
(
@est_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          where est_rcd_cod = @est_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          where est_rcd_cod = @est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(est_rcd_cod), '0') as est_rcd_cod
     from TNGS_Mrln..Estados

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_INSERT
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Estados
   values (
           @est_rcd_cod,
           @est_des_des,
           @est_txt_txtcontingencia,
           @est_cd1_operativo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UPDATE
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estados
      set est_des_des= @est_des_des,
          est_txt_txtcontingencia= @est_txt_txtcontingencia,
          est_cd1_operativo= @est_cd1_operativo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DELETE
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_RECALL
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DROP
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Estados
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Estados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estados
//--------------------------------------------------------------------------*/
