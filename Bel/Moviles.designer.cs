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
    // Fecha                    : 03/11/2013 15:54
    // Sistema                  : Rivn
    // Clase para Administrar   : Moviles y Tablas Hijas
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: MovilCombus
    /// <summary>
    /// Clase que representa la Entidad: MovilCombus
    /// </summary>
    public sealed partial class EMovilCombus : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MvlCombustible
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMovilCombus(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilCombus
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMovilCombus(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilCombus
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMovilCombus(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMovilCombus.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mco_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "mco_ecd_patente");
            l_drTemp["mco_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "mco_fyh_fecha", true);
            l_drTemp["mco_val_litros"]= XMLRuts.ExtractXAttr(l_xndData, "mco_val_litros", (double) 0);
            l_drTemp["mco_imp_importe"]= XMLRuts.ExtractXAttr(l_xndData, "mco_imp_importe", (decimal) 0);
            l_drTemp["mco_rcd_codestacion"]= XMLRuts.ExtractXAttr(l_xndData, "mco_rcd_codestacion");

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
        private EMovilCombus(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: MovilCombus
        /// </summary>
        /// <returns>Entidad vacia: MovilCombus</returns>
        public static EMovilCombus NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilCombus.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mco_ecd_patente"]= "";
            l_drTemp["mco_fyh_fecha"]= DateTimeRuts.Empty;
            l_drTemp["mco_val_litros"]= 0;
            l_drTemp["mco_imp_importe"]= 0;
            l_drTemp["mco_rcd_codestacion"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilCombus l_entRet= new EMovilCombus(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MovilCombus
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_dLitros">Litros Cargados</param>
        /// <param name="p_dcImporte">Importe</param>
        /// <param name="p_strCodestacion">Codigo estacion</param>
        /// <returns>Entidad: MovilCombus</returns>
        public static EMovilCombus NewFilled(string p_strPatente,
                                             DateTime p_dtFecha,
                                             double p_dLitros,
                                             decimal p_dcImporte,
                                             string p_strCodestacion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilCombus.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mco_ecd_patente"]= p_strPatente;
            l_drTemp["mco_fyh_fecha"]= p_dtFecha;
            l_drTemp["mco_val_litros"]= p_dLitros;
            l_drTemp["mco_imp_importe"]= p_dcImporte;
            l_drTemp["mco_rcd_codestacion"]= p_strCodestacion;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilCombus l_entRet= new EMovilCombus(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[9];

                l_dcStruct[0]= new DataColumn("mco_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("mco_fyh_fecha", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("mco_val_litros", typeof(double));
                l_dcStruct[3]= new DataColumn("mco_imp_importe", typeof(decimal));
                l_dcStruct[4]= new DataColumn("mco_rcd_codestacion", typeof(string));
                EMovilCombus.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Patente
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["mco_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["mco_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["mco_fyh_fecha"];}
            set {InternalData["mco_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Litros Cargados
        /// </summary>
        public double Litros
        {
            get {return (double) InternalData["mco_val_litros"];}
            set {InternalData["mco_val_litros"]= value;}
        }

        /// <summary>
        /// Importe
        /// </summary>
        public decimal Importe
        {
            get {return (decimal) InternalData["mco_imp_importe"];}
            set {InternalData["mco_imp_importe"]= value;}
        }

        /// <summary>
        /// Codigo estacion
        /// </summary>
        public string Codestacion
        {
            get {return (string) InternalData["mco_rcd_codestacion"];}
            set {InternalData["mco_rcd_codestacion"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilCombus] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilCombus] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMovilCombus", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mco_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mco_fyh_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mco_val_litros", Litros));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mco_imp_importe", Importe));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mco_rcd_codestacion", Codestacion));

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

    #region Lista-Entidad: MovilesCombus
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesCombus
    /// </summary>
    public sealed partial class LEMovilesCombus : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MvlCombustible
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesCombus(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesCombus(string p_strXMLData) :
            base(EMovilCombus.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMovilCombus(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMovilesCombus(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: MovilesCombus
        /// </summary>
        /// <returns>Lista-Entidad vacia: MvlCombustible</returns>
        public static LEMovilesCombus NewEmpty()
        {
            return new LEMovilesCombus(EMovilCombus.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMovilCombus">Entidad a agregar</param>
        public void AddEntity(EMovilCombus p_entEMovilCombus)
        {
            base.AddEntity(p_entEMovilCombus);
        }

        /// <summary>
        /// Remueve una entidad [MovilCombus] por clave
        /// </summary>
        public int RemoveEntity(string p_strPatente,
                                DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mco_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                "convert(mco_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

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
        /// Verifca si una entidad [MovilCombus] esta en la lista
        /// </summary>
        public bool Contains(string p_strPatente,
                             DateTime p_dtFecha)
        {
            using (EMovilCombus l_entTemp= this[p_strPatente,
                                                p_dtFecha])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MovilesCombus
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EMovilCombus l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMovilCombus(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MovilesCombus
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMovilCombus l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MovilesCombus
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMovilesCombus GetAsLET()
        {
            // Llenamos la lista tipada
            LETMovilesCombus l_lentRet= new LETMovilesCombus();

            foreach (EMovilCombus l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilCombus] por indice
        /// </summary>
        public new EMovilCombus this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MovilCombus con los datos de la fila
                return new EMovilCombus(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilCombus] por clave
        /// </summary>
        public EMovilCombus this[string p_strPatente,
                                 DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mco_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                    "convert(mco_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MovilCombus con los datos de la fila
                if (l_drData == null) return null;
                return new EMovilCombus(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMovilesCombus", null);

                foreach (EMovilCombus l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MovilesCombus
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesCombus
    /// </summary>
    public sealed partial class LETMovilesCombus : LET<EMovilCombus>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MovilesCombus
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMovilesCombus GetAsLE()
        {
            // Llenamos la lista
            LEMovilesCombus l_lentRet= LEMovilesCombus.NewEmpty();

            foreach (EMovilCombus l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilCombus] por clave
        /// </summary>
        public EMovilCombus this[string p_strPatente,
                                 DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (EMovilCombus l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Patente == p_strPatente) &&
                        (l_entItem.Fecha == p_dtFecha))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: MovilEquip
    /// <summary>
    /// Clase que representa la Entidad: MovilEquip
    /// </summary>
    public sealed partial class EMovilEquip : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMovilEquip(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilEquip
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMovilEquip(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilEquip
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMovilEquip(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMovilEquip.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["meq_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "meq_ecd_patente");
            l_drTemp["meq_cod_codequip"]= XMLRuts.ExtractXAttr(l_xndData, "meq_cod_codequip");
            l_drTemp["meq_cd1_esfijo"]= XMLRuts.ExtractXAttr(l_xndData, "meq_cd1_esfijo");

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
        private EMovilEquip(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: MovilEquip
        /// </summary>
        /// <returns>Entidad vacia: MovilEquip</returns>
        public static EMovilEquip NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilEquip.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["meq_ecd_patente"]= "";
            l_drTemp["meq_cod_codequip"]= "";
            l_drTemp["meq_cd1_esfijo"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilEquip l_entRet= new EMovilEquip(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MovilEquip
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_strCodequip">Codigo del Equipamento.</param>
        /// <param name="p_strEsfijo">Es fijo o no.</param>
        /// <returns>Entidad: MovilEquip</returns>
        public static EMovilEquip NewFilled(string p_strPatente,
                                            string p_strCodequip,
                                            string p_strEsfijo)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilEquip.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["meq_ecd_patente"]= p_strPatente;
            l_drTemp["meq_cod_codequip"]= p_strCodequip;
            l_drTemp["meq_cd1_esfijo"]= p_strEsfijo;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilEquip l_entRet= new EMovilEquip(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("meq_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("meq_cod_codequip", typeof(string));
                l_dcStruct[2]= new DataColumn("meq_cd1_esfijo", typeof(string));
                EMovilEquip.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Patente
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["meq_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["meq_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Codigo del Equipamento.
        /// </summary>
        public string Codequip
        {
            get {return (string) InternalData["meq_cod_codequip"];}
            set {
                if (value.Trim().Length > 4) value= value.Trim().Substring(0,4);
                InternalData["meq_cod_codequip"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Es fijo o no.
        /// </summary>
        public string Esfijo
        {
            get {return (string) InternalData["meq_cd1_esfijo"];}
            set {InternalData["meq_cd1_esfijo"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilEquip] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilEquip] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMovilEquip", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "meq_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "meq_cod_codequip", Codequip));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "meq_cd1_esfijo", Esfijo));

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

    #region Lista-Entidad: MovilesEquip
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesEquip
    /// </summary>
    public sealed partial class LEMovilesEquip : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MvlEquipamiento
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesEquip(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesEquip(string p_strXMLData) :
            base(EMovilEquip.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMovilEquip(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMovilesEquip(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: MovilesEquip
        /// </summary>
        /// <returns>Lista-Entidad vacia: MvlEquipamiento</returns>
        public static LEMovilesEquip NewEmpty()
        {
            return new LEMovilesEquip(EMovilEquip.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMovilEquip">Entidad a agregar</param>
        public void AddEntity(EMovilEquip p_entEMovilEquip)
        {
            base.AddEntity(p_entEMovilEquip);
        }

        /// <summary>
        /// Remueve una entidad [MovilEquip] por clave
        /// </summary>
        public int RemoveEntity(string p_strPatente,
                                string p_strCodequip)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "meq_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                "meq_cod_codequip = " + Ruts.Co(p_strCodequip);

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
        /// Verifca si una entidad [MovilEquip] esta en la lista
        /// </summary>
        public bool Contains(string p_strPatente,
                             string p_strCodequip)
        {
            using (EMovilEquip l_entTemp= this[p_strPatente,
                                               p_strCodequip])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MovilesEquip
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EMovilEquip l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMovilEquip(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MovilesEquip
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMovilEquip l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MovilesEquip
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMovilesEquip GetAsLET()
        {
            // Llenamos la lista tipada
            LETMovilesEquip l_lentRet= new LETMovilesEquip();

            foreach (EMovilEquip l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEquip] por indice
        /// </summary>
        public new EMovilEquip this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MovilEquip con los datos de la fila
                return new EMovilEquip(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEquip] por clave
        /// </summary>
        public EMovilEquip this[string p_strPatente,
                                string p_strCodequip]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "meq_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                    "meq_cod_codequip = " + Ruts.Co(p_strCodequip);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MovilEquip con los datos de la fila
                if (l_drData == null) return null;
                return new EMovilEquip(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMovilesEquip", null);

                foreach (EMovilEquip l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MovilesEquip
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesEquip
    /// </summary>
    public sealed partial class LETMovilesEquip : LET<EMovilEquip>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MovilesEquip
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMovilesEquip GetAsLE()
        {
            // Llenamos la lista
            LEMovilesEquip l_lentRet= LEMovilesEquip.NewEmpty();

            foreach (EMovilEquip l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEquip] por clave
        /// </summary>
        public EMovilEquip this[string p_strPatente,
                                string p_strCodequip]
        {
            get {
                // Buscamos la entidad
                foreach (EMovilEquip l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Patente == p_strPatente) &&
                        (l_entItem.Codequip == p_strCodequip))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: MovilEstado
    /// <summary>
    /// Clase que representa la Entidad: MovilEstado
    /// </summary>
    public sealed partial class EMovilEstado : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MvlEstados
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMovilEstado(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilEstado
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMovilEstado(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilEstado
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMovilEstado(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMovilEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mve_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "mve_ecd_patente");
            l_drTemp["mve_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "mve_fyh_fecha", true);
            l_drTemp["mve_rcd_codestado"]= XMLRuts.ExtractXAttr(l_xndData, "mve_rcd_codestado");
            l_drTemp["mve_nro_km"]= XMLRuts.ExtractXAttr(l_xndData, "mve_nro_km", 0);

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
        private EMovilEstado(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: MovilEstado
        /// </summary>
        /// <returns>Entidad vacia: MovilEstado</returns>
        public static EMovilEstado NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mve_ecd_patente"]= "";
            l_drTemp["mve_fyh_fecha"]= DateTimeRuts.Empty;
            l_drTemp["mve_rcd_codestado"]= "";
            l_drTemp["mve_nro_km"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilEstado l_entRet= new EMovilEstado(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MovilEstado
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha y Hora</param>
        /// <param name="p_strCodestado">Codigo del estado.</param>
        /// <param name="p_iKm">Kilometraje</param>
        /// <returns>Entidad: MovilEstado</returns>
        public static EMovilEstado NewFilled(string p_strPatente,
                                             DateTime p_dtFecha,
                                             string p_strCodestado,
                                             int p_iKm)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilEstado.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mve_ecd_patente"]= p_strPatente;
            l_drTemp["mve_fyh_fecha"]= p_dtFecha;
            l_drTemp["mve_rcd_codestado"]= p_strCodestado;
            l_drTemp["mve_nro_km"]= p_iKm;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilEstado l_entRet= new EMovilEstado(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo del estado.
        /// </summary>
        public static string FrmtCodestado(string p_strCodestado)
        {
            if (p_strCodestado.Trim().Length > 2)
                p_strCodestado= p_strCodestado.Trim().Substring(0,2);

            return p_strCodestado.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("mve_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("mve_fyh_fecha", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("mve_rcd_codestado", typeof(string));
                l_dcStruct[3]= new DataColumn("mve_nro_km", typeof(int));
                EMovilEstado.FillFixedFields(ref l_dcStruct, 4);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Patente
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["mve_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["mve_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Fecha y Hora
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["mve_fyh_fecha"];}
            set {InternalData["mve_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Codigo del estado.
        /// </summary>
        public string Codestado
        {
            get {return (string) InternalData["mve_rcd_codestado"];}
            set {InternalData["mve_rcd_codestado"]= EMovilEstado.FrmtCodestado(value);}
        }

        /// <summary>
        /// Kilometraje
        /// </summary>
        public int Km
        {
            get {return (int) InternalData["mve_nro_km"];}
            set {InternalData["mve_nro_km"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilEstado] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilEstado] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMovilEstado", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mve_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mve_fyh_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mve_rcd_codestado", Codestado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mve_nro_km", Km));

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

    #region Lista-Entidad: MovilesEstado
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesEstado
    /// </summary>
    public sealed partial class LEMovilesEstado : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MvlEstados
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesEstado(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesEstado(string p_strXMLData) :
            base(EMovilEstado.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMovilEstado(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMovilesEstado(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: MovilesEstado
        /// </summary>
        /// <returns>Lista-Entidad vacia: MvlEstados</returns>
        public static LEMovilesEstado NewEmpty()
        {
            return new LEMovilesEstado(EMovilEstado.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMovilEstado">Entidad a agregar</param>
        public void AddEntity(EMovilEstado p_entEMovilEstado)
        {
            base.AddEntity(p_entEMovilEstado);
        }

        /// <summary>
        /// Remueve una entidad [MovilEstado] por clave
        /// </summary>
        public int RemoveEntity(string p_strPatente,
                                DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mve_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                "convert(mve_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

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
        /// Verifca si una entidad [MovilEstado] esta en la lista
        /// </summary>
        public bool Contains(string p_strPatente,
                             DateTime p_dtFecha)
        {
            using (EMovilEstado l_entTemp= this[p_strPatente,
                                                p_dtFecha])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MovilesEstado
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EMovilEstado l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMovilEstado(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MovilesEstado
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMovilEstado l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MovilesEstado
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMovilesEstado GetAsLET()
        {
            // Llenamos la lista tipada
            LETMovilesEstado l_lentRet= new LETMovilesEstado();

            foreach (EMovilEstado l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEstado] por indice
        /// </summary>
        public new EMovilEstado this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MovilEstado con los datos de la fila
                return new EMovilEstado(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEstado] por clave
        /// </summary>
        public EMovilEstado this[string p_strPatente,
                                 DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mve_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                    "convert(mve_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MovilEstado con los datos de la fila
                if (l_drData == null) return null;
                return new EMovilEstado(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMovilesEstado", null);

                foreach (EMovilEstado l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MovilesEstado
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesEstado
    /// </summary>
    public sealed partial class LETMovilesEstado : LET<EMovilEstado>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MovilesEstado
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMovilesEstado GetAsLE()
        {
            // Llenamos la lista
            LEMovilesEstado l_lentRet= LEMovilesEstado.NewEmpty();

            foreach (EMovilEstado l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilEstado] por clave
        /// </summary>
        public EMovilEstado this[string p_strPatente,
                                 DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (EMovilEstado l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Patente == p_strPatente) &&
                        (l_entItem.Fecha == p_dtFecha))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: MovilKms
    /// <summary>
    /// Clase que representa la Entidad: MovilKms
    /// </summary>
    public sealed partial class EMovilKms : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MvlKilometros
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMovilKms(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilKms
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMovilKms(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MovilKms
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMovilKms(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMovilKms.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mkm_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "mkm_ecd_patente");
            l_drTemp["mkm_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "mkm_fyh_fecha", true);
            l_drTemp["mkm_nro_km"]= XMLRuts.ExtractXAttr(l_xndData, "mkm_nro_km", 1);

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
        private EMovilKms(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: MovilKms
        /// </summary>
        /// <returns>Entidad vacia: MovilKms</returns>
        public static EMovilKms NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilKms.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mkm_ecd_patente"]= "";
            l_drTemp["mkm_fyh_fecha"]= DateTimeRuts.Empty;
            l_drTemp["mkm_nro_km"]= 1;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilKms l_entRet= new EMovilKms(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MovilKms
        /// </summary>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_iKm">Kilometros</param>
        /// <returns>Entidad: MovilKms</returns>
        public static EMovilKms NewFilled(string p_strPatente,
                                          DateTime p_dtFecha,
                                          int p_iKm)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovilKms.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mkm_ecd_patente"]= p_strPatente;
            l_drTemp["mkm_fyh_fecha"]= p_dtFecha;
            l_drTemp["mkm_nro_km"]= p_iKm;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovilKms l_entRet= new EMovilKms(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("mkm_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("mkm_fyh_fecha", typeof(DateTime));
                l_dcStruct[2]= new DataColumn("mkm_nro_km", typeof(int));
                EMovilKms.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Patente
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["mkm_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["mkm_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["mkm_fyh_fecha"];}
            set {InternalData["mkm_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Kilometros
        /// </summary>
        public int Km
        {
            get {return (int) InternalData["mkm_nro_km"];}
            set {InternalData["mkm_nro_km"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilKms] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovilKms] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMovilKms", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mkm_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mkm_fyh_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mkm_nro_km", Km));

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

    #region Lista-Entidad: MovilesKms
    /// <summary>
    /// Clase que representa la Lista-Entidad: MovilesKms
    /// </summary>
    public sealed partial class LEMovilesKms : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MvlKilometros
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesKms(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMovilesKms(string p_strXMLData) :
            base(EMovilKms.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMovilKms(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMovilesKms(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: MovilesKms
        /// </summary>
        /// <returns>Lista-Entidad vacia: MvlKilometros</returns>
        public static LEMovilesKms NewEmpty()
        {
            return new LEMovilesKms(EMovilKms.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMovilKms">Entidad a agregar</param>
        public void AddEntity(EMovilKms p_entEMovilKms)
        {
            base.AddEntity(p_entEMovilKms);
        }

        /// <summary>
        /// Remueve una entidad [MovilKms] por clave
        /// </summary>
        public int RemoveEntity(string p_strPatente,
                                DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mkm_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                "convert(mkm_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

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
        /// Verifca si una entidad [MovilKms] esta en la lista
        /// </summary>
        public bool Contains(string p_strPatente,
                             DateTime p_dtFecha)
        {
            using (EMovilKms l_entTemp= this[p_strPatente,
                                             p_dtFecha])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MovilesKms
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EMovilKms l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMovilKms(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MovilesKms
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMovilKms l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MovilesKms
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMovilesKms GetAsLET()
        {
            // Llenamos la lista tipada
            LETMovilesKms l_lentRet= new LETMovilesKms();

            foreach (EMovilKms l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilKms] por indice
        /// </summary>
        public new EMovilKms this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MovilKms con los datos de la fila
                return new EMovilKms(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilKms] por clave
        /// </summary>
        public EMovilKms this[string p_strPatente,
                              DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mkm_ecd_patente = " + Ruts.Co(p_strPatente) + " and " + 
                    "convert(mkm_fyh_fecha,'System.String') = '" + p_dtFecha + "'";

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MovilKms con los datos de la fila
                if (l_drData == null) return null;
                return new EMovilKms(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMovilesKms", null);

                foreach (EMovilKms l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MovilesKms
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MovilesKms
    /// </summary>
    public sealed partial class LETMovilesKms : LET<EMovilKms>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MovilesKms
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMovilesKms GetAsLE()
        {
            // Llenamos la lista
            LEMovilesKms l_lentRet= LEMovilesKms.NewEmpty();

            foreach (EMovilKms l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MovilKms] por clave
        /// </summary>
        public EMovilKms this[string p_strPatente,
                              DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (EMovilKms l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Patente == p_strPatente) &&
                        (l_entItem.Fecha == p_dtFecha))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Movil
    /// <summary>
    /// Clase que representa la Entidad: Movil
    /// </summary>
    public sealed partial class EMovil : Entidad
    {
        #region Miembros de la clase
            private LEMovilesCombus m_lentMovilesCombus= null;
            private LEMovilesEquip m_lentMovilesEquip= null;
            private LEMovilesEstado m_lentMovilesEstado= null;
            private LEMovilesKms m_lentMovilesKms= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Moviles
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMovil(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Movil
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMovil(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Movil
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMovil(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMovil.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mov_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "mov_ecd_patente");
            l_drTemp["mov_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "mov_des_des");
            l_drTemp["mov_txt_anot"]= XMLRuts.ExtractXAttr(l_xndData, "mov_txt_anot");
            l_drTemp["mov_des_nrochasis"]= XMLRuts.ExtractXAttr(l_xndData, "mov_des_nrochasis");
            l_drTemp["mov_des_nromotor"]= XMLRuts.ExtractXAttr(l_xndData, "mov_des_nromotor");
            l_drTemp["mov_rcd_modelo"]= XMLRuts.ExtractXAttr(l_xndData, "mov_rcd_modelo");
            l_drTemp["mov_nro_aniofabric"]= XMLRuts.ExtractXAttr(l_xndData, "mov_nro_aniofabric", 1);
            l_drTemp["mov_cd1_propio"]= XMLRuts.ExtractXAttr(l_xndData, "mov_cd1_propio");

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
        private EMovil(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentMovilesCombus= LEMovilesCombus.NewEmpty();
            m_lentMovilesEquip= LEMovilesEquip.NewEmpty();
            m_lentMovilesEstado= LEMovilesEstado.NewEmpty();
            m_lentMovilesKms= LEMovilesKms.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Movil
        /// </summary>
        /// <returns>Entidad vacia: Movil</returns>
        public static EMovil NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovil.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mov_ecd_patente"]= "";
            l_drTemp["mov_des_des"]= "";
            l_drTemp["mov_txt_anot"]= "";
            l_drTemp["mov_des_nrochasis"]= "";
            l_drTemp["mov_des_nromotor"]= "";
            l_drTemp["mov_rcd_modelo"]= "";
            l_drTemp["mov_nro_aniofabric"]= 1;
            l_drTemp["mov_cd1_propio"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovil l_entRet= new EMovil(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Movil
        /// </summary>
        /// <param name="p_strPatente">Patente de la Ambulancia</param>
        /// <param name="p_strDes">Descripcion</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">Año de fabricación</param>
        /// <param name="p_strPropio">Propio o no</param>
        /// <returns>Entidad: Movil</returns>
        public static EMovil NewFilled(string p_strPatente,
                                       string p_strDes,
                                       string p_strAnot,
                                       string p_strNrochasis,
                                       string p_strNromotor,
                                       string p_strModelo,
                                       int p_iAniofabric,
                                       string p_strPropio)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMovil.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mov_ecd_patente"]= p_strPatente;
            l_drTemp["mov_des_des"]= p_strDes;
            l_drTemp["mov_txt_anot"]= p_strAnot;
            l_drTemp["mov_des_nrochasis"]= p_strNrochasis;
            l_drTemp["mov_des_nromotor"]= p_strNromotor;
            l_drTemp["mov_rcd_modelo"]= p_strModelo;
            l_drTemp["mov_nro_aniofabric"]= p_iAniofabric;
            l_drTemp["mov_cd1_propio"]= p_strPropio;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMovil l_entRet= new EMovil(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Modelo
        /// </summary>
        public static string FrmtModelo(string p_strModelo)
        {
            if (p_strModelo.Trim().Length > 2)
                p_strModelo= p_strModelo.Trim().Substring(0,2);

            return p_strModelo.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[12];

                l_dcStruct[0]= new DataColumn("mov_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("mov_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("mov_txt_anot", typeof(string));
                l_dcStruct[3]= new DataColumn("mov_des_nrochasis", typeof(string));
                l_dcStruct[4]= new DataColumn("mov_des_nromotor", typeof(string));
                l_dcStruct[5]= new DataColumn("mov_rcd_modelo", typeof(string));
                l_dcStruct[6]= new DataColumn("mov_nro_aniofabric", typeof(int));
                l_dcStruct[7]= new DataColumn("mov_cd1_propio", typeof(string));
                EMovil.FillFixedFields(ref l_dcStruct, 8);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Patente de la Ambulancia
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["mov_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["mov_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["mov_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mov_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Anotaciones
        /// </summary>
        public string Anot
        {
            get {return (string) InternalData["mov_txt_anot"];}
            set {InternalData["mov_txt_anot"]= value;}
        }

        /// <summary>
        /// Nro Chasis
        /// </summary>
        public string Nrochasis
        {
            get {return ((string) InternalData["mov_des_nrochasis"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mov_des_nrochasis"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Nro Motor
        /// </summary>
        public string Nromotor
        {
            get {return ((string) InternalData["mov_des_nromotor"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mov_des_nromotor"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Modelo
        /// </summary>
        public string Modelo
        {
            get {return (string) InternalData["mov_rcd_modelo"];}
            set {InternalData["mov_rcd_modelo"]= EMovil.FrmtModelo(value);}
        }

        /// <summary>
        /// Año de fabricación
        /// </summary>
        public int Aniofabric
        {
            get {return (int) InternalData["mov_nro_aniofabric"];}
            set {InternalData["mov_nro_aniofabric"]= value;}
        }

        /// <summary>
        /// Propio o no
        /// </summary>
        public string Propio
        {
            get {return (string) InternalData["mov_cd1_propio"];}
            set {InternalData["mov_cd1_propio"]= value;}
        }

        /// <summary>
        /// Combustible en moviles
        /// </summary>
        public LEMovilesCombus MovilesCombus
        {
            get {return m_lentMovilesCombus;}
            set {m_lentMovilesCombus= value;}
        }

        /// <summary>
        /// Moviles Equipamiento
        /// </summary>
        public LEMovilesEquip MovilesEquip
        {
            get {return m_lentMovilesEquip;}
            set {m_lentMovilesEquip= value;}
        }

        /// <summary>
        /// Movil Estado
        /// </summary>
        public LEMovilesEstado MovilesEstado
        {
            get {return m_lentMovilesEstado;}
            set {m_lentMovilesEstado= value;}
        }

        /// <summary>
        /// Kilometros de los moviles
        /// </summary>
        public LEMovilesKms MovilesKms
        {
            get {return m_lentMovilesKms;}
            set {m_lentMovilesKms= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovil] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMovil] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMovil", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_txt_anot", Anot));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_des_nrochasis", Nrochasis));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_des_nromotor", Nromotor));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_rcd_modelo", Modelo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_nro_aniofabric", Aniofabric));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_cd1_propio", Propio));

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

    #region Lista-Entidad: Moviles
    /// <summary>
    /// Clase que representa la Lista-Entidad: Moviles
    /// </summary>
    public sealed partial class LEMoviles : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Moviles
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMoviles(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMoviles(string p_strXMLData) :
            base(EMovil.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMovil(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMoviles(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Moviles
        /// </summary>
        /// <returns>Lista-Entidad vacia: Moviles</returns>
        public static LEMoviles NewEmpty()
        {
            return new LEMoviles(EMovil.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMovil">Entidad a agregar</param>
        public void AddEntity(EMovil p_entEMovil)
        {
            base.AddEntity(p_entEMovil);
        }

        /// <summary>
        /// Remueve una entidad [Movil] por clave
        /// </summary>
        public int RemoveEntity(string p_strPatente)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mov_ecd_patente = " + Ruts.Co(p_strPatente);

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
        /// Verifca si una entidad [Movil] esta en la lista
        /// </summary>
        public bool Contains(string p_strPatente)
        {
            using (EMovil l_entTemp= this[p_strPatente])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Moviles
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EMovil l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMovil(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Moviles
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMovil l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Moviles
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMoviles GetAsLET()
        {
            // Llenamos la lista tipada
            LETMoviles l_lentRet= new LETMoviles();

            foreach (EMovil l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Movil] por indice
        /// </summary>
        public new EMovil this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Movil con los datos de la fila
                return new EMovil(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Movil] por clave
        /// </summary>
        public EMovil this[string p_strPatente]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mov_ecd_patente = " + Ruts.Co(p_strPatente);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Movil con los datos de la fila
                if (l_drData == null) return null;
                return new EMovil(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMoviles", null);

                foreach (EMovil l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Moviles
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Moviles
    /// </summary>
    public sealed partial class LETMoviles : LET<EMovil>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Moviles
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMoviles GetAsLE()
        {
            // Llenamos la lista
            LEMoviles l_lentRet= LEMoviles.NewEmpty();

            foreach (EMovil l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Movil] por clave
        /// </summary>
        public EMovil this[string p_strPatente]
        {
            get {
                // Buscamos la entidad
                foreach (EMovil l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Patente == p_strPatente)
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
