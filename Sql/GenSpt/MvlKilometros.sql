/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 28/10/2013 18:04
// Sistema     : Rivn
// Tabla       : MvlKilometros
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

print 'Store Procedure: dbo.MVLKILOMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where deleted = 0
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_CHKVERSION
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_SEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FSEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and deleted = 0
          order by mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
          order by mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_INSERT
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlKilometros
   values (
           @mkm_ecd_patente,
           @mkm_fyh_fecha,
           @mkm_nro_km,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UPDATE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set mkm_nro_km= @mkm_nro_km,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DELETE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDELETE
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_RECALL
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FRECALL
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DROP
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDROP
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLKILOMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlKilometros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FPACK
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
