/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 14/08/2018 17:33
// Sistema     : Mrln
// Tabla       : MvlAccidentes
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

print 'Store Procedure: dbo.MVLACCIDENTES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          where deleted = 0
          order by mva_ecd_patente,
                mva_fyh_fecha
      end
   else
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          order by mva_ecd_patente,
                mva_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_CHKVERSION
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlAccidentes
    where mva_ecd_patente = @mva_ecd_patente
      and mva_fyh_fecha = @mva_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_SEARCH
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          where mva_ecd_patente = @mva_ecd_patente
            and mva_fyh_fecha = @mva_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          where mva_ecd_patente = @mva_ecd_patente
            and mva_fyh_fecha = @mva_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_FSEARCH
(
@mva_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          where mva_ecd_patente = @mva_ecd_patente
            and deleted = 0
          order by mva_fyh_fecha
      end
   else
      begin
         Select mva_ecd_patente,
                mva_fyh_fecha,
                mva_ede_localidad,
                mva_xde_direccion,
                mva_ede_motivo,
                mva_txt_detalle,
                mva_xde_dotacion,
                TNGS_Mrln..MvlAccidentes.instante,
                TNGS_Mrln..MvlAccidentes.deleted,
                TNGS_Mrln..MvlAccidentes.usuario,
                TNGS_Mrln..MvlAccidentes.version
           from TNGS_Mrln..MvlAccidentes
          where mva_ecd_patente = @mva_ecd_patente
          order by mva_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@mva_ede_localidad">Localidad</param>
--- <param name="@mva_xde_direccion">Direccion</param>
--- <param name="@mva_ede_motivo">Motivo</param>
--- <param name="@mva_txt_detalle">Detalle</param>
--- <param name="@mva_xde_dotacion">Dotación</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_INSERT
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@mva_ede_localidad tngs_descripcion_e,
@mva_xde_direccion tngs_descripcion_x,
@mva_ede_motivo tngs_descripcion_e,
@mva_txt_detalle tngs_texto,
@mva_xde_dotacion tngs_descripcion_x,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlAccidentes
   values (
           @mva_ecd_patente,
           @mva_fyh_fecha,
           @mva_ede_localidad,
           @mva_xde_direccion,
           @mva_ede_motivo,
           @mva_txt_detalle,
           @mva_xde_dotacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@mva_ede_localidad">Localidad</param>
--- <param name="@mva_xde_direccion">Direccion</param>
--- <param name="@mva_ede_motivo">Motivo</param>
--- <param name="@mva_txt_detalle">Detalle</param>
--- <param name="@mva_xde_dotacion">Dotación</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_UPDATE
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@mva_ede_localidad tngs_descripcion_e,
@mva_xde_direccion tngs_descripcion_x,
@mva_ede_motivo tngs_descripcion_e,
@mva_txt_detalle tngs_texto,
@mva_xde_dotacion tngs_descripcion_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAccidentes
      set mva_ede_localidad= @mva_ede_localidad,
          mva_xde_direccion= @mva_xde_direccion,
          mva_ede_motivo= @mva_ede_motivo,
          mva_txt_detalle= @mva_txt_detalle,
          mva_xde_dotacion= @mva_xde_dotacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mva_ecd_patente = @mva_ecd_patente
      and mva_fyh_fecha = @mva_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_DELETE
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAccidentes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mva_ecd_patente = @mva_ecd_patente
      and mva_fyh_fecha = @mva_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_FDELETE
(
@mva_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlAccidentes
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mva_ecd_patente = @mva_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_RECALL
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAccidentes
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mva_ecd_patente = @mva_ecd_patente
      and mva_fyh_fecha = @mva_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_FRECALL
(
@mva_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlAccidentes
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mva_ecd_patente = @mva_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlAccidentes
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mva_ecd_patente = @mva_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@mva_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_DROP
(
@mva_ecd_patente tngs_codigo_e,
@mva_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAccidentes
    where mva_ecd_patente = @mva_ecd_patente
      and mva_fyh_fecha = @mva_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_FDROP
(
@mva_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAccidentes
    where mva_ecd_patente = @mva_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLACCIDENTES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlAccidentes
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mva_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_FPACK
(
@mva_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAccidentes
    where mva_ecd_patente = @mva_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZAccidentesPorMovil
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Final</param>
--- <param name="@patenteini">Patente Inicial</param>
--- <param name="@patentefin">Patente Final</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLACCIDENTES_ZACCIDENTESPORMOVIL'

if exists (select * from sysobjects where id = object_id('dbo.MVLACCIDENTES_ZACCIDENTESPORMOVIL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLACCIDENTES_ZACCIDENTESPORMOVIL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLACCIDENTES_ZACCIDENTESPORMOVIL
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@patenteini tngs_codigo_e,
@patentefin tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select	mva_ecd_patente, 
   		mov_des_des, 
   		mov_des_tipodemovil, 
   		mva_fyh_fecha, 
   		mva_ede_localidad, 
   		mva_xde_direccion, 
   		mva_ede_motivo, 
   		mva_xde_dotacion, 
   		substring(mva_txt_detalle, 1, 250) as detalle 
    from MvlAccidentes 
    join Moviles on mov_ecd_patente = mva_ecd_patente 
   where	mva_fyh_fecha between @fechaini and @fechafin 
   and		mva_ecd_patente between @patenteini and @patentefin 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLACCIDENTES_ZACCIDENTESPORMOVIL to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlAccidentes
//--------------------------------------------------------------------------*/
