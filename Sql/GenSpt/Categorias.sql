/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/04/2019 03:40
// Sistema     : Mrln
// Tabla       : Categorias
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

print 'Store Procedure: dbo.CATEGORIAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          where deleted = 0
          order by cat_rcd_cod
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          order by cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_CHKVERSION
(
@cat_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Categorias
    where cat_rcd_cod = @cat_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_SEARCH
(
@cat_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          where cat_rcd_cod = @cat_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          where cat_rcd_cod = @cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(cat_rcd_cod), '0') as cat_rcd_cod
     from TNGS_Mrln..Categorias

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_INSERT
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Categorias
   values (
           @cat_rcd_cod,
           @cat_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UPDATE
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Categorias
      set cat_des_des= @cat_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DELETE
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Categorias
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_RECALL
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Categorias
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DROP
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Categorias
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Categorias
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getByDesc
--- </summary>
--- <param name="@desc">.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_GETBYDESC
(
@desc tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select * from Categorias 
   where cat_des_des like '%' + ltrim(rtrim(@desc)) + '%' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Categorias
//--------------------------------------------------------------------------*/
