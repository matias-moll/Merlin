/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 14/12/2018 04:11
// Sistema     : Mrln
// Tabla       : Equipamiento
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

print 'Store Procedure: dbo.EQUIPAMIENTO_UP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          where deleted = 0
          order by eqi_cod_cod
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          order by eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_CHKVERSION
(
@eqi_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_SEARCH
(
@eqi_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
            and deleted = 0
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.EQUIPAMIENTO_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(eqi_cod_cod), '0') as eqi_cod_cod
     from TNGS_Mrln..Equipamiento

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_INSERT
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Equipamiento
   values (
           @eqi_cod_cod,
           @eqi_des_des,
           @eqi_imp_valor,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UPDATE
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Equipamiento
      set eqi_des_des= @eqi_des_des,
          eqi_imp_valor= @eqi_imp_valor,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DELETE
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Equipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_RECALL
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Equipamiento
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DROP
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DROP to tngsmodulos

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

print 'Store Procedure: dbo.EQUIPAMIENTO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Equipamiento
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
