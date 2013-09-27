/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 20/09/2013 16:51
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de los usuarios de la base
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Rivn
go

/*--------------------------------------------------------------------------*/
/* Creacion de los usuarios                                                 */
/*--------------------------------------------------------------------------*/

print 'Creando Usuario:  tngsmodulos'
print ' '

if not exists (select * from sysusers where name = 'tngsmodulos' and uid < 16382)
   EXEC sp_adduser 'tngsmodulos', 'tngsmodulos', 'public'
go

print 'Creando Usuario:  tngsqbe'
print ' '

if not exists (select * from sysusers where name = 'tngsqbe' and uid < 16382)
   EXEC sp_adduser 'tngsqbe', 'tngsqbe', 'public'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp01.sql                                             */
/*--------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 20/09/2013 16:51
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de los tipos de datos
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Rivn
go

/*--------------------------------------------------------------------------*/
/* Creacion de los tipos de datos                                           */
/*--------------------------------------------------------------------------*/

set nocount on

print 'Creando tipos de dato:'

print '                        - codigo_1'
EXEC sp_addtype tngs_codigo_1, 'char (1)', 'NOT NULL'
go

print '                        - codigo_r'
EXEC sp_addtype tngs_codigo_r, 'char (2)', 'NOT NULL'
go

print '                        - codigo_3'
EXEC sp_addtype tngs_codigo_3, 'char (3)', 'NOT NULL'
go

print '                        - codigo'
EXEC sp_addtype tngs_codigo, 'char (4)', 'NOT NULL'
go

print '                        - codigo_5'
EXEC sp_addtype tngs_codigo_5, 'char (5)', 'NOT NULL'
go

print '                        - codigo_6'
EXEC sp_addtype tngs_codigo_6, 'char (6)', 'NOT NULL'
go

print '                        - codigo_7'
EXEC sp_addtype tngs_codigo_7, 'char (7)', 'NOT NULL'
go

print '                        - codigo_e'
EXEC sp_addtype tngs_codigo_e, 'char (8)', 'NOT NULL'
go

print '                        - codigo_9'
EXEC sp_addtype tngs_codigo_9, 'char (9)', 'NOT NULL'
go

print '                        - codigo_x'
EXEC sp_addtype tngs_codigo_x, 'char (10)', 'NOT NULL'
go

print '                        - codigo_12'
EXEC sp_addtype tngs_codigo_12, 'char (12)', 'NOT NULL'
go

print '                        - codigo_15'
EXEC sp_addtype tngs_codigo_15, 'char (15)', 'NOT NULL'
go

print '                        - codigo_xl'
EXEC sp_addtype tngs_codigo_xl, 'char (20)', 'NOT NULL'
go

print '                        - codigo_30'
EXEC sp_addtype tngs_codigo_30, 'char (30)', 'NOT NULL'
go

print '                        - descripcion_2'
EXEC sp_addtype tngs_descripcion_2, 'char (2)', 'NOT NULL'
go

print '                        - descripcion_4'
EXEC sp_addtype tngs_descripcion_4, 'char (4)', 'NOT NULL'
go

print '                        - descripcion_6'
EXEC sp_addtype tngs_descripcion_6, 'char (6)', 'NOT NULL'
go

print '                        - descripcion_10'
EXEC sp_addtype tngs_descripcion_10, 'char (10)', 'NOT NULL'
go

print '                        - descripcion_r'
EXEC sp_addtype tngs_descripcion_r, 'char (15)', 'NOT NULL'
go

print '                        - descripcion_20'
EXEC sp_addtype tngs_descripcion_20, 'char (20)', 'NOT NULL'
go

print '                        - descripcion'
EXEC sp_addtype tngs_descripcion, 'char (30)', 'NOT NULL'
go

print '                        - descripcion_40'
EXEC sp_addtype tngs_descripcion_40, 'char (40)', 'NOT NULL'
go

print '                        - descripcion_50'
EXEC sp_addtype tngs_descripcion_50, 'char (50)', 'NOT NULL'
go

print '                        - descripcion_e'
EXEC sp_addtype tngs_descripcion_e, 'char (60)', 'NOT NULL'
go

print '                        - descripcion_80'
EXEC sp_addtype tngs_descripcion_80, 'varchar (80)', 'NOT NULL'
go

print '                        - descripcion_100'
EXEC sp_addtype tngs_descripcion_100, 'varchar (100)', 'NOT NULL'
go

