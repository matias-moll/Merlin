using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Rivn;
using Rivn.Bel;


namespace Rivn.Bll.ObjetosSoporte
{
    public class AsociadosMovil
    {
        #region Miembros
        List<ListaEntidades> m_lstLEListaEntidades = new List<ListaEntidades>();
        StatMsg m_smResult = null;
        #endregion

        public AsociadosMovil(ref StatMsg p_smResult)
        {
            m_smResult = p_smResult;
        }
        #region Metodos
        public void CargarDatos(string p_strPatente)
        {
            m_lstLEListaEntidades = Bll.Moviles.fGetLastFiveTodos(p_strPatente,true,ref m_smResult);
            llenarCaptions();
        }

        private void llenarCaptions()
        {
            //Seteamos caption de los combustibles
            Combustibles.ChangeCaption("mco_val_litros", "V1Litros2N1");
            Combustibles.ChangeCaption("mco_imp_importe", "V1Importe2S2");
            Combustibles.ChangeCaption("mco_fyh_fecha", "V1FechaFN1");
            Combustibles.ChangeCaption("ets_des_des", "V1EstacionCN2");



            //Seteamos caption de Km
            Kms.ChangeCaption("mkm_fyh_fecha", "V1FechaFN1");
            Kms.ChangeCaption("mkm_nro_km", "V1KilometrosNN1");

            //Seteamos caption de estados
            Estados.ChangeCaption("mve_fyh_fecha", "V1FechaFN1");
            Estados.ChangeCaption("est_des_des", "V1EstadoCN1");
            Estados.ChangeCaption("mve_nro_km", "V1KmsCN1");
            Estados.ChangeCaption("mve_rcd_codestado", "V1Codigo EstadoCN1");

        }


        #region Propiedades

        public ListaEntidades Kms {
            get { return m_lstLEListaEntidades[1]; }
        
        }

        public ListaEntidades Combustibles
        {
            get { return m_lstLEListaEntidades[0]; }
        }

        public ListaEntidades Estados
        {
            get { return m_lstLEListaEntidades[2]; }
        }


        public ListaEntidades Equipamiento
        {
            get { return m_lstLEListaEntidades[3]; }
        }


        public LEMovilesEquip EquipamientoTip
        {
            get { return (LEMovilesEquip)m_lstLEListaEntidades[3]; }
        }

        #endregion
        #endregion

    }
}
