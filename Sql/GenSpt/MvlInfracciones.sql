/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 27/06/2018 00:45
// Sistema     : Mrln
// Tabla       : MvlInfracciones
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

print 'Store Procedure: dbo.MVLINFRACCIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          where TNGS_Mrln..MvlInfracciones.deleted = 0
          order by mvi_ecd_patente,
                mvi_fyh_fecha
      end
   else
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          order by mvi_ecd_patente,
                mvi_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_CHKVERSION
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlInfracciones
    where mvi_ecd_patente = @mvi_ecd_patente
      and mvi_fyh_fecha = @mvi_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_SEARCH
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          where mvi_ecd_patente = @mvi_ecd_patente
            and mvi_fyh_fecha = @mvi_fyh_fecha
            and TNGS_Mrln..MvlInfracciones.deleted = 0
      end
   else
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          where mvi_ecd_patente = @mvi_ecd_patente
            and mvi_fyh_fecha = @mvi_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_FSEARCH
(
@mvi_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          where mvi_ecd_patente = @mvi_ecd_patente
            and TNGS_Mrln..MvlInfracciones.deleted = 0
          order by mvi_fyh_fecha
      end
   else
      begin
         Select mvi_ecd_patente,
                mvi_fyh_fecha,
                mvi_cod_codmotivo,
                mti_ede_descripcion as mif_motivo,
                mvi_ede_lugar,
                mvi_cd1_pagada,
                mvi_imp_importe,
                mvi_txt_comentario,
                mvi_cd1_anulada,
                TNGS_Mrln..MvlInfracciones.instante,
                TNGS_Mrln..MvlInfracciones.deleted,
                TNGS_Mrln..MvlInfracciones.usuario,
                TNGS_Mrln..MvlInfracciones.version
           from TNGS_Mrln..MvlInfracciones
                join TNGS_Mrln..MotivosInfracciones
                  on mvi_cod_codmotivo = mti_cod_codigo
          where mvi_ecd_patente = @mvi_ecd_patente
          order by mvi_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@mvi_cod_codmotivo">Motivo</param>
--- <param name="@mvi_ede_lugar">Lugar</param>
--- <param name="@mvi_cd1_pagada">Pagada</param>
--- <param name="@mvi_imp_importe">Importe</param>
--- <param name="@mvi_txt_comentario">Comentario</param>
--- <param name="@mvi_cd1_anulada">Anulada</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_INSERT
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@mvi_cod_codmotivo tngs_codigo,
@mvi_ede_lugar tngs_descripcion_e,
@mvi_cd1_pagada tngs_codigo_1,
@mvi_imp_importe tngs_importe,
@mvi_txt_comentario tngs_texto,
@mvi_cd1_anulada tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlInfracciones
   values (
           @mvi_ecd_patente,
           @mvi_fyh_fecha,
           @mvi_cod_codmotivo,
           @mvi_ede_lugar,
           @mvi_cd1_pagada,
           @mvi_imp_importe,
           @mvi_txt_comentario,
           @mvi_cd1_anulada,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@mvi_cod_codmotivo">Motivo</param>
--- <param name="@mvi_ede_lugar">Lugar</param>
--- <param name="@mvi_cd1_pagada">Pagada</param>
--- <param name="@mvi_imp_importe">Importe</param>
--- <param name="@mvi_txt_comentario">Comentario</param>
--- <param name="@mvi_cd1_anulada">Anulada</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_UPDATE
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@mvi_cod_codmotivo tngs_codigo,
@mvi_ede_lugar tngs_descripcion_e,
@mvi_cd1_pagada tngs_codigo_1,
@mvi_imp_importe tngs_importe,
@mvi_txt_comentario tngs_texto,
@mvi_cd1_anulada tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlInfracciones
      set mvi_cod_codmotivo= @mvi_cod_codmotivo,
          mvi_ede_lugar= @mvi_ede_lugar,
          mvi_cd1_pagada= @mvi_cd1_pagada,
          mvi_imp_importe= @mvi_imp_importe,
          mvi_txt_comentario= @mvi_txt_comentario,
          mvi_cd1_anulada= @mvi_cd1_anulada,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mvi_ecd_patente = @mvi_ecd_patente
      and mvi_fyh_fecha = @mvi_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_DELETE
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlInfracciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mvi_ecd_patente = @mvi_ecd_patente
      and mvi_fyh_fecha = @mvi_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_FDELETE
(
@mvi_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlInfracciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mvi_ecd_patente = @mvi_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_RECALL
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlInfracciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mvi_ecd_patente = @mvi_ecd_patente
      and mvi_fyh_fecha = @mvi_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_FRECALL
(
@mvi_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlInfracciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mvi_ecd_patente = @mvi_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlInfracciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mvi_ecd_patente = @mvi_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@mvi_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_DROP
(
@mvi_ecd_patente tngs_codigo_e,
@mvi_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlInfracciones
    where mvi_ecd_patente = @mvi_ecd_patente
      and mvi_fyh_fecha = @mvi_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_FDROP
(
@mvi_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlInfracciones
    where mvi_ecd_patente = @mvi_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLINFRACCIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlInfracciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mvi_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLINFRACCIONES_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLINFRACCIONES_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLINFRACCIONES_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLINFRACCIONES_FPACK
(
@mvi_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlInfracciones
    where mvi_ecd_patente = @mvi_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLINFRACCIONES_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlInfracciones
//--------------------------------------------------------------------------*/
