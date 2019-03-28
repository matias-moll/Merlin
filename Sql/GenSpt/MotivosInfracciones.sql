/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 28/03/2019 19:05
// Sistema     : Mrln
// Tabla       : MotivosInfracciones
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

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where deleted = 0
          order by mti_cod_codigo
      end
   else
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          order by mti_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_CHKVERSION
(
@mti_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MotivosInfracciones
    where mti_cod_codigo = @mti_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_SEARCH
(
@mti_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where mti_cod_codigo = @mti_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where mti_cod_codigo = @mti_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mti_cod_codigo), '0') as mti_cod_codigo
     from TNGS_Mrln..MotivosInfracciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@mti_ede_descripcion">Descripción</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_INSERT
(
@mti_cod_codigo tngs_codigo,
@mti_ede_descripcion tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MotivosInfracciones
   values (
           @mti_cod_codigo,
           @mti_ede_descripcion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@mti_ede_descripcion">Descripción</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_UPDATE
(
@mti_cod_codigo tngs_codigo,
@mti_ede_descripcion tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set mti_ede_descripcion= @mti_ede_descripcion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_DELETE
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_RECALL
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_DROP
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MotivosInfracciones
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MotivosInfracciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MotivosInfracciones
//--------------------------------------------------------------------------*/