print '                        - descripcion_x'
EXEC sp_addtype tngs_descripcion_x, 'varchar (120)', 'NOT NULL'
go

print '                        - descripcion_150'
EXEC sp_addtype tngs_descripcion_150, 'varchar (150)', 'NOT NULL'
go

print '                        - descripcion_200'
EXEC sp_addtype tngs_descripcion_200, 'varchar (200)', 'NOT NULL'
go

print '                        - descripcion_xl'
EXEC sp_addtype tngs_descripcion_xl, 'varchar (240)', 'NOT NULL'
go

print '                        - estado'
EXEC sp_addtype tngs_estado, 'char (1)', 'NOT NULL'
go

print '                        - nombre'
EXEC sp_addtype tngs_nombre, 'char (20)', 'NOT NULL'
go

print '                        - codpos'
EXEC sp_addtype tngs_codpos, 'char (8)', 'NOT NULL'
go

print '                        - cuit'
EXEC sp_addtype tngs_cuit, 'char (13)', 'NOT NULL'
go

print '                        - cbu'
EXEC sp_addtype tngs_cbu, 'char (25)', 'NOT NULL'
go

print '                        - email'
EXEC sp_addtype tngs_email, 'varchar (60)', 'NOT NULL'
go

print '                        - telefono'
EXEC sp_addtype tngs_telefono, 'char (30)', 'NOT NULL'
go

print '                        - telefono_e'
EXEC sp_addtype tngs_telefono_e, 'varchar (60)', 'NOT NULL'
go

print '                        - mes'
EXEC sp_addtype tngs_mes, 'char (6)', 'NOT NULL'
go

print '                        - clave'
EXEC sp_addtype tngs_clave, 'char (32)', 'NOT NULL'
go

print '                        - observaciones_r'
EXEC sp_addtype tngs_observaciones_r, 'varchar (254)', 'NOT NULL'
go

print '                        - observaciones'
EXEC sp_addtype tngs_observaciones, 'text', 'NOT NULL'
go

print '                        - texto'
EXEC sp_addtype tngs_texto, 'text', 'NOT NULL'
go

print '                        - texto'
EXEC sp_addtype tngs_texto, 'text', 'NOT NULL'
go

print '                        - numero'
EXEC sp_addtype tngs_numero, 'int', 'NOT NULL'
go

print '                        - cantidad'
EXEC sp_addtype tngs_cantidad, 'int', 'NOT NULL'
go

print '                        - item'
EXEC sp_addtype tngs_item, 'int', 'NOT NULL'
go

print '                        - importe'
EXEC sp_addtype tngs_importe, 'money', 'NOT NULL'
go

print '                        - precio'
EXEC sp_addtype tngs_precio, 'money', 'NOT NULL'
go

print '                        - porcentaje'
EXEC sp_addtype tngs_porcentaje, 'money', 'NOT NULL'
go

print '                        - valor'
EXEC sp_addtype tngs_valor, 'float', 'NOT NULL'
go

print '                        - valor'
EXEC sp_addtype tngs_valor, 'float', 'NOT NULL'
go

print '                        - numero'
EXEC sp_addtype tngs_numero, 'int', 'NOT NULL'
go

print '                        - numero'
EXEC sp_addtype tngs_numero, 'bigint', 'NOT NULL'
go

print '                        - fecha'
EXEC sp_addtype tngs_fecha, 'datetime', 'NOT NULL'
go

print '                        - hora'
EXEC sp_addtype tngs_hora, 'datetime', 'NOT NULL'
go

print '                        - fecyhor'
EXEC sp_addtype tngs_fecyhor, 'datetime', 'NOT NULL'
go

