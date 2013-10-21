/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 21/10/2013 16:24
// Sistema     : Rivn
// Tabla       : Estaciones
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

print 'Store Procedure: dbo.ESTACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where deleted = 0
          order by ets_rcd_cod
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          order by ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_CHKVERSION
(
@ets_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Estaciones
    where ets_rcd_cod = @ets_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_SEARCH
(
@ets_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_SEARCH to tngsmodulos

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

print 'Store Procedure: dbo.ESTACIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ets_rcd_cod), '0') as ets_rcd_cod
     from TNGS_Rivn..Estaciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@ets_des_des">descripcion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_INSERT
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Estaciones
   values (
           @ets_rcd_cod,
           @ets_des_des,
           @ets_ede_domicilio,
           @ets_des_contacto,
           @ets_ete_telefono,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@ets_des_des">descripcion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UPDATE
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set ets_des_des= @ets_des_des,
          ets_ede_domicilio= @ets_ede_domicilio,
          ets_des_contacto= @ets_des_contacto,
          ets_ete_telefono= @ets_ete_telefono,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DELETE
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_RECALL
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">CodigoEstacion</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DROP
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Estaciones
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Estaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estaciones
//--------------------------------------------------------------------------*/
