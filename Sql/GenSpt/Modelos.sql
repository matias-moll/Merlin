/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 28/10/2013 18:04
// Sistema     : Rivn
// Tabla       : Modelos
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

print 'Store Procedure: dbo.MODELOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where deleted = 0
          order by mds_rcd_cod
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          order by mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_CHKVERSION
(
@mds_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_SEARCH
(
@mds_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.MODELOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mds_rcd_cod), '0') as mds_rcd_cod
     from TNGS_Rivn..Modelos

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@mds_des_des">descripcion</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_INSERT
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Modelos
   values (
           @mds_rcd_cod,
           @mds_des_des,
           @mds_rcd_codmarca,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@mds_des_des">descripcion</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UPDATE
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set mds_des_des= @mds_des_des,
          mds_rcd_codmarca= @mds_rcd_codmarca,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DELETE
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_RECALL
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DROP
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MODELOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Modelos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Modelos
//--------------------------------------------------------------------------*/
