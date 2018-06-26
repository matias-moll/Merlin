/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 25/06/2018 15:42
// Sistema     : Mrln
// Tabla       : TallerCategoria
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

print 'Store Procedure: dbo.TALLERCATEGORIA_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where TNGS_Mrln..TallerCategoria.deleted = 0
          order by tct_cod_codigotaller,
                tct_rcd_codigocategoria
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          order by tct_cod_codigotaller,
                tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_CHKVERSION
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_SEARCH
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
            and TNGS_Mrln..TallerCategoria.deleted = 0
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FSEARCH
(
@tct_cod_codigotaller tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and TNGS_Mrln..TallerCategoria.deleted = 0
          order by tct_rcd_codigocategoria
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
          order by tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@tct_cod_dummy">dummy</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_INSERT
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@tct_cod_dummy tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..TallerCategoria
   values (
           @tct_cod_codigotaller,
           @tct_rcd_codigocategoria,
           @tct_cod_dummy,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@tct_cod_dummy">dummy</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_UPDATE
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@tct_cod_dummy tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set tct_cod_dummy= @tct_cod_dummy,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_DELETE
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FDELETE
(
@tct_cod_codigotaller tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..TallerCategoria
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_RECALL
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FRECALL
(
@tct_cod_codigotaller tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..TallerCategoria
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where tct_cod_codigotaller = @tct_cod_codigotaller
      end
   else
      begin
         Update TNGS_Mrln..TallerCategoria
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_DROP
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FDROP
(
@tct_cod_codigotaller tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.TALLERCATEGORIA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..TallerCategoria
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FPACK
(
@tct_cod_codigotaller tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TallerCategoria
//--------------------------------------------------------------------------*/
