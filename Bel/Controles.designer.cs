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
    // Fecha                    : 31/10/2013 17:05
    // Sistema                  : Rivn
    // Clase para Administrar   : Controles con sus Reparaciones
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: ControlRepa
    /// <summary>
    /// Clase que representa la Entidad: ControlRepa
    /// </summary>
    public sealed partial class EControlRepa : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: ControlesReparations
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EControlRepa(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ControlRepa
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EControlRepa(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ControlRepa
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EControlRepa(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EControlRepa.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctr_cod_codctl"]= XMLRuts.ExtractXAttr(l_xndData, "ctr_cod_codctl");
            l_drTemp["ctr_nro_nroitem"]= XMLRuts.ExtractXAttr(l_xndData, "ctr_nro_nroitem", 1);
            l_drTemp["ctr_cd6_codrep"]= XMLRuts.ExtractXAttr(l_xndData, "ctr_cd6_codrep");
            l_drTemp["ctr_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "ctr_des_des", false);

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
        private EControlRepa(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: ControlRepa
        /// </summary>
        /// <returns>Entidad vacia: ControlRepa</returns>
        public static EControlRepa NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EControlRepa.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctr_cod_codctl"]= "";
            l_drTemp["ctr_nro_nroitem"]= 1;
            l_drTemp["ctr_cd6_codrep"]= "";
            l_drTemp["ctr_des_des"]= DateTimeRuts.Empty;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EControlRepa l_entRet= new EControlRepa(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: ControlRepa
        /// </summary>
        /// <param name="p_strCodctl">codigoControl</param>
        /// <param name="p_iNroitem">item</param>
        /// <param name="p_strCodrep">codigoReparacion</param>
        /// <returns>Entidad: ControlRepa</returns>
        public static EControlRepa NewFilled(string p_strCodctl,
                                             int p_iNroitem,
                                             string p_strCodrep)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EControlRepa.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctr_cod_codctl"]= p_strCodctl;
            l_drTemp["ctr_nro_nroitem"]= p_iNroitem;
            l_drTemp["ctr_cd6_codrep"]= p_strCodrep;
            l_drTemp["ctr_des_des"]= DateTimeRuts.Empty;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EControlRepa l_entRet= new EControlRepa(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: codigoControl
        /// </summary>
        public static string FrmtCodctl(string p_strCodctl)
        {
            if (p_strCodctl.Trim().Length > 4)
                p_strCodctl= p_strCodctl.Trim().Substring(0,4);

            return p_strCodctl.Trim().PadLeft(4).ToUpper();
        }
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

                l_dcStruct[0]= new DataColumn("ctr_cod_codctl", typeof(string));
                l_dcStruct[1]= new DataColumn("ctr_nro_nroitem", typeof(int));
                l_dcStruct[2]= new DataColumn("ctr_cd6_codrep", typeof(string));
                l_dcStruct[3]= new DataColumn("ctr_des_des", typeof(DateTime));
                EControlRepa.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// codigoControl
        /// </summary>
        public string Codctl
        {
            get {return (string) InternalData["ctr_cod_codctl"];}
            set {InternalData["ctr_cod_codctl"]= EControlRepa.FrmtCodctl(value);}
        }

        /// <summary>
        /// item
        /// </summary>
        public int Nroitem
        {
            get {return (int) InternalData["ctr_nro_nroitem"];}
            set {InternalData["ctr_nro_nroitem"]= value;}
        }

        /// <summary>
        /// codigoReparacion
        /// </summary>
        public string Codrep
        {
            get {return ((string) InternalData["ctr_cd6_codrep"]).Trim();}
            set {
                if (value.Trim().Length > 6) value= value.Trim().Substring(0,6);
                InternalData["ctr_cd6_codrep"]= value.Trim();
            }
        }

        /// <summary>
        /// Title
        /// </summary>
        public DateTime Ctr_des_des
        {
            get {return (DateTime) InternalData["ctr_des_des"];}
            set {InternalData["ctr_des_des"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EControlRepa] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EControlRepa] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EControlRepa", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctr_cod_codctl", Codctl));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctr_nro_nroitem", Nroitem));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctr_cd6_codrep", Codrep));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctr_des_des", Ctr_des_des));

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

    #region Lista-Entidad: ControlesRepa
    /// <summary>
    /// Clase que representa la Lista-Entidad: ControlesRepa
    /// </summary>
    public sealed partial class LEControlesRepa : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: ControlesReparations
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEControlesRepa(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEControlesRepa(string p_strXMLData) :
            base(EControlRepa.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EControlRepa(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEControlesRepa(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: ControlesRepa
        /// </summary>
        /// <returns>Lista-Entidad vacia: ControlesReparations</returns>
        public static LEControlesRepa NewEmpty()
        {
            return new LEControlesRepa(EControlRepa.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEControlRepa">Entidad a agregar</param>
        public void AddEntity(EControlRepa p_entEControlRepa)
        {
            base.AddEntity(p_entEControlRepa);
        }

        /// <summary>
        /// Remueve una entidad [ControlRepa] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodctl,
                                int p_iNroitem)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "ctr_cod_codctl = " + Ruts.Co(EControlRepa.FrmtCodctl(p_strCodctl)) + " and " + 
                "ctr_nro_nroitem = " + Ruts.Nu(p_iNroitem);

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
        /// Verifca si una entidad [ControlRepa] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodctl,
                             int p_iNroitem)
        {
            using (EControlRepa l_entTemp= this[p_strCodctl,
                                                p_iNroitem])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: ControlesRepa
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EControlRepa l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EControlRepa(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: ControlesRepa
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EControlRepa l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: ControlesRepa
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETControlesRepa GetAsLET()
        {
            // Llenamos la lista tipada
            LETControlesRepa l_lentRet= new LETControlesRepa();

            foreach (EControlRepa l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ControlRepa] por indice
        /// </summary>
        public new EControlRepa this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad ControlRepa con los datos de la fila
                return new EControlRepa(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [ControlRepa] por clave
        /// </summary>
        public EControlRepa this[string p_strCodctl,
                                 int p_iNroitem]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "ctr_cod_codctl = " + Ruts.Co(EControlRepa.FrmtCodctl(p_strCodctl)) + " and " + 
                    "ctr_nro_nroitem = " + Ruts.Nu(p_iNroitem);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad ControlRepa con los datos de la fila
                if (l_drData == null) return null;
                return new EControlRepa(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEControlesRepa", null);

                foreach (EControlRepa l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: ControlesRepa
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: ControlesRepa
    /// </summary>
    public sealed partial class LETControlesRepa : LET<EControlRepa>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: ControlesRepa
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEControlesRepa GetAsLE()
        {
            // Llenamos la lista
            LEControlesRepa l_lentRet= LEControlesRepa.NewEmpty();

            foreach (EControlRepa l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [ControlRepa] por clave
        /// </summary>
        public EControlRepa this[string p_strCodctl,
                                 int p_iNroitem]
        {
            get {
                // Buscamos la entidad
                foreach (EControlRepa l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Codctl == EControlRepa.FrmtCodctl(p_strCodctl)) &&
                        (l_entItem.Nroitem == p_iNroitem))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Control
    /// <summary>
    /// Clase que representa la Entidad: Control
    /// </summary>
    public sealed partial class EControl : Entidad
    {
        #region Miembros de la clase
            private LEControlesRepa m_lentControlesRepa= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Controles
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EControl(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Control
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EControl(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Control
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EControl(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EControl.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_cod_cod");
            l_drTemp["ctl_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_des_des");
            l_drTemp["ctl_cd1_crit"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_cd1_crit");

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
        private EControl(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentControlesRepa= LEControlesRepa.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Control
        /// </summary>
        /// <returns>Entidad vacia: Control</returns>
        public static EControl NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EControl.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_cod_cod"]= "";
            l_drTemp["ctl_des_des"]= "";
            l_drTemp["ctl_cd1_crit"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EControl l_entRet= new EControl(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Control
        /// </summary>
        /// <param name="p_strCod">Codigo</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strCrit">Critico</param>
        /// <returns>Entidad: Control</returns>
        public static EControl NewFilled(string p_strCod,
                                         string p_strDes,
                                         string p_strCrit)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EControl.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ctl_cod_cod"]= p_strCod;
            l_drTemp["ctl_des_des"]= p_strDes;
            l_drTemp["ctl_cd1_crit"]= p_strCrit;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EControl l_entRet= new EControl(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 4)
                p_strCod= p_strCod.Trim().Substring(0,4);

            return p_strCod.Trim().PadLeft(4).ToUpper();
        }
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
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("ctl_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("ctl_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("ctl_cd1_crit", typeof(string));
                EControl.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["ctl_cod_cod"];}
            set {InternalData["ctl_cod_cod"]= EControl.FrmtCod(value);}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["ctl_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["ctl_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Critico
        /// </summary>
        public string Crit
        {
            get {return (string) InternalData["ctl_cd1_crit"];}
            set {InternalData["ctl_cd1_crit"]= value;}
        }

        /// <summary>
        /// Controles de las reaparaciones
        /// </summary>
        public LEControlesRepa ControlesRepa
        {
            get {return m_lentControlesRepa;}
            set {m_lentControlesRepa= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EControl] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EControl] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EControl", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_cd1_crit", Crit));

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

    #region Lista-Entidad: Controles
    /// <summary>
    /// Clase que representa la Lista-Entidad: Controles
    /// </summary>
    public sealed partial class LEControles : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Controles
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEControles(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEControles(string p_strXMLData) :
            base(EControl.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EControl(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEControles(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Controles
        /// </summary>
        /// <returns>Lista-Entidad vacia: Controles</returns>
        public static LEControles NewEmpty()
        {
            return new LEControles(EControl.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEControl">Entidad a agregar</param>
        public void AddEntity(EControl p_entEControl)
        {
            base.AddEntity(p_entEControl);
        }

        /// <summary>
        /// Remueve una entidad [Control] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "ctl_cod_cod = " + Ruts.Co(EControl.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Control] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EControl l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Controles
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EControl l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EControl(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Controles
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EControl l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Controles
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETControles GetAsLET()
        {
            // Llenamos la lista tipada
            LETControles l_lentRet= new LETControles();

            foreach (EControl l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Control] por indice
        /// </summary>
        public new EControl this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Control con los datos de la fila
                return new EControl(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Control] por clave
        /// </summary>
        public EControl this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "ctl_cod_cod = " + Ruts.Co(EControl.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Control con los datos de la fila
                if (l_drData == null) return null;
                return new EControl(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEControles", null);

                foreach (EControl l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Controles
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Controles
    /// </summary>
    public sealed partial class LETControles : LET<EControl>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Controles
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEControles GetAsLE()
        {
            // Llenamos la lista
            LEControles l_lentRet= LEControles.NewEmpty();

            foreach (EControl l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Control] por clave
        /// </summary>
        public EControl this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EControl l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EControl.FrmtCod(p_strCod))
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
