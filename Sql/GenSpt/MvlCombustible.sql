/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
<<<<<<< HEAD
// Fecha       : 28/10/2013 18:04
=======
// Fecha       : 31/10/2013 14:57
>>>>>>> 3a252f53020dd3b440332b25355995d4c9ecb060
// Sistema     : Rivn
// Tabla       : MvlCombustible
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

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where deleted = 0
          order by mco_ecd_patente,
                mco_fyh_fecha
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          order by mco_ecd_patente,
                mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_CHKVERSION
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_SEARCH
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and mco_fyh_fecha = @mco_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and mco_fyh_fecha = @mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FSEARCH
(
@mco_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and deleted = 0
          order by mco_fyh_fecha
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
          order by mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@mco_val_litros">Litros Cargados</param>
--- <param name="@mco_imp_importe">Importe</param>
--- <param name="@mco_rcd_codestacion">Codigo estacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_INSERT
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@mco_val_litros tngs_valor,
@mco_imp_importe tngs_importe,
@mco_rcd_codestacion tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlCombustible
   values (
           @mco_ecd_patente,
           @mco_fyh_fecha,
           @mco_val_litros,
           @mco_imp_importe,
           @mco_rcd_codestacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@mco_val_litros">Litros Cargados</param>
--- <param name="@mco_imp_importe">Importe</param>
--- <param name="@mco_rcd_codestacion">Codigo estacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_UPDATE
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@mco_val_litros tngs_valor,
@mco_imp_importe tngs_importe,
@mco_rcd_codestacion tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set mco_val_litros= @mco_val_litros,
          mco_imp_importe= @mco_imp_importe,
          mco_rcd_codestacion= @mco_rcd_codestacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_DELETE
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FDELETE
(
@mco_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlCombustible
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_RECALL
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FRECALL
(
@mco_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlCombustible
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mco_ecd_patente = @mco_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlCombustible
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mco_ecd_patente = @mco_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_DROP
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FDROP
(
@mco_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlCombustible
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FPACK
(
@mco_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
