/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/07/2018 16:31
// Sistema     : Mrln
// Tabla       : ControlesReparations
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

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where TNGS_Mrln..ControlesReparations.deleted = 0
          order by ctr_cod_codctl,
                ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          order by ctr_cod_codctl,
                ctr_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_CHKVERSION
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_SEARCH
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
            and TNGS_Mrln..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FSEARCH
(
@ctr_cod_codctl tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Mrln..ControlesReparations.deleted = 0
          order by ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
          order by ctr_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_INSERT
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..ControlesReparations
   values (
           @ctr_cod_codctl,
           @ctr_nro_nroitem,
           @ctr_cd6_codrep,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UPDATE
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..ControlesReparations
      set ctr_cd6_codrep= @ctr_cd6_codrep,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DELETE
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDELETE
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_RECALL
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..ControlesReparations
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FRECALL
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
      end
   else
      begin
         Update TNGS_Mrln..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DROP
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDROP
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CONTROLESREPARATIONS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..ControlesReparations
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FPACK
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
