select * from Moviles


select * from (

select	mco_ecd_patente as patente,
		Moviles.mov_des_des as movil,
		mco_fyh_fecha as fecha,
		'Combustible' as tipo,
		rtrim(ets_des_des) + ' : ' + CONVERT(varchar(4), mco_val_litros)  + 'litros' as descripcion,
		mco_imp_importe as importe
from MvlCombustible
join Moviles on mov_ecd_patente = mco_ecd_patente
join Estaciones on mco_rcd_codestacion = ets_rcd_cod

union

select	mvi_ecd_patente as patente,
		Moviles.mov_des_des as movil,
		mvi_fyh_fecha as fecha,
		'Infracción' as tipo,
		mti_ede_descripcion as descripcion,
		mvi_imp_importe as importe
from MvlInfracciones
join Moviles on mov_ecd_patente = mvi_ecd_patente
join MotivosInfracciones on mvi_cod_codmotivo = mti_cod_codigo

union

select	odt_ecd_patente as patente,
		Moviles.mov_des_des as movil,
		odt_fyh_feccierre as fecha,
		'Control/Reparación' as tipo,
		OtItems.oti_des_destarea as descripcion,
		oti_imp_importecierre as importe
from OrdenesTrabajo
join OTItems on odt_nro_nro = oti_nro_nroot
join Moviles on mov_ecd_patente = odt_ecd_patente

) as result

order by patente, fecha, tipo


select mco_val_litros + ' : '
from MvlCombustible