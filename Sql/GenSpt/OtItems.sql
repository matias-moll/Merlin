/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : OtItems
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
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where deleted = 0
          order by oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          order by oti_nro_nro,
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@version">Número de version a verificar</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..OtItems
    where oti_nro_nro = @oti_nro_nro
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
--- <param name="@oti_nro_nro">nro</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nro = @oti_nro_nro
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
            and deleted = 0
      end
   else
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nro = @oti_nro_nro
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
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación.</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_des_descategoria">Descripción de la categoría.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..OtItems
   values (
           @oti_nro_nro,
           @oti_nro_nroagrupador,
           @oti_nro_nroitem,
           @oti_des_desoperacion,
           @oti_des_destarea,
           @oti_des_descategoria,
           @oti_imp_importe,
           @oti_ede_comentario,
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
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación.</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_des_descategoria">Descripción de la categoría.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set oti_des_desoperacion= @oti_des_desoperacion,
          oti_des_destarea= @oti_des_destarea,
          oti_des_descategoria= @oti_des_descategoria,
          oti_imp_importe= @oti_imp_importe,
          oti_ede_comentario= @oti_ede_comentario,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
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
--- Recupera un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
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
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OtItems
    where oti_nro_nro = @oti_nro_nro
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Rivn..OtItems
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OtItems
//--------------------------------------------------------------------------*/
