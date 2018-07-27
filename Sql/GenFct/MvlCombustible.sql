/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 27/07/2018 07:12
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
