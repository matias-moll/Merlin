-- View para retornar los moviles activos para el CEDI. Solo devuelve la patente.

use TNGS_Mrln
go

print 'View : dbo.CediMovilesActivosV1'

if exists (select * from sysobjects where id = object_id('dbo.CediMovilesActivosV1'))
begin
   print '       - Borrando la vieja confiable view'
   drop view dbo.CediMovilesActivosV1
end
go

print '       - Creando la nueva view'
go

CREATE VIEW dbo.CediMovilesActivosV1 AS
select	mv.mov_ecd_patente as patente
from Moviles mv
join MvlEstados mve1
on mov_ecd_patente = mve_ecd_patente
-- Joineamos con la misma tabla para filtrar que traiga solo el ultimo estado (fecha sea maxima)
inner join (
	select mve2.mve_ecd_patente, max(mve2.mve_fyh_fecha) as maxfecha from MvlEstados mve2 group by mve2.mve_ecd_patente
) b on mve1.mve_ecd_patente = b.mve_ecd_patente and mve1.mve_fyh_fecha = b.maxfecha 
join Estados 
on est_rcd_cod = mve1.mve_rcd_codestado
group by mov_ecd_patente, est_cd1_operativo
having est_cd1_operativo = 'S'

go

grant select on dbo.CediMovilesActivosV1 to tngsmodulos

go

print ' '
go

