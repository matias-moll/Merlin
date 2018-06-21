/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/06/2018 22:19
// Sistema     : Mrln
// Tabla       : Encargados
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

print 'Store Procedure: dbo.ENCARGADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where deleted = 0
          order by enc_cod_cod
      end
   else
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          order by enc_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_CHKVERSION
(
@enc_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Encargados
    where enc_cod_cod = @enc_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_SEARCH
(
@enc_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where enc_cod_cod = @enc_cod_cod
            and deleted = 0
      end
   else
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where enc_cod_cod = @enc_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.ENCARGADOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(enc_cod_cod), '0') as enc_cod_cod
     from TNGS_Mrln..Encargados

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@enc_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_INSERT
(
@enc_cod_cod tngs_codigo,
@enc_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Encargados
   values (
           @enc_cod_cod,
           @enc_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@enc_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_UPDATE
(
@enc_cod_cod tngs_codigo,
@enc_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set enc_des_des= @enc_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_DELETE
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_RECALL
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_DROP
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Encargados
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ENCARGADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Encargados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Encargados
//--------------------------------------------------------------------------*/
