/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 28/03/2019 19:05
// Sistema     : Mrln
// Tabla       : Controles
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

print 'Store Procedure: dbo.CONTROLES_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          where deleted = 0
          order by ctl_cod_cod
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          order by ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_CHKVERSION
(
@ctl_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Controles
    where ctl_cod_cod = @ctl_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_SEARCH
(
@ctl_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          where ctl_cod_cod = @ctl_cod_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          where ctl_cod_cod = @ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.CONTROLES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ctl_cod_cod), '0') as ctl_cod_cod
     from TNGS_Mrln..Controles

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Control</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_INSERT
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Controles
   values (
           @ctl_cod_cod,
           @ctl_des_des,
           @ctl_cd1_crit,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Control</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UPDATE
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Controles
      set ctl_des_des= @ctl_des_des,
          ctl_cd1_crit= @ctl_cd1_crit,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DELETE
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Controles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_RECALL
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Controles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DROP
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Controles
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CONTROLES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Controles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Controles
//--------------------------------------------------------------------------*/
