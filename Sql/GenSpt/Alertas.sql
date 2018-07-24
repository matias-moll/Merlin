/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 24/07/2018 10:42
// Sistema     : Mrln
// Tabla       : Alertas
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

print 'Store Procedure: dbo.ALERTAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select alr_nro_nroconfig,
                alr_nro_nroalerta,
                alr_des_descripcion,
                alr_d2x_detalle,
                alr_cd1_importancia,
                alr_fyh_fechadisparada,
                alr_fyh_fechavista,
                alr_nom_usuariovista,
                alr_nro_repetirendias,
                alr_cd1_finalizada,
                TNGS_Mrln..Alertas.instante,
                TNGS_Mrln..Alertas.deleted,
                TNGS_Mrln..Alertas.usuario,
                TNGS_Mrln..Alertas.version
           from TNGS_Mrln..Alertas
          where deleted = 0
          order by alr_nro_nroconfig,
                alr_nro_nroalerta
      end
   else
      begin
         Select alr_nro_nroconfig,
                alr_nro_nroalerta,
                alr_des_descripcion,
                alr_d2x_detalle,
                alr_cd1_importancia,
                alr_fyh_fechadisparada,
                alr_fyh_fechavista,
                alr_nom_usuariovista,
                alr_nro_repetirendias,
                alr_cd1_finalizada,
                TNGS_Mrln..Alertas.instante,
                TNGS_Mrln..Alertas.deleted,
                TNGS_Mrln..Alertas.usuario,
                TNGS_Mrln..Alertas.version
           from TNGS_Mrln..Alertas
          order by alr_nro_nroconfig,
                alr_nro_nroalerta
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_CHKVERSION
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Alertas
    where alr_nro_nroconfig = @alr_nro_nroconfig
      and alr_nro_nroalerta = @alr_nro_nroalerta
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_SEARCH
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select alr_nro_nroconfig,
                alr_nro_nroalerta,
                alr_des_descripcion,
                alr_d2x_detalle,
                alr_cd1_importancia,
                alr_fyh_fechadisparada,
                alr_fyh_fechavista,
                alr_nom_usuariovista,
                alr_nro_repetirendias,
                alr_cd1_finalizada,
                TNGS_Mrln..Alertas.instante,
                TNGS_Mrln..Alertas.deleted,
                TNGS_Mrln..Alertas.usuario,
                TNGS_Mrln..Alertas.version
           from TNGS_Mrln..Alertas
          where alr_nro_nroconfig = @alr_nro_nroconfig
            and alr_nro_nroalerta = @alr_nro_nroalerta
            and deleted = 0
      end
   else
      begin
         Select alr_nro_nroconfig,
                alr_nro_nroalerta,
                alr_des_descripcion,
                alr_d2x_detalle,
                alr_cd1_importancia,
                alr_fyh_fechadisparada,
                alr_fyh_fechavista,
                alr_nom_usuariovista,
                alr_nro_repetirendias,
                alr_cd1_finalizada,
                TNGS_Mrln..Alertas.instante,
                TNGS_Mrln..Alertas.deleted,
                TNGS_Mrln..Alertas.usuario,
                TNGS_Mrln..Alertas.version
           from TNGS_Mrln..Alertas
          where alr_nro_nroconfig = @alr_nro_nroconfig
            and alr_nro_nroalerta = @alr_nro_nroalerta
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@alr_des_descripcion">Descripción</param>
--- <param name="@alr_d2x_detalle">Detalle</param>
--- <param name="@alr_cd1_importancia">Importancia</param>
--- <param name="@alr_fyh_fechadisparada">Fecha Disparada</param>
--- <param name="@alr_fyh_fechavista">Fecha Vista</param>
--- <param name="@alr_nom_usuariovista">Usuario Vista</param>
--- <param name="@alr_nro_repetirendias">Repetir en Dias</param>
--- <param name="@alr_cd1_finalizada">Finalizada</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_INSERT
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@alr_des_descripcion tngs_descripcion,
@alr_d2x_detalle tngs_descripcion_200,
@alr_cd1_importancia tngs_codigo_1,
@alr_fyh_fechadisparada tngs_fecyhor,
@alr_fyh_fechavista tngs_fecyhor,
@alr_nom_usuariovista tngs_nombre,
@alr_nro_repetirendias tngs_numero,
@alr_cd1_finalizada tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Alertas
   values (
           @alr_nro_nroconfig,
           @alr_nro_nroalerta,
           @alr_des_descripcion,
           @alr_d2x_detalle,
           @alr_cd1_importancia,
           @alr_fyh_fechadisparada,
           @alr_fyh_fechavista,
           @alr_nom_usuariovista,
           @alr_nro_repetirendias,
           @alr_cd1_finalizada,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@alr_des_descripcion">Descripción</param>
--- <param name="@alr_d2x_detalle">Detalle</param>
--- <param name="@alr_cd1_importancia">Importancia</param>
--- <param name="@alr_fyh_fechadisparada">Fecha Disparada</param>
--- <param name="@alr_fyh_fechavista">Fecha Vista</param>
--- <param name="@alr_nom_usuariovista">Usuario Vista</param>
--- <param name="@alr_nro_repetirendias">Repetir en Dias</param>
--- <param name="@alr_cd1_finalizada">Finalizada</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_UPDATE
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@alr_des_descripcion tngs_descripcion,
@alr_d2x_detalle tngs_descripcion_200,
@alr_cd1_importancia tngs_codigo_1,
@alr_fyh_fechadisparada tngs_fecyhor,
@alr_fyh_fechavista tngs_fecyhor,
@alr_nom_usuariovista tngs_nombre,
@alr_nro_repetirendias tngs_numero,
@alr_cd1_finalizada tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Alertas
      set alr_des_descripcion= @alr_des_descripcion,
          alr_d2x_detalle= @alr_d2x_detalle,
          alr_cd1_importancia= @alr_cd1_importancia,
          alr_fyh_fechadisparada= @alr_fyh_fechadisparada,
          alr_fyh_fechavista= @alr_fyh_fechavista,
          alr_nom_usuariovista= @alr_nom_usuariovista,
          alr_nro_repetirendias= @alr_nro_repetirendias,
          alr_cd1_finalizada= @alr_cd1_finalizada,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where alr_nro_nroconfig = @alr_nro_nroconfig
      and alr_nro_nroalerta = @alr_nro_nroalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_DELETE
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Alertas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where alr_nro_nroconfig = @alr_nro_nroconfig
      and alr_nro_nroalerta = @alr_nro_nroalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_RECALL
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Alertas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where alr_nro_nroconfig = @alr_nro_nroconfig
      and alr_nro_nroalerta = @alr_nro_nroalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@alr_nro_nroconfig">Nro Config Alerta</param>
--- <param name="@alr_nro_nroalerta">Nro Alerta</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_DROP
(
@alr_nro_nroconfig tngs_numero,
@alr_nro_nroalerta tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Alertas
    where alr_nro_nroconfig = @alr_nro_nroconfig
      and alr_nro_nroalerta = @alr_nro_nroalerta

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ALERTAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Alertas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetAlertasFromMovil
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_GETALERTASFROMMOVIL'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_GETALERTASFROMMOVIL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_GETALERTASFROMMOVIL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_GETALERTASFROMMOVIL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select alr_nro_nroconfig,
          alr_nro_nroalerta,
          alr_des_descripcion,
          alr_d2x_detalle,
          alr_cd1_importancia,
          alr_fyh_fechadisparada,
          alr_fyh_fechavista,
          alr_nom_usuariovista,
          alr_nro_repetirendias,
          alr_cd1_finalizada,
          TNGS_Mrln..Alertas.instante,
          TNGS_Mrln..Alertas.deleted,
          TNGS_Mrln..Alertas.usuario,
          TNGS_Mrln..Alertas.version
     from TNGS_Mrln..Alertas 
   join MvlAlertas 
   on alr_nro_nroconfig = mal_nro_nroconfigalerta 
   where mal_ecd_patente = @patente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_GETALERTASFROMMOVIL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetPendientesFromMov
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ALERTAS_GETPENDIENTESFROMMOV'

if exists (select * from sysobjects where id = object_id('dbo.ALERTAS_GETPENDIENTESFROMMOV'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ALERTAS_GETPENDIENTESFROMMOV
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ALERTAS_GETPENDIENTESFROMMOV
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select alr_nro_nroconfig,
          alr_nro_nroalerta,
          alr_des_descripcion,
          alr_d2x_detalle,
          alr_cd1_importancia,
          alr_fyh_fechadisparada,
          alr_fyh_fechavista,
          alr_nom_usuariovista,
          alr_nro_repetirendias,
          alr_cd1_finalizada,
          TNGS_Mrln..Alertas.instante,
          TNGS_Mrln..Alertas.deleted,
          TNGS_Mrln..Alertas.usuario,
          TNGS_Mrln..Alertas.version
     from TNGS_Mrln..Alertas 
   join MvlAlertas 
   on alr_nro_nroconfig = mal_nro_nroconfigalerta 
   where mal_ecd_patente = @patente 
   and alr_cd1_finalizada <> 'S' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ALERTAS_GETPENDIENTESFROMMOV to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Alertas
//--------------------------------------------------------------------------*/
