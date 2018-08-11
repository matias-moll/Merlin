/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 31/07/2018 21:45
// Base de Datos      : TNGS_Mrln
// Tabla              : OrdenesTrabajo
//----------------------------------------------------------------------------
// � 1999-2018 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
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
