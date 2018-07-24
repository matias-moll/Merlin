/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 24/07/2018 10:42
// Sistema     : Mrln
// Tabla       : DestinatariosMails
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

print 'Store Procedure: dbo.DESTINATARIOSMAILS_UP'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where deleted = 0
          order by dem_cod_codigo
      end
   else
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          order by dem_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_CHKVERSION
(
@dem_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..DestinatariosMails
    where dem_cod_codigo = @dem_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_SEARCH
(
@dem_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where dem_cod_codigo = @dem_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where dem_cod_codigo = @dem_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@dem_des_descripcion">Descripción</param>
--- <param name="@dem_txt_destinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_INSERT
(
@dem_cod_codigo tngs_codigo,
@dem_des_descripcion tngs_descripcion,
@dem_txt_destinatarios tngs_texto,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..DestinatariosMails
   values (
           @dem_cod_codigo,
           @dem_des_descripcion,
           @dem_txt_destinatarios,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@dem_des_descripcion">Descripción</param>
--- <param name="@dem_txt_destinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_UPDATE
(
@dem_cod_codigo tngs_codigo,
@dem_des_descripcion tngs_descripcion,
@dem_txt_destinatarios tngs_texto,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set dem_des_descripcion= @dem_des_descripcion,
          dem_txt_destinatarios= @dem_txt_destinatarios,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_DELETE
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_RECALL
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_DROP
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..DestinatariosMails
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.DESTINATARIOSMAILS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..DestinatariosMails
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: DestinatariosMails
//--------------------------------------------------------------------------*/
