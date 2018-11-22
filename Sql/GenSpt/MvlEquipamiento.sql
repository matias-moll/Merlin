/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 21/11/2018 20:16
// Sistema     : Mrln
// Tabla       : MvlEquipamiento
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

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where TNGS_Mrln..MvlEquipamiento.deleted = 0
          order by meq_ecd_patente,
                meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          order by meq_ecd_patente,
                meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_CHKVERSION
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_SEARCH
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and meq_cod_codequip = @meq_cod_codequip
            and TNGS_Mrln..MvlEquipamiento.deleted = 0
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and meq_cod_codequip = @meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FSEARCH
(
@meq_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and TNGS_Mrln..MvlEquipamiento.deleted = 0
          order by meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Mrln..MvlEquipamiento.instante,
                TNGS_Mrln..MvlEquipamiento.deleted,
                TNGS_Mrln..MvlEquipamiento.usuario,
                TNGS_Mrln..MvlEquipamiento.version
           from TNGS_Mrln..MvlEquipamiento
                join TNGS_Mrln..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
          order by meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@meq_cd1_esfijo">equipamiento es fijo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_INSERT
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@meq_cd1_esfijo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlEquipamiento
   values (
           @meq_ecd_patente,
           @meq_cod_codequip,
           @meq_cd1_esfijo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@meq_cd1_esfijo">equipamiento es fijo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_UPDATE
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@meq_cd1_esfijo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEquipamiento
      set meq_cd1_esfijo= @meq_cd1_esfijo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_DELETE
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEquipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FDELETE
(
@meq_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlEquipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_RECALL
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlEquipamiento
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FRECALL
(
@meq_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlEquipamiento
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where meq_ecd_patente = @meq_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlEquipamiento
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where meq_ecd_patente = @meq_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_DROP
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FDROP
(
@meq_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlEquipamiento
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FPACK
(
@meq_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: EliminarEquipamiento
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   DELETE FROM TNGS_Mrln..MvlEquipamiento 
   WHERE @patente=meq_ecd_patente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getEquipamientos
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 eqi_des_des 
    
   FROM TNGS_Mrln..MvlEquipamiento 
   JOIN TNGS_Mrln..Equipamiento 
   on meq_cod_codequip = eqi_cod_cod 
   WHERE meq_ecd_patente = @patente 
   ORDER BY eqi_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
