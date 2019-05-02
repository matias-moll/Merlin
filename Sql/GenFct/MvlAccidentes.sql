/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : MvlAccidentes
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
--- Funci�n : getCountFromMovil
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MVLACCIDENTES_GETCOUNTFROMMOVIL'

if exists (select * from sysobjects where id = object_id('MVLACCIDENTES_GETCOUNTFROMMOVIL'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function MVLACCIDENTES_GETCOUNTFROMMOVIL
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on MVLACCIDENTES_GETCOUNTFROMMOVIL to tngsmodulos
grant execute on MVLACCIDENTES_GETCOUNTFROMMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlAccidentes
//--------------------------------------------------------------------------*/
