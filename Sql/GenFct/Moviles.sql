/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : Moviles
//----------------------------------------------------------------------------
// © 1999-2019 by TNG Software                                      Gndr 5.20
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
