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


        #endregion
        #endregion

    }
}
