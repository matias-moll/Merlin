/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/04/2019 09:57
// Sistema     : Mrln
// Tabla       : OtItems
//----------------------------------------------------------------------------
// � 1999-2019 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.OTITEMS_UP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where TNGS_Mrln..OtItems.deleted = 0
          order by oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          order by oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_CHKVERSION
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_SEARCH
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
            and TNGS_Mrln..OtItems.deleted = 0
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FSEARCH
(
@oti_nro_nroot tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
            and TNGS_Mrln..OtItems.deleted = 0
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripci�n de la operaci�n</param>
--- <param name="@oti_des_destarea">Descripci�n de la tarea</param>
--- <param name="@oti_rcd_codcategoria">Categor�a</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@oti_d20_estado">Estado</param>
--- <param name="@oti_imp_importecierre">Importe Cierre</param>
--- <param name="@oti_ede_comentariocierre">Comentario Cierre</param>
--- <param name="@oti_cd6_codreparacion">Codigo Reparacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_INSERT
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_rcd_codcategoria tngs_codigo_r,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@oti_d20_estado tngs_descripcion_20,
@oti_imp_importecierre tngs_importe,
@oti_ede_comentariocierre tngs_descripcion_e,
@oti_cd6_codreparacion tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..OtItems
   values (
           @oti_nro_nroot,
           @oti_nro_nroagrupador,
           @oti_nro_nroitem,
           @oti_des_desoperacion,
           @oti_des_destarea,
           @oti_rcd_codcategoria,
           @oti_imp_importe,
           @oti_ede_comentario,
           @oti_d20_estado,
           @oti_imp_importecierre,
           @oti_ede_comentariocierre,
           @oti_cd6_codreparacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripci�n de la operaci�n</param>
--- <param name="@oti_des_destarea">Descripci�n de la tarea</param>
--- <param name="@oti_rcd_codcategoria">Categor�a</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@oti_d20_estado">Estado</param>
--- <param name="@oti_imp_importecierre">Importe Cierre</param>
--- <param name="@oti_ede_comentariocierre">Comentario Cierre</param>
--- <param name="@oti_cd6_codreparacion">Codigo Reparacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UPDATE
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_rcd_codcategoria tngs_codigo_r,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@oti_d20_estado tngs_descripcion_20,
@oti_imp_importecierre tngs_importe,
@oti_ede_comentariocierre tngs_descripcion_e,
@oti_cd6_codreparacion tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set oti_des_desoperacion= @oti_des_desoperacion,
          oti_des_destarea= @oti_des_destarea,
          oti_rcd_codcategoria= @oti_rcd_codcategoria,
          oti_imp_importe= @oti_imp_importe,
          oti_ede_comentario= @oti_ede_comentario,
          oti_d20_estado= @oti_d20_estado,
          oti_imp_importecierre= @oti_imp_importecierre,
          oti_ede_comentariocierre= @oti_ede_comentariocierre,
          oti_cd6_codreparacion= @oti_cd6_codreparacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DELETE
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro por clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDELETE
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_RECALL
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera l�gicamente los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FRECALL
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
      end
   else
      begin
         Update TNGS_Mrln..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DROP
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro por clave for�nea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDROP
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.OTITEMS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..OtItems
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FPACK
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- M�todo Fijo: GetRealizadosMvl
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_GETREALIZADOSMVL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_GETREALIZADOSMVL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_GETREALIZADOSMVL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_GETREALIZADOSMVL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select oti_nro_nroot,
          oti_nro_nroagrupador,
          oti_nro_nroitem,
          oti_des_desoperacion,
          oti_des_destarea,
          oti_rcd_codcategoria,
          cat_des_des as oti_categoria,
          oti_imp_importe,
          oti_ede_comentario,
          oti_d20_estado,
          oti_imp_importecierre,
          oti_ede_comentariocierre,
          oti_cd6_codreparacion,
          odt_nro_kmsactuales as oti_kilometraje,
          TNGS_Mrln..OtItems.instante,
          TNGS_Mrln..OtItems.deleted,
          TNGS_Mrln..OtItems.usuario,
          TNGS_Mrln..OtItems.version
     from TNGS_Mrln..OtItems 
          join TNGS_Mrln..Categorias
            on oti_rcd_codCategoria = cat_rcd_cod
          join TNGS_Mrln..OrdenesTrabajo
            on oti_nro_nroOt = odt_nro_nro
     where odt_ecd_patente = @patente and year(odt_fyh_feccierre) <> 1900 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_GETREALIZADOSMVL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- M�todo Fijo: ZPendientes
--- </summary>
--- <param name="@inipatente">Inicio Patentes</param>
--- <param name="@finpatente">Fin Patentes</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_ZPENDIENTES'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_ZPENDIENTES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_ZPENDIENTES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_ZPENDIENTES
(
@inipatente tngs_codigo_e,
@finpatente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select odt_ecd_patente, odt_nro_nro,odt_fyh_fecapertura, odt_fyh_feccierre, oti_des_desoperacion, oti_des_destarea, oti_imp_importe 
    from OtItems 
   join OrdenesTrabajo 
   	on odt_nro_nro = oti_nro_nroot 
   where oti_d20_estado = 'Pendiente' 
   and odt_ecd_patente between @inipatente and @finpatente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_ZPENDIENTES to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OtItems
//--------------------------------------------------------------------------*/
