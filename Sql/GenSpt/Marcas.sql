/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/06/2018 03:58
// Sistema     : Mrln
// Tabla       : Marcas
//----------------------------------------------------------------------------
// � 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
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

print 'Store Procedure: dbo.MARCAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          where deleted = 0
          order by mrc_rcd_codigo
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          order by mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_CHKVERSION
(
@mrc_rcd_codigo tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_SEARCH
(
@mrc_rcd_codigo tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave m�xima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mrc_rcd_codigo), '0') as mrc_rcd_codigo
     from TNGS_Mrln..Marcas

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_INSERT
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Marcas
   values (
           @mrc_rcd_codigo,
           @mrc_des_descripcion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UPDATE
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Marcas
      set mrc_des_descripcion= @mrc_des_descripcion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DELETE
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Marcas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_RECALL
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Marcas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DROP
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registros borrados l�gicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Marcas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Marcas
//--------------------------------------------------------------------------*/
