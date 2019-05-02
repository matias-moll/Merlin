using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Mrln;
using Mrln.Bel;


namespace Mrln.Bll.ObjetosSoporte
{
    public class AsociadosMovil
    {
        #region Miembros
        List<ListaEntidades> m_lstLEListaEntidades = new List<ListaEntidades>();
        StatMsg m_smResult = null;
        #endregion

        public AsociadosMovil(StatMsg p_smResult)
        {
            m_smResult = p_smResult;
        }
        #region Metodos
        public void CargarDatos(string p_strPatente)
        {
            m_lstLEListaEntidades = Bll.Moviles.fGetLastFiveTodos(p_strPatente,true,m_smResult);
            llenarCaptions();
        }

        private void llenarCaptions()
        {
            //Seteamos caption de los combustibles
            Combustibles.ChangeCaption(EMovilCombus.LitrosCmp, "V1Litros2N1");
            Combustibles.ChangeCaption(EMovilCombus.ImporteCmp, "V1Importe2S2");
            Combustibles.ChangeCaption(EMovilCombus.FechaCmp, "V1FechaFN1");
            Combustibles.ChangeCaption(EEstacion.DesCmp, "V1EstacionCN2");
            Combustibles.ChangeCaption(EMovilCombus.KilometrosCmp, "V1KMsNN2");

            ////Cambiar caption de equipamiento
            Equipamiento.ChangeCaption(EMovilEquip.CodequipCmp, "V1CCN1");
            Equipamiento.ChangeCaption("meq_des_Equip", "V1EquipamientoCN2");
            Equipamiento.ChangeCaption("deleted", "");

            //Seteamos caption de Km
            Kms.ChangeCaption(EMovilKms.FechaCmp, "V1FechaFN2");
            Kms.ChangeCaption(EMovilKms.KmCmp, "V1KilometrosNN2");

            //Seteamos caption de estados
            Estados.ChangeCaption(EMovilEstado.FechaCmp, "V1FechaFN2");
            Estados.ChangeCaption(EEstado.DesCmp, "V1EstadoCN2");
            Estados.ChangeCaption(EMovilEstado.KmCmp, "V1KmsCN2");
            Estados.ChangeCaption(EMovilEstado.CodestadoCmp, "V1CCN1");
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
            get { return m_lstLEListaEntidades.Count != 0 ? (LEMovilesEquip)m_lstLEListaEntidades[3] : null; }
        }

        #endregion
        #endregion

    }
}
