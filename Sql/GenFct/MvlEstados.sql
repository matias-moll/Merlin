/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : MvlEstados
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
