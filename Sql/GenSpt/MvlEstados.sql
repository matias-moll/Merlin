/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 06/06/2018 03:58
// Sistema     : Mrln
// Tabla       : MvlEstados
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

print 'Store Procedure: dbo.MVLESTADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          where deleted = 0
          order by mve_ecd_patente,
                mve_fyh_fecha
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          order by mve_ecd_patente,
                mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_CHKVERSION
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_SEARCH
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and mve_fyh_fecha = @mve_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and mve_fyh_fecha = @mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FSEARCH
(
@mve_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and deleted = 0
          order by mve_fyh_fecha
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
          order by mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@mve_rcd_codestado">Codigo del estado.</param>
--- <param name="@mve_nro_km">Kilometraje</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_INSERT
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@mve_rcd_codestado tngs_codigo_r,
@mve_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlEstados
   values (
           @mve_ecd_patente,
           @mve_fyh_fecha,
           @mve_rcd_codestado,
           @mve_nro_km,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@mve_rcd_codestado">Codigo del estado.</param>
--- <param name="@mve_nro_km">Kilometraje</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_UPDATE
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@mve_rcd_codestado tngs_codigo_r,
@mve_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEstados
      set mve_rcd_codestado= @mve_rcd_codestado,
          mve_nro_km= @mve_nro_km,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_DELETE
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEstados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FDELETE
(
@mve_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlEstados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_RECALL
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEstados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FRECALL
(
@mve_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_DROP
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FDROP
(
@mve_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLESTADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlEstados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FPACK
(
@mve_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlEstads
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 est_des_des, 
   mve_nro_km, 
   mve_fyh_fecha, 
   mve_rcd_codestado 
   FROM TNGS_Mrln..MvlEstados 
   JOIN TNGS_Mrln..Estados 
   on mve_rcd_codestado = est_rcd_cod 
   WHERE mve_ecd_patente = @patente 
   ORDER BY mve_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_GETLASTFIVEMVLESTADS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
