/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Categorias
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

print 'Store Procedure: dbo.CATEGORIAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where deleted = 0
          order by cat_rcd_cod
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          order by cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_CHKVERSION
(
@cat_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Categorias
    where cat_rcd_cod = @cat_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_SEARCH
(
@cat_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where cat_rcd_cod = @cat_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where cat_rcd_cod = @cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@cat_des_des">descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_INSERT
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Categorias
   values (
           @cat_rcd_cod,
           @cat_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@cat_des_des">descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UPDATE
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set cat_des_des= @cat_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DELETE
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_RECALL
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DROP
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Categorias
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CATEGORIAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Categorias
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- M�todo Fijo: getByDesc
--- </summary>
--- <param name="@desc">.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_GETBYDESC
(
@desc tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select * from Categorias 
    
         where cat_des_des like '%' + ltrim(rtrim(@desc)) + '%' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Categorias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Controles
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

print 'Store Procedure: dbo.CONTROLES_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where deleted = 0
          order by ctl_cod_cod
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          order by ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_CHKVERSION
(
@ctl_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Controles
    where ctl_cod_cod = @ctl_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_SEARCH
(
@ctl_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where ctl_cod_cod = @ctl_cod_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where ctl_cod_cod = @ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Descripcion</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_INSERT
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Controles
   values (
           @ctl_cod_cod,
           @ctl_des_des,
           @ctl_cd1_crit,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Descripcion</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UPDATE
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set ctl_des_des= @ctl_des_des,
          ctl_cd1_crit= @ctl_cd1_crit,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DELETE
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_RECALL
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DROP
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Controles
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.CONTROLES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Controles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Controles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : ControlesReparations
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

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where TNGS_Rivn..ControlesReparations.deleted = 0
          order by ctr_cod_codctl
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          order by ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_CHKVERSION
(
@ctr_cod_codctl tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_SEARCH
(
@ctr_cod_codctl tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Rivn..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FSEARCH
(
@ctr_cod_codctl tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Rivn..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@ctr_nro_nroitem">item</param>
--- <param name="@ctr_cd6_codrep">codigoReparacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_INSERT
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..ControlesReparations
   values (
           @ctr_cod_codctl,
           @ctr_nro_nroitem,
           @ctr_cd6_codrep,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@ctr_nro_nroitem">item</param>
--- <param name="@ctr_cd6_codrep">codigoReparacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UPDATE
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set ctr_nro_nroitem= @ctr_nro_nroitem,
          ctr_cd6_codrep= @ctr_cd6_codrep,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DELETE
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro por clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDELETE
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_RECALL
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera l�gicamente los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FRECALL
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
      end
   else
      begin
         Update TNGS_Rivn..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DROP
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro por clave for�nea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDROP
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.CONTROLESREPARATIONS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..ControlesReparations
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FPACK
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Equipamiento
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

print 'Store Procedure: dbo.EQUIPAMIENTO_UP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where deleted = 0
          order by eqi_cod_cod
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          order by eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_CHKVERSION
(
@eqi_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_SEARCH
(
@eqi_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
            and deleted = 0
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@eqi_des_des">des</param>
--- <param name="@eqi_imp_valor">valor</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_INSERT
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Equipamiento
   values (
           @eqi_cod_cod,
           @eqi_des_des,
           @eqi_imp_valor,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@eqi_des_des">des</param>
--- <param name="@eqi_imp_valor">valor</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UPDATE
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set eqi_des_des= @eqi_des_des,
          eqi_imp_valor= @eqi_imp_valor,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DELETE
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_RECALL
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DROP
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DROP to tngsmodulos

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

print 'Store Procedure: dbo.EQUIPAMIENTO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Equipamiento
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Estados
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

print 'Store Procedure: dbo.ESTADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where deleted = 0
          order by est_rcd_cod
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          order by est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_CHKVERSION
(
@est_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Estados
    where est_rcd_cod = @est_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_SEARCH
(
@est_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where est_rcd_cod = @est_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where est_rcd_cod = @est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@est_des_des">des</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_INSERT
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Estados
   values (
           @est_rcd_cod,
           @est_des_des,
           @est_txt_txtcontingencia,
           @est_cd1_operativo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@est_des_des">des</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UPDATE
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set est_des_des= @est_des_des,
          est_txt_txtcontingencia= @est_txt_txtcontingencia,
          est_cd1_operativo= @est_cd1_operativo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DELETE
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_RECALL
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DROP
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Estados
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Estados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Marcas
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

print 'Store Procedure: dbo.MARCAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where deleted = 0
          order by mrc_rcd_codigo
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          order by mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_CHKVERSION
(
@mrc_rcd_codigo tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_SEARCH
(
@mrc_rcd_codigo tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave m�xima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mrc_rcd_codigo), '0') as mrc_rcd_codigo
     from TNGS_Rivn..Marcas

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@mrc_des_descripcion">des</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_INSERT
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Marcas
   values (
           @mrc_rcd_codigo,
           @mrc_des_descripcion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@mrc_des_descripcion">des</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UPDATE
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set mrc_des_descripcion= @mrc_des_descripcion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DELETE
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_RECALL
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DROP
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MARCAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Marcas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Modelos
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

print 'Store Procedure: dbo.MODELOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where deleted = 0
          order by mds_rcd_cod
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          order by mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_CHKVERSION
(
@mds_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_SEARCH
(
@mds_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave m�xima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mds_rcd_cod), '0') as mds_rcd_cod
     from TNGS_Rivn..Modelos

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@mds_des_des">descripcion</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_INSERT
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Modelos
   values (
           @mds_rcd_cod,
           @mds_des_des,
           @mds_rcd_codmarca,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@mds_des_des">descripcion</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UPDATE
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set mds_des_des= @mds_des_des,
          mds_rcd_codmarca= @mds_rcd_codmarca,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DELETE
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_RECALL
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DROP
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MODELOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Modelos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Modelos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Moviles
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

print 'Store Procedure: dbo.MOVILES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where deleted = 0
          order by mov_ecd_patente
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          order by mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_CHKVERSION
(
@mov_ecd_patente tngs_codigo_e,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_SEARCH
(
@mov_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
            and deleted = 0
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_rcd_estado,
                mov_nro_kms,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">des</param>
--- <param name="@mov_rcd_estado">estado</param>
--- <param name="@mov_nro_kms">Kilometros</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">A�o de fabricaci�n</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_INSERT
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_rcd_estado tngs_codigo_r,
@mov_nro_kms tngs_numero,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Moviles
   values (
           @mov_ecd_patente,
           @mov_des_des,
           @mov_rcd_estado,
           @mov_nro_kms,
           @mov_txt_anot,
           @mov_des_nrochasis,
           @mov_des_nromotor,
           @mov_rcd_modelo,
           @mov_nro_aniofabric,
           @mov_cd1_propio,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">des</param>
--- <param name="@mov_rcd_estado">estado</param>
--- <param name="@mov_nro_kms">Kilometros</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">A�o de fabricaci�n</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UPDATE
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_rcd_estado tngs_codigo_r,
@mov_nro_kms tngs_numero,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set mov_des_des= @mov_des_des,
          mov_rcd_estado= @mov_rcd_estado,
          mov_nro_kms= @mov_nro_kms,
          mov_txt_anot= @mov_txt_anot,
          mov_des_nrochasis= @mov_des_nrochasis,
          mov_des_nromotor= @mov_des_nromotor,
          mov_rcd_modelo= @mov_rcd_modelo,
          mov_nro_aniofabric= @mov_nro_aniofabric,
          mov_cd1_propio= @mov_cd1_propio,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DELETE
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_RECALL
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DROP
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MOVILES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Moviles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Moviles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : MvlEquipamiento
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
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
          where deleted = 0
          order by meq_ecd_patente,
                meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
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
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@version">N�mero de version a verificar</param>
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
     from TNGS_Rivn..MvlEquipamiento
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
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
          where meq_ecd_patente = @meq_ecd_patente
            and meq_cod_codequip = @meq_cod_codequip
            and deleted = 0
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
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
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
          where meq_ecd_patente = @meq_ecd_patente
            and deleted = 0
          order by meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
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
--- <param name="@meq_cd1_esfijo">Es fijo o no.</param>
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

   Insert into TNGS_Rivn..MvlEquipamiento
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
--- <param name="@meq_cd1_esfijo">Es fijo o no.</param>
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

   Update TNGS_Rivn..MvlEquipamiento
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
--- Borra l�gicamente un registro
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

   Update TNGS_Rivn..MvlEquipamiento
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
--- Borra l�gicamente un registro por clave foranea
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

   Update TNGS_Rivn..MvlEquipamiento
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

   Update TNGS_Rivn..MvlEquipamiento
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
--- Recupera l�gicamente los registros de una clave foranea
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
         Update TNGS_Rivn..MvlEquipamiento
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where meq_ecd_patente = @meq_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlEquipamiento
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
--- Borra f�sicamente un registro
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

   Delete from TNGS_Rivn..MvlEquipamiento
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
--- Borra f�sicamente un registro por clave for�nea
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

   Delete from TNGS_Rivn..MvlEquipamiento
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
--- Borra f�sicamente los registros borrados l�gicamente
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

   Delete TNGS_Rivn..MvlEquipamiento
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
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
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

   Delete from TNGS_Rivn..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@version">N�mero de version a verificar</param>
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
     from TNGS_Rivn..MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
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

   Insert into TNGS_Rivn..MvlEstados
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

   Update TNGS_Rivn..MvlEstados
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
--- Borra l�gicamente un registro
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

   Update TNGS_Rivn..MvlEstados
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
--- Borra l�gicamente un registro por clave foranea
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

   Update TNGS_Rivn..MvlEstados
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

   Update TNGS_Rivn..MvlEstados
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
--- Recupera l�gicamente los registros de una clave foranea
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
         Update TNGS_Rivn..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlEstados
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
--- Borra f�sicamente un registro
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

   Delete from TNGS_Rivn..MvlEstados
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
--- Borra f�sicamente un registro por clave for�nea
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

   Delete from TNGS_Rivn..MvlEstados
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
--- Borra f�sicamente los registros borrados l�gicamente
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

   Delete TNGS_Rivn..MvlEstados
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
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
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

   Delete from TNGS_Rivn..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
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
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_FSEARCH
(
@odt_ecd_patente tngs_codigo_e,
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
          where odt_ecd_patente = @odt_ecd_patente
            and deleted = 0
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
          where odt_ecd_patente = @odt_ecd_patente
          order by odt_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave m�xima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(odt_nro_nro), '0') as odt_nro_nro
     from TNGS_Rivn..OrdenesTrabajo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_GETMAXKEY to tngsmodulos

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
--- Borra l�gicamente un registro por clave foranea
--- </summary>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_FDELETE
(
@odt_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..OrdenesTrabajo
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where odt_ecd_patente = @odt_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_FDELETE to tngsmodulos

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
--- Recupera l�gicamente los registros de una clave foranea
--- </summary>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_FRECALL
(
@odt_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..OrdenesTrabajo
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where odt_ecd_patente = @odt_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..OrdenesTrabajo
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where odt_ecd_patente = @odt_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_FRECALL to tngsmodulos

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
--- Borra f�sicamente un registro por clave for�nea
--- </summary>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_FDROP
(
@odt_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OrdenesTrabajo
    where odt_ecd_patente = @odt_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_FDROP to tngsmodulos

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

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
--- </summary>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_FPACK
(
@odt_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OrdenesTrabajo
    where odt_ecd_patente = @odt_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : OtItems
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

print 'Store Procedure: dbo.OTITEMS_UP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where deleted = 0
          order by oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          order by oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_CHKVERSION
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..OtItems
    where oti_nro_nro = @oti_nro_nro
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_SEARCH
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nro = @oti_nro_nro
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
            and deleted = 0
      end
   else
      begin
         Select oti_nro_nro,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nro = @oti_nro_nro
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripci�n de la operaci�n.</param>
--- <param name="@oti_des_destarea">Descripci�n de la tarea</param>
--- <param name="@oti_des_descategoria">Descripci�n de la categor�a.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_INSERT
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..OtItems
   values (
           @oti_nro_nro,
           @oti_nro_nroagrupador,
           @oti_nro_nroitem,
           @oti_des_desoperacion,
           @oti_des_destarea,
           @oti_des_descategoria,
           @oti_imp_importe,
           @oti_ede_comentario,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripci�n de la operaci�n.</param>
--- <param name="@oti_des_destarea">Descripci�n de la tarea</param>
--- <param name="@oti_des_descategoria">Descripci�n de la categor�a.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UPDATE
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set oti_des_desoperacion= @oti_des_desoperacion,
          oti_des_destarea= @oti_des_destarea,
          oti_des_descategoria= @oti_des_descategoria,
          oti_imp_importe= @oti_imp_importe,
          oti_ede_comentario= @oti_ede_comentario,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DELETE
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_RECALL
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nro = @oti_nro_nro
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@oti_nro_nro">nro</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DROP
(
@oti_nro_nro tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OtItems
    where oti_nro_nro = @oti_nro_nro
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.OTITEMS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..OtItems
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OtItems
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Parametros
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

print 'Store Procedure: dbo.PARAMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where deleted = 0
          order by par_xcd_codigo
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          order by par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_CHKVERSION
(
@par_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Parametros
    where par_xcd_codigo = @par_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_SEARCH
(
@par_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where par_xcd_codigo = @par_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where par_xcd_codigo = @par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@par_des_descripcion">Descripci�n</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">S�lo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_INSERT
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Parametros
   values (
           @par_xcd_codigo,
           @par_des_descripcion,
           @par_xde_valor,
           @par_est_editable,
           @par_est_sololectura,
           @par_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@par_des_descripcion">Descripci�n</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">S�lo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UPDATE
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set par_des_descripcion= @par_des_descripcion,
          par_xde_valor= @par_xde_valor,
          par_est_editable= @par_est_editable,
          par_est_sololectura= @par_est_sololectura,
          par_rob_detalle= @par_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DELETE
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_RECALL
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DROP
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Parametros
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.PARAMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Parametros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Reparaciones
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

print 'Store Procedure: dbo.REPARACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_CHKVERSION
(
@rep_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_SEARCH
(
@rep_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
            and TNGS_Rivn..Reparaciones.deleted = 0
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FSEARCH
(
@rep_rcd_cat tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
            and TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_INSERT
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Reparaciones
   values (
           @rep_cd6_cod,
           @rep_xde_des,
           @rep_rcd_cat,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UPDATE
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set rep_xde_des= @rep_xde_des,
          rep_rcd_cat= @rep_rcd_cat,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DELETE
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro por clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDELETE
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_RECALL
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera l�gicamente los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FRECALL
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
      end
   else
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DROP
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro por clave for�nea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDROP
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.REPARACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Reparaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente los registro borrados l�gicamente por clave for�nea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FPACK
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- M�todo Fijo: Getbydesc
--- </summary>
--- <param name="@des">Levanta descripciones de las reparaciones.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_GETBYDESC
(
@des tngs_descripcion_10,
@usuario tngs_nombre
)
as
begin

   select * from Reparaciones 
   where rep_xde_des like '%' + rtrim(@des) + '%' 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 18/10/2013 15:51
// Sistema     : Rivn
// Tabla       : Talonarios
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

print 'Store Procedure: dbo.TALONARIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where deleted = 0
          order by tal_xcd_codigo
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          order by tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el n�mero de versi�n de un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@version">N�mero de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_CHKVERSION
(
@tal_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_SEARCH
(
@tal_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where tal_xcd_codigo = @tal_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where tal_xcd_codigo = @tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@tal_des_descripcion">Descripci�n</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">N�mero</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_INSERT
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Talonarios
   values (
           @tal_xcd_codigo,
           @tal_des_descripcion,
           @tal_cd1_tipo,
           @tal_nro_valor,
           @tal_fyh_referencia,
           @tal_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@tal_des_descripcion">Descripci�n</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">N�mero</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UPDATE
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set tal_des_descripcion= @tal_des_descripcion,
          tal_cd1_tipo= @tal_cd1_tipo,
          tal_nro_valor= @tal_nro_valor,
          tal_fyh_referencia= @tal_fyh_referencia,
          tal_rob_detalle= @tal_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra l�gicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DELETE
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_RECALL
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra f�sicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">C�digo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DROP
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TALONARIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Talonarios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Talonarios
//--------------------------------------------------------------------------*/
