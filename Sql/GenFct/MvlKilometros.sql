/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : MvlKilometros
//----------------------------------------------------------------------------
// � 1999-2019 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*--------------------------------------------------*/
/* Selecciono la base en la que se crearan las Fcts */
/*--------------------------------------------------*/

use TNGS_Mrln
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Funci�n : getKmActualMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLKILOMETROS_GETKMACTUALMOVIL'

if exists (select * from sysobjects where id = object_id('MVLKILOMETROS_GETKMACTUALMOVIL'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function MVLKILOMETROS_GETKMACTUALMOVIL
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on MVLKILOMETROS_GETKMACTUALMOVIL to tngsmodulos
grant execute on MVLKILOMETROS_GETKMACTUALMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
