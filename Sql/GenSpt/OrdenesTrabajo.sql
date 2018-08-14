/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 14/08/2018 17:33
// Sistema     : Mrln
// Tabla       : OrdenesTrabajo
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

print 'Store Procedure: dbo.ORDENESTRABAJO_UP'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                odt_cod_codtaller,
                isnull(tll_ede_descripcion, '') as ot_taller,
                odt_d20_estado,
                odt_nro_kmsactuales,
                TNGS_Mrln..OrdenesTrabajo.instante,
                TNGS_Mrln..OrdenesTrabajo.deleted,
                TNGS_Mrln..OrdenesTrabajo.usuario,
                TNGS_Mrln..OrdenesTrabajo.version
           from TNGS_Mrln..OrdenesTrabajo
                left outer join TNGS_Mrln..Taller
                  on odt_cod_codtaller = tll_cod_codigo
          where TNGS_Mrln..OrdenesTrabajo.deleted = 0
          order by odt_nro_nro
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                odt_cod_codtaller,
                isnull(tll_ede_descripcion, '') as ot_taller,
                odt_d20_estado,
                odt_nro_kmsactuales,
                TNGS_Mrln..OrdenesTrabajo.instante,
                TNGS_Mrln..OrdenesTrabajo.deleted,
                TNGS_Mrln..OrdenesTrabajo.usuario,
                TNGS_Mrln..OrdenesTrabajo.version
           from TNGS_Mrln..OrdenesTrabajo
                left outer join TNGS_Mrln..Taller
                  on odt_cod_codtaller = tll_cod_codigo
          order by odt_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_CHKVERSION
