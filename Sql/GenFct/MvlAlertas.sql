/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 10/08/2018 20:30
// Sistema     : Mrln
// Tabla       : MvlAlertas
//----------------------------------------------------------------------------
// � 1999-2018 by TNG Software                                      Gndr 5.20
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

print 'Function: MVLALERTAS_GETCOUNTFROMMOVIL'

if exists (select * from sysobjects where id = object_id('MVLALERTAS_GETCOUNTFROMMOVIL'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function MVLALERTAS_GETCOUNTFROMMOVIL
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on MVLALERTAS_GETCOUNTFROMMOVIL to tngsmodulos
grant execute on MVLALERTAS_GETCOUNTFROMMOVIL to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: MvlAlertas
//--------------------------------------------------------------------------*/
