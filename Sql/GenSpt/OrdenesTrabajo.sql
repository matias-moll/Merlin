/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
<<<<<<< HEAD
// Fecha       : 28/10/2013 18:04
=======
// Fecha       : 31/10/2013 14:57
>>>>>>> 3a252f53020dd3b440332b25355995d4c9ecb060
// Sistema     : Rivn
// Tabla       : OrdenesTrabajo
//----------------------------------------------------------------------------
// � 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
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
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          where deleted = 0
          order by odt_nro_nro
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
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
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@version">N�mero de version a verificar</param>
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
     from TNGS_Rivn..OrdenesTrabajo
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
--- <param name="@odt_nro_nro">nro</param>
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
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          where odt_nro_nro = @odt_nro_nro
            and deleted = 0
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
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
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre.</param>
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
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..OrdenesTrabajo
   values (
           @odt_nro_nro,
           @odt_ecd_patente,
           @odt_fyh_fecapertura,
           @odt_nom_operador,
           @odt_fyh_feccierre,
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
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre.</param>
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
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OrdenesTrabajo
      set odt_ecd_patente= @odt_ecd_patente,
          odt_fyh_fecapertura= @odt_fyh_fecapertura,
          odt_nom_operador= @odt_nom_operador,
          odt_fyh_feccierre= @odt_fyh_feccierre,
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
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
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

   Update TNGS_Rivn..OrdenesTrabajo
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
--- <param name="@odt_nro_nro">nro</param>
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

   Update TNGS_Rivn..OrdenesTrabajo
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
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
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

   Delete from TNGS_Rivn..OrdenesTrabajo
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
--- Borra f�sicamente los registros borrados l�gicamente
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

   Delete TNGS_Rivn..OrdenesTrabajo
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
