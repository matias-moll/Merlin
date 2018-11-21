/*
Tenemos que hacer una opcion de consulta de historia del movil donde vamos a tener que hacer un select union
de todo lo que le paso al movil: combustibles, estados, ordenes de trabajo, etc. Usar una entidad fija 
con datos en comun: patente, fecha, tipo, descripcion.
El tipo de los registros que traemos es fijo para combustibles, estados, y dsps para los items de OT es la categoria de la reparacion
y ademas necesitamos otro para los controles que se le hicieron al auto donde el tipo seria la descripcion del control
*/

select	mco_ecd_patente as Patente, 
		mco_fyh_fecha as Fecha, 
		'Combustibles' as Tipo, 
		'Litros: ' + CONVERT(varchar(10), mco_val_litros)  + ', Importe: ' + CONVERT(varchar(10), mco_imp_importe)  as Descripcion
from MvlCombustible

union

select	mve_ecd_patente as Patente,
		mve_fyh_fecha as Fecha,
		'Estados' as Tipo,
		 rtrim(ltrim(est_des_des)) + ', Kilometros: ' + CONVERT(varchar(10), mve_nro_km) as Descripcion
from MvlEstados
join Estados 
	on mve_rcd_codestado = est_rcd_cod

union

select  mkm_ecd_patente as Patente,
		mkm_fyh_fecha as Fecha,
		'Kilometros' as Tipo,
		'Nuevo Valor: ' +  CONVERT(varchar(10), mkm_nro_km) as Descripcion
from MvlKilometros

union

select  odt_ecd_patente as Patente,
		odt_fyh_fecapertura as Fecha,
		'Orden de Trabajo' as Tipo,
		case when oti_des_desoperacion <> oti_des_destarea then
		'Control ' + ltrim(rtrim(oti_des_desoperacion)) + ' : ' + oti_des_destarea else
		oti_des_destarea end as Descripcion
from OrdenesTrabajo
join Moviles
	on odt_ecd_patente = mov_ecd_patente
join OTItems 
	on oti_nro_nroot = odt_nro_nro
