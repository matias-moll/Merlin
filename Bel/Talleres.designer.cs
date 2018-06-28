#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using Mrln;
#endregion

namespace Mrln.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 27/06/2018 19:49
    // Sistema                  : Mrln
    // Clase para Administrar   : Talleres y sus categorias
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: TallerCategoria
    /// <summary>
    /// Clase que representa la Entidad: TallerCategoria
    /// </summary>
    public sealed partial class ETallerCategoria : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: TallerCategoria
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ETallerCategoria(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TallerCategoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ETallerCategoria(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: TallerCategoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ETallerCategoria(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ETallerCategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tct_cod_codigotaller"]= XMLRuts.ExtractXAttr(l_xndData, "tct_cod_codigotaller");
            l_drTemp["tct_rcd_codigocategoria"]= XMLRuts.ExtractXAttr(l_xndData, "tct_rcd_codigocategoria");
            l_drTemp["tct_cod_dummy"]= XMLRuts.ExtractXAttr(l_xndData, "tct_cod_dummy");
            l_drTemp["ctl_taller"]= XMLRuts.ExtractXAttr(l_xndData, "ctl_taller");
            l_drTemp["tlc_categoria"]= XMLRuts.ExtractXAttr(l_xndData, "tlc_categoria");

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
        private ETallerCategoria(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: TallerCategoria
        /// </summary>
        /// <returns>Entidad vacia: TallerCategoria</returns>
        public static ETallerCategoria NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETallerCategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tct_cod_codigotaller"]= "";
            l_drTemp["tct_rcd_codigocategoria"]= "";
            l_drTemp["tct_cod_dummy"]= "";
            l_drTemp["ctl_taller"]= "";
            l_drTemp["tlc_categoria"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETallerCategoria l_entRet= new ETallerCategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: TallerCategoria
        /// </summary>
        /// <param name="p_strCodigotaller">Codigo Taller</param>
        /// <param name="p_strCodigocategoria">Codigo Categoria</param>
        /// <param name="p_strDummy">dummy</param>
        /// <returns>Entidad: TallerCategoria</returns>
        public static ETallerCategoria NewFilled(string p_strCodigotaller,
                                                 string p_strCodigocategoria,
                                                 string p_strDummy)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETallerCategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tct_cod_codigotaller"]= p_strCodigotaller;
            l_drTemp["tct_rcd_codigocategoria"]= p_strCodigocategoria;
            l_drTemp["tct_cod_dummy"]= p_strDummy;
            l_drTemp["ctl_taller"]= "";
            l_drTemp["tlc_categoria"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETallerCategoria l_entRet= new ETallerCategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Taller
        /// </summary>
        public static string FrmtCodigotaller(string p_strCodigotaller)
        {
            if (p_strCodigotaller.Trim().Length > 4)
                p_strCodigotaller= p_strCodigotaller.Trim().Substring(0,4);

            return p_strCodigotaller.Trim().PadLeft(4).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[9];

                l_dcStruct[0]= new DataColumn("tct_cod_codigotaller", typeof(string));
                l_dcStruct[1]= new DataColumn("ctl_taller", typeof(string));
                l_dcStruct[2]= new DataColumn("tct_rcd_codigocategoria", typeof(string));
                l_dcStruct[3]= new DataColumn("tlc_categoria", typeof(string));
                l_dcStruct[4]= new DataColumn("tct_cod_dummy", typeof(string));
                ETallerCategoria.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Taller
        /// </summary>
        public static string CodigotallerCmp
        {
           get {return "tct_cod_codigotaller";}
        }

        /// <summary>
        /// Codigo Taller
        /// </summary>
        public string Codigotaller
        {
            get {return (string) InternalData["tct_cod_codigotaller"];}
            set {InternalData["tct_cod_codigotaller"]= ETallerCategoria.FrmtCodigotaller(value);}
        }

        /// <summary>
        /// Codigo Categoria
        /// </summary>
        public static string CodigocategoriaCmp
        {
           get {return "tct_rcd_codigocategoria";}
        }

        /// <summary>
        /// Codigo Categoria
        /// </summary>
        public string Codigocategoria
        {
            get {return (string) InternalData["tct_rcd_codigocategoria"];}
            set {InternalData["tct_rcd_codigocategoria"]= value;}
        }

        /// <summary>
        /// dummy
        /// </summary>
        public static string DummyCmp
        {
           get {return "tct_cod_dummy";}
        }

        /// <summary>
        /// dummy
        /// </summary>
        public string Dummy
        {
            get {return ((string) InternalData["tct_cod_dummy"]).Trim();}
            set {
                if (value.Trim().Length > 4) value= value.Trim().Substring(0,4);
                InternalData["tct_cod_dummy"]= value.Trim();
            }
        }

        /// <summary>
        /// Taller
        /// </summary>
        public string Ctl_taller
        {
            get {return (string) InternalData["ctl_taller"];}
            set {InternalData["ctl_taller"]= value;}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Tlc_categoria
        {
            get {return (string) InternalData["tlc_categoria"];}
            set {InternalData["tlc_categoria"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ETallerCategoria] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ETallerCategoria] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ETallerCategoria", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tct_cod_codigotaller", Codigotaller));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tct_rcd_codigocategoria", Codigocategoria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tct_cod_dummy", Dummy));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ctl_taller", Ctl_taller));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tlc_categoria", Tlc_categoria));

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

    #region Lista-Entidad: TalleresCategorias
    /// <summary>
    /// Clase que representa la Lista-Entidad: TalleresCategorias
    /// </summary>
    public sealed partial class LETalleresCategorias : ListaEntidades, IEnumerable<ETallerCategoria>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: TallerCategoria
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETalleresCategorias(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETalleresCategorias(string p_strXMLData) :
            base(ETallerCategoria.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ETallerCategoria(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LETalleresCategorias(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: TalleresCategorias
        /// </summary>
        /// <returns>Lista-Entidad vacia: TallerCategoria</returns>
        public static LETalleresCategorias NewEmpty()
        {
            return new LETalleresCategorias(ETallerCategoria.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entETallerCategoria">Entidad a agregar</param>
        public void AddEntity(ETallerCategoria p_entETallerCategoria)
        {
            base.AddEntity(p_entETallerCategoria);
        }

        /// <summary>
        /// Remueve una entidad [TallerCategoria] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigotaller,
                                string p_strCodigocategoria)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "tct_cod_codigotaller = " + Ruts.Co(p_strCodigotaller) + " and " + 
                "tct_rcd_codigocategoria = " + Ruts.Co(p_strCodigocategoria);

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
        /// Verifca si una entidad [TallerCategoria] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigotaller,
                             string p_strCodigocategoria)
        {
            using (ETallerCategoria l_entTemp= this[p_strCodigotaller,
                                                    p_strCodigocategoria])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: TalleresCategorias
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ETallerCategoria> GetEnumerator() 
        {
            ETallerCategoria l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ETallerCategoria(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: TalleresCategorias
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ETallerCategoria l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: TalleresCategorias
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETTalleresCategorias GetAsLET()
        {
            // Llenamos la lista tipada
            LETTalleresCategorias l_lentRet= new LETTalleresCategorias();

            foreach (ETallerCategoria l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<TalleresCategorias>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ETallerCategoria> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ETallerCategoria>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TallerCategoria] por indice
        /// </summary>
        public new ETallerCategoria this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad TallerCategoria con los datos de la fila
                return new ETallerCategoria(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [TallerCategoria] por clave
        /// </summary>
        public ETallerCategoria this[string p_strCodigotaller,
                                     string p_strCodigocategoria]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "tct_cod_codigotaller = " + Ruts.Co(p_strCodigotaller) + " and " + 
                    "tct_rcd_codigocategoria = " + Ruts.Co(p_strCodigocategoria);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad TallerCategoria con los datos de la fila
                if (l_drData == null) return null;
                return new ETallerCategoria(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LETalleresCategorias", null);

                foreach (ETallerCategoria l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: TalleresCategorias
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: TalleresCategorias
    /// </summary>
    public sealed partial class LETTalleresCategorias : LET<ETallerCategoria>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: TalleresCategorias
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LETalleresCategorias GetAsLE()
        {
            // Llenamos la lista
            LETalleresCategorias l_lentRet= LETalleresCategorias.NewEmpty();

            foreach (ETallerCategoria l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [TallerCategoria] por clave
        /// </summary>
        public ETallerCategoria this[string p_strCodigotaller,
                                     string p_strCodigocategoria]
        {
            get {
                // Buscamos la entidad
                foreach (ETallerCategoria l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Codigotaller == p_strCodigotaller) &&
                        (l_entItem.Codigocategoria == p_strCodigocategoria))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Taller
    /// <summary>
    /// Clase que representa la Entidad: Taller
    /// </summary>
    public sealed partial class ETaller : Entidad
    {
        #region Miembros de la clase
            private LETalleresCategorias m_lentTalleresCategorias= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Taller
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ETaller(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Taller
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ETaller(string p_strXML) :
            this(p_strXML, false)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentTalleresCategorias= LETalleresCategorias.NewEmpty();
        }

        /// <summary>
        /// Construye una entidad desde un XML: Taller
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ETaller(string p_strXML,
                       bool p_bEsNueva,
                       bool p_bInitChilds= false)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETaller.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tll_cod_codigo"]= XMLRuts.ExtractXAttr(l_xndData, "tll_cod_codigo");
            l_drTemp["tll_ede_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "tll_ede_descripcion");
            l_drTemp["tll_xde_direccion"]= XMLRuts.ExtractXAttr(l_xndData, "tll_xde_direccion");
            l_drTemp["tll_tel_telefono"]= XMLRuts.ExtractXAttr(l_xndData, "tll_tel_telefono");
            l_drTemp["tll_ede_contacto"]= XMLRuts.ExtractXAttr(l_xndData, "tll_ede_contacto");

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
            fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);

            if (!p_bInitChilds) return;

            // Creamos las listas-entidad hijas vacias
            m_lentTalleresCategorias= LETalleresCategorias.NewEmpty();
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private ETaller(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentTalleresCategorias= LETalleresCategorias.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Taller
        /// </summary>
        /// <returns>Entidad vacia: Taller</returns>
        public static ETaller NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETaller.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tll_cod_codigo"]= "";
            l_drTemp["tll_ede_descripcion"]= "";
            l_drTemp["tll_xde_direccion"]= "";
            l_drTemp["tll_tel_telefono"]= "";
            l_drTemp["tll_ede_contacto"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETaller l_entRet= new ETaller(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Taller
        /// </summary>
        /// <param name="p_strCodigo">Codigo</param>
        /// <param name="p_strDescripcion">Descripcion</param>
        /// <param name="p_strDireccion">Direccion</param>
        /// <param name="p_strTelefono">Telefono</param>
        /// <param name="p_strContacto">Contacto</param>
        /// <returns>Entidad: Taller</returns>
        public static ETaller NewFilled(string p_strCodigo,
                                        string p_strDescripcion,
                                        string p_strDireccion,
                                        string p_strTelefono,
                                        string p_strContacto)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ETaller.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["tll_cod_codigo"]= p_strCodigo;
            l_drTemp["tll_ede_descripcion"]= p_strDescripcion;
            l_drTemp["tll_xde_direccion"]= p_strDireccion;
            l_drTemp["tll_tel_telefono"]= p_strTelefono;
            l_drTemp["tll_ede_contacto"]= p_strContacto;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ETaller l_entRet= new ETaller(l_dtTemp);
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
        public static string FrmtCodigo(string p_strCodigo)
        {
            if (p_strCodigo.Trim().Length > 4)
                p_strCodigo= p_strCodigo.Trim().Substring(0,4);

            return p_strCodigo.Trim().PadLeft(4).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[9];

                l_dcStruct[0]= new DataColumn("tll_cod_codigo", typeof(string));
                l_dcStruct[1]= new DataColumn("tll_ede_descripcion", typeof(string));
                l_dcStruct[2]= new DataColumn("tll_xde_direccion", typeof(string));
                l_dcStruct[3]= new DataColumn("tll_tel_telefono", typeof(string));
                l_dcStruct[4]= new DataColumn("tll_ede_contacto", typeof(string));
                ETaller.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public static string CodigoCmp
        {
           get {return "tll_cod_codigo";}
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Codigo
        {
            get {return (string) InternalData["tll_cod_codigo"];}
            set {InternalData["tll_cod_codigo"]= ETaller.FrmtCodigo(value);}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "tll_ede_descripcion";}
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["tll_ede_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["tll_ede_descripcion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Direccion
        /// </summary>
        public static string DireccionCmp
        {
           get {return "tll_xde_direccion";}
        }

        /// <summary>
        /// Direccion
        /// </summary>
        public string Direccion
        {
            get {return ((string) InternalData["tll_xde_direccion"]).Trim();}
            set {
                if (value.Trim().Length > 120) value= value.Trim().Substring(0,120);
                InternalData["tll_xde_direccion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Telefono
        /// </summary>
        public static string TelefonoCmp
        {
           get {return "tll_tel_telefono";}
        }

        /// <summary>
        /// Telefono
        /// </summary>
        public string Telefono
        {
            get {return ((string) InternalData["tll_tel_telefono"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["tll_tel_telefono"]= value.Trim();
            }
        }

        /// <summary>
        /// Contacto
        /// </summary>
        public static string ContactoCmp
        {
           get {return "tll_ede_contacto";}
        }

        /// <summary>
        /// Contacto
        /// </summary>
        public string Contacto
        {
            get {return ((string) InternalData["tll_ede_contacto"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["tll_ede_contacto"]= value.Trim();
            }
        }

        /// <summary>
        /// Categorias de los talleres
        /// </summary>
        public LETalleresCategorias TalleresCategorias
        {
            get {return m_lentTalleresCategorias;}
            set {m_lentTalleresCategorias= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ETaller] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ETaller] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ETaller", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tll_cod_codigo", Codigo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tll_ede_descripcion", Descripcion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tll_xde_direccion", Direccion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tll_tel_telefono", Telefono));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "tll_ede_contacto", Contacto));

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

    #region Lista-Entidad: Talleres
    /// <summary>
    /// Clase que representa la Lista-Entidad: Talleres
    /// </summary>
    public sealed partial class LETalleres : ListaEntidades, IEnumerable<ETaller>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Taller
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETalleres(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LETalleres(string p_strXMLData) :
            base(ETaller.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ETaller(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LETalleres(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Talleres
        /// </summary>
        /// <returns>Lista-Entidad vacia: Taller</returns>
        public static LETalleres NewEmpty()
        {
            return new LETalleres(ETaller.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entETaller">Entidad a agregar</param>
        public void AddEntity(ETaller p_entETaller)
        {
            base.AddEntity(p_entETaller);
        }

        /// <summary>
        /// Remueve una entidad [Taller] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigo)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "tll_cod_codigo = " + Ruts.Co(ETaller.FrmtCodigo(p_strCodigo));

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
        /// Verifca si una entidad [Taller] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigo)
        {
            using (ETaller l_entTemp= this[p_strCodigo])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Talleres
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ETaller> GetEnumerator() 
        {
            ETaller l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ETaller(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Talleres
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ETaller l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Talleres
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETTalleres GetAsLET()
        {
            // Llenamos la lista tipada
            LETTalleres l_lentRet= new LETTalleres();

            foreach (ETaller l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Talleres>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ETaller> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ETaller>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Taller] por indice
        /// </summary>
        public new ETaller this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Taller con los datos de la fila
                return new ETaller(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Taller] por clave
        /// </summary>
        public ETaller this[string p_strCodigo]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "tll_cod_codigo = " + Ruts.Co(ETaller.FrmtCodigo(p_strCodigo));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Taller con los datos de la fila
                if (l_drData == null) return null;
                return new ETaller(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LETalleres", null);

                foreach (ETaller l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Talleres
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Talleres
    /// </summary>
    public sealed partial class LETTalleres : LET<ETaller>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Talleres
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LETalleres GetAsLE()
        {
            // Llenamos la lista
            LETalleres l_lentRet= LETalleres.NewEmpty();

            foreach (ETaller l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Taller] por clave
        /// </summary>
        public ETaller this[string p_strCodigo]
        {
            get {
                // Buscamos la entidad
                foreach (ETaller l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codigo == ETaller.FrmtCodigo(p_strCodigo))
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
