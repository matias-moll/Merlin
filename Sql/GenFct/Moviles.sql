/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : Moviles
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
--- Funci�n : getModelo
--- </summary>
--- <param name="@patente">Patente</param>
---
---////////////////////////////////////////////////////////

print 'Function: MOVILES_GETMODELO'

if exists (select * from sysobjects where id = object_id('MOVILES_GETMODELO'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function MOVILES_GETMODELO
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on MOVILES_GETMODELO to tngsmodulos
grant execute on MOVILES_GETMODELO to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: Moviles
//--------------------------------------------------------------------------*/