(
@odt_nro_nro tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..OrdenesTrabajo
    where odt_nro_nro = @odt_nro_nro
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_SEARCH
(
@odt_nro_nro tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                odt_cod_codtaller,
                isnull(tll_ede_descripcion, '') as ot_taller,
                odt_d20_estado,
                odt_nro_kmsactuales,
                TNGS_Mrln..OrdenesTrabajo.instante,
                TNGS_Mrln..OrdenesTrabajo.deleted,
                TNGS_Mrln..OrdenesTrabajo.usuario,
                TNGS_Mrln..OrdenesTrabajo.version
           from TNGS_Mrln..OrdenesTrabajo
                left outer join TNGS_Mrln..Taller
                  on odt_cod_codtaller = tll_cod_codigo
          where odt_nro_nro = @odt_nro_nro
            and TNGS_Mrln..OrdenesTrabajo.deleted = 0
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                odt_cod_codtaller,
                isnull(tll_ede_descripcion, '') as ot_taller,
                odt_d20_estado,
                odt_nro_kmsactuales,
                TNGS_Mrln..OrdenesTrabajo.instante,
                TNGS_Mrln..OrdenesTrabajo.deleted,
                TNGS_Mrln..OrdenesTrabajo.usuario,
                TNGS_Mrln..OrdenesTrabajo.version
           from TNGS_Mrln..OrdenesTrabajo
                left outer join TNGS_Mrln..Taller
                  on odt_cod_codtaller = tll_cod_codigo
          where odt_nro_nro = @odt_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre</param>
--- <param name="@odt_cod_codtaller">Taller</param>
--- <param name="@odt_d20_estado">Estado</param>
--- <param name="@odt_nro_kmsactuales">Kms Movil</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_INSERT
(
@odt_nro_nro tngs_numero,
@odt_ecd_patente tngs_codigo_e,
@odt_fyh_fecapertura tngs_fecyhor,
@odt_nom_operador tngs_nombre,
@odt_fyh_feccierre tngs_fecyhor,
@odt_cod_codtaller tngs_codigo,
@odt_d20_estado tngs_descripcion_20,
@odt_nro_kmsactuales tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..OrdenesTrabajo
   values (
           @odt_nro_nro,
           @odt_ecd_patente,
           @odt_fyh_fecapertura,
           @odt_nom_operador,
           @odt_fyh_feccierre,
           @odt_cod_codtaller,
           @odt_d20_estado,
           @odt_nro_kmsactuales,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre</param>
--- <param name="@odt_cod_codtaller">Taller</param>
--- <param name="@odt_d20_estado">Estado</param>
--- <param name="@odt_nro_kmsactuales">Kms Movil</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_UPDATE
(
@odt_nro_nro tngs_numero,
@odt_ecd_patente tngs_codigo_e,
@odt_fyh_fecapertura tngs_fecyhor,
@odt_nom_operador tngs_nombre,
@odt_fyh_feccierre tngs_fecyhor,
@odt_cod_codtaller tngs_codigo,
@odt_d20_estado tngs_descripcion_20,
@odt_nro_kmsactuales tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OrdenesTrabajo
      set odt_ecd_patente= @odt_ecd_patente,
          odt_fyh_fecapertura= @odt_fyh_fecapertura,
          odt_nom_operador= @odt_nom_operador,
          odt_fyh_feccierre= @odt_fyh_feccierre,
          odt_cod_codtaller= @odt_cod_codtaller,
          odt_d20_estado= @odt_d20_estado,
          odt_nro_kmsactuales= @odt_nro_kmsactuales,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_DELETE
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OrdenesTrabajo
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_RECALL
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OrdenesTrabajo
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">Número OT</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_DROP
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OrdenesTrabajo
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ORDENESTRABAJO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..OrdenesTrabajo
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZFinalizadas
--- </summary>
--- <param name="@fechaini">Fecha inicio</param>
--- <param name="@fechafin">Fecha Fin</param>
--- <param name="@patenteini">Patente Inicio</param>
--- <param name="@patentefin">Patente Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_ZFINALIZADAS'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_ZFINALIZADAS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_ZFINALIZADAS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_ZFINALIZADAS
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@patenteini tngs_codigo_e,
@patentefin tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select  odt_nro_nro, 
   		odt_ecd_patente, 
   		max(mov_des_des) as movil, 
   		max(odt_fyh_fecapertura) as fapertura, 
   		max(odt_fyh_feccierre) as fcierre, 
   		max(tll_ede_descripcion) as taller, 
   		sum(oti_imp_importecierre) as total 
   from OrdenesTrabajo 
   join OtItems on odt_nro_nro = oti_nro_nroot 
   join Taller on tll_cod_codigo = odt_cod_codtaller 
   join Moviles on mov_ecd_patente = odt_ecd_patente 
   where odt_d20_estado = 'Finalizada' 
   and odt_fyh_feccierre between @fechaini and @fechafin 
   and odt_ecd_patente between @patenteini and @patentefin 
   group by odt_ecd_patente, odt_nro_nro 
   order by odt_ecd_patente, odt_nro_nro 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_ZFINALIZADAS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getPendByPatente
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_GETPENDBYPATENTE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_GETPENDBYPATENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_GETPENDBYPATENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_GETPENDBYPATENTE
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select odt_nro_nro,
          odt_ecd_patente,
          odt_fyh_fecapertura,
          odt_nom_operador,
          odt_fyh_feccierre,
          odt_cod_codtaller,
          isnull(tll_ede_descripcion, '') as ot_taller,
          odt_d20_estado,
          odt_nro_kmsactuales,
          TNGS_Mrln..OrdenesTrabajo.instante,
          TNGS_Mrln..OrdenesTrabajo.deleted,
          TNGS_Mrln..OrdenesTrabajo.usuario,
          TNGS_Mrln..OrdenesTrabajo.version
     from TNGS_Mrln..OrdenesTrabajo 
          left outer join TNGS_Mrln..Taller
            on odt_cod_codtaller = tll_cod_codigo
     where odt_ecd_patente = @patente and year(odt_fyh_feccierre) = 1900 
           and odt_d20_estado = 'Pendiente' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_GETPENDBYPATENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getPendientes
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_GETPENDIENTES'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_GETPENDIENTES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_GETPENDIENTES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_GETPENDIENTES
(
@usuario tngs_nombre
)
as
begin

   Select odt_nro_nro,
          odt_ecd_patente,
          odt_fyh_fecapertura,
          odt_nom_operador,
          odt_fyh_feccierre,
          odt_cod_codtaller,
          isnull(tll_ede_descripcion, '') as ot_taller,
          odt_d20_estado,
          odt_nro_kmsactuales,
          TNGS_Mrln..OrdenesTrabajo.instante,
          TNGS_Mrln..OrdenesTrabajo.deleted,
          TNGS_Mrln..OrdenesTrabajo.usuario,
          TNGS_Mrln..OrdenesTrabajo.version
     from TNGS_Mrln..OrdenesTrabajo 
          left outer join TNGS_Mrln..Taller
            on odt_cod_codtaller = tll_cod_codigo
     where year(odt_fyh_feccierre) = 1900 and odt_d20_estado = 'Pendiente' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_GETPENDIENTES to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
