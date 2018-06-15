/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 15/06/2018 19:16
// Base de Datos      : TNGS_Mrln
// Tabla              : OrdenesTrabajo
//----------------------------------------------------------------------------
// © 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-----------------------------------------------------*/
/* Selecciono la base en la que se crearan los indices */
/*-----------------------------------------------------*/

use TNGS_Mrln
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: OrdenesTrabajo_is1'

print '    - Creando el nuevo indice'

create index OrdenesTrabajo_is1 on OrdenesTrabajo
   (
       odt_d20_estado
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