print '                        - borrado'
EXEC sp_addtype tngs_borrado, 'money', 'NOT NULL'
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp02.sql                                             */
/*--------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 20/09/2013 16:51
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de las funciones básicas
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------*/
/* Selecciono la base de trabajo */
/*-------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : Trim
--- </summary>
--- <param name="@texto">Texto a trimear</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_TRIM'

if exists (select * from sysobjects where id = object_id('TNGS_TRIM'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_TRIM
end
go

print '       - Creando la nueva Función'
go

create function TNGS_TRIM
(
@texto varchar(8000)
)
returns varchar(8000)
as
begin

   return ltrim(rtrim(@texto))

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_TRIM to tngsmodulos
grant execute on TNGS_TRIM to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MakeDateTime
--- </summary>
--- <param name="@texto">Texto a convertir</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEDATETIME'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEDATETIME'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEDATETIME
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEDATETIME
(
@texto varchar(30)
)
returns datetime
as
begin

   return convert(datetime, @texto, 103)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEDATETIME to tngsmodulos
grant execute on TNGS_MAKEDATETIME to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetDate
--- </summary>
--- <param name="@fecyhor">Fecha y Hora a procesar</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_GETDATE'

if exists (select * from sysobjects where id = object_id('TNGS_GETDATE'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_GETDATE
end
go

print '       - Creando la nueva Función'
go

create function TNGS_GETDATE
(
@fecyhor datetime
)
returns datetime
as
begin

   return convert(datetime, convert(char(30), @fecyhor, 101), 101)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_GETDATE to tngsmodulos
grant execute on TNGS_GETDATE to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : GetTime
--- </summary>
--- <param name="@fecyhor">Fecha y Hora a procesar</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_GETTIME'

if exists (select * from sysobjects where id = object_id('TNGS_GETTIME'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_GETTIME
end
go

print '       - Creando la nueva Función'
go

create function TNGS_GETTIME
(
@fecyhor datetime
)
returns datetime
as
begin

   return convert(datetime, convert(char(30), @fecyhor, 108), 108)

end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_GETTIME to tngsmodulos
grant execute on TNGS_GETTIME to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : PadR
--- </summary>
--- <param name="@texto">Texto sobre el que realizar el PADR</param>
--- <param name="@largo">Longitud del PAD</param>
--- <param name="@caracter">Caracter del PAD</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_PADR'

if exists (select * from sysobjects where id = object_id('TNGS_PADR'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_PADR
end
go

print '       - Creando la nueva Función'
go

create function TNGS_PADR
(
@texto varchar(100),
@largo smallint, 
@caracter varchar(1)
)
returns varchar(100)
as
   begin
      declare @strlen smallint

      select @strlen= datalength(ltrim(rtrim(@texto)))

      if @strlen >= @largo
         begin
            set @texto= left(ltrim(rtrim(@texto)), @largo)
         end
      else
         begin
            declare @rlargo smallint

            set @rlargo= @largo - @strlen
            set @texto= ltrim(rtrim(@texto)) + left(replicate(@caracter, @rlargo + 2), @rlargo)
      end

      return (@texto)
   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_PADR to tngsmodulos
grant execute on TNGS_PADR to tngsqbe

print ' '
go


---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : PadL
--- </summary>
--- <param name="@texto">Texto sobre el que realizar el PADL</param>
--- <param name="@largo">Longitud del PAD</param>
--- <param name="@caracter">Caracter del PAD</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_PADL'

if exists (select * from sysobjects where id = object_id('TNGS_PADL'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_PADL
end
go

print '       - Creando la nueva Función'
go

create function TNGS_PADL
(
@texto varchar(100),
@largo smallint, 
@caracter varchar(1)
)
returns varchar(100)
as
   begin
      declare @strlen smallint

      select @strlen= datalength(ltrim(rtrim(@texto)))

      if @strlen >= @largo
         begin
            set @texto= left(ltrim(rtrim(@texto)), @largo)
         end
      else
         begin
            declare @rlargo smallint

            set @rlargo= @largo - @strlen
            set @texto= left(replicate(@caracter, @rlargo + 2), @rlargo) + ltrim(rtrim(@texto))
      end

      return (@texto)
   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_PADL to tngsmodulos
grant execute on TNGS_PADL to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MAKESINO
--- </summary>
--- <param name="@sino">Caracter S/N</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEYESNO'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEYESNO'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEYESNO
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEYESNO
(
@sino char(1)
)
returns varchar(11)
as
   begin

      return case @sino
                when 'S' then 'SI'
                when 'N' then 'NO'
                else 'DESCONOCIDO'
             end

   end
go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEYESNO to tngsmodulos
grant execute on TNGS_MAKEYESNO to tngsqbe

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Función : MAKEVTEXT
--- </summary>
--- <param name="@sexo">Sexo</param>
---
---////////////////////////////////////////////////////////

print 'Function: TNGS_MAKEVTEXT'

if exists (select * from sysobjects where id = object_id('TNGS_MAKEVTEXT'))
begin
   print '       - Borrando la vieja Función'
   drop function TNGS_MAKEVTEXT
end
go

print '       - Creando la nueva Función'
go

create function TNGS_MAKEVTEXT
(
@texto text
)
returns varchar(60)
as
   begin
      declare @ret varchar(60),
              @temp varchar(60)

      select @temp= ltrim(rtrim(substring(@texto, 61, 60))),
             @ret= ltrim(rtrim(substring(@texto, 1, 60)))

      if @temp <> ' '
         begin
            select @ret= rtrim(substring(@ret, 1, 57)) + '...'
         end

      return (@ret)
   end

go

print '       - Asignando permisos a la Función'

grant execute on TNGS_MAKEVTEXT to tngsmodulos
grant execute on TNGS_MAKEVTEXT to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------*/
/* Fin del programa: Scrp03.sql                                             */
/*--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 29/08/2013 09:32
// Base de Datos      : TNGS_Rivn
// Tabla              : Categorias
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Categorias'

if exists (select * from sysobjects where id = object_id('dbo.Categorias'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Categorias
end
go

print '   - Creando la nueva tabla'

create table Categorias
   (
      cat_rcd_cod tngs_codigo_r,
      cat_des_des tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Categorias_pk primary key clustered
      (
         cat_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Categorias to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Categorias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 29/08/2013 09:32
// Base de Datos      : TNGS_Rivn
// Tabla              : Controles
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Controles'

if exists (select * from sysobjects where id = object_id('dbo.Controles'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Controles
end
go

print '   - Creando la nueva tabla'

create table Controles
   (
      ctl_cod_cod tngs_codigo,
      ctl_des_des tngs_descripcion,
      ctl_cd1_crit tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Controles_pk primary key clustered
      (
         ctl_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Controles to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Controles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 29/08/2013 09:32
// Base de Datos      : TNGS_Rivn
// Tabla              : ControlesReparations
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: ControlesReparations'

if exists (select * from sysobjects where id = object_id('dbo.ControlesReparations'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ControlesReparations
end
go

print '   - Creando la nueva tabla'

create table ControlesReparations
   (
      ctr_cod_codctl tngs_codigo,
      ctr_nro_nroitem tngs_numero,
      ctr_cd6_codrep tngs_codigo_6,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ControlesReparations_pk primary key clustered
      (
         ctr_cod_codctl
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ControlesReparations to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 20/09/2013 16:51
// Base de Datos      : TNGS_Rivn
// Tabla              : Parametros
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Parametros'

if exists (select * from sysobjects where id = object_id('dbo.Parametros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Parametros
end
go

print '   - Creando la nueva tabla'

create table Parametros
   (
      par_xcd_codigo tngs_codigo_x,
      par_des_descripcion tngs_descripcion,
      par_xde_valor tngs_descripcion_x,
      par_est_editable tngs_estado,
      par_est_sololectura tngs_estado,
      par_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Parametros_pk primary key clustered
      (
         par_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Parametros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 26/08/2013 16:39
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Reparaciones'

if exists (select * from sysobjects where id = object_id('dbo.Reparaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Reparaciones
end
go

print '   - Creando la nueva tabla'

create table Reparaciones
   (
      rep_cd6_cod tngs_codigo_6,
      rep_xde_des tngs_descripcion_x,
      rep_rcd_cat tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Reparaciones_pk primary key clustered
      (
         rep_cd6_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Reparaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 20/09/2013 16:51
// Base de Datos      : TNGS_Rivn
// Tabla              : Talonarios
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Rivn
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: Talonarios'

if exists (select * from sysobjects where id = object_id('dbo.Talonarios'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Talonarios
end
go

print '   - Creando la nueva tabla'

create table Talonarios
   (
      tal_xcd_codigo tngs_codigo_x,
      tal_des_descripcion tngs_descripcion,
      tal_cd1_tipo tngs_codigo_1,
      tal_nro_valor tngs_numero,
      tal_fyh_referencia tngs_fecyhor,
      tal_rob_detalle tngs_observaciones_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Talonarios_pk primary key clustered
      (
         tal_xcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Talonarios to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Talonarios
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Indices)                    
//----------------------------------------------------------------------------
// Fecha              : 26/08/2013 16:39
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
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

use TNGS_Rivn
go

/*-----------------------------------------------
// Crea el indice: is1
//-----------------------------------------------*/

