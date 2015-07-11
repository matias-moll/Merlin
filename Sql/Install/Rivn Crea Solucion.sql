/*---------------------------------------------------------------------------
//                   TNG Software (Scripts iniciales de la Base)
//---------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de los usuarios de la base
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de los tipos de datos
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print '                        - tiempo'
EXEC sp_addtype tngs_tiempo, 'int', 'NOT NULL'
go

print '                        - numero_e'
EXEC sp_addtype tngs_numero_e, 'bigint', 'NOT NULL'
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Objetivo           : Creación de las funciones básicas
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Categorias
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Controles
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : ControlesReparations
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
         ctr_cod_codctl,
         ctr_nro_nroitem
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Equipamiento
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Equipamiento'

if exists (select * from sysobjects where id = object_id('dbo.Equipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Equipamiento
end
go

print '   - Creando la nueva tabla'

create table Equipamiento
   (
      eqi_cod_cod tngs_codigo,
      eqi_des_des tngs_descripcion,
      eqi_imp_valor tngs_importe,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Equipamiento_pk primary key clustered
      (
         eqi_cod_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Equipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Equipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Estaciones
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Estaciones'

if exists (select * from sysobjects where id = object_id('dbo.Estaciones'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estaciones
end
go

print '   - Creando la nueva tabla'

create table Estaciones
   (
      ets_rcd_cod tngs_codigo_r,
      ets_des_des tngs_descripcion,
      ets_ede_domicilio tngs_descripcion_e,
      ets_des_contacto tngs_descripcion,
      ets_ete_telefono tngs_telefono_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estaciones_pk primary key clustered
      (
         ets_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estaciones to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Estados
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Estados'

if exists (select * from sysobjects where id = object_id('dbo.Estados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Estados
end
go

print '   - Creando la nueva tabla'

create table Estados
   (
      est_rcd_cod tngs_codigo_r,
      est_des_des tngs_descripcion,
      est_txt_txtcontingencia tngs_texto,
      est_cd1_operativo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Estados_pk primary key clustered
      (
         est_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Estados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Estados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Marcas
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Marcas'

if exists (select * from sysobjects where id = object_id('dbo.Marcas'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Marcas
end
go

print '   - Creando la nueva tabla'

create table Marcas
   (
      mrc_rcd_codigo tngs_codigo_r,
      mrc_des_descripcion tngs_descripcion,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Marcas_pk primary key clustered
      (
         mrc_rcd_codigo
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Marcas to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Modelos
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Modelos'

if exists (select * from sysobjects where id = object_id('dbo.Modelos'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Modelos
end
go

print '   - Creando la nueva tabla'

create table Modelos
   (
      mds_rcd_cod tngs_codigo_r,
      mds_des_des tngs_descripcion,
      mds_rcd_codmarca tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Modelos_pk primary key clustered
      (
         mds_rcd_cod
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Modelos to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Modelos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Moviles
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: Moviles'

if exists (select * from sysobjects where id = object_id('dbo.Moviles'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.Moviles
end
go

print '   - Creando la nueva tabla'

create table Moviles
   (
      mov_ecd_patente tngs_codigo_e,
      mov_des_des tngs_descripcion,
      mov_txt_anot tngs_texto,
      mov_des_nrochasis tngs_descripcion,
      mov_des_nromotor tngs_descripcion,
      mov_rcd_modelo tngs_codigo_r,
      mov_nro_aniofabric tngs_numero,
      mov_cd1_propio tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint Moviles_pk primary key clustered
      (
         mov_ecd_patente
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on Moviles to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: Moviles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlCombustible
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlCombustible'

if exists (select * from sysobjects where id = object_id('dbo.MvlCombustible'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlCombustible
end
go

print '   - Creando la nueva tabla'

create table MvlCombustible
   (
      mco_ecd_patente tngs_codigo_e,
      mco_fyh_fecha tngs_fecyhor,
      mco_val_litros tngs_valor,
      mco_imp_importe tngs_importe,
      mco_rcd_codestacion tngs_codigo_r,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlCombustible_pk primary key clustered
      (
         mco_ecd_patente,
         mco_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlCombustible to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlEquipamiento
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlEquipamiento'

if exists (select * from sysobjects where id = object_id('dbo.MvlEquipamiento'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEquipamiento
end
go

print '   - Creando la nueva tabla'

create table MvlEquipamiento
   (
      meq_ecd_patente tngs_codigo_e,
      meq_cod_codequip tngs_codigo,
      meq_cd1_esfijo tngs_codigo_1,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEquipamiento_pk primary key clustered
      (
         meq_ecd_patente,
         meq_cod_codequip
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEquipamiento to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlEstados
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlEstados'

if exists (select * from sysobjects where id = object_id('dbo.MvlEstados'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlEstados
end
go

print '   - Creando la nueva tabla'

create table MvlEstados
   (
      mve_ecd_patente tngs_codigo_e,
      mve_fyh_fecha tngs_fecyhor,
      mve_rcd_codestado tngs_codigo_r,
      mve_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlEstados_pk primary key clustered
      (
         mve_ecd_patente,
         mve_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlEstados to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : MvlKilometros
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: MvlKilometros'

if exists (select * from sysobjects where id = object_id('dbo.MvlKilometros'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.MvlKilometros
end
go

print '   - Creando la nueva tabla'

create table MvlKilometros
   (
      mkm_ecd_patente tngs_codigo_e,
      mkm_fyh_fecha tngs_fecyhor,
      mkm_nro_km tngs_numero,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint MvlKilometros_pk primary key clustered
      (
         mkm_ecd_patente,
         mkm_fyh_fecha
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on MvlKilometros to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : OrdenesTrabajo
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: OrdenesTrabajo'

if exists (select * from sysobjects where id = object_id('dbo.OrdenesTrabajo'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.OrdenesTrabajo
end
go

print '   - Creando la nueva tabla'

create table OrdenesTrabajo
   (
      odt_nro_nro tngs_numero,
      odt_ecd_patente tngs_codigo_e,
      odt_fyh_fecapertura tngs_fecyhor,
      odt_nom_operador tngs_nombre,
      odt_fyh_feccierre tngs_fecyhor,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint OrdenesTrabajo_pk primary key clustered
      (
         odt_nro_nro
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on OrdenesTrabajo to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : OtItems
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Tabla: OtItems'

if exists (select * from sysobjects where id = object_id('dbo.OtItems'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.OtItems
end
go

print '   - Creando la nueva tabla'

create table OtItems
   (
      oti_nro_nroot tngs_numero,
      oti_nro_nroagrupador tngs_numero,
      oti_nro_nroitem tngs_numero,
      oti_des_desoperacion tngs_descripcion,
      oti_des_destarea tngs_descripcion,
      oti_des_descategoria tngs_descripcion,
      oti_imp_importe tngs_importe,
      oti_ede_comentario tngs_descripcion_e,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint OtItems_pk primary key clustered
      (
         oti_nro_nroot,
         oti_nro_nroagrupador,
         oti_nro_nroitem
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on OtItems to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: OtItems
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Parametros
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
      rep_rcd_codcat tngs_codigo_r,
      rep_cd1_solicitadetalle tngs_codigo_1,
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Talonarios
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha              : 11/07/2015 08:29
// Base de Datos      : TNGS_Rivn
// Tabla              : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Categorias
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
--- <param name="@cat_des_des">Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
--- <param name="@cat_rcd_cod">Cod Categoria</param>
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Controles
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.CONTROLES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.CONTROLES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.CONTROLES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.CONTROLES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ctl_cod_cod), '0') as ctl_cod_cod
     from TNGS_Rivn..Controles

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.CONTROLES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ctl_cod_cod">Codigo</param>
--- <param name="@ctl_des_des">Control</param>
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
--- <param name="@ctl_des_des">Control</param>
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : ControlesReparations
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where TNGS_Rivn..ControlesReparations.deleted = 0
          order by ctr_cod_codctl,
                ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          order by ctr_cod_codctl,
                ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
            and TNGS_Rivn..ControlesReparations.deleted = 0
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and ctr_nro_nroitem = @ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
            and TNGS_Rivn..ControlesReparations.deleted = 0
          order by ctr_nro_nroitem
      end
   else
      begin
         Select ctr_cod_codctl,
                ctr_nro_nroitem,
                rep_xde_des as ctr_des_descRep,
                ctr_cd6_codrep,
                TNGS_Rivn..ControlesReparations.instante,
                TNGS_Rivn..ControlesReparations.deleted,
                TNGS_Rivn..ControlesReparations.usuario,
                TNGS_Rivn..ControlesReparations.version
           from TNGS_Rivn..ControlesReparations
                join TNGS_Rivn..Reparaciones
                  on ctr_cd6_codRep = rep_cd6_cod
          where ctr_cod_codctl = @ctr_cod_codctl
          order by ctr_nro_nroitem
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
--- <param name="@ctr_cd6_codrep">Codigo de Reparacion</param>
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
      set ctr_cd6_codrep= @ctr_cd6_codrep,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
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
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
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
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
--- <param name="@ctr_nro_nroitem">Item</param>
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
@ctr_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..ControlesReparations
    where ctr_cod_codctl = @ctr_cod_codctl
      and ctr_nro_nroitem = @ctr_nro_nroitem

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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
--- <param name="@ctr_cod_codctl">Codigo Control</param>
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Equipamiento
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.EQUIPAMIENTO_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.EQUIPAMIENTO_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.EQUIPAMIENTO_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.EQUIPAMIENTO_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(eqi_cod_cod), '0') as eqi_cod_cod
     from TNGS_Rivn..Equipamiento

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.EQUIPAMIENTO_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
--- <param name="@eqi_des_des">Equipamiento</param>
--- <param name="@eqi_imp_valor">Importe</param>
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
--- <param name="@eqi_cod_cod">Codigo Equipamiento</param>
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Estaciones
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.ESTACIONES_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where deleted = 0
          order by ets_rcd_cod
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          order by ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_CHKVERSION
(
@ets_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Estaciones
    where ets_rcd_cod = @ets_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_SEARCH
(
@ets_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select ets_rcd_cod,
                ets_des_des,
                ets_ede_domicilio,
                ets_des_contacto,
                ets_ete_telefono,
                TNGS_Rivn..Estaciones.instante,
                TNGS_Rivn..Estaciones.deleted,
                TNGS_Rivn..Estaciones.usuario,
                TNGS_Rivn..Estaciones.version
           from TNGS_Rivn..Estaciones
          where ets_rcd_cod = @ets_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(ets_rcd_cod), '0') as ets_rcd_cod
     from TNGS_Rivn..Estaciones

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@ets_des_des">Estacion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_INSERT
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Estaciones
   values (
           @ets_rcd_cod,
           @ets_des_des,
           @ets_ede_domicilio,
           @ets_des_contacto,
           @ets_ete_telefono,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@ets_des_des">Estacion</param>
--- <param name="@ets_ede_domicilio">Domicilio</param>
--- <param name="@ets_des_contacto">Contacto</param>
--- <param name="@ets_ete_telefono">Telefono</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_UPDATE
(
@ets_rcd_cod tngs_codigo_r,
@ets_des_des tngs_descripcion,
@ets_ede_domicilio tngs_descripcion_e,
@ets_des_contacto tngs_descripcion,
@ets_ete_telefono tngs_telefono_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set ets_des_des= @ets_des_des,
          ets_ede_domicilio= @ets_ede_domicilio,
          ets_des_contacto= @ets_des_contacto,
          ets_ete_telefono= @ets_ete_telefono,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DELETE
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_RECALL
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estaciones
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@ets_rcd_cod">Codigo Estacion</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTACIONES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_DROP
(
@ets_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Estaciones
    where ets_rcd_cod = @ets_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTACIONES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTACIONES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTACIONES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTACIONES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Estaciones
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTACIONES_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estaciones
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Estados
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.ESTADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where deleted = 0
          order by est_rcd_cod
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          order by est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_CHKVERSION
(
@est_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Estados
    where est_rcd_cod = @est_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_SEARCH
(
@est_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where est_rcd_cod = @est_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select est_rcd_cod,
                est_des_des,
                est_txt_txtcontingencia,
                est_cd1_operativo,
                TNGS_Rivn..Estados.instante,
                TNGS_Rivn..Estados.deleted,
                TNGS_Rivn..Estados.usuario,
                TNGS_Rivn..Estados.version
           from TNGS_Rivn..Estados
          where est_rcd_cod = @est_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(est_rcd_cod), '0') as est_rcd_cod
     from TNGS_Rivn..Estados

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_INSERT
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Estados
   values (
           @est_rcd_cod,
           @est_des_des,
           @est_txt_txtcontingencia,
           @est_cd1_operativo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@est_des_des">Estado</param>
--- <param name="@est_txt_txtcontingencia">Texto de Contingencia</param>
--- <param name="@est_cd1_operativo">Operativo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_UPDATE
(
@est_rcd_cod tngs_codigo_r,
@est_des_des tngs_descripcion,
@est_txt_txtcontingencia tngs_texto,
@est_cd1_operativo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set est_des_des= @est_des_des,
          est_txt_txtcontingencia= @est_txt_txtcontingencia,
          est_cd1_operativo= @est_cd1_operativo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DELETE
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_RECALL
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Estados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@est_rcd_cod">Codigo Estado</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ESTADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_DROP
(
@est_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Estados
    where est_rcd_cod = @est_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ESTADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ESTADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ESTADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ESTADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Estados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ESTADOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Estados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Marcas
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MARCAS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where deleted = 0
          order by mrc_rcd_codigo
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          order by mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_CHKVERSION
(
@mrc_rcd_codigo tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_SEARCH
(
@mrc_rcd_codigo tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
            and deleted = 0
      end
   else
      begin
         Select mrc_rcd_codigo,
                mrc_des_descripcion,
                TNGS_Rivn..Marcas.instante,
                TNGS_Rivn..Marcas.deleted,
                TNGS_Rivn..Marcas.usuario,
                TNGS_Rivn..Marcas.version
           from TNGS_Rivn..Marcas
          where mrc_rcd_codigo = @mrc_rcd_codigo
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mrc_rcd_codigo), '0') as mrc_rcd_codigo
     from TNGS_Rivn..Marcas

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_INSERT
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Marcas
   values (
           @mrc_rcd_codigo,
           @mrc_des_descripcion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@mrc_des_descripcion">Marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_UPDATE
(
@mrc_rcd_codigo tngs_codigo_r,
@mrc_des_descripcion tngs_descripcion,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set mrc_des_descripcion= @mrc_des_descripcion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DELETE
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_RECALL
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Marcas
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mrc_rcd_codigo">Codigo Marca</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MARCAS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_DROP
(
@mrc_rcd_codigo tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Marcas
    where mrc_rcd_codigo = @mrc_rcd_codigo

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MARCAS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MARCAS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MARCAS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MARCAS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Marcas
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MARCAS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Marcas
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Modelos
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MODELOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where deleted = 0
          order by mds_rcd_cod
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          order by mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_CHKVERSION
(
@mds_rcd_cod tngs_codigo_r,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_SEARCH
(
@mds_rcd_cod tngs_codigo_r,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
            and deleted = 0
      end
   else
      begin
         Select mds_rcd_cod,
                mds_des_des,
                mds_rcd_codmarca,
                TNGS_Rivn..Modelos.instante,
                TNGS_Rivn..Modelos.deleted,
                TNGS_Rivn..Modelos.usuario,
                TNGS_Rivn..Modelos.version
           from TNGS_Rivn..Modelos
          where mds_rcd_cod = @mds_rcd_cod
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca la clave máxima de la tabla
--- </summary>
--- <param name="@reservado">Reservado para futuras expansiones</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_GETMAXKEY'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_GETMAXKEY'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_GETMAXKEY
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_GETMAXKEY
(
@dummy tngs_codigo_1
)
as
begin

   Select isnull(max(mds_rcd_cod), '0') as mds_rcd_cod
     from TNGS_Rivn..Modelos

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_GETMAXKEY to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@mds_des_des">Modelo</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_INSERT
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Modelos
   values (
           @mds_rcd_cod,
           @mds_des_des,
           @mds_rcd_codmarca,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@mds_des_des">Modelo</param>
--- <param name="@mds_rcd_codmarca">Codigo de la marca</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_UPDATE
(
@mds_rcd_cod tngs_codigo_r,
@mds_des_des tngs_descripcion,
@mds_rcd_codmarca tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set mds_des_des= @mds_des_des,
          mds_rcd_codmarca= @mds_rcd_codmarca,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DELETE
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_RECALL
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Modelos
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mds_rcd_cod">Codigo Modelo</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MODELOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_DROP
(
@mds_rcd_cod tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Modelos
    where mds_rcd_cod = @mds_rcd_cod

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MODELOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MODELOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MODELOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MODELOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Modelos
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MODELOS_PACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Modelos
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Moviles
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MOVILES_UP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where deleted = 0
          order by mov_ecd_patente
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          order by mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_CHKVERSION
(
@mov_ecd_patente tngs_codigo_e,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_SEARCH
(
@mov_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
            and deleted = 0
      end
   else
      begin
         Select mov_ecd_patente,
                mov_des_des,
                mov_txt_anot,
                mov_des_nrochasis,
                mov_des_nromotor,
                mov_rcd_modelo,
                mov_nro_aniofabric,
                mov_cd1_propio,
                TNGS_Rivn..Moviles.instante,
                TNGS_Rivn..Moviles.deleted,
                TNGS_Rivn..Moviles.usuario,
                TNGS_Rivn..Moviles.version
           from TNGS_Rivn..Moviles
          where mov_ecd_patente = @mov_ecd_patente
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">Descripcion</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_INSERT
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Moviles
   values (
           @mov_ecd_patente,
           @mov_des_des,
           @mov_txt_anot,
           @mov_des_nrochasis,
           @mov_des_nromotor,
           @mov_rcd_modelo,
           @mov_nro_aniofabric,
           @mov_cd1_propio,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@mov_des_des">Descripcion</param>
--- <param name="@mov_txt_anot">Anotaciones</param>
--- <param name="@mov_des_nrochasis">Nro Chasis</param>
--- <param name="@mov_des_nromotor">Nro Motor</param>
--- <param name="@mov_rcd_modelo">Modelo</param>
--- <param name="@mov_nro_aniofabric">Año de fabricación</param>
--- <param name="@mov_cd1_propio">Propio o no</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_UPDATE
(
@mov_ecd_patente tngs_codigo_e,
@mov_des_des tngs_descripcion,
@mov_txt_anot tngs_texto,
@mov_des_nrochasis tngs_descripcion,
@mov_des_nromotor tngs_descripcion,
@mov_rcd_modelo tngs_codigo_r,
@mov_nro_aniofabric tngs_numero,
@mov_cd1_propio tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set mov_des_des= @mov_des_des,
          mov_txt_anot= @mov_txt_anot,
          mov_des_nrochasis= @mov_des_nrochasis,
          mov_des_nromotor= @mov_des_nromotor,
          mov_rcd_modelo= @mov_rcd_modelo,
          mov_nro_aniofabric= @mov_nro_aniofabric,
          mov_cd1_propio= @mov_cd1_propio,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DELETE
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_RECALL
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Moviles
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mov_ecd_patente">Patente de la Ambulancia</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_DROP
(
@mov_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..Moviles
    where mov_ecd_patente = @mov_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_DROP to tngsmodulos

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

print 'Store Procedure: dbo.MOVILES_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..Moviles
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getMovilesTree
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MOVILES_GETMOVILESTREE'

if exists (select * from sysobjects where id = object_id('dbo.MOVILES_GETMOVILESTREE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MOVILES_GETMOVILESTREE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MOVILES_GETMOVILESTREE
(
@usuario tngs_nombre
)
as
begin

   select mov_ecd_patente, 
   		mov_des_des, 
   		2 as Nivel, 
   		2 as Orden , 
   		1 as Imagen, 
   		2 as Niveles 
     		from TNGS_Rivn..Moviles 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MOVILES_GETMOVILESTREE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: Moviles
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : MvlCombustible
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where deleted = 0
          order by mco_ecd_patente,
                mco_fyh_fecha
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          order by mco_ecd_patente,
                mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_CHKVERSION
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_SEARCH
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and mco_fyh_fecha = @mco_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and mco_fyh_fecha = @mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FSEARCH
(
@mco_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
            and deleted = 0
          order by mco_fyh_fecha
      end
   else
      begin
         Select mco_ecd_patente,
                mco_fyh_fecha,
                mco_val_litros,
                mco_imp_importe,
                mco_rcd_codestacion,
                TNGS_Rivn..MvlCombustible.instante,
                TNGS_Rivn..MvlCombustible.deleted,
                TNGS_Rivn..MvlCombustible.usuario,
                TNGS_Rivn..MvlCombustible.version
           from TNGS_Rivn..MvlCombustible
          where mco_ecd_patente = @mco_ecd_patente
          order by mco_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@mco_val_litros">Litros Cargados</param>
--- <param name="@mco_imp_importe">Importe</param>
--- <param name="@mco_rcd_codestacion">Codigo estacion</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_INSERT
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@mco_val_litros tngs_valor,
@mco_imp_importe tngs_importe,
@mco_rcd_codestacion tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlCombustible
   values (
           @mco_ecd_patente,
           @mco_fyh_fecha,
           @mco_val_litros,
           @mco_imp_importe,
           @mco_rcd_codestacion,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@mco_val_litros">Litros Cargados</param>
--- <param name="@mco_imp_importe">Importe</param>
--- <param name="@mco_rcd_codestacion">Codigo estacion</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_UPDATE
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@mco_val_litros tngs_valor,
@mco_imp_importe tngs_importe,
@mco_rcd_codestacion tngs_codigo_r,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set mco_val_litros= @mco_val_litros,
          mco_imp_importe= @mco_imp_importe,
          mco_rcd_codestacion= @mco_rcd_codestacion,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_DELETE
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FDELETE
(
@mco_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlCombustible
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_RECALL
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlCombustible
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FRECALL
(
@mco_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlCombustible
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mco_ecd_patente = @mco_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlCombustible
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mco_ecd_patente = @mco_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@mco_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_DROP
(
@mco_ecd_patente tngs_codigo_e,
@mco_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and mco_fyh_fecha = @mco_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FDROP
(
@mco_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlCombustible
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mco_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_FPACK
(
@mco_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlCombustible
    where mco_ecd_patente = @mco_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlCombus
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS'

if exists (select * from sysobjects where id = object_id('dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 mco_val_litros, 
   mco_imp_importe, 
   mco_fyh_fecha, 
   ets_des_des 
    
   FROM TNGS_Rivn..MvlCombustible 
   JOIN TNGS_Rivn..Estaciones 
   on mco_rcd_codestacion = ets_rcd_cod 
   WHERE mco_ecd_patente = @patente 
   ORDER BY mco_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLCOMBUSTIBLE_GETLASTFIVEMVLCOMBUS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlCombustible
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : MvlEquipamiento
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where TNGS_Rivn..MvlEquipamiento.deleted = 0
          order by meq_ecd_patente,
                meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          order by meq_ecd_patente,
                meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_CHKVERSION
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_SEARCH
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and meq_cod_codequip = @meq_cod_codequip
            and TNGS_Rivn..MvlEquipamiento.deleted = 0
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and meq_cod_codequip = @meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FSEARCH
(
@meq_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
            and TNGS_Rivn..MvlEquipamiento.deleted = 0
          order by meq_cod_codequip
      end
   else
      begin
         Select meq_ecd_patente,
                meq_cod_codequip,
                eqi_des_des as meq_des_Equip,
                meq_cd1_esfijo,
                TNGS_Rivn..MvlEquipamiento.instante,
                TNGS_Rivn..MvlEquipamiento.deleted,
                TNGS_Rivn..MvlEquipamiento.usuario,
                TNGS_Rivn..MvlEquipamiento.version
           from TNGS_Rivn..MvlEquipamiento
                join TNGS_Rivn..Equipamiento
                  on meq_cod_codequip = eqi_cod_cod
          where meq_ecd_patente = @meq_ecd_patente
          order by meq_cod_codequip
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@meq_cd1_esfijo">equipamiento es fijo</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_INSERT
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@meq_cd1_esfijo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlEquipamiento
   values (
           @meq_ecd_patente,
           @meq_cod_codequip,
           @meq_cd1_esfijo,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@meq_cd1_esfijo">equipamiento es fijo</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_UPDATE
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@meq_cd1_esfijo tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEquipamiento
      set meq_cd1_esfijo= @meq_cd1_esfijo,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_DELETE
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEquipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FDELETE
(
@meq_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlEquipamiento
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_RECALL
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEquipamiento
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FRECALL
(
@meq_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlEquipamiento
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where meq_ecd_patente = @meq_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlEquipamiento
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where meq_ecd_patente = @meq_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@meq_cod_codequip">Codigo del Equipamento.</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_DROP
(
@meq_ecd_patente tngs_codigo_e,
@meq_cod_codequip tngs_codigo,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and meq_cod_codequip = @meq_cod_codequip

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FDROP
(
@meq_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlEquipamiento
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@meq_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_FPACK
(
@meq_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEquipamiento
    where meq_ecd_patente = @meq_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: EliminarEquipamiento
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   DELETE FROM TNGS_Rivn..MvlEquipamiento 
   WHERE @patente=meq_ecd_patente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_ELIMINAREQUIPAMIENTO to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getEquipamientos
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS'

if exists (select * from sysobjects where id = object_id('dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 eqi_des_des 
    
   FROM TNGS_Rivn..MvlEquipamiento 
   JOIN TNGS_Rivn..Equipamiento 
   on meq_cod_codequip = eqi_cod_cod 
   WHERE meq_ecd_patente = @patente 
   ORDER BY eqi_des_des 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLEQUIPAMIENTO_GETEQUIPAMIENTOS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEquipamiento
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : MvlEstados
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MVLESTADOS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          where deleted = 0
          order by mve_ecd_patente,
                mve_fyh_fecha
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          order by mve_ecd_patente,
                mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_CHKVERSION
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_SEARCH
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and mve_fyh_fecha = @mve_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and mve_fyh_fecha = @mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FSEARCH
(
@mve_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
            and deleted = 0
          order by mve_fyh_fecha
      end
   else
      begin
         Select mve_ecd_patente,
                mve_fyh_fecha,
                mve_rcd_codestado,
                mve_nro_km,
                TNGS_Rivn..MvlEstados.instante,
                TNGS_Rivn..MvlEstados.deleted,
                TNGS_Rivn..MvlEstados.usuario,
                TNGS_Rivn..MvlEstados.version
           from TNGS_Rivn..MvlEstados
          where mve_ecd_patente = @mve_ecd_patente
          order by mve_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@mve_rcd_codestado">Codigo del estado.</param>
--- <param name="@mve_nro_km">Kilometraje</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_INSERT
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@mve_rcd_codestado tngs_codigo_r,
@mve_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlEstados
   values (
           @mve_ecd_patente,
           @mve_fyh_fecha,
           @mve_rcd_codestado,
           @mve_nro_km,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@mve_rcd_codestado">Codigo del estado.</param>
--- <param name="@mve_nro_km">Kilometraje</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_UPDATE
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@mve_rcd_codestado tngs_codigo_r,
@mve_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEstados
      set mve_rcd_codestado= @mve_rcd_codestado,
          mve_nro_km= @mve_nro_km,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_DELETE
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEstados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FDELETE
(
@mve_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlEstados
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_RECALL
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlEstados
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FRECALL
(
@mve_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlEstados
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mve_ecd_patente = @mve_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@mve_fyh_fecha">Fecha y Hora</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_DROP
(
@mve_ecd_patente tngs_codigo_e,
@mve_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and mve_fyh_fecha = @mve_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FDROP
(
@mve_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLESTADOS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlEstados
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mve_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_FPACK
(
@mve_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlEstados
    where mve_ecd_patente = @mve_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlEstads
--- </summary>
--- <param name="@patente">patente del movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'

if exists (select * from sysobjects where id = object_id('dbo.MVLESTADOS_GETLASTFIVEMVLESTADS'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLESTADOS_GETLASTFIVEMVLESTADS
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 est_des_des, 
   mve_nro_km, 
   mve_fyh_fecha, 
   mve_rcd_codestado 
   FROM TNGS_Rivn..MvlEstados 
   JOIN TNGS_Rivn..Estados 
   on mve_rcd_codestado = est_rcd_cod 
   WHERE mve_ecd_patente = @patente 
   ORDER BY mve_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLESTADOS_GETLASTFIVEMVLESTADS to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlEstados
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : MvlKilometros
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.MVLKILOMETROS_UP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where deleted = 0
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          order by mkm_ecd_patente,
                mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_CHKVERSION
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_SEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
            and deleted = 0
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and mkm_fyh_fecha = @mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FSEARCH
(
@mkm_ecd_patente tngs_codigo_e,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
            and deleted = 0
          order by mkm_fyh_fecha
      end
   else
      begin
         Select mkm_ecd_patente,
                mkm_fyh_fecha,
                mkm_nro_km,
                TNGS_Rivn..MvlKilometros.instante,
                TNGS_Rivn..MvlKilometros.deleted,
                TNGS_Rivn..MvlKilometros.usuario,
                TNGS_Rivn..MvlKilometros.version
           from TNGS_Rivn..MvlKilometros
          where mkm_ecd_patente = @mkm_ecd_patente
          order by mkm_fyh_fecha
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_INSERT
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..MvlKilometros
   values (
           @mkm_ecd_patente,
           @mkm_fyh_fecha,
           @mkm_nro_km,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@mkm_nro_km">Kilometros</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_UPDATE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@mkm_nro_km tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set mkm_nro_km= @mkm_nro_km,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DELETE
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDELETE
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..MvlKilometros
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_RECALL
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..MvlKilometros
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FRECALL
(
@mkm_ecd_patente tngs_codigo_e,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
      end
   else
      begin
         Update TNGS_Rivn..MvlKilometros
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where mkm_ecd_patente = @mkm_ecd_patente
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@mkm_fyh_fecha">Fecha</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_DROP
(
@mkm_ecd_patente tngs_codigo_e,
@mkm_fyh_fecha tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and mkm_fyh_fecha = @mkm_fyh_fecha

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FDROP
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.MVLKILOMETROS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..MvlKilometros
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@mkm_ecd_patente">Patente</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_FPACK
(
@mkm_ecd_patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..MvlKilometros
    where mkm_ecd_patente = @mkm_ecd_patente
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_FPACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: RemoveAllPatente
--- </summary>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_REMOVEALLPATENTE'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_REMOVEALLPATENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_REMOVEALLPATENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_REMOVEALLPATENTE
(
@usuario tngs_nombre
)
as
begin


fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_REMOVEALLPATENTE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getLastFiveMvlKm
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.MVLKILOMETROS_GETLASTFIVEMVLKM'

if exists (select * from sysobjects where id = object_id('dbo.MVLKILOMETROS_GETLASTFIVEMVLKM'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.MVLKILOMETROS_GETLASTFIVEMVLKM
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.MVLKILOMETROS_GETLASTFIVEMVLKM
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   SELECT TOP 5 mkm_nro_km, 
   mkm_fyh_fecha 
   FROM TNGS_Rivn..MvlKilometros 
   WHERE mkm_ecd_patente = @patente 
   ORDER BY mkm_fyh_fecha DESC 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.MVLKILOMETROS_GETLASTFIVEMVLKM to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: MvlKilometros
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : OrdenesTrabajo
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.ORDENESTRABAJO_UP'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          where deleted = 0
          order by odt_nro_nro
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          order by odt_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_CHKVERSION
(
@odt_nro_nro tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..OrdenesTrabajo
    where odt_nro_nro = @odt_nro_nro
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_SEARCH
(
@odt_nro_nro tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          where odt_nro_nro = @odt_nro_nro
            and deleted = 0
      end
   else
      begin
         Select odt_nro_nro,
                odt_ecd_patente,
                odt_fyh_fecapertura,
                odt_nom_operador,
                odt_fyh_feccierre,
                TNGS_Rivn..OrdenesTrabajo.instante,
                TNGS_Rivn..OrdenesTrabajo.deleted,
                TNGS_Rivn..OrdenesTrabajo.usuario,
                TNGS_Rivn..OrdenesTrabajo.version
           from TNGS_Rivn..OrdenesTrabajo
          where odt_nro_nro = @odt_nro_nro
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre.</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_INSERT
(
@odt_nro_nro tngs_numero,
@odt_ecd_patente tngs_codigo_e,
@odt_fyh_fecapertura tngs_fecyhor,
@odt_nom_operador tngs_nombre,
@odt_fyh_feccierre tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..OrdenesTrabajo
   values (
           @odt_nro_nro,
           @odt_ecd_patente,
           @odt_fyh_fecapertura,
           @odt_nom_operador,
           @odt_fyh_feccierre,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@odt_ecd_patente">Patente</param>
--- <param name="@odt_fyh_fecapertura">Fecha de apertura</param>
--- <param name="@odt_nom_operador">Operador</param>
--- <param name="@odt_fyh_feccierre">Fecha de cierre.</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_UPDATE
(
@odt_nro_nro tngs_numero,
@odt_ecd_patente tngs_codigo_e,
@odt_fyh_fecapertura tngs_fecyhor,
@odt_nom_operador tngs_nombre,
@odt_fyh_feccierre tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OrdenesTrabajo
      set odt_ecd_patente= @odt_ecd_patente,
          odt_fyh_fecapertura= @odt_fyh_fecapertura,
          odt_nom_operador= @odt_nom_operador,
          odt_fyh_feccierre= @odt_fyh_feccierre,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_DELETE
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OrdenesTrabajo
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_RECALL
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OrdenesTrabajo
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@odt_nro_nro">nro</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_DROP'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_DROP
(
@odt_nro_nro tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OrdenesTrabajo
    where odt_nro_nro = @odt_nro_nro

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_DROP to tngsmodulos

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

print 'Store Procedure: dbo.ORDENESTRABAJO_PACK'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..OrdenesTrabajo
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Método Fijo: getByPatente
--- </summary>
--- <param name="@patente">patente de un movil</param>
--- <param name="@usuario">Usuario que ejecuta el SP</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.ORDENESTRABAJO_GETBYPATENTE'

if exists (select * from sysobjects where id = object_id('dbo.ORDENESTRABAJO_GETBYPATENTE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.ORDENESTRABAJO_GETBYPATENTE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.ORDENESTRABAJO_GETBYPATENTE
(
@patente tngs_codigo_e,
@usuario tngs_nombre
)
as
begin

   Select odt_nro_nro,
          odt_ecd_patente,
          odt_fyh_fecapertura,
          odt_nom_operador,
          odt_fyh_feccierre,
          TNGS_Rivn..OrdenesTrabajo.instante,
          TNGS_Rivn..OrdenesTrabajo.deleted,
          TNGS_Rivn..OrdenesTrabajo.usuario,
          TNGS_Rivn..OrdenesTrabajo.version
     from TNGS_Rivn..OrdenesTrabajo 
     where odt_ecd_patente = @patente 

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.ORDENESTRABAJO_GETBYPATENTE to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OrdenesTrabajo
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : OtItems
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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

print 'Store Procedure: dbo.OTITEMS_UP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UP
(
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where deleted = 0
          order by oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          order by oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Verifica el número de versión de un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@version">Número de version a verificar</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_CHKVERSION'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_CHKVERSION'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_CHKVERSION
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_CHKVERSION
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@version tngs_numero
)
as
begin

   Select count(*) as cantidad
     from TNGS_Rivn..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem
      and version = @version

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_CHKVERSION to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca el registro de una clave
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_SEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_SEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_SEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_SEARCH
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nroot = @oti_nro_nroot
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
            and deleted = 0
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nroot = @oti_nro_nroot
            and oti_nro_nroagrupador = @oti_nro_nroagrupador
            and oti_nro_nroitem = @oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_SEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Busca los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@onlyactive">Flag de SoloActivos</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FSEARCH'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FSEARCH'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FSEARCH
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FSEARCH
(
@oti_nro_nroot tngs_numero,
@onlyactive tngs_valor
)
as
begin

   if @onlyactive = 1
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nroot = @oti_nro_nroot
            and deleted = 0
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end
   else
      begin
         Select oti_nro_nroot,
                oti_nro_nroagrupador,
                oti_nro_nroitem,
                oti_des_desoperacion,
                oti_des_destarea,
                oti_des_descategoria,
                oti_imp_importe,
                oti_ede_comentario,
                TNGS_Rivn..OtItems.instante,
                TNGS_Rivn..OtItems.deleted,
                TNGS_Rivn..OtItems.usuario,
                TNGS_Rivn..OtItems.version
           from TNGS_Rivn..OtItems
          where oti_nro_nroot = @oti_nro_nroot
          order by oti_nro_nroagrupador,
                oti_nro_nroitem
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FSEARCH to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación.</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_des_descategoria">Descripción de la categoría.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@usuario">Usuario que genera el insert</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_INSERT'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_INSERT'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_INSERT
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_INSERT
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..OtItems
   values (
           @oti_nro_nroot,
           @oti_nro_nroagrupador,
           @oti_nro_nroitem,
           @oti_des_desoperacion,
           @oti_des_destarea,
           @oti_des_descategoria,
           @oti_imp_importe,
           @oti_ede_comentario,
           getdate(), 0, @usuario, 1
          )

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_INSERT to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Actualiza un registro de la tabla
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@oti_des_desoperacion">Descripción de la operación.</param>
--- <param name="@oti_des_destarea">Descripción de la tarea</param>
--- <param name="@oti_des_descategoria">Descripción de la categoría.</param>
--- <param name="@oti_imp_importe">Importe</param>
--- <param name="@oti_ede_comentario">Comentario</param>
--- <param name="@usuario">Usuario que genera el update</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_UPDATE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_UPDATE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_UPDATE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_UPDATE
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@oti_des_desoperacion tngs_descripcion,
@oti_des_destarea tngs_descripcion,
@oti_des_descategoria tngs_descripcion,
@oti_imp_importe tngs_importe,
@oti_ede_comentario tngs_descripcion_e,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set oti_des_desoperacion= @oti_des_desoperacion,
          oti_des_destarea= @oti_des_destarea,
          oti_des_descategoria= @oti_des_descategoria,
          oti_imp_importe= @oti_imp_importe,
          oti_ede_comentario= @oti_ede_comentario,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_UPDATE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DELETE
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra lógicamente un registro por clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante del delete</param>
--- <param name="@usuario">Usuario que realiza el delete</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDELETE'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDELETE'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDELETE
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDELETE
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         select @instante= getdate()
      end

   Update TNGS_Rivn..OtItems
      set deleted = 1,
          version = ((version+1) % 32767),
          instante= @instante,
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDELETE to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_RECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_RECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_RECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_RECALL
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..OtItems
      set deleted = 0,
          version = ((version+1) % 32767),
          instante= getdate(),
          usuario = @usuario
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_RECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Recupera lógicamente los registros de una clave foranea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@instante">Instante de referencia</param>
--- <param name="@usuario">Usuario que realiza el recall</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FRECALL'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FRECALL'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FRECALL
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FRECALL
(
@oti_nro_nroot tngs_numero,
@instante tngs_fecyhor,
@usuario tngs_nombre
)
as
begin

   if datepart(yyyy, @instante) = 1900
      begin
         Update TNGS_Rivn..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
      end
   else
      begin
         Update TNGS_Rivn..OtItems
            set deleted = 0,
                version = ((version+1) % 32767),
                instante= getdate(),
                usuario = @usuario
          where oti_nro_nroot = @oti_nro_nroot
            and instante= @instante
      end

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FRECALL to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@oti_nro_nroagrupador">Numero de agrupador</param>
--- <param name="@oti_nro_nroitem">Numero del item</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_DROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_DROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_DROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_DROP
(
@oti_nro_nroot tngs_numero,
@oti_nro_nroagrupador tngs_numero,
@oti_nro_nroitem tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and oti_nro_nroagrupador = @oti_nro_nroagrupador
      and oti_nro_nroitem = @oti_nro_nroitem

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_DROP to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente un registro por clave foránea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el drop</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FDROP'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FDROP'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FDROP
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FDROP
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OtItems
    where oti_nro_nroot = @oti_nro_nroot

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FDROP to tngsmodulos

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

print 'Store Procedure: dbo.OTITEMS_PACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_PACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_PACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_PACK
(
@usuario tngs_nombre
)
as
begin

   Delete TNGS_Rivn..OtItems
    where deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_PACK to tngsmodulos

print ' '
go

---////////////////////////////////////////////////////////
---
--- <summary>
--- Borra físicamente los registro borrados lógicamente por clave foránea
--- </summary>
--- <param name="@oti_nro_nroot">nroOt</param>
--- <param name="@usuario">Usuario que realiza el pack</param>
---
---////////////////////////////////////////////////////////

print 'Store Procedure: dbo.OTITEMS_FPACK'

if exists (select * from sysobjects where id = object_id('dbo.OTITEMS_FPACK'))
begin
   print '       - Borrando el viejo SP'
   drop procedure dbo.OTITEMS_FPACK
end
go

print '       - Creando el nuevo SP'
go

create procedure dbo.OTITEMS_FPACK
(
@oti_nro_nroot tngs_numero,
@usuario tngs_nombre
)
as
begin

   Delete from TNGS_Rivn..OtItems
    where oti_nro_nroot = @oti_nro_nroot
      and deleted = 1

fin:

end
go

print '       - Asignando permisos al nuevo SP'

grant execute on dbo.OTITEMS_FPACK to tngsmodulos

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de los SP de la tabla: OtItems
//--------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------
//                         TNG Software SPs Generator
//----------------------------------------------------------------------------
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Parametros
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Reparaciones
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
                rep_rcd_codcat,
                rep_cd1_solicitadetalle,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
          where deleted = 0
          order by rep_cd6_cod
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                rep_rcd_codcat,
                rep_cd1_solicitadetalle,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
                rep_rcd_codcat,
                rep_cd1_solicitadetalle,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
          where rep_cd6_cod = @rep_cd6_cod
            and deleted = 0
      end
   else
      begin
         Select rep_cd6_cod,
                rep_xde_des,
                rep_rcd_codcat,
                rep_cd1_solicitadetalle,
                TNGS_Rivn..Reparaciones.instante,
                TNGS_Rivn..Reparaciones.deleted,
                TNGS_Rivn..Reparaciones.usuario,
                TNGS_Rivn..Reparaciones.version
           from TNGS_Rivn..Reparaciones
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
--- Inserta un registro en la tabla
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
--- <param name="@rep_xde_des">Reparacion</param>
--- <param name="@rep_rcd_codcat">Categoria</param>
--- <param name="@rep_cd1_solicitadetalle">Se Solicita Detalle</param>
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
@rep_rcd_codcat tngs_codigo_r,
@rep_cd1_solicitadetalle tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Insert into TNGS_Rivn..Reparaciones
   values (
           @rep_cd6_cod,
           @rep_xde_des,
           @rep_rcd_codcat,
           @rep_cd1_solicitadetalle,
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
--- <param name="@rep_xde_des">Reparacion</param>
--- <param name="@rep_rcd_codcat">Categoria</param>
--- <param name="@rep_cd1_solicitadetalle">Se Solicita Detalle</param>
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
@rep_rcd_codcat tngs_codigo_r,
@rep_cd1_solicitadetalle tngs_codigo_1,
@usuario tngs_nombre
)
as
begin

   Update TNGS_Rivn..Reparaciones
      set rep_xde_des= @rep_xde_des,
          rep_rcd_codcat= @rep_rcd_codcat,
          rep_cd1_solicitadetalle= @rep_cd1_solicitadetalle,
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
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
--- Recupera un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
--- Borra físicamente un registro
--- </summary>
--- <param name="@rep_cd6_cod">Codigo Reparacion</param>
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
// Fecha       : 11/07/2015 08:30
// Sistema     : Rivn
// Tabla       : Talonarios
//----------------------------------------------------------------------------
// © 1999-2015 by TNG Software                                      Gndr 5.20
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
