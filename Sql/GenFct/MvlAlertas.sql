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
