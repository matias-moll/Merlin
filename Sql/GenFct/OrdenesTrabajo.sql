/*----------------------------------------------------------------------------
//                         TNG Software Fcts Generator
//----------------------------------------------------------------------------
// Fecha       : 15/04/2019 00:59
// Sistema     : Mrln
// Tabla       : OrdenesTrabajo
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
--- Funci�n : getImporteCierreItms
--- </summary>
--- <param name="@nroorden">Numero de Orden</param>
---
---////////////////////////////////////////////////////////

print 'Function: ORDENESTRABAJO_GETIMPORTECIERREITMS'

if exists (select * from sysobjects where id = object_id('ORDENESTRABAJO_GETIMPORTECIERREITMS'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function ORDENESTRABAJO_GETIMPORTECIERREITMS
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on ORDENESTRABAJO_GETIMPORTECIERREITMS to tngsmodulos
grant execute on ORDENESTRABAJO_GETIMPORTECIERREITMS to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Funci�n : getImporteItems
--- </summary>
--- <param name="@nroorden">Numero de Orden</param>
---
---////////////////////////////////////////////////////////

print 'Function: ORDENESTRABAJO_GETIMPORTEITEMS'

if exists (select * from sysobjects where id = object_id('ORDENESTRABAJO_GETIMPORTEITEMS'))
begin
   print '       - Borrando la vieja Funci�n'
   drop function ORDENESTRABAJO_GETIMPORTEITEMS
end
go

print '       - Creando la nueva Funci�n'
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

print '       - Asignando permisos a la Funci�n'

grant execute on ORDENESTRABAJO_GETIMPORTEITEMS to tngsmodulos
grant execute on ORDENESTRABAJO_GETIMPORTEITEMS to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de las Funciones de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
