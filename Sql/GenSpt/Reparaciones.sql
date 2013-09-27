/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Reparaciones
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

print 'Store Procedure: dbo.REPARACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_CHKVERSION
(
@rep_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_SEARCH
(
@rep_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
            and TNGS_Rivn..Reparaciones.deleted = 0
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FSEARCH
(
@rep_rcd_cat tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
            and TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_INSERT
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Reparaciones
   values (
           @rep_cd6_cod,
           @rep_xde_des,
           @rep_rcd_cat,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UPDATE
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set rep_xde_des= @rep_xde_des,
          rep_rcd_cat= @rep_rcd_cat,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DELETE
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDELETE
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_RECALL
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FRECALL
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
      end
   else
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DROP
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDROP
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.REPARACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Reparaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FPACK
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: Getbydesc
--- </summary>
--- <param name="@des">Levanta descripciones de las reparaciones.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_GETBYDESC
(
@des tngs_descripcion_10,
@usuario tngs_nombre
)
as
begin

   select * from Reparaciones 
   where rep_xde_des like '%' + rtrim(@des) + '%' 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
