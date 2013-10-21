#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using Rivn;
#endregion

namespace Rivn.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 21/10/2013 15:07
    // Sistema                  : Rivn
    // Clase para Administrar   : Estados Posibles de un Movil
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: Estado
    /// <summary>
    /// Clase que representa la Entidad: Estado
    /// </summary>
    public sealed partial class EEstado : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Estados
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EEstado(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Estado
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EEstado(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Estado
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EEstado(string p_strXML,
                       bool p_bEsNueva)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["est_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "est_rcd_cod");
            l_drTemp["est_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "est_des_des");
            l_drTemp["est_txt_txtcontingencia"]= XMLRuts.ExtractXAttr(l_xndData, "est_txt_txtcontingencia");
            l_drTemp["est_cd1_operativo"]= XMLRuts.ExtractXAttr(l_xndData, "est_cd1_operativo");

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
            fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private EEstado(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Estado
        /// </summary>
        /// <returns>Entidad vacia: Estado</returns>
        public static EEstado NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["est_rcd_cod"]= "";
            l_drTemp["est_des_des"]= "";
            l_drTemp["est_txt_txtcontingencia"]= "";
            l_drTemp["est_cd1_operativo"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEstado l_entRet= new EEstado(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Estado
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_strDes">des</param>
        /// <param name="p_strTxtcontingencia">Texto de Contingencia</param>
        /// <param name="p_strOperativo">Operativo</param>
        /// <returns>Entidad: Estado</returns>
        public static EEstado NewFilled(string p_strCod,
                                        string p_strDes,
                                        string p_strTxtcontingencia,
                                        string p_strOperativo)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["est_rcd_cod"]= p_strCod;
            l_drTemp["est_des_des"]= p_strDes;
            l_drTemp["est_txt_txtcontingencia"]= p_strTxtcontingencia;
            l_drTemp["est_cd1_operativo"]= p_strOperativo;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEstado l_entRet= new EEstado(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la estructura de la tabla interna de la entidad
        /// </summary>
        public static DataColumn[] Struct
        {
            get {
                // Creamos el vector de DataColumns y lo llenamos
                DataColumn[] l_dcStruct= new DataColumn[8];

                l_dcStruct[0]= new DataColumn("est_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("est_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("est_txt_txtcontingencia", typeof(string));
                l_dcStruct[3]= new DataColumn("est_cd1_operativo", typeof(string));
                EEstado.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// cod
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["est_rcd_cod"];}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["est_rcd_cod"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// des
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["est_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["est_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Texto de Contingencia
        /// </summary>
        public string Txtcontingencia
        {
            get {return (string) InternalData["est_txt_txtcontingencia"];}
            set {InternalData["est_txt_txtcontingencia"]= value;}
        }

        /// <summary>
        /// Operativo
        /// </summary>
        public string Operativo
        {
            get {return (string) InternalData["est_cd1_operativo"];}
            set {InternalData["est_cd1_operativo"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EEstado] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EEstado] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EEstado", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "est_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "est_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "est_txt_txtcontingencia", Txtcontingencia));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "est_cd1_operativo", Operativo));

                // Asignamos los campos fijos
                FixedFields2XML(l_xdocData, ref l_xndEntidad);

                // Llamamos al metodo fijo
                fAddXMLData(ref l_xdocData, ref l_xndEntidad);

                // Armamos el documento y lo devolvemos
                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad: Estados
    /// <summary>
    /// Clase que representa la Lista-Entidad: Estados
    /// </summary>
    public sealed partial class LEEstados : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Estados
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEstados(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEstados(string p_strXMLData) :
            base(EEstado.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EEstado(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEEstados(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Estados
        /// </summary>
        /// <returns>Lista-Entidad vacia: Estados</returns>
        public static LEEstados NewEmpty()
        {
            return new LEEstados(EEstado.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEEstado">Entidad a agregar</param>
        public void AddEntity(EEstado p_entEEstado)
        {
            base.AddEntity(p_entEEstado);
        }

        /// <summary>
        /// Remueve una entidad [Estado] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "est_rcd_cod = " + Ruts.Co(p_strCod);

            if (m_dtDatos.DefaultView.Count == 1) {
                // La borramos
                m_dtDatos.Rows.Remove(m_dtDatos.DefaultView[0].Row);
                l_iRet= 1;
            }

            // Quito el filtro
            m_dtDatos.DefaultView.RowFilter= "";
            return l_iRet;
        }

        /// <summary>
        /// Verifca si una entidad [Estado] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EEstado l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Estados
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EEstado l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EEstado(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Estados
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EEstado l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Estados
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETEstados GetAsLET()
        {
            // Llenamos la lista tipada
            LETEstados l_lentRet= new LETEstados();

            foreach (EEstado l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Estado] por indice
        /// </summary>
        public new EEstado this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Estado con los datos de la fila
                return new EEstado(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Estado] por clave
        /// </summary>
        public EEstado this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "est_rcd_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Estado con los datos de la fila
                if (l_drData == null) return null;
                return new EEstado(l_drData);
            }
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML en string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                // Construimos el XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEEstados", null);

                foreach (EEstado l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Estados
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Estados
    /// </summary>
    public sealed partial class LETEstados : LET<EEstado>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Estados
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEEstados GetAsLE()
        {
            // Llenamos la lista
            LEEstados l_lentRet= LEEstados.NewEmpty();

            foreach (EEstado l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Estado] por clave
        /// </summary>
        public EEstado this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EEstado l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion
}
