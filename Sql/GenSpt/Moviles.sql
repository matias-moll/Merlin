/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 21/11/2018 20:16
// Sistema     : Mrln
// Tabla       : Moviles
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
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                mov_ecd_nroploteado,
                mov_des_tipodemovil,
                TNGS_Mrln..Moviles.instante,
                TNGS_Mrln..Moviles.deleted,
                TNGS_Mrln..Moviles.usuario,
                TNGS_Mrln..Moviles.version
           from TNGS_Mrln..Moviles
          where deleted = 0
          order by mov_ecd_patente
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                mov_ecd_nroploteado,
                mov_des_tipodemovil,
                TNGS_Mrln..Moviles.instante,
                TNGS_Mrln..Moviles.deleted,
                TNGS_Mrln..Moviles.usuario,
                TNGS_Mrln..Moviles.version
           from TNGS_Mrln..Moviles
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Moviles
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
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                mov_ecd_nroploteado,
                mov_des_tipodemovil,
                TNGS_Mrln..Moviles.instante,
                TNGS_Mrln..Moviles.deleted,
                TNGS_Mrln..Moviles.usuario,
                TNGS_Mrln..Moviles.version
           from TNGS_Mrln..Moviles
          where mov_ecd_patente = @mov_ecd_patente
            and deleted = 0
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                mov_ecd_nroploteado,
                mov_des_tipodemovil,
                TNGS_Mrln..Moviles.instante,
                TNGS_Mrln..Moviles.deleted,
                TNGS_Mrln..Moviles.usuario,
                TNGS_Mrln..Moviles.version
           from TNGS_Mrln..Moviles
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
--- <param name="@mov_des_des">Descripcion</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@mov_ecd_nroploteado">Numero Ploteado</param>
--- <param name="@mov_des_tipodemovil">Tipo de Móvil</param>
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
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@mov_ecd_nroploteado tngs_codigo_e,
@mov_des_tipodemovil tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Moviles
   values (
           @mov_ecd_patente,
           @mov_des_des,
           @mov_txt_anot,
           @mov_des_nrochasis,
           @mov_des_nromotor,
           @mov_rcd_modelo,
           @mov_nro_aniofabric,
           @mov_cd1_propio,
           @mov_ecd_nroploteado,
           @mov_des_tipodemovil,
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
--- <param name="@mov_des_des">Descripcion</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@mov_ecd_nroploteado">Numero Ploteado</param>
--- <param name="@mov_des_tipodemovil">Tipo de Móvil</param>
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
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@mov_ecd_nroploteado tngs_codigo_e,
@mov_des_tipodemovil tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Moviles
      set mov_des_des= @mov_des_des,
          mov_txt_anot= @mov_txt_anot,
          mov_des_nrochasis= @mov_des_nrochasis,
          mov_des_nromotor= @mov_des_nromotor,
          mov_rcd_modelo= @mov_rcd_modelo,
          mov_nro_aniofabric= @mov_nro_aniofabric,
          mov_cd1_propio= @mov_cd1_propio,
          mov_ecd_nroploteado= @mov_ecd_nroploteado,
          mov_des_tipodemovil= @mov_des_tipodemovil,
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
--- Borra lógicamente un registro
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

   Update TNGS_Mrln..Moviles
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

   Update TNGS_Mrln..Moviles
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
--- Borra físicamente un registro
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

   Delete from TNGS_Mrln..Moviles
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Moviles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetHistorialFull
--- </summary>
--- <param name="@patente">Patente Movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_GETHISTORIALFULL'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_GETHISTORIALFULL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_GETHISTORIALFULL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_GETHISTORIALFULL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select	mco_fyh_fecha as rhi_fyh_fecha, 
   		'Combustibles' as rhi_des_tipo, 
   		'Litros: ' + CONVERT(varchar(10), mco_val_litros)  + ', Importe: ' + CONVERT(varchar(10), mco_imp_importe)  as rhi_xde_descripcion, 
   		GETDATE() as instante, 0.0 as deleted, '' as usuario, 1 as version 
   from	MvlCombustible 
   where	mco_ecd_patente = @patente 
    
   union 
    
   select	mve_fyh_fecha as rhi_fyh_fecha, 
   		'Estados' as rhi_des_tipo, 
   		 rtrim(ltrim(est_des_des)) + ', Kilometros: ' + CONVERT(varchar(10), mve_nro_km) as rhi_xde_descripcion, 
   		 GETDATE() as instante, 0.0 as deleted, '' as usuario, 1 as version 
   from	MvlEstados 
   join	Estados 
   	on	mve_rcd_codestado = est_rcd_cod 
   where	mve_ecd_patente = @patente 
    
   union 
    
   select  mkm_fyh_fecha as rhi_fyh_fecha, 
   		'Kilometros' as rhi_des_tipo, 
   		'Nuevo Valor: ' +  CONVERT(varchar(10), mkm_nro_km) as rhi_xde_descripcion, 
   		GETDATE() as instante, 0.0 as deleted, '' as usuario, 1 as version 
   from	MvlKilometros 
   where	mkm_ecd_patente = @patente 
    
   union 
    
   select  odt_fyh_fecapertura as rhi_fyh_fecha, 
   		'Orden de Trabajo' as rhi_des_tipo, 
   		case when oti_des_desoperacion <> oti_des_destarea then 
   		'Control ' + ltrim(rtrim(oti_des_desoperacion)) + ' : ' + ltrim(rtrim(oti_des_destarea)) + ' (' + ltrim(rtrim(oti_d20_estado)) + ')' else 
   		ltrim(rtrim(oti_des_destarea)) + ' (' + ltrim(rtrim(oti_d20_estado)) + ')' end as rhi_xde_descripcion, 
   		GETDATE() as instante, 0.0 as deleted, '' as usuario, 1 as version 
   from	OrdenesTrabajo 
   join	Moviles 
   	on	odt_ecd_patente = mov_ecd_patente 
   join	OTItems 
   	on	oti_nro_nroot = odt_nro_nro 
   where	odt_ecd_patente = @patente 
    
   order by 1 
    
    
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_GETHISTORIALFULL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetMovilesTree
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_GETMOVILESTREE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_GETMOVILESTREE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_GETMOVILESTREE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_GETMOVILESTREE
(
@usuario tngs_nombre
)
as
begin

   select mov_ecd_patente, 
   		mov_des_des, 
   		2 as Nivel, 
   		2 as Orden , 
   		1 as Imagen, 
   		2 as Niveles 
     		from TNGS_Mrln..Moviles 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_GETMOVILESTREE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZCostosPorMovil
--- </summary>
--- <param name="@fechaini">Fecha Inicial</param>
--- <param name="@fechafin">Fecha Final</param>
--- <param name="@patenteini">Patente Ini</param>
--- <param name="@patentefin">Patente Fin</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_ZCOSTOSPORMOVIL'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_ZCOSTOSPORMOVIL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_ZCOSTOSPORMOVIL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_ZCOSTOSPORMOVIL
(
@fechaini tngs_fecha,
@fechafin tngs_fecha,
@patenteini tngs_codigo_e,
@patentefin tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select * from ( 
    
   select	mco_ecd_patente as patente, 
   		Moviles.mov_des_des as movil, 
   		mco_fyh_fecha as fecha, 
   		'Combustible' as tipo, 
   		rtrim(ets_des_des) + ' : ' + CONVERT(varchar(4), mco_val_litros)  + 'litros' as descripcion, 
   		mco_imp_importe as importe 
   from MvlCombustible 
   join Moviles on mov_ecd_patente = mco_ecd_patente 
   join Estaciones on mco_rcd_codestacion = ets_rcd_cod 
    
   union 
    
   select	mvi_ecd_patente as patente, 
   		Moviles.mov_des_des as movil, 
   		mvi_fyh_fecha as fecha, 
   		'Infracción' as tipo, 
   		mti_ede_descripcion as descripcion, 
   		mvi_imp_importe as importe 
   from MvlInfracciones 
   join Moviles on mov_ecd_patente = mvi_ecd_patente 
   join MotivosInfracciones on mvi_cod_codmotivo = mti_cod_codigo 
    
   union 
    
   select	odt_ecd_patente as patente, 
   		Moviles.mov_des_des as movil, 
   		odt_fyh_feccierre as fecha, 
   		'Control/Reparación' as tipo, 
   		OtItems.oti_des_destarea as descripcion, 
   		oti_imp_importecierre as importe 
   from OrdenesTrabajo 
   join OTItems on odt_nro_nro = oti_nro_nroot 
   join Moviles on mov_ecd_patente = odt_ecd_patente 
    
   ) as result 
   where	fecha between @fechaini and @fechafin 
   and		patente between @patenteini and @patentefin 
   order by patente, fecha, tipo 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_ZCOSTOSPORMOVIL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZMovilesPorEstado
--- </summary>
--- <param name="@estadoini">Estado Inicial</param>
--- <param name="@estadofin">Estado Final</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_ZMOVILESPORESTADO'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_ZMOVILESPORESTADO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_ZMOVILESPORESTADO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_ZMOVILESPORESTADO
(
@estadoini tngs_descripcion,
@estadofin tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select	mov_ecd_patente, 
   		max(mov_des_des) as mov_des_des, 
   		TNGS_Mrln.dbo.MVLESTADOS_GETESTADOACTUAL(mov_ecd_patente) as est_des_des, 
   		max(mov_des_tipodemovil) as mov_des_tipodemovil, 
   		TNGS_Mrln.dbo.MVLKILOMETROS_GETKMACTUALMOVIL(mov_ecd_patente) as kmActual, 
   		max(mov_des_nrochasis) as mov_des_nrochasis, 
   		max(mov_des_nromotor) as mov_des_nromotor, 
   		max(mov_ecd_nroploteado) as mov_ecd_nroploteado 
   from Moviles 
   join	MvlEstados on mov_ecd_patente = mve_ecd_patente 
   join	Estados on est_rcd_cod = mve_rcd_codestado 
   where TNGS_Mrln.dbo.MVLESTADOS_GETESTADOACTUAL(mov_ecd_patente) between @estadoini and @estadofin 
   group by mov_ecd_patente 
   order by est_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_ZMOVILESPORESTADO to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Moviles
//--------------------------------------------------------------------------*/
