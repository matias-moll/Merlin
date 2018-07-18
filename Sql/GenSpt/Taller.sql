/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/07/2018 08:15
// Sistema     : Mrln
// Tabla       : Taller
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

print 'Store Procedure: dbo.TALLER_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where deleted = 0
          order by tll_cod_codigo
      end
   else
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          order by tll_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_CHKVERSION
(
@tll_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Taller
    where tll_cod_codigo = @tll_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_SEARCH
(
@tll_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where tll_cod_codigo = @tll_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where tll_cod_codigo = @tll_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.TALLER_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tll_cod_codigo), '0') as tll_cod_codigo
     from TNGS_Mrln..Taller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@tll_ede_descripcion">Descripcion</param>
--- <param name="@tll_xde_direccion">Direccion</param>
--- <param name="@tll_tel_telefono">Telefono</param>
--- <param name="@tll_ede_contacto">Contacto</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_INSERT
(
@tll_cod_codigo tngs_codigo,
@tll_ede_descripcion tngs_descripcion_e,
@tll_xde_direccion tngs_descripcion_x,
@tll_tel_telefono tngs_telefono,
@tll_ede_contacto tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Taller
   values (
           @tll_cod_codigo,
           @tll_ede_descripcion,
           @tll_xde_direccion,
           @tll_tel_telefono,
           @tll_ede_contacto,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@tll_ede_descripcion">Descripcion</param>
--- <param name="@tll_xde_direccion">Direccion</param>
--- <param name="@tll_tel_telefono">Telefono</param>
--- <param name="@tll_ede_contacto">Contacto</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_UPDATE
(
@tll_cod_codigo tngs_codigo,
@tll_ede_descripcion tngs_descripcion_e,
@tll_xde_direccion tngs_descripcion_x,
@tll_tel_telefono tngs_telefono,
@tll_ede_contacto tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set tll_ede_descripcion= @tll_ede_descripcion,
          tll_xde_direccion= @tll_xde_direccion,
          tll_tel_telefono= @tll_tel_telefono,
          tll_ede_contacto= @tll_ede_contacto,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_DELETE
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_RECALL
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_DROP
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Taller
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TALLER_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Taller
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Taller
//--------------------------------------------------------------------------*/