print 'Indice: Reparaciones_is1'

print '    - Creando el nuevo indice'

create index Reparaciones_is1 on Reparaciones
   (
       rep_xde_des
   )
go

print '  '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los indices de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Categorias
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where deleted = 0
          order by cat_rcd_cod
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          order by cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_CHKVERSION
(
@cat_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Categorias
    where cat_rcd_cod = @cat_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_SEARCH
(
@cat_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where cat_rcd_cod = @cat_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select cat_rcd_cod,
                cat_des_des,
                TNGS_Rivn..Categorias.instante,
                TNGS_Rivn..Categorias.deleted,
                TNGS_Rivn..Categorias.usuario,
                TNGS_Rivn..Categorias.version
           from TNGS_Rivn..Categorias
          where cat_rcd_cod = @cat_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@cat_des_des">descripcion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_INSERT
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Categorias
   values (
           @cat_rcd_cod,
           @cat_des_des,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@cat_des_des">descripcion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_UPDATE
(
@cat_rcd_cod tngs_codigo_r,
@cat_des_des tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set cat_des_des= @cat_des_des,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DELETE
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_RECALL
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Categorias
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@cat_rcd_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_DROP
(
@cat_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Categorias
    where cat_rcd_cod = @cat_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Categorias
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getByDesc
--- </summary>
--- <param name="@desc">.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CATEGORIAS_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.CATEGORIAS_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CATEGORIAS_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CATEGORIAS_GETBYDESC
(
@desc tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   select * from Categorias 
    
         where cat_des_des like '%' + ltrim(rtrim(@desc)) + '%' 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CATEGORIAS_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Categorias
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Controles
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where deleted = 0
          order by ctl_cod_cod
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          order by ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_CHKVERSION
(
@ctl_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Controles
    where ctl_cod_cod = @ctl_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_SEARCH
(
@ctl_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where ctl_cod_cod = @ctl_cod_cod
            and deleted = 0
      end
   else
      begin
         Select ctl_cod_cod,
                ctl_des_des,
                ctl_cd1_crit,
                TNGS_Rivn..Controles.instante,
                TNGS_Rivn..Controles.deleted,
                TNGS_Rivn..Controles.usuario,
                TNGS_Rivn..Controles.version
           from TNGS_Rivn..Controles
          where ctl_cod_cod = @ctl_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Descripcion</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_INSERT
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Controles
   values (
           @ctl_cod_cod,
           @ctl_des_des,
           @ctl_cd1_crit,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Descripcion</param>
--- <param name="@ctl_cd1_crit">Critico</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_UPDATE
(
@ctl_cod_cod tngs_codigo,
@ctl_des_des tngs_descripcion,
@ctl_cd1_crit tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set ctl_des_des= @ctl_des_des,
          ctl_cd1_crit= @ctl_cd1_crit,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DELETE
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_RECALL
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Controles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_DROP
(
@ctl_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Controles
    where ctl_cod_cod = @ctl_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Controles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Controles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : ControlesReparations
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where TNGS_Rivn..ControlesReparations.deleted = 0
          order by ctr_cod_codctl
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          order by ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_CHKVERSION
(
@ctr_cod_codctl tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_SEARCH
(
@ctr_cod_codctl tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Rivn..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FSEARCH
(
@ctr_cod_codctl tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Rivn..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                ctr_cd6_codrep,
                ctl_des_des as ctr_des_des,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Controles
                  on ctr_cd6_codRep = ctl_cod_cod
          where ctr_cod_codctl = @ctr_cod_codctl
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@ctr_nro_nroitem">item</param>
--- <param name="@ctr_cd6_codrep">codigoReparacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_INSERT
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..ControlesReparations
   values (
           @ctr_cod_codctl,
           @ctr_nro_nroitem,
           @ctr_cd6_codrep,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@ctr_nro_nroitem">item</param>
--- <param name="@ctr_cd6_codrep">codigoReparacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_UPDATE
(
@ctr_cod_codctl tngs_codigo,
@ctr_nro_nroitem tngs_numero,
@ctr_cd6_codrep tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set ctr_nro_nroitem= @ctr_nro_nroitem,
          ctr_cd6_codrep= @ctr_cd6_codrep,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DELETE
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDELETE
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..ControlesReparations
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_RECALL
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..ControlesReparations
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FRECALL
(
@ctr_cod_codctl tngs_codigo,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
      end
   else
      begin
         Update TNGS_Rivn..ControlesReparations
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where ctr_cod_codctl = @ctr_cod_codctl
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_DROP
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FDROP
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FDROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..ControlesReparations
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@ctr_cod_codctl">codigoControl</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLESREPARATIONS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLESREPARATIONS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLESREPARATIONS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLESREPARATIONS_FPACK
(
@ctr_cod_codctl tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLESREPARATIONS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Equipamiento
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_UP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where deleted = 0
          order by eqi_cod_cod
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          order by eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_CHKVERSION
(
@eqi_cod_cod tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_SEARCH
(
@eqi_cod_cod tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
            and deleted = 0
      end
   else
      begin
         Select eqi_cod_cod,
                eqi_des_des,
                eqi_imp_valor,
                TNGS_Rivn..Equipamiento.instante,
                TNGS_Rivn..Equipamiento.deleted,
                TNGS_Rivn..Equipamiento.usuario,
                TNGS_Rivn..Equipamiento.version
           from TNGS_Rivn..Equipamiento
          where eqi_cod_cod = @eqi_cod_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@eqi_des_des">des</param>
--- <param name="@eqi_imp_valor">valor</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_INSERT
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Equipamiento
   values (
           @eqi_cod_cod,
           @eqi_des_des,
           @eqi_imp_valor,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@eqi_des_des">des</param>
--- <param name="@eqi_imp_valor">valor</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_UPDATE
(
@eqi_cod_cod tngs_codigo,
@eqi_des_des tngs_descripcion,
@eqi_imp_valor tngs_importe,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set eqi_des_des= @eqi_des_des,
          eqi_imp_valor= @eqi_imp_valor,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DELETE
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_RECALL
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Equipamiento
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@eqi_cod_cod">cod</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_DROP
(
@eqi_cod_cod tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Equipamiento
    where eqi_cod_cod = @eqi_cod_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Equipamiento
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Parametros
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where deleted = 0
          order by par_xcd_codigo
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          order by par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_CHKVERSION
(
@par_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Parametros
    where par_xcd_codigo = @par_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_SEARCH
(
@par_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where par_xcd_codigo = @par_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select par_xcd_codigo,
                par_des_descripcion,
                par_xde_valor,
                par_est_editable,
                par_est_sololectura,
                par_rob_detalle,
                TNGS_Rivn..Parametros.instante,
                TNGS_Rivn..Parametros.deleted,
                TNGS_Rivn..Parametros.usuario,
                TNGS_Rivn..Parametros.version
           from TNGS_Rivn..Parametros
          where par_xcd_codigo = @par_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_INSERT
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Parametros
   values (
           @par_xcd_codigo,
           @par_des_descripcion,
           @par_xde_valor,
           @par_est_editable,
           @par_est_sololectura,
           @par_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@par_des_descripcion">Descripción</param>
--- <param name="@par_xde_valor">Valor</param>
--- <param name="@par_est_editable">Editable</param>
--- <param name="@par_est_sololectura">Sólo lectura</param>
--- <param name="@par_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_UPDATE
(
@par_xcd_codigo tngs_codigo_x,
@par_des_descripcion tngs_descripcion,
@par_xde_valor tngs_descripcion_x,
@par_est_editable tngs_estado,
@par_est_sololectura tngs_estado,
@par_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set par_des_descripcion= @par_des_descripcion,
          par_xde_valor= @par_xde_valor,
          par_est_editable= @par_est_editable,
          par_est_sololectura= @par_est_sololectura,
          par_rob_detalle= @par_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DELETE
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_RECALL
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Parametros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@par_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_DROP
(
@par_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Parametros
    where par_xcd_codigo = @par_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.PARAMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.PARAMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.PARAMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.PARAMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Parametros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.PARAMETROS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Parametros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_CHKVERSION
(
@rep_cd6_cod tngs_codigo_6,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_SEARCH
(
@rep_cd6_cod tngs_codigo_6,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
            and TNGS_Rivn..Reparaciones.deleted = 0
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_cd6_cod = @rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FSEARCH
(
@rep_rcd_cat tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
            and TNGS_Rivn..Reparaciones.deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                cat_des_des as rep_des_des,
                rep_rcd_cat,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
                join TNGS_Rivn..Categorias
                  on rep_rcd_cat = cat_rcd_cod
          where rep_rcd_cat = @rep_rcd_cat
          order by rep_cd6_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_INSERT
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Reparaciones
   values (
           @rep_cd6_cod,
           @rep_xde_des,
           @rep_rcd_cat,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@rep_xde_des">descripcion</param>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_UPDATE
(
@rep_cd6_cod tngs_codigo_6,
@rep_xde_des tngs_descripcion_x,
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set rep_xde_des= @rep_xde_des,
          rep_rcd_cat= @rep_rcd_cat,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DELETE
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDELETE
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..Reparaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_RECALL
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FRECALL
(
@rep_rcd_cat tngs_codigo_r,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
      end
   else
      begin
         Update TNGS_Rivn..Reparaciones
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where rep_rcd_cat = @rep_rcd_cat
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">codigo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_DROP
(
@rep_cd6_cod tngs_codigo_6,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_cd6_cod = @rep_cd6_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FDROP
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FDROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Reparaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@rep_rcd_cat">categoria</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_FPACK
(
@rep_rcd_cat tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Reparaciones
    where rep_rcd_cat = @rep_rcd_cat
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: Getbydesc
--- </summary>
--- <param name="@des">Levanta descripciones de las reparaciones.</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.REPARACIONES_GETBYDESC'

if exists (select * from sysobjects where id = object_id('dbo.REPARACIONES_GETBYDESC'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.REPARACIONES_GETBYDESC
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.REPARACIONES_GETBYDESC
(
@des tngs_descripcion_10,
@usuario tngs_nombre
)
as
begin

   select * from Reparaciones 
   where rep_xde_des like '%' + rtrim(@des) + '%' 
    

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.REPARACIONES_GETBYDESC to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Reparaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 20/09/2013 17:49
// Sistema     : Rivn
// Tabla       : Talonarios
//----------------------------------------------------------------------------
// © 1999-2013 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma automática. Cualquier
/     modificación que se realize sobre él se perderá en la próxima
/     regeneración.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se crearan los SPs */
/*-------------------------------------------------*/

use TNGS_Rivn
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Levanta todos los registros de una tabla
--- </summary>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where deleted = 0
          order by tal_xcd_codigo
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          order by tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_CHKVERSION
(
@tal_xcd_codigo tngs_codigo_x,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_SEARCH
(
@tal_xcd_codigo tngs_codigo_x,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where tal_xcd_codigo = @tal_xcd_codigo
            and deleted = 0
      end
   else
      begin
         Select tal_xcd_codigo,
                tal_des_descripcion,
                tal_cd1_tipo,
                tal_nro_valor,
                tal_fyh_referencia,
                tal_rob_detalle,
                TNGS_Rivn..Talonarios.instante,
                TNGS_Rivn..Talonarios.deleted,
                TNGS_Rivn..Talonarios.usuario,
                TNGS_Rivn..Talonarios.version
           from TNGS_Rivn..Talonarios
          where tal_xcd_codigo = @tal_xcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_INSERT
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Talonarios
   values (
           @tal_xcd_codigo,
           @tal_des_descripcion,
           @tal_cd1_tipo,
           @tal_nro_valor,
           @tal_fyh_referencia,
           @tal_rob_detalle,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@tal_des_descripcion">Descripción</param>
--- <param name="@tal_cd1_tipo">Tipo</param>
--- <param name="@tal_nro_valor">Número</param>
--- <param name="@tal_fyh_referencia">Referencia</param>
--- <param name="@tal_rob_detalle">Detalle</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_UPDATE
(
@tal_xcd_codigo tngs_codigo_x,
@tal_des_descripcion tngs_descripcion,
@tal_cd1_tipo tngs_codigo_1,
@tal_nro_valor tngs_numero,
@tal_fyh_referencia tngs_fecyhor,
@tal_rob_detalle tngs_observaciones_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set tal_des_descripcion= @tal_des_descripcion,
          tal_cd1_tipo= @tal_cd1_tipo,
          tal_nro_valor= @tal_nro_valor,
          tal_fyh_referencia= @tal_fyh_referencia,
          tal_rob_detalle= @tal_rob_detalle,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DELETE
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_RECALL
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Talonarios
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@tal_xcd_codigo">Código</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_DROP
(
@tal_xcd_codigo tngs_codigo_x,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Talonarios
    where tal_xcd_codigo = @tal_xcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registros borrados lógicamente
--- </summary>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.TALONARIOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.TALONARIOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.TALONARIOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.TALONARIOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Talonarios
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.TALONARIOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Talonarios
//--------------------------------------------------------------------------*/
