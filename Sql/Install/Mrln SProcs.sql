/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
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

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getModelo
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MOVILES_GETMODELO'

if exists (select * from sysobjects where id = object_id('MOVILES_GETMODELO'))
begin
   print '       - Borrando la vieja Función'
   drop function MOVILES_GETMODELO
end
go

print '       - Creando la nueva Función'
go

create function MOVILES_GETMODELO
(
@patente tngs_codigo_e
)
returns char(30)
as
begin

   DECLARE @retval char(30) 
    
   select @retval = mds_des_des 
   from Modelos 
   join Moviles 
   on mds_rcd_cod = mov_rcd_modelo 
   where mov_ecd_patente = @patente 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MOVILES_GETMODELO to tngsmodulos
grant execute on MOVILES_GETMODELO to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: Moviles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
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

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getCountFromMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLACCIDENTES_GETCOUNTFROMMOVIL'

if exists (select * from sysobjects where id = object_id('MVLACCIDENTES_GETCOUNTFROMMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLACCIDENTES_GETCOUNTFROMMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLACCIDENTES_GETCOUNTFROMMOVIL
(
@patente tngs_codigo_e
)
returns int
as
begin

   DECLARE @retval int 
    
   SELECT @retval = count(*) 
   FROM MvlAccidentes 
   WHERE mva_ecd_patente = @patente 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLACCIDENTES_GETCOUNTFROMMOVIL to tngsmodulos
grant execute on MVLACCIDENTES_GETCOUNTFROMMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlAccidentes
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
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

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getCountFromMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLALERTAS_GETCOUNTFROMMOVIL'

if exists (select * from sysobjects where id = object_id('MVLALERTAS_GETCOUNTFROMMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLALERTAS_GETCOUNTFROMMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLALERTAS_GETCOUNTFROMMOVIL
(
@patente tngs_codigo_e
)
returns int
as
begin

   DECLARE @retval int 
    
   SELECT @retval = count(*) 
   FROM MvlAlertas 
   WHERE mal_ecd_patente = @patente 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLALERTAS_GETCOUNTFROMMOVIL to tngsmodulos
grant execute on MVLALERTAS_GETCOUNTFROMMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlAlertas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
// Sistema     : Mrln
// Tabla       : MvlCombustible
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getEstacion
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@fecha">Fecha y Hora</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLCOMBUSTIBLE_GETESTACION'

if exists (select * from sysobjects where id = object_id('MVLCOMBUSTIBLE_GETESTACION'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLCOMBUSTIBLE_GETESTACION
end
go

print '       - Creando la nueva Función'
go

create function MVLCOMBUSTIBLE_GETESTACION
(
@patente tngs_codigo_e,
@fecha tngs_fecyhor
)
returns char(30)
as
begin

   DECLARE @retval char(30) 
    
   select @retval = ets_des_des 
   from Estaciones 
   join MvlCombustible 
   on mco_rcd_codestacion = ets_rcd_cod 
   where mco_ecd_patente = @patente and mco_fyh_fecha = @fecha 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLCOMBUSTIBLE_GETESTACION to tngsmodulos
grant execute on MVLCOMBUSTIBLE_GETESTACION to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getTotal1AnioMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL'

if exists (select * from sysobjects where id = object_id('MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL
(
@patente tngs_codigo_e
)
returns decimal
as
begin

   DECLARE @retval decimal 
    
   SELECT @retval = Sum(mco_imp_importe) 
   FROM MvlCombustible 
   WHERE mco_ecd_patente = @patente 
   and mco_fyh_fecha between DATEADD(MONTH, -12, GETDATE()) and GETDATE() 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL to tngsmodulos
grant execute on MVLCOMBUSTIBLE_GETTOTAL1ANIOMOVIL to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getTotal1MesMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL'

if exists (select * from sysobjects where id = object_id('MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL
(
@patente tngs_codigo_e
)
returns decimal
as
begin

   DECLARE @retval decimal 
    
   SELECT @retval = Sum(mco_imp_importe) 
   FROM MvlCombustible 
   WHERE mco_ecd_patente = @patente 
   and mco_fyh_fecha between DATEADD(MONTH, -1, GETDATE()) and GETDATE() 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL to tngsmodulos
grant execute on MVLCOMBUSTIBLE_GETTOTAL1MESMOVIL to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getTotal6MesesMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL'

if exists (select * from sysobjects where id = object_id('MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL
(
@patente tngs_codigo_e
)
returns decimal
as
begin

   DECLARE @retval decimal 
    
   SELECT @retval = Sum(mco_imp_importe) 
   FROM MvlCombustible 
   WHERE mco_ecd_patente = @patente 
   and mco_fyh_fecha between DATEADD(MONTH, -6, GETDATE()) and GETDATE() 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL to tngsmodulos
grant execute on MVLCOMBUSTIBLE_GETTOTAL6MESESMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
// Sistema     : Mrln
// Tabla       : MvlEstados
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getEstadoActual
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLESTADOS_GETESTADOACTUAL'

if exists (select * from sysobjects where id = object_id('MVLESTADOS_GETESTADOACTUAL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLESTADOS_GETESTADOACTUAL
end
go

print '       - Creando la nueva Función'
go

create function MVLESTADOS_GETESTADOACTUAL
(
@patente tngs_codigo_e
)
returns char(30)
as
begin

   DECLARE @retval char(30) 
    
   select @retval = est_des_des 
   from Moviles mv 
   join MvlEstados mve1 
   on mov_ecd_patente = mve_ecd_patente 
   -- Joineamos con la misma tabla para filtrar que traiga solo el ultimo estado (fecha sea maxima) 
   inner join ( 
   	select mve2.mve_ecd_patente, max(mve2.mve_fyh_fecha) as maxfecha from MvlEstados mve2 group by mve2.mve_ecd_patente 
   ) b on mve1.mve_ecd_patente = b.mve_ecd_patente and mve1.mve_fyh_fecha = b.maxfecha 
   join Estados 
   on est_rcd_cod = mve1.mve_rcd_codestado 
   where mve1.mve_ecd_patente = @patente 
   group by est_des_des 
    
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLESTADOS_GETESTADOACTUAL to tngsmodulos
grant execute on MVLESTADOS_GETESTADOACTUAL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
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

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getCountFromMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLINFRACCIONES_GETCOUNTFROMMOVIL'

if exists (select * from sysobjects where id = object_id('MVLINFRACCIONES_GETCOUNTFROMMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLINFRACCIONES_GETCOUNTFROMMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLINFRACCIONES_GETCOUNTFROMMOVIL
(
@patente tngs_codigo_e
)
returns int
as
begin

   DECLARE @retval int 
    
   SELECT @retval = count(*) 
   FROM MvlInfracciones 
   WHERE mvi_ecd_patente = @patente 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLINFRACCIONES_GETCOUNTFROMMOVIL to tngsmodulos
grant execute on MVLINFRACCIONES_GETCOUNTFROMMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlInfracciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
// Sistema     : Mrln
// Tabla       : MvlKilometros
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getKmActualMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLKILOMETROS_GETKMACTUALMOVIL'

if exists (select * from sysobjects where id = object_id('MVLKILOMETROS_GETKMACTUALMOVIL'))
begin
   print '       - Borrando la vieja Función'
   drop function MVLKILOMETROS_GETKMACTUALMOVIL
end
go

print '       - Creando la nueva Función'
go

create function MVLKILOMETROS_GETKMACTUALMOVIL
(
@patente tngs_codigo_e
)
returns int
as
begin

   DECLARE @retval int 
    
   SELECT @retval = max(mkm_nro_km) 
   FROM MvlKilometros 
   WHERE mkm_ecd_patente = @patente 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on MVLKILOMETROS_GETKMACTUALMOVIL to tngsmodulos
grant execute on MVLKILOMETROS_GETKMACTUALMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
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

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getImporteCierreItms
--- </summary>
--- <param name="@nroorden">Numero de Orden</param>
---
---////////////////////////////////////////////////////////

print 'Function: ORDENESTRABAJO_GETIMPORTECIERREITMS'

if exists (select * from sysobjects where id = object_id('ORDENESTRABAJO_GETIMPORTECIERREITMS'))
begin
   print '       - Borrando la vieja Función'
   drop function ORDENESTRABAJO_GETIMPORTECIERREITMS
end
go

print '       - Creando la nueva Función'
go

create function ORDENESTRABAJO_GETIMPORTECIERREITMS
(
@nroorden tngs_numero
)
returns decimal
as
begin

   DECLARE @retval decimal 
    
   select @retval = sum(oti_imp_importecierre) 
   from OrdenesTrabajo 
   join OtItems 
   on oti_nro_nroot = odt_nro_nro 
   where odt_nro_nro = @nroorden 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on ORDENESTRABAJO_GETIMPORTECIERREITMS to tngsmodulos
grant execute on ORDENESTRABAJO_GETIMPORTECIERREITMS to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : getImporteItems
--- </summary>
--- <param name="@nroorden">Numero de Orden</param>
---
---////////////////////////////////////////////////////////

print 'Function: ORDENESTRABAJO_GETIMPORTEITEMS'

if exists (select * from sysobjects where id = object_id('ORDENESTRABAJO_GETIMPORTEITEMS'))
begin
   print '       - Borrando la vieja Función'
   drop function ORDENESTRABAJO_GETIMPORTEITEMS
end
go

print '       - Creando la nueva Función'
go

create function ORDENESTRABAJO_GETIMPORTEITEMS
(
@nroorden tngs_numero
)
returns decimal
as
begin

   DECLARE @retval decimal 
    
   select @retval = sum(oti_imp_importe) 
   from OrdenesTrabajo 
   join OtItems 
   on oti_nro_nroot = odt_nro_nro 
   where odt_nro_nro = @nroorden 
    
   return @retval 

end
go

print '       - Asignando permisos a la Función'

grant execute on ORDENESTRABAJO_GETIMPORTEITEMS to tngsmodulos
grant execute on ORDENESTRABAJO_GETIMPORTEITEMS to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
-- View para retornar los moviles activos para el CEDI. Solo devuelve la patente.

use TNGS_Mrln
go

print 'View : dbo.CediMovilesActivosV1'

if exists (select * from sysobjects where id = object_id('dbo.CediMovilesActivosV1'))
begin
   print '       - Borrando la vieja confiable view'
   drop view dbo.CediMovilesActivosV1
end
go

print '       - Creando la nueva view'
go

CREATE VIEW dbo.CediMovilesActivosV1 AS
select	mv.mov_ecd_patente as patente
from Moviles mv
join MvlEstados mve1
on mov_ecd_patente = mve_ecd_patente
-- Joineamos con la misma tabla para filtrar que traiga solo el ultimo estado (fecha sea maxima)
inner join (
	select mve2.mve_ecd_patente, max(mve2.mve_fyh_fecha) as maxfecha from MvlEstados mve2 group by mve2.mve_ecd_patente
) b on mve1.mve_ecd_patente = b.mve_ecd_patente and mve1.mve_fyh_fecha = b.maxfecha 
join Estados 
on est_rcd_cod = mve1.mve_rcd_codestado
group by mov_ecd_patente, est_cd1_operativo
having est_cd1_operativo = 'S'

go

grant select on dbo.CediMovilesActivosV1 to tngsmodulos

go

print ' '
go

/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Categorias
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
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          where deleted = 0
          order by cat_rcd_cod
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Categorias
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
          where cat_rcd_cod = @cat_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Mrln..Categorias.instante,
                TNGS_Mrln..Categorias.deleted,
                TNGS_Mrln..Categorias.usuario,
                TNGS_Mrln..Categorias.version
           from TNGS_Mrln..Categorias
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(cat_rcd_cod), '0') as cat_rcd_cod
     from TNGS_Mrln..Categorias

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
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

   Insert into TNGS_Mrln..Categorias
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
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

   Update TNGS_Mrln..Categorias
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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

   Update TNGS_Mrln..Categorias
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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

   Update TNGS_Mrln..Categorias
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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

   Delete from TNGS_Mrln..Categorias
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Categorias
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
--- Método Fijo: getByDesc
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Controles
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
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          where deleted = 0
          order by ctl_cod_cod
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Controles
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
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
          where ctl_cod_cod = @ctl_cod_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Mrln..Controles.instante,
                TNGS_Mrln..Controles.deleted,
                TNGS_Mrln..Controles.usuario,
                TNGS_Mrln..Controles.version
           from TNGS_Mrln..Controles
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ctl_cod_cod), '0') as ctl_cod_cod
     from TNGS_Mrln..Controles

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Control</param>
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

   Insert into TNGS_Mrln..Controles
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
--- <param name="@ctl_des_des">Control</param>
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

   Update TNGS_Mrln..Controles
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
--- Borra lógicamente un registro
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

   Update TNGS_Mrln..Controles
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

   Update TNGS_Mrln..Controles
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
--- Borra físicamente un registro
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

   Delete from TNGS_Mrln..Controles
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Controles
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : ControlesReparations
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
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where TNGS_Mrln..ControlesReparations.deleted = 0
          order by ctr_cod_codctl,
                ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          order by ctr_cod_codctl,
                ctr_nro_nroitem
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@version">Número de version a verificar</param>
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
@ctr_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
            and TNGS_Mrln..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Mrln..ControlesReparations.deleted = 0
          order by ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Mrln..ControlesReparations.instante,
                TNGS_Mrln..ControlesReparations.deleted,
                TNGS_Mrln..ControlesReparations.usuario,
                TNGS_Mrln..ControlesReparations.version
           from TNGS_Mrln..ControlesReparations
                join TNGS_Mrln..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
          order by ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
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

   Insert into TNGS_Mrln..ControlesReparations
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
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

   Update TNGS_Mrln..ControlesReparations
      set ctr_cd6_codrep= @ctr_cd6_codrep,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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

   Update TNGS_Mrln..ControlesReparations
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..ControlesReparations
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
         Update TNGS_Mrln..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
      end
   else
      begin
         Update TNGS_Mrln..ControlesReparations
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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

   Delete from TNGS_Mrln..ControlesReparations
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..ControlesReparations
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
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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

   Delete from TNGS_Mrln..ControlesReparations
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : DestinatariosMails
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

print 'Store Procedure: dbo.DESTINATARIOSMAILS_UP'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where deleted = 0
          order by dem_cod_codigo
      end
   else
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          order by dem_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_CHKVERSION
(
@dem_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..DestinatariosMails
    where dem_cod_codigo = @dem_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_SEARCH
(
@dem_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where dem_cod_codigo = @dem_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select dem_cod_codigo,
                dem_des_descripcion,
                dem_txt_destinatarios,
                TNGS_Mrln..DestinatariosMails.instante,
                TNGS_Mrln..DestinatariosMails.deleted,
                TNGS_Mrln..DestinatariosMails.usuario,
                TNGS_Mrln..DestinatariosMails.version
           from TNGS_Mrln..DestinatariosMails
          where dem_cod_codigo = @dem_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(dem_cod_codigo), '0') as dem_cod_codigo
     from TNGS_Mrln..DestinatariosMails

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@dem_des_descripcion">Descripción</param>
--- <param name="@dem_txt_destinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_INSERT
(
@dem_cod_codigo tngs_codigo,
@dem_des_descripcion tngs_descripcion,
@dem_txt_destinatarios tngs_texto,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..DestinatariosMails
   values (
           @dem_cod_codigo,
           @dem_des_descripcion,
           @dem_txt_destinatarios,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@dem_des_descripcion">Descripción</param>
--- <param name="@dem_txt_destinatarios">Destinatarios</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_UPDATE
(
@dem_cod_codigo tngs_codigo,
@dem_des_descripcion tngs_descripcion,
@dem_txt_destinatarios tngs_texto,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set dem_des_descripcion= @dem_des_descripcion,
          dem_txt_destinatarios= @dem_txt_destinatarios,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_DELETE
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_RECALL
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..DestinatariosMails
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@dem_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.DESTINATARIOSMAILS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_DROP
(
@dem_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..DestinatariosMails
    where dem_cod_codigo = @dem_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.DESTINATARIOSMAILS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.DESTINATARIOSMAILS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.DESTINATARIOSMAILS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.DESTINATARIOSMAILS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..DestinatariosMails
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.DESTINATARIOSMAILS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: DestinatariosMails
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 27/06/2018 00:45
// Sistema     : Mrln
// Tabla       : Encargados
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

print 'Store Procedure: dbo.ENCARGADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where deleted = 0
          order by enc_cod_cod
      end
   else
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          order by enc_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_CHKVERSION
(
@enc_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Encargados
    where enc_cod_cod = @enc_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_SEARCH
(
@enc_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where enc_cod_cod = @enc_cod_cod
            and deleted = 0
      end
   else
      begin
         Select enc_cod_cod,
                enc_des_des,
                TNGS_Mrln..Encargados.instante,
                TNGS_Mrln..Encargados.deleted,
                TNGS_Mrln..Encargados.usuario,
                TNGS_Mrln..Encargados.version
           from TNGS_Mrln..Encargados
          where enc_cod_cod = @enc_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(enc_cod_cod), '0') as enc_cod_cod
     from TNGS_Mrln..Encargados

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@enc_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_INSERT
(
@enc_cod_cod tngs_codigo,
@enc_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Encargados
   values (
           @enc_cod_cod,
           @enc_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@enc_des_des">Descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_UPDATE
(
@enc_cod_cod tngs_codigo,
@enc_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set enc_des_des= @enc_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_DELETE
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_RECALL
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Encargados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@enc_cod_cod">Cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ENCARGADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_DROP
(
@enc_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Encargados
    where enc_cod_cod = @enc_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ENCARGADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ENCARGADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ENCARGADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ENCARGADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Encargados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ENCARGADOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Encargados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Equipamiento
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
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          where deleted = 0
          order by eqi_cod_cod
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Equipamiento
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
            and deleted = 0
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Mrln..Equipamiento.instante,
                TNGS_Mrln..Equipamiento.deleted,
                TNGS_Mrln..Equipamiento.usuario,
                TNGS_Mrln..Equipamiento.version
           from TNGS_Mrln..Equipamiento
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(eqi_cod_cod), '0') as eqi_cod_cod
     from TNGS_Mrln..Equipamiento

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
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

   Insert into TNGS_Mrln..Equipamiento
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
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

   Update TNGS_Mrln..Equipamiento
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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

   Update TNGS_Mrln..Equipamiento
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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

   Update TNGS_Mrln..Equipamiento
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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

   Delete from TNGS_Mrln..Equipamiento
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Equipamiento
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Estaciones
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

print 'Store Procedure: dbo.ESTACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Mrln..Estaciones.instante,
                TNGS_Mrln..Estaciones.deleted,
                TNGS_Mrln..Estaciones.usuario,
                TNGS_Mrln..Estaciones.version
           from TNGS_Mrln..Estaciones
          where deleted = 0
          order by ets_rcd_cod
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Mrln..Estaciones.instante,
                TNGS_Mrln..Estaciones.deleted,
                TNGS_Mrln..Estaciones.usuario,
                TNGS_Mrln..Estaciones.version
           from TNGS_Mrln..Estaciones
          order by ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_CHKVERSION
(
@ets_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Estaciones
    where ets_rcd_cod = @ets_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_SEARCH
(
@ets_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Mrln..Estaciones.instante,
                TNGS_Mrln..Estaciones.deleted,
                TNGS_Mrln..Estaciones.usuario,
                TNGS_Mrln..Estaciones.version
           from TNGS_Mrln..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Mrln..Estaciones.instante,
                TNGS_Mrln..Estaciones.deleted,
                TNGS_Mrln..Estaciones.usuario,
                TNGS_Mrln..Estaciones.version
           from TNGS_Mrln..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ets_rcd_cod), '0') as ets_rcd_cod
     from TNGS_Mrln..Estaciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@ets_des_des">Estacion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_INSERT
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Estaciones
   values (
           @ets_rcd_cod,
           @ets_des_des,
           @ets_ede_domicilio,
           @ets_des_contacto,
           @ets_ete_telefono,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@ets_des_des">Estacion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UPDATE
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estaciones
      set ets_des_des= @ets_des_des,
          ets_ede_domicilio= @ets_ede_domicilio,
          ets_des_contacto= @ets_des_contacto,
          ets_ete_telefono= @ets_ete_telefono,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DELETE
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_RECALL
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Estaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DROP
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Estaciones
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Estaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Estados
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
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          where deleted = 0
          order by est_rcd_cod
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Estados
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
--- <param name="@est_rcd_cod">Codigo Estado</param>
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
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
          where est_rcd_cod = @est_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Mrln..Estados.instante,
                TNGS_Mrln..Estados.deleted,
                TNGS_Mrln..Estados.usuario,
                TNGS_Mrln..Estados.version
           from TNGS_Mrln..Estados
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(est_rcd_cod), '0') as est_rcd_cod
     from TNGS_Mrln..Estados

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
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

   Insert into TNGS_Mrln..Estados
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
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
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

   Update TNGS_Mrln..Estados
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
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

   Update TNGS_Mrln..Estados
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
--- <param name="@est_rcd_cod">Codigo Estado</param>
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

   Update TNGS_Mrln..Estados
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
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

   Delete from TNGS_Mrln..Estados
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Estados
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Marcas
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
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          where deleted = 0
          order by mrc_rcd_codigo
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Marcas
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
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
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
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Mrln..Marcas.instante,
                TNGS_Mrln..Marcas.deleted,
                TNGS_Mrln..Marcas.usuario,
                TNGS_Mrln..Marcas.version
           from TNGS_Mrln..Marcas
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
--- Busca la clave máxima de la tabla
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
     from TNGS_Mrln..Marcas

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
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
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

   Insert into TNGS_Mrln..Marcas
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
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
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

   Update TNGS_Mrln..Marcas
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
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

   Update TNGS_Mrln..Marcas
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
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
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

   Update TNGS_Mrln..Marcas
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
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

   Delete from TNGS_Mrln..Marcas
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Marcas
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Modelos
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
                TNGS_Mrln..Modelos.instante,
                TNGS_Mrln..Modelos.deleted,
                TNGS_Mrln..Modelos.usuario,
                TNGS_Mrln..Modelos.version
           from TNGS_Mrln..Modelos
          where deleted = 0
          order by mds_rcd_cod
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Mrln..Modelos.instante,
                TNGS_Mrln..Modelos.deleted,
                TNGS_Mrln..Modelos.usuario,
                TNGS_Mrln..Modelos.version
           from TNGS_Mrln..Modelos
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Modelos
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
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
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
                TNGS_Mrln..Modelos.instante,
                TNGS_Mrln..Modelos.deleted,
                TNGS_Mrln..Modelos.usuario,
                TNGS_Mrln..Modelos.version
           from TNGS_Mrln..Modelos
          where mds_rcd_cod = @mds_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Mrln..Modelos.instante,
                TNGS_Mrln..Modelos.deleted,
                TNGS_Mrln..Modelos.usuario,
                TNGS_Mrln..Modelos.version
           from TNGS_Mrln..Modelos
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
--- Busca la clave máxima de la tabla
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
     from TNGS_Mrln..Modelos

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
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@mds_des_des">Modelo</param>
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

   Insert into TNGS_Mrln..Modelos
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
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@mds_des_des">Modelo</param>
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

   Update TNGS_Mrln..Modelos
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
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

   Update TNGS_Mrln..Modelos
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
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
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

   Update TNGS_Mrln..Modelos
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
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

   Delete from TNGS_Mrln..Modelos
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Modelos
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : MotivosInfracciones
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

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where deleted = 0
          order by mti_cod_codigo
      end
   else
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          order by mti_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_CHKVERSION
(
@mti_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MotivosInfracciones
    where mti_cod_codigo = @mti_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_SEARCH
(
@mti_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where mti_cod_codigo = @mti_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select mti_cod_codigo,
                mti_ede_descripcion,
                TNGS_Mrln..MotivosInfracciones.instante,
                TNGS_Mrln..MotivosInfracciones.deleted,
                TNGS_Mrln..MotivosInfracciones.usuario,
                TNGS_Mrln..MotivosInfracciones.version
           from TNGS_Mrln..MotivosInfracciones
          where mti_cod_codigo = @mti_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mti_cod_codigo), '0') as mti_cod_codigo
     from TNGS_Mrln..MotivosInfracciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@mti_ede_descripcion">Descripción</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_INSERT
(
@mti_cod_codigo tngs_codigo,
@mti_ede_descripcion tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MotivosInfracciones
   values (
           @mti_cod_codigo,
           @mti_ede_descripcion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@mti_ede_descripcion">Descripción</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_UPDATE
(
@mti_cod_codigo tngs_codigo,
@mti_ede_descripcion tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set mti_ede_descripcion= @mti_ede_descripcion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_DELETE
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_RECALL
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MotivosInfracciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mti_cod_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_DROP
(
@mti_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MotivosInfracciones
    where mti_cod_codigo = @mti_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MOTIVOSINFRACCIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOTIVOSINFRACCIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOTIVOSINFRACCIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOTIVOSINFRACCIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MotivosInfracciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOTIVOSINFRACCIONES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MotivosInfracciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getMovilesTree
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

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Moviles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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
     from TNGS_Mrln..MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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
                TNGS_Mrln..MvlCombustible.instante,
                TNGS_Mrln..MvlCombustible.deleted,
                TNGS_Mrln..MvlCombustible.usuario,
                TNGS_Mrln..MvlCombustible.version
           from TNGS_Mrln..MvlCombustible
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

   Insert into TNGS_Mrln..MvlCombustible
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

   Update TNGS_Mrln..MvlCombustible
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

   Update TNGS_Mrln..MvlCombustible
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

   Update TNGS_Mrln..MvlCombustible
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

   Update TNGS_Mrln..MvlCombustible
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
         Update TNGS_Mrln..MvlCombustible
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mco_ecd_patente = @mco_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlCombustible
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

   Delete from TNGS_Mrln..MvlCombustible
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

   Delete from TNGS_Mrln..MvlCombustible
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

   Delete TNGS_Mrln..MvlCombustible
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

   Delete from TNGS_Mrln..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlCombus
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 mco_val_litros, 
   mco_imp_importe, 
   mco_fyh_fecha, 
   ets_des_des 
    
   FROM TNGS_Mrln..MvlCombustible 
   JOIN TNGS_Mrln..Estaciones 
   on mco_rcd_codestacion = ets_rcd_cod 
   WHERE mco_ecd_patente = @patente 
   ORDER BY mco_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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
                TNGS_Mrln..MvlEstados.instante,
                TNGS_Mrln..MvlEstados.deleted,
                TNGS_Mrln..MvlEstados.usuario,
                TNGS_Mrln..MvlEstados.version
           from TNGS_Mrln..MvlEstados
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

   Insert into TNGS_Mrln..MvlEstados
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

   Update TNGS_Mrln..MvlEstados
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
--- Borra lógicamente un registro
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

   Update TNGS_Mrln..MvlEstados
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
--- Borra lógicamente un registro por clave foranea
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

   Update TNGS_Mrln..MvlEstados
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

   Update TNGS_Mrln..MvlEstados
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
--- Recupera lógicamente los registros de una clave foranea
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
         Update TNGS_Mrln..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlEstados
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
--- Borra físicamente un registro
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

   Delete from TNGS_Mrln..MvlEstados
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
--- Borra físicamente un registro por clave foránea
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

   Delete from TNGS_Mrln..MvlEstados
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..MvlEstados
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
--- Borra físicamente los registro borrados lógicamente por clave foránea
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

   Delete from TNGS_Mrln..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlEstads
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 est_des_des, 
   mve_nro_km, 
   mve_fyh_fecha, 
   mve_rcd_codestado 
   FROM TNGS_Mrln..MvlEstados 
   JOIN TNGS_Mrln..Estados 
   on mve_rcd_codestado = est_rcd_cod 
   WHERE mve_ecd_patente = @patente 
   ORDER BY mve_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_GETLASTFIVEMVLESTADS to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getMovilEstadoActual
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_GETMOVILESTADOACTUAL'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_GETMOVILESTADOACTUAL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_GETMOVILESTADOACTUAL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_GETMOVILESTADOACTUAL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select top 1 <S> 
     from TNGS_Mrln..MvlEstados 
   where mve_ecd_patente = @patente 
   ORDER BY mve_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_GETMOVILESTADOACTUAL to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : MvlKilometros
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

print 'Store Procedure: dbo.MVLKILOMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          where deleted = 0
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_CHKVERSION
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_SEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FSEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and deleted = 0
          order by mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Mrln..MvlKilometros.instante,
                TNGS_Mrln..MvlKilometros.deleted,
                TNGS_Mrln..MvlKilometros.usuario,
                TNGS_Mrln..MvlKilometros.version
           from TNGS_Mrln..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
          order by mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_INSERT
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..MvlKilometros
   values (
           @mkm_ecd_patente,
           @mkm_fyh_fecha,
           @mkm_nro_km,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UPDATE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlKilometros
      set mkm_nro_km= @mkm_nro_km,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DELETE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDELETE
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_RECALL
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..MvlKilometros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FRECALL
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
      end
   else
      begin
         Update TNGS_Mrln..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DROP
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDROP
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLKILOMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..MvlKilometros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FPACK
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getKmsActualesMvl
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_GETKMSACTUALESMVL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_GETKMSACTUALESMVL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_GETKMSACTUALESMVL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_GETKMSACTUALESMVL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select kmsActuales = dbo.MVLKILOMETROS_GETKMACTUALMOVIL(@patente) 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_GETKMSACTUALESMVL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlKm
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_GETLASTFIVEMVLKM'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_GETLASTFIVEMVLKM'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_GETLASTFIVEMVLKM
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_GETLASTFIVEMVLKM
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 mkm_nro_km, 
   mkm_fyh_fecha 
   FROM TNGS_Mrln..MvlKilometros 
   WHERE mkm_ecd_patente = @patente 
   ORDER BY mkm_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_GETLASTFIVEMVLKM to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
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
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : OtItems
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
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where TNGS_Mrln..OtItems.deleted = 0
          order by oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          order by oti_nro_nroot,
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@version">Número de version a verificar</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
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
--- <param name="@oti_nro_nroot">nroOt</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
            and TNGS_Mrln..OtItems.deleted = 0
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
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
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FSEARCH
(
@oti_nro_nroot tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
            and TNGS_Mrln..OtItems.deleted = 0
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_rcd_codcategoria,
                cat_des_des as oti_categoria,
                oti_imp_importe,
                oti_ede_comentario,
                oti_d20_estado,
                oti_imp_importecierre,
                oti_ede_comentariocierre,
                oti_cd6_codreparacion,
                odt_nro_kmsactuales as oti_kilometraje,
                TNGS_Mrln..OtItems.instante,
                TNGS_Mrln..OtItems.deleted,
                TNGS_Mrln..OtItems.usuario,
                TNGS_Mrln..OtItems.version
           from TNGS_Mrln..OtItems
                join TNGS_Mrln..Categorias
                  on oti_rcd_codCategoria = cat_rcd_cod
                join TNGS_Mrln..OrdenesTrabajo
                  on oti_nro_nroOt = odt_nro_nro
          where oti_nro_nroot = @oti_nro_nroot
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_rcd_codcategoria">Categoría</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@oti_d20_estado">Estado</param>
--- <param name="@oti_imp_importecierre">Importe Cierre</param>
--- <param name="@oti_ede_comentariocierre">Comentario Cierre</param>
--- <param name="@oti_cd6_codreparacion">Codigo Reparacion</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_rcd_codcategoria tngs_codigo_r,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@oti_d20_estado tngs_descripcion_20,
@oti_imp_importecierre tngs_importe,
@oti_ede_comentariocierre tngs_descripcion_e,
@oti_cd6_codreparacion tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..OtItems
   values (
           @oti_nro_nroot,
           @oti_nro_nroagrupador,
           @oti_nro_nroitem,
           @oti_des_desoperacion,
           @oti_des_destarea,
           @oti_rcd_codcategoria,
           @oti_imp_importe,
           @oti_ede_comentario,
           @oti_d20_estado,
           @oti_imp_importecierre,
           @oti_ede_comentariocierre,
           @oti_cd6_codreparacion,
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
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_rcd_codcategoria">Categoría</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@oti_d20_estado">Estado</param>
--- <param name="@oti_imp_importecierre">Importe Cierre</param>
--- <param name="@oti_ede_comentariocierre">Comentario Cierre</param>
--- <param name="@oti_cd6_codreparacion">Codigo Reparacion</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_rcd_codcategoria tngs_codigo_r,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@oti_d20_estado tngs_descripcion_20,
@oti_imp_importecierre tngs_importe,
@oti_ede_comentariocierre tngs_descripcion_e,
@oti_cd6_codreparacion tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set oti_des_desoperacion= @oti_des_desoperacion,
          oti_des_destarea= @oti_des_destarea,
          oti_rcd_codcategoria= @oti_rcd_codcategoria,
          oti_imp_importe= @oti_imp_importe,
          oti_ede_comentario= @oti_ede_comentario,
          oti_d20_estado= @oti_d20_estado,
          oti_imp_importecierre= @oti_imp_importecierre,
          oti_ede_comentariocierre= @oti_ede_comentariocierre,
          oti_cd6_codreparacion= @oti_cd6_codreparacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
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
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDELETE
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..OtItems
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
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
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FRECALL
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
      end
   else
      begin
         Update TNGS_Mrln..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
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
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
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
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDROP
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDROP to tngsmodulos

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

   Delete TNGS_Mrln..OtItems
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FPACK
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: GetRealizadosMvl
--- </summary>
--- <param name="@patente">Patente</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_GETREALIZADOSMVL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_GETREALIZADOSMVL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_GETREALIZADOSMVL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_GETREALIZADOSMVL
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select oti_nro_nroot,
          oti_nro_nroagrupador,
          oti_nro_nroitem,
          oti_des_desoperacion,
          oti_des_destarea,
          oti_rcd_codcategoria,
          cat_des_des as oti_categoria,
          oti_imp_importe,
          oti_ede_comentario,
          oti_d20_estado,
          oti_imp_importecierre,
          oti_ede_comentariocierre,
          oti_cd6_codreparacion,
          odt_nro_kmsactuales as oti_kilometraje,
          TNGS_Mrln..OtItems.instante,
          TNGS_Mrln..OtItems.deleted,
          TNGS_Mrln..OtItems.usuario,
          TNGS_Mrln..OtItems.version
     from TNGS_Mrln..OtItems 
          join TNGS_Mrln..Categorias
            on oti_rcd_codCategoria = cat_rcd_cod
          join TNGS_Mrln..OrdenesTrabajo
            on oti_nro_nroOt = odt_nro_nro
     where odt_ecd_patente = @patente and year(odt_fyh_feccierre) <> 1900 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_GETREALIZADOSMVL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: ZPendientes
--- </summary>
--- <param name="@inipatente">Inicio Patentes</param>
--- <param name="@finpatente">Fin Patentes</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_ZPENDIENTES'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_ZPENDIENTES'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_ZPENDIENTES
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_ZPENDIENTES
(
@inipatente tngs_codigo_e,
@finpatente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   select odt_ecd_patente, odt_nro_nro,odt_fyh_fecapertura, odt_fyh_feccierre, oti_des_desoperacion, oti_des_destarea, oti_imp_importe 
    from OtItems 
   join OrdenesTrabajo 
   	on odt_nro_nro = oti_nro_nroot 
   where oti_d20_estado = 'Pendiente' 
   and odt_ecd_patente between @inipatente and @finpatente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_ZPENDIENTES to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OtItems
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Parametros
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
                TNGS_Mrln..Parametros.instante,
                TNGS_Mrln..Parametros.deleted,
                TNGS_Mrln..Parametros.usuario,
                TNGS_Mrln..Parametros.version
           from TNGS_Mrln..Parametros
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
                TNGS_Mrln..Parametros.instante,
                TNGS_Mrln..Parametros.deleted,
                TNGS_Mrln..Parametros.usuario,
                TNGS_Mrln..Parametros.version
           from TNGS_Mrln..Parametros
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Parametros
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
--- <param name="@par_xcd_codigo">Código</param>
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
                TNGS_Mrln..Parametros.instante,
                TNGS_Mrln..Parametros.deleted,
                TNGS_Mrln..Parametros.usuario,
                TNGS_Mrln..Parametros.version
           from TNGS_Mrln..Parametros
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
                TNGS_Mrln..Parametros.instante,
                TNGS_Mrln..Parametros.deleted,
                TNGS_Mrln..Parametros.usuario,
                TNGS_Mrln..Parametros.version
           from TNGS_Mrln..Parametros
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
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
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

   Insert into TNGS_Mrln..Parametros
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
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
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

   Update TNGS_Mrln..Parametros
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
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

   Update TNGS_Mrln..Parametros
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
--- <param name="@par_xcd_codigo">Código</param>
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

   Update TNGS_Mrln..Parametros
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
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

   Delete from TNGS_Mrln..Parametros
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Parametros
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Reparaciones
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
                rep_rcd_codcat,
                cat_des_des as rep_categoria,
                rep_cd1_solicitadetalle,
                TNGS_Mrln..Reparaciones.instante,
                TNGS_Mrln..Reparaciones.deleted,
                TNGS_Mrln..Reparaciones.usuario,
                TNGS_Mrln..Reparaciones.version
           from TNGS_Mrln..Reparaciones
                join TNGS_Mrln..Categorias
                  on rep_rcd_codCat = cat_rcd_cod
          where TNGS_Mrln..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                rep_rcd_codcat,
                cat_des_des as rep_categoria,
                rep_cd1_solicitadetalle,
                TNGS_Mrln..Reparaciones.instante,
                TNGS_Mrln..Reparaciones.deleted,
                TNGS_Mrln..Reparaciones.usuario,
                TNGS_Mrln..Reparaciones.version
           from TNGS_Mrln..Reparaciones
                join TNGS_Mrln..Categorias
                  on rep_rcd_codCat = cat_rcd_cod
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Reparaciones
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
                rep_rcd_codcat,
                cat_des_des as rep_categoria,
                rep_cd1_solicitadetalle,
                TNGS_Mrln..Reparaciones.instante,
                TNGS_Mrln..Reparaciones.deleted,
                TNGS_Mrln..Reparaciones.usuario,
                TNGS_Mrln..Reparaciones.version
           from TNGS_Mrln..Reparaciones
                join TNGS_Mrln..Categorias
                  on rep_rcd_codCat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
            and TNGS_Mrln..Reparaciones.deleted = 0
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                rep_rcd_codcat,
                cat_des_des as rep_categoria,
                rep_cd1_solicitadetalle,
                TNGS_Mrln..Reparaciones.instante,
                TNGS_Mrln..Reparaciones.deleted,
                TNGS_Mrln..Reparaciones.usuario,
                TNGS_Mrln..Reparaciones.version
           from TNGS_Mrln..Reparaciones
                join TNGS_Mrln..Categorias
                  on rep_rcd_codCat = cat_rcd_cod
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(rep_cd6_cod), '0') as rep_cd6_cod
     from TNGS_Mrln..Reparaciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
--- <param name="@rep_xde_des">Reparacion</param>
--- <param name="@rep_rcd_codcat">Categoria</param>
--- <param name="@rep_cd1_solicitadetalle">Se Solicita Detalle</param>
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
@rep_rcd_codcat tngs_codigo_r,
@rep_cd1_solicitadetalle tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Reparaciones
   values (
           @rep_cd6_cod,
           @rep_xde_des,
           @rep_rcd_codcat,
           @rep_cd1_solicitadetalle,
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
--- <param name="@rep_xde_des">Reparacion</param>
--- <param name="@rep_rcd_codcat">Categoria</param>
--- <param name="@rep_cd1_solicitadetalle">Se Solicita Detalle</param>
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
@rep_rcd_codcat tngs_codigo_r,
@rep_cd1_solicitadetalle tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Reparaciones
      set rep_xde_des= @rep_xde_des,
          rep_rcd_codcat= @rep_rcd_codcat,
          rep_cd1_solicitadetalle= @rep_cd1_solicitadetalle,
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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

   Update TNGS_Mrln..Reparaciones
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
--- Recupera un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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

   Update TNGS_Mrln..Reparaciones
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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

   Delete from TNGS_Mrln..Reparaciones
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Reparaciones
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
--- Método Fijo: Getbydesc
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
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Taller
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

print 'Store Procedure: dbo.TALLER_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where deleted = 0
          order by tll_cod_codigo
      end
   else
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          order by tll_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_CHKVERSION
(
@tll_cod_codigo tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..Taller
    where tll_cod_codigo = @tll_cod_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_SEARCH
(
@tll_cod_codigo tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where tll_cod_codigo = @tll_cod_codigo
            and deleted = 0
      end
   else
      begin
         Select tll_cod_codigo,
                tll_ede_descripcion,
                tll_xde_direccion,
                tll_tel_telefono,
                tll_ede_contacto,
                TNGS_Mrln..Taller.instante,
                TNGS_Mrln..Taller.deleted,
                TNGS_Mrln..Taller.usuario,
                TNGS_Mrln..Taller.version
           from TNGS_Mrln..Taller
          where tll_cod_codigo = @tll_cod_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(tll_cod_codigo), '0') as tll_cod_codigo
     from TNGS_Mrln..Taller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@tll_ede_descripcion">Descripcion</param>
--- <param name="@tll_xde_direccion">Direccion</param>
--- <param name="@tll_tel_telefono">Telefono</param>
--- <param name="@tll_ede_contacto">Contacto</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_INSERT
(
@tll_cod_codigo tngs_codigo,
@tll_ede_descripcion tngs_descripcion_e,
@tll_xde_direccion tngs_descripcion_x,
@tll_tel_telefono tngs_telefono,
@tll_ede_contacto tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..Taller
   values (
           @tll_cod_codigo,
           @tll_ede_descripcion,
           @tll_xde_direccion,
           @tll_tel_telefono,
           @tll_ede_contacto,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@tll_ede_descripcion">Descripcion</param>
--- <param name="@tll_xde_direccion">Direccion</param>
--- <param name="@tll_tel_telefono">Telefono</param>
--- <param name="@tll_ede_contacto">Contacto</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_UPDATE
(
@tll_cod_codigo tngs_codigo,
@tll_ede_descripcion tngs_descripcion_e,
@tll_xde_direccion tngs_descripcion_x,
@tll_tel_telefono tngs_telefono,
@tll_ede_contacto tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set tll_ede_descripcion= @tll_ede_descripcion,
          tll_xde_direccion= @tll_xde_direccion,
          tll_tel_telefono= @tll_tel_telefono,
          tll_ede_contacto= @tll_ede_contacto,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_DELETE
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_RECALL
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..Taller
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tll_cod_codigo">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLER_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_DROP
(
@tll_cod_codigo tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..Taller
    where tll_cod_codigo = @tll_cod_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_DROP to tngsmodulos

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

print 'Store Procedure: dbo.TALLER_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLER_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLER_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLER_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..Taller
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLER_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Taller
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : TallerCategoria
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

print 'Store Procedure: dbo.TALLERCATEGORIA_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where TNGS_Mrln..TallerCategoria.deleted = 0
          order by tct_cod_codigotaller,
                tct_rcd_codigocategoria
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          order by tct_cod_codigotaller,
                tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_CHKVERSION
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_SEARCH
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
            and TNGS_Mrln..TallerCategoria.deleted = 0
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and tct_rcd_codigocategoria = @tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FSEARCH
(
@tct_cod_codigotaller tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and TNGS_Mrln..TallerCategoria.deleted = 0
          order by tct_rcd_codigocategoria
      end
   else
      begin
         Select tct_cod_codigotaller,
                tll_ede_descripcion as ctl_taller,
                tct_rcd_codigocategoria,
                cat_des_des as tlc_categoria,
                tct_cod_dummy,
                TNGS_Mrln..TallerCategoria.instante,
                TNGS_Mrln..TallerCategoria.deleted,
                TNGS_Mrln..TallerCategoria.usuario,
                TNGS_Mrln..TallerCategoria.version
           from TNGS_Mrln..TallerCategoria
                join TNGS_Mrln..Taller
                  on tct_cod_codigotaller = tll_cod_codigo
                join TNGS_Mrln..Categorias
                  on tct_rcd_codigocategoria = cat_rcd_cod
          where tct_cod_codigotaller = @tct_cod_codigotaller
          order by tct_rcd_codigocategoria
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@tct_cod_dummy">dummy</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_INSERT
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@tct_cod_dummy tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Mrln..TallerCategoria
   values (
           @tct_cod_codigotaller,
           @tct_rcd_codigocategoria,
           @tct_cod_dummy,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@tct_cod_dummy">dummy</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_UPDATE
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@tct_cod_dummy tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set tct_cod_dummy= @tct_cod_dummy,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_DELETE
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FDELETE
(
@tct_cod_codigotaller tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Mrln..TallerCategoria
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_RECALL
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Mrln..TallerCategoria
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FRECALL
(
@tct_cod_codigotaller tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Mrln..TallerCategoria
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where tct_cod_codigotaller = @tct_cod_codigotaller
      end
   else
      begin
         Update TNGS_Mrln..TallerCategoria
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where tct_cod_codigotaller = @tct_cod_codigotaller
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@tct_rcd_codigocategoria">Codigo Categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_DROP
(
@tct_cod_codigotaller tngs_codigo,
@tct_rcd_codigocategoria tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and tct_rcd_codigocategoria = @tct_rcd_codigocategoria

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FDROP
(
@tct_cod_codigotaller tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.TALLERCATEGORIA_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Mrln..TallerCategoria
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@tct_cod_codigotaller">Codigo Taller</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALLERCATEGORIA_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.TALLERCATEGORIA_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALLERCATEGORIA_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALLERCATEGORIA_FPACK
(
@tct_cod_codigotaller tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Mrln..TallerCategoria
    where tct_cod_codigotaller = @tct_cod_codigotaller
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALLERCATEGORIA_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: TallerCategoria
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 05/10/2018 18:14
// Sistema     : Mrln
// Tabla       : Talonarios
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
                TNGS_Mrln..Talonarios.instante,
                TNGS_Mrln..Talonarios.deleted,
                TNGS_Mrln..Talonarios.usuario,
                TNGS_Mrln..Talonarios.version
           from TNGS_Mrln..Talonarios
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
                TNGS_Mrln..Talonarios.instante,
                TNGS_Mrln..Talonarios.deleted,
                TNGS_Mrln..Talonarios.usuario,
                TNGS_Mrln..Talonarios.version
           from TNGS_Mrln..Talonarios
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
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
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
     from TNGS_Mrln..Talonarios
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
--- <param name="@tal_xcd_codigo">Código</param>
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
                TNGS_Mrln..Talonarios.instante,
                TNGS_Mrln..Talonarios.deleted,
                TNGS_Mrln..Talonarios.usuario,
                TNGS_Mrln..Talonarios.version
           from TNGS_Mrln..Talonarios with (XLOCK)
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
                TNGS_Mrln..Talonarios.instante,
                TNGS_Mrln..Talonarios.deleted,
                TNGS_Mrln..Talonarios.usuario,
                TNGS_Mrln..Talonarios.version
           from TNGS_Mrln..Talonarios with (XLOCK)
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
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
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

   Insert into TNGS_Mrln..Talonarios
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
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
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

   Update TNGS_Mrln..Talonarios
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
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
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

   Update TNGS_Mrln..Talonarios
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
--- <param name="@tal_xcd_codigo">Código</param>
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

   Update TNGS_Mrln..Talonarios
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
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

   Delete from TNGS_Mrln..Talonarios
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
--- Borra físicamente los registros borrados lógicamente
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

   Delete TNGS_Mrln..Talonarios
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
