/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 14/12/2018 04:11
// Sistema     : Mrln
// Tabla       : MvlAlertas
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

print 'Store Procedure: dbo.MVLALERTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          where TNGS_Mrln..MvlAlertas.deleted = 0
          order by mal_ecd_patente,
                mal_nro_nroconfigalerta
      end
   else
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          order by mal_ecd_patente,
                mal_nro_nroconfigalerta
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_CHKVERSION
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlAlertas
    where mal_ecd_patente = @mal_ecd_patente
      and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_SEARCH
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          where mal_ecd_patente = @mal_ecd_patente
            and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta
            and TNGS_Mrln..MvlAlertas.deleted = 0
      end
   else
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          where mal_ecd_patente = @mal_ecd_patente
            and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_FSEARCH
(
@mal_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          where mal_ecd_patente = @mal_ecd_patente
            and TNGS_Mrln..MvlAlertas.deleted = 0
          order by mal_nro_nroconfigalerta
      end
   else
      begin
         Select mal_ecd_patente,
                mal_nro_nroconfigalerta,
                mal_nro_kilometros,
                mal_cd6_codreparacion,
                isnull(rep_xde_des, '') as mal_reparacion,
                mal_cod_codcontrol,
                isnull(ctl_des_des, '') as mal_control,
                mal_cod_coddestinatarios,
                isnull(dem_des_descripcion, '') as mal_destinats,
                TNGS_Mrln..MvlAlertas.instante,
                TNGS_Mrln..MvlAlertas.deleted,
                TNGS_Mrln..MvlAlertas.usuario,
                TNGS_Mrln..MvlAlertas.version
           from TNGS_Mrln..MvlAlertas
                left outer join TNGS_Mrln..Controles
                  on mal_cod_codcontrol = ctl_cod_cod
                left outer join TNGS_Mrln..DestinatariosMails
                  on mal_cod_coddestinatarios = dem_cod_codigo
                left outer join TNGS_Mrln..Reparaciones
                  on mal_cd6_codreparacion = rep_cd6_cod
          where mal_ecd_patente = @mal_ecd_patente
          order by mal_nro_nroconfigalerta
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@mal_nro_kilometros">Kilometros</param>
--- <param name="@mal_cd6_codreparacion">Reparacion</param>
--- <param name="@mal_cod_codcontrol">Control</param>
--- <param name="@mal_cod_coddestinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_INSERT
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@mal_nro_kilometros tngs_numero,
@mal_cd6_codreparacion tngs_codigo_6,
@mal_cod_codcontrol tngs_codigo,
@mal_cod_coddestinatarios tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlAlertas
   values (
           @mal_ecd_patente,
           @mal_nro_nroconfigalerta,
           @mal_nro_kilometros,
           @mal_cd6_codreparacion,
           @mal_cod_codcontrol,
           @mal_cod_coddestinatarios,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@mal_nro_kilometros">Kilometros</param>
--- <param name="@mal_cd6_codreparacion">Reparacion</param>
--- <param name="@mal_cod_codcontrol">Control</param>
--- <param name="@mal_cod_coddestinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_UPDATE
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@mal_nro_kilometros tngs_numero,
@mal_cd6_codreparacion tngs_codigo_6,
@mal_cod_codcontrol tngs_codigo,
@mal_cod_coddestinatarios tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAlertas
      set mal_nro_kilometros= @mal_nro_kilometros,
          mal_cd6_codreparacion= @mal_cd6_codreparacion,
          mal_cod_codcontrol= @mal_cod_codcontrol,
          mal_cod_coddestinatarios= @mal_cod_coddestinatarios,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mal_ecd_patente = @mal_ecd_patente
      and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_DELETE
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAlertas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mal_ecd_patente = @mal_ecd_patente
      and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_FDELETE
(
@mal_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlAlertas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mal_ecd_patente = @mal_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_RECALL
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlAlertas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mal_ecd_patente = @mal_ecd_patente
      and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_FRECALL
(
@mal_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlAlertas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mal_ecd_patente = @mal_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlAlertas
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mal_ecd_patente = @mal_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@mal_nro_nroconfigalerta">Nro Config Alerta</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_DROP
(
@mal_ecd_patente tngs_codigo_e,
@mal_nro_nroconfigalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAlertas
    where mal_ecd_patente = @mal_ecd_patente
      and mal_nro_nroconfigalerta = @mal_nro_nroconfigalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_FDROP
(
@mal_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAlertas
    where mal_ecd_patente = @mal_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLALERTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlAlertas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mal_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLALERTAS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLALERTAS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLALERTAS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLALERTAS_FPACK
(
@mal_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlAlertas
    where mal_ecd_patente = @mal_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLALERTAS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlAlertas
//--------------------------------------------------------------------------*/
