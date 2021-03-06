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
    // Fecha                    : 07/02/2019 03:30
    // Sistema                  : Mrln
    // Clase para Administrar   : Tablas Generales
    //----------------------------------------------------------------------------
    // � 1996-2019 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma autom�tica. Cualquier
    //    modificaci�n que se realize sobre ella se perder� en la pr�xima
    //    regeneraci�n.
    //****************************************************************************

    #region Entidad: Categoria
    /// <summary>
    /// Clase que representa la Entidad: Categoria
    /// </summary>
    public sealed partial class ECategoria : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Categorias
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECategoria(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Categoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECategoria(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Categoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECategoria(string p_strXML,
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
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "cat_rcd_cod");
            l_drTemp["cat_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "cat_des_des");

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
        private ECategoria(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Categoria
        /// </summary>
        /// <returns>Entidad vacia: Categoria</returns>
        public static ECategoria NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= "";
            l_drTemp["cat_des_des"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoria l_entRet= new ECategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Categoria
        /// </summary>
        /// <param name="p_strCod">Cod Categoria</param>
        /// <param name="p_strDes">Categoria</param>
        /// <returns>Entidad: Categoria</returns>
        public static ECategoria NewFilled(string p_strCod,
                                           string p_strDes)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= p_strCod;
            l_drTemp["cat_des_des"]= p_strDes;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoria l_entRet= new ECategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Cod Categoria
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("cat_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("cat_des_des", typeof(string));
                ECategoria.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Cod Categoria
        /// </summary>
        public static string CodCmp
        {
           get {return "cat_rcd_cod";}
        }

        /// <summary>
        /// Cod Categoria
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["cat_rcd_cod"];}
            set {InternalData["cat_rcd_cod"]= ECategoria.FrmtCod(value);}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public static string DesCmp
        {
           get {return "cat_des_des";}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["cat_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cat_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [ECategoria] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECategoria] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECategoria", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cat_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cat_des_des", Des));

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

    #region Lista-Entidad: Categorias
    /// <summary>
    /// Clase que representa la Lista-Entidad: Categorias
    /// </summary>
    public sealed partial class LECategorias : ListaEntidades, IEnumerable<ECategoria>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Categorias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategorias(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategorias(string p_strXMLData) :
            base(ECategoria.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECategoria(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECategorias(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Categorias
        /// </summary>
        /// <returns>Lista-Entidad vacia: Categorias</returns>
        public static LECategorias NewEmpty()
        {
            return new LECategorias(ECategoria.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECategoria">Entidad a agregar</param>
        public void AddEntity(ECategoria p_entECategoria)
        {
            base.AddEntity(p_entECategoria);
        }

        /// <summary>
        /// Remueve una entidad [Categoria] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cat_rcd_cod = " + Ruts.Co(ECategoria.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Categoria] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ECategoria l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Categorias
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ECategoria> GetEnumerator() 
        {
            ECategoria l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECategoria(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Categorias
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECategoria l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Categorias
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCategorias GetAsLET()
        {
            // Llenamos la lista tipada
            LETCategorias l_lentRet= new LETCategorias();

            foreach (ECategoria l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Categorias>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ECategoria> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ECategoria>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por indice
        /// </summary>
        public new ECategoria this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Categoria con los datos de la fila
                return new ECategoria(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por clave
        /// </summary>
        public ECategoria this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cat_rcd_cod = " + Ruts.Co(ECategoria.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Categoria con los datos de la fila
                if (l_drData == null) return null;
                return new ECategoria(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECategorias", null);

                foreach (ECategoria l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Categorias
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Categorias
    /// </summary>
    public sealed partial class LETCategorias : LET<ECategoria>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Categorias
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECategorias GetAsLE()
        {
            // Llenamos la lista
            LECategorias l_lentRet= LECategorias.NewEmpty();

            foreach (ECategoria l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por clave
        /// </summary>
        public ECategoria this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ECategoria l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == ECategoria.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: DestinatariosMail
    /// <summary>
    /// Clase que representa la Entidad: DestinatariosMail
    /// </summary>
    public sealed partial class EDestinatariosMail : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EDestinatariosMail(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: DestinatariosMail
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EDestinatariosMail(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: DestinatariosMail
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EDestinatariosMail(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EDestinatariosMail.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["dem_cod_codigo"]= XMLRuts.ExtractXAttr(l_xndData, "dem_cod_codigo");
            l_drTemp["dem_des_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "dem_des_descripcion");
            l_drTemp["dem_txt_destinatarios"]= XMLRuts.ExtractXAttr(l_xndData, "dem_txt_destinatarios");

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
        private EDestinatariosMail(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: DestinatariosMail
        /// </summary>
        /// <returns>Entidad vacia: DestinatariosMail</returns>
        public static EDestinatariosMail NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EDestinatariosMail.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["dem_cod_codigo"]= "";
            l_drTemp["dem_des_descripcion"]= "";
            l_drTemp["dem_txt_destinatarios"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EDestinatariosMail l_entRet= new EDestinatariosMail(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: DestinatariosMail
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_strDescripcion">Descripci�n</param>
        /// <param name="p_strDestinatarios">Destinatarios</param>
        /// <returns>Entidad: DestinatariosMail</returns>
        public static EDestinatariosMail NewFilled(string p_strCodigo,
                                                   string p_strDescripcion,
                                                   string p_strDestinatarios)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EDestinatariosMail.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["dem_cod_codigo"]= p_strCodigo;
            l_drTemp["dem_des_descripcion"]= p_strDescripcion;
            l_drTemp["dem_txt_destinatarios"]= p_strDestinatarios;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EDestinatariosMail l_entRet= new EDestinatariosMail(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: C�digo
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
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("dem_cod_codigo", typeof(string));
                l_dcStruct[1]= new DataColumn("dem_des_descripcion", typeof(string));
                l_dcStruct[2]= new DataColumn("dem_txt_destinatarios", typeof(string));
                EDestinatariosMail.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// C�digo
        /// </summary>
        public static string CodigoCmp
        {
           get {return "dem_cod_codigo";}
        }

        /// <summary>
        /// C�digo
        /// </summary>
        public string Codigo
        {
            get {return (string) InternalData["dem_cod_codigo"];}
            set {InternalData["dem_cod_codigo"]= EDestinatariosMail.FrmtCodigo(value);}
        }

        /// <summary>
        /// Descripci�n
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "dem_des_descripcion";}
        }

        /// <summary>
        /// Descripci�n
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["dem_des_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["dem_des_descripcion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Destinatarios
        /// </summary>
        public static string DestinatariosCmp
        {
           get {return "dem_txt_destinatarios";}
        }

        /// <summary>
        /// Destinatarios
        /// </summary>
        public string Destinatarios
        {
            get {return (string) InternalData["dem_txt_destinatarios"];}
            set {InternalData["dem_txt_destinatarios"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EDestinatariosMail] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EDestinatariosMail] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EDestinatariosMail", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "dem_cod_codigo", Codigo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "dem_des_descripcion", Descripcion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "dem_txt_destinatarios", Destinatarios));

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

    #region Lista-Entidad: DestinatariosMails
    /// <summary>
    /// Clase que representa la Lista-Entidad: DestinatariosMails
    /// </summary>
    public sealed partial class LEDestinatariosMails : ListaEntidades, IEnumerable<EDestinatariosMail>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: DestinatariosMails
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEDestinatariosMails(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEDestinatariosMails(string p_strXMLData) :
            base(EDestinatariosMail.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EDestinatariosMail(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEDestinatariosMails(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: DestinatariosMails
        /// </summary>
        /// <returns>Lista-Entidad vacia: DestinatariosMails</returns>
        public static LEDestinatariosMails NewEmpty()
        {
            return new LEDestinatariosMails(EDestinatariosMail.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEDestinatariosMail">Entidad a agregar</param>
        public void AddEntity(EDestinatariosMail p_entEDestinatariosMail)
        {
            base.AddEntity(p_entEDestinatariosMail);
        }

        /// <summary>
        /// Remueve una entidad [DestinatariosMail] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigo)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "dem_cod_codigo = " + Ruts.Co(EDestinatariosMail.FrmtCodigo(p_strCodigo));

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
        /// Verifca si una entidad [DestinatariosMail] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigo)
        {
            using (EDestinatariosMail l_entTemp= this[p_strCodigo])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: DestinatariosMails
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EDestinatariosMail> GetEnumerator() 
        {
            EDestinatariosMail l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EDestinatariosMail(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: DestinatariosMails
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EDestinatariosMail l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: DestinatariosMails
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETDestinatariosMails GetAsLET()
        {
            // Llenamos la lista tipada
            LETDestinatariosMails l_lentRet= new LETDestinatariosMails();

            foreach (EDestinatariosMail l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<DestinatariosMails>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EDestinatariosMail> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EDestinatariosMail>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [DestinatariosMail] por indice
        /// </summary>
        public new EDestinatariosMail this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad DestinatariosMail con los datos de la fila
                return new EDestinatariosMail(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [DestinatariosMail] por clave
        /// </summary>
        public EDestinatariosMail this[string p_strCodigo]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "dem_cod_codigo = " + Ruts.Co(EDestinatariosMail.FrmtCodigo(p_strCodigo));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad DestinatariosMail con los datos de la fila
                if (l_drData == null) return null;
                return new EDestinatariosMail(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEDestinatariosMails", null);

                foreach (EDestinatariosMail l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: DestinatariosMails
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: DestinatariosMails
    /// </summary>
    public sealed partial class LETDestinatariosMails : LET<EDestinatariosMail>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: DestinatariosMails
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEDestinatariosMails GetAsLE()
        {
            // Llenamos la lista
            LEDestinatariosMails l_lentRet= LEDestinatariosMails.NewEmpty();

            foreach (EDestinatariosMail l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [DestinatariosMail] por clave
        /// </summary>
        public EDestinatariosMail this[string p_strCodigo]
        {
            get {
                // Buscamos la entidad
                foreach (EDestinatariosMail l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codigo == EDestinatariosMail.FrmtCodigo(p_strCodigo))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Equipamento
    /// <summary>
    /// Clase que representa la Entidad: Equipamento
    /// </summary>
    public sealed partial class EEquipamento : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EEquipamento(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Equipamento
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EEquipamento(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Equipamento
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EEquipamento(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_cod_cod");
            l_drTemp["eqi_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_des_des");
            l_drTemp["eqi_imp_valor"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_imp_valor", (decimal) 0);

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
        private EEquipamento(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Equipamento
        /// </summary>
        /// <returns>Entidad vacia: Equipamento</returns>
        public static EEquipamento NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= "";
            l_drTemp["eqi_des_des"]= "";
            l_drTemp["eqi_imp_valor"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEquipamento l_entRet= new EEquipamento(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Equipamento
        /// </summary>
        /// <param name="p_strCod">Codigo Equipamiento</param>
        /// <param name="p_strDes">Equipamiento</param>
        /// <param name="p_dcValor">Importe</param>
        /// <returns>Entidad: Equipamento</returns>
        public static EEquipamento NewFilled(string p_strCod,
                                             string p_strDes,
                                             decimal p_dcValor)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= p_strCod;
            l_drTemp["eqi_des_des"]= p_strDes;
            l_drTemp["eqi_imp_valor"]= p_dcValor;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEquipamento l_entRet= new EEquipamento(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Equipamiento
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

                l_dcStruct[0]= new DataColumn("eqi_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("eqi_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("eqi_imp_valor", typeof(decimal));
                EEquipamento.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Equipamiento
        /// </summary>
        public static string CodCmp
        {
           get {return "eqi_cod_cod";}
        }

        /// <summary>
        /// Codigo Equipamiento
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["eqi_cod_cod"];}
            set {InternalData["eqi_cod_cod"]= EEquipamento.FrmtCod(value);}
        }

        /// <summary>
        /// Equipamiento
        /// </summary>
        public static string DesCmp
        {
           get {return "eqi_des_des";}
        }

        /// <summary>
        /// Equipamiento
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["eqi_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["eqi_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Importe
        /// </summary>
        public static string ValorCmp
        {
           get {return "eqi_imp_valor";}
        }

        /// <summary>
        /// Importe
        /// </summary>
        public decimal Valor
        {
            get {return (decimal) InternalData["eqi_imp_valor"];}
            set {InternalData["eqi_imp_valor"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EEquipamento] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EEquipamento] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EEquipamento", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_imp_valor", Valor));

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

    #region Lista-Entidad: Equipamientos
    /// <summary>
    /// Clase que representa la Lista-Entidad: Equipamientos
    /// </summary>
    public sealed partial class LEEquipamientos : ListaEntidades, IEnumerable<EEquipamento>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Equipamiento
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEquipamientos(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEquipamientos(string p_strXMLData) :
            base(EEquipamento.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EEquipamento(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEEquipamientos(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Equipamientos
        /// </summary>
        /// <returns>Lista-Entidad vacia: Equipamiento</returns>
        public static LEEquipamientos NewEmpty()
        {
            return new LEEquipamientos(EEquipamento.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEEquipamento">Entidad a agregar</param>
        public void AddEntity(EEquipamento p_entEEquipamento)
        {
            base.AddEntity(p_entEEquipamento);
        }

        /// <summary>
        /// Remueve una entidad [Equipamento] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "eqi_cod_cod = " + Ruts.Co(EEquipamento.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Equipamento] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EEquipamento l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Equipamientos
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EEquipamento> GetEnumerator() 
        {
            EEquipamento l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EEquipamento(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Equipamientos
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EEquipamento l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Equipamientos
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETEquipamientos GetAsLET()
        {
            // Llenamos la lista tipada
            LETEquipamientos l_lentRet= new LETEquipamientos();

            foreach (EEquipamento l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Equipamientos>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EEquipamento> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EEquipamento>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por indice
        /// </summary>
        public new EEquipamento this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Equipamento con los datos de la fila
                return new EEquipamento(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por clave
        /// </summary>
        public EEquipamento this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "eqi_cod_cod = " + Ruts.Co(EEquipamento.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Equipamento con los datos de la fila
                if (l_drData == null) return null;
                return new EEquipamento(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEEquipamientos", null);

                foreach (EEquipamento l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Equipamientos
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Equipamientos
    /// </summary>
    public sealed partial class LETEquipamientos : LET<EEquipamento>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Equipamientos
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEEquipamientos GetAsLE()
        {
            // Llenamos la lista
            LEEquipamientos l_lentRet= LEEquipamientos.NewEmpty();

            foreach (EEquipamento l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por clave
        /// </summary>
        public EEquipamento this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EEquipamento l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EEquipamento.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Estacion
    /// <summary>
    /// Clase que representa la Entidad: Estacion
    /// </summary>
    public sealed partial class EEstacion : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Estaciones
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EEstacion(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Estacion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EEstacion(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Estacion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EEstacion(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EEstacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ets_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "ets_rcd_cod");
            l_drTemp["ets_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "ets_des_des");
            l_drTemp["ets_ede_domicilio"]= XMLRuts.ExtractXAttr(l_xndData, "ets_ede_domicilio");
            l_drTemp["ets_des_contacto"]= XMLRuts.ExtractXAttr(l_xndData, "ets_des_contacto");
            l_drTemp["ets_ete_telefono"]= XMLRuts.ExtractXAttr(l_xndData, "ets_ete_telefono");

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
        private EEstacion(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Estacion
        /// </summary>
        /// <returns>Entidad vacia: Estacion</returns>
        public static EEstacion NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEstacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ets_rcd_cod"]= "";
            l_drTemp["ets_des_des"]= "";
            l_drTemp["ets_ede_domicilio"]= "";
            l_drTemp["ets_des_contacto"]= "";
            l_drTemp["ets_ete_telefono"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEstacion l_entRet= new EEstacion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Estacion
        /// </summary>
        /// <param name="p_strCod">Codigo Estacion</param>
        /// <param name="p_strDes">Estacion</param>
        /// <param name="p_strDomicilio">Domicilio</param>
        /// <param name="p_strContacto">Contacto</param>
        /// <param name="p_strTelefono">Telefono</param>
        /// <returns>Entidad: Estacion</returns>
        public static EEstacion NewFilled(string p_strCod,
                                          string p_strDes,
                                          string p_strDomicilio,
                                          string p_strContacto,
                                          string p_strTelefono)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEstacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["ets_rcd_cod"]= p_strCod;
            l_drTemp["ets_des_des"]= p_strDes;
            l_drTemp["ets_ede_domicilio"]= p_strDomicilio;
            l_drTemp["ets_des_contacto"]= p_strContacto;
            l_drTemp["ets_ete_telefono"]= p_strTelefono;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEstacion l_entRet= new EEstacion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Estacion
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("ets_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("ets_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("ets_ede_domicilio", typeof(string));
                l_dcStruct[3]= new DataColumn("ets_des_contacto", typeof(string));
                l_dcStruct[4]= new DataColumn("ets_ete_telefono", typeof(string));
                EEstacion.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Estacion
        /// </summary>
        public static string CodCmp
        {
           get {return "ets_rcd_cod";}
        }

        /// <summary>
        /// Codigo Estacion
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["ets_rcd_cod"];}
            set {InternalData["ets_rcd_cod"]= EEstacion.FrmtCod(value);}
        }

        /// <summary>
        /// Estacion
        /// </summary>
        public static string DesCmp
        {
           get {return "ets_des_des";}
        }

        /// <summary>
        /// Estacion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["ets_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["ets_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Domicilio
        /// </summary>
        public static string DomicilioCmp
        {
           get {return "ets_ede_domicilio";}
        }

        /// <summary>
        /// Domicilio
        /// </summary>
        public string Domicilio
        {
            get {return ((string) InternalData["ets_ede_domicilio"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["ets_ede_domicilio"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Contacto
        /// </summary>
        public static string ContactoCmp
        {
           get {return "ets_des_contacto";}
        }

        /// <summary>
        /// Contacto
        /// </summary>
        public string Contacto
        {
            get {return ((string) InternalData["ets_des_contacto"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["ets_des_contacto"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Telefono
        /// </summary>
        public static string TelefonoCmp
        {
           get {return "ets_ete_telefono";}
        }

        /// <summary>
        /// Telefono
        /// </summary>
        public string Telefono
        {
            get {return ((string) InternalData["ets_ete_telefono"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["ets_ete_telefono"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EEstacion] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EEstacion] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EEstacion", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ets_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ets_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ets_ede_domicilio", Domicilio));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ets_des_contacto", Contacto));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ets_ete_telefono", Telefono));

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

    #region Lista-Entidad: Estaciones
    /// <summary>
    /// Clase que representa la Lista-Entidad: Estaciones
    /// </summary>
    public sealed partial class LEEstaciones : ListaEntidades, IEnumerable<EEstacion>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Estaciones
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEstaciones(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEstaciones(string p_strXMLData) :
            base(EEstacion.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EEstacion(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEEstaciones(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Estaciones
        /// </summary>
        /// <returns>Lista-Entidad vacia: Estaciones</returns>
        public static LEEstaciones NewEmpty()
        {
            return new LEEstaciones(EEstacion.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEEstacion">Entidad a agregar</param>
        public void AddEntity(EEstacion p_entEEstacion)
        {
            base.AddEntity(p_entEEstacion);
        }

        /// <summary>
        /// Remueve una entidad [Estacion] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "ets_rcd_cod = " + Ruts.Co(EEstacion.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Estacion] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EEstacion l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Estaciones
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EEstacion> GetEnumerator() 
        {
            EEstacion l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EEstacion(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Estaciones
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EEstacion l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Estaciones
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETEstaciones GetAsLET()
        {
            // Llenamos la lista tipada
            LETEstaciones l_lentRet= new LETEstaciones();

            foreach (EEstacion l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Estaciones>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EEstacion> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EEstacion>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Estacion] por indice
        /// </summary>
        public new EEstacion this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Estacion con los datos de la fila
                return new EEstacion(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Estacion] por clave
        /// </summary>
        public EEstacion this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "ets_rcd_cod = " + Ruts.Co(EEstacion.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Estacion con los datos de la fila
                if (l_drData == null) return null;
                return new EEstacion(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEEstaciones", null);

                foreach (EEstacion l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Estaciones
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Estaciones
    /// </summary>
    public sealed partial class LETEstaciones : LET<EEstacion>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Estaciones
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEEstaciones GetAsLE()
        {
            // Llenamos la lista
            LEEstaciones l_lentRet= LEEstaciones.NewEmpty();

            foreach (EEstacion l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Estacion] por clave
        /// </summary>
        public EEstacion this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EEstacion l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EEstacion.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

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
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Estado
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
        /// <param name="p_strCod">Codigo Estado</param>
        /// <param name="p_strDes">Estado</param>
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

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Estado
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
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
        /// Codigo Estado
        /// </summary>
        public static string CodCmp
        {
           get {return "est_rcd_cod";}
        }

        /// <summary>
        /// Codigo Estado
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["est_rcd_cod"];}
            set {InternalData["est_rcd_cod"]= EEstado.FrmtCod(value);}
        }

        /// <summary>
        /// Estado
        /// </summary>
        public static string DesCmp
        {
           get {return "est_des_des";}
        }

        /// <summary>
        /// Estado
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
        public static string TxtcontingenciaCmp
        {
           get {return "est_txt_txtcontingencia";}
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
        public static string OperativoCmp
        {
           get {return "est_cd1_operativo";}
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
    public sealed partial class LEEstados : ListaEntidades, IEnumerable<EEstado>
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
        /// Construye una lista-entidad vac�a: Estados
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
                "est_rcd_cod = " + Ruts.Co(EEstado.FrmtCod(p_strCod));

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
        public new IEnumerator<EEstado> GetEnumerator() 
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

        /// <summary>
        /// Devuelve la lista entidad como una List<Estados>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EEstado> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EEstado>) GetAsLET();
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
                    "est_rcd_cod = " + Ruts.Co(EEstado.FrmtCod(p_strCod));

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
                    if (l_entItem.Cod == EEstado.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Marca
    /// <summary>
    /// Clase que representa la Entidad: Marca
    /// </summary>
    public sealed partial class EMarca : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Marcas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMarca(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Marca
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMarca(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Marca
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMarca(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_codigo"]= XMLRuts.ExtractXAttr(l_xndData, "mrc_rcd_codigo");
            l_drTemp["mrc_des_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "mrc_des_descripcion");

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
        private EMarca(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Marca
        /// </summary>
        /// <returns>Entidad vacia: Marca</returns>
        public static EMarca NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_codigo"]= "";
            l_drTemp["mrc_des_descripcion"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMarca l_entRet= new EMarca(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Marca
        /// </summary>
        /// <param name="p_strCodigo">Codigo Marca</param>
        /// <param name="p_strDescripcion">Marca</param>
        /// <returns>Entidad: Marca</returns>
        public static EMarca NewFilled(string p_strCodigo,
                                       string p_strDescripcion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMarca.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mrc_rcd_codigo"]= p_strCodigo;
            l_drTemp["mrc_des_descripcion"]= p_strDescripcion;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMarca l_entRet= new EMarca(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Marca
        /// </summary>
        public static string FrmtCodigo(string p_strCodigo)
        {
            if (p_strCodigo.Trim().Length > 2)
                p_strCodigo= p_strCodigo.Trim().Substring(0,2);

            return p_strCodigo.Trim().PadLeft(2).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("mrc_rcd_codigo", typeof(string));
                l_dcStruct[1]= new DataColumn("mrc_des_descripcion", typeof(string));
                EMarca.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Marca
        /// </summary>
        public static string CodigoCmp
        {
           get {return "mrc_rcd_codigo";}
        }

        /// <summary>
        /// Codigo Marca
        /// </summary>
        public string Codigo
        {
            get {return (string) InternalData["mrc_rcd_codigo"];}
            set {InternalData["mrc_rcd_codigo"]= EMarca.FrmtCodigo(value);}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "mrc_des_descripcion";}
        }

        /// <summary>
        /// Marca
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["mrc_des_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mrc_des_descripcion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EMarca] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMarca] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMarca", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mrc_rcd_codigo", Codigo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mrc_des_descripcion", Descripcion));

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

    #region Lista-Entidad: Marcas
    /// <summary>
    /// Clase que representa la Lista-Entidad: Marcas
    /// </summary>
    public sealed partial class LEMarcas : ListaEntidades, IEnumerable<EMarca>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Marcas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMarcas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMarcas(string p_strXMLData) :
            base(EMarca.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMarca(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMarcas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Marcas
        /// </summary>
        /// <returns>Lista-Entidad vacia: Marcas</returns>
        public static LEMarcas NewEmpty()
        {
            return new LEMarcas(EMarca.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMarca">Entidad a agregar</param>
        public void AddEntity(EMarca p_entEMarca)
        {
            base.AddEntity(p_entEMarca);
        }

        /// <summary>
        /// Remueve una entidad [Marca] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigo)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mrc_rcd_codigo = " + Ruts.Co(EMarca.FrmtCodigo(p_strCodigo));

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
        /// Verifca si una entidad [Marca] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigo)
        {
            using (EMarca l_entTemp= this[p_strCodigo])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Marcas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EMarca> GetEnumerator() 
        {
            EMarca l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMarca(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Marcas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMarca l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Marcas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMarcas GetAsLET()
        {
            // Llenamos la lista tipada
            LETMarcas l_lentRet= new LETMarcas();

            foreach (EMarca l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Marcas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EMarca> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EMarca>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por indice
        /// </summary>
        public new EMarca this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Marca con los datos de la fila
                return new EMarca(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por clave
        /// </summary>
        public EMarca this[string p_strCodigo]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mrc_rcd_codigo = " + Ruts.Co(EMarca.FrmtCodigo(p_strCodigo));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Marca con los datos de la fila
                if (l_drData == null) return null;
                return new EMarca(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMarcas", null);

                foreach (EMarca l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Marcas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Marcas
    /// </summary>
    public sealed partial class LETMarcas : LET<EMarca>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Marcas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMarcas GetAsLE()
        {
            // Llenamos la lista
            LEMarcas l_lentRet= LEMarcas.NewEmpty();

            foreach (EMarca l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Marca] por clave
        /// </summary>
        public EMarca this[string p_strCodigo]
        {
            get {
                // Buscamos la entidad
                foreach (EMarca l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codigo == EMarca.FrmtCodigo(p_strCodigo))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Modelo
    /// <summary>
    /// Clase que representa la Entidad: Modelo
    /// </summary>
    public sealed partial class EModelo : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Modelos
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EModelo(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Modelo
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EModelo(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Modelo
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EModelo(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EModelo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mds_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "mds_rcd_cod");
            l_drTemp["mds_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "mds_des_des");
            l_drTemp["mds_rcd_codmarca"]= XMLRuts.ExtractXAttr(l_xndData, "mds_rcd_codmarca");

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
        private EModelo(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Modelo
        /// </summary>
        /// <returns>Entidad vacia: Modelo</returns>
        public static EModelo NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EModelo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mds_rcd_cod"]= "";
            l_drTemp["mds_des_des"]= "";
            l_drTemp["mds_rcd_codmarca"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EModelo l_entRet= new EModelo(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Modelo
        /// </summary>
        /// <param name="p_strCod">Codigo Modelo</param>
        /// <param name="p_strDes">Modelo</param>
        /// <param name="p_strCodmarca">Codigo de la marca</param>
        /// <returns>Entidad: Modelo</returns>
        public static EModelo NewFilled(string p_strCod,
                                        string p_strDes,
                                        string p_strCodmarca)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EModelo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mds_rcd_cod"]= p_strCod;
            l_drTemp["mds_des_des"]= p_strDes;
            l_drTemp["mds_rcd_codmarca"]= p_strCodmarca;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EModelo l_entRet= new EModelo(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Modelo
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 2)
                p_strCod= p_strCod.Trim().Substring(0,2);

            return p_strCod.Trim().PadLeft(2).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Codigo de la marca
        /// </summary>
        public static string FrmtCodmarca(string p_strCodmarca)
        {
            if (p_strCodmarca.Trim().Length > 2)
                p_strCodmarca= p_strCodmarca.Trim().Substring(0,2);

            return p_strCodmarca.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("mds_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("mds_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("mds_rcd_codmarca", typeof(string));
                EModelo.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Modelo
        /// </summary>
        public static string CodCmp
        {
           get {return "mds_rcd_cod";}
        }

        /// <summary>
        /// Codigo Modelo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["mds_rcd_cod"];}
            set {InternalData["mds_rcd_cod"]= EModelo.FrmtCod(value);}
        }

        /// <summary>
        /// Modelo
        /// </summary>
        public static string DesCmp
        {
           get {return "mds_des_des";}
        }

        /// <summary>
        /// Modelo
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["mds_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["mds_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Codigo de la marca
        /// </summary>
        public static string CodmarcaCmp
        {
           get {return "mds_rcd_codmarca";}
        }

        /// <summary>
        /// Codigo de la marca
        /// </summary>
        public string Codmarca
        {
            get {return (string) InternalData["mds_rcd_codmarca"];}
            set {InternalData["mds_rcd_codmarca"]= EModelo.FrmtCodmarca(value);}
        }

        /// <summary>
        /// Devuelve la entidad [EModelo] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EModelo] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EModelo", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mds_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mds_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mds_rcd_codmarca", Codmarca));

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

    #region Lista-Entidad: Modelos
    /// <summary>
    /// Clase que representa la Lista-Entidad: Modelos
    /// </summary>
    public sealed partial class LEModelos : ListaEntidades, IEnumerable<EModelo>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Modelos
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEModelos(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEModelos(string p_strXMLData) :
            base(EModelo.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EModelo(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEModelos(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Modelos
        /// </summary>
        /// <returns>Lista-Entidad vacia: Modelos</returns>
        public static LEModelos NewEmpty()
        {
            return new LEModelos(EModelo.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEModelo">Entidad a agregar</param>
        public void AddEntity(EModelo p_entEModelo)
        {
            base.AddEntity(p_entEModelo);
        }

        /// <summary>
        /// Remueve una entidad [Modelo] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mds_rcd_cod = " + Ruts.Co(EModelo.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Modelo] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EModelo l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Modelos
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EModelo> GetEnumerator() 
        {
            EModelo l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EModelo(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Modelos
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EModelo l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Modelos
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETModelos GetAsLET()
        {
            // Llenamos la lista tipada
            LETModelos l_lentRet= new LETModelos();

            foreach (EModelo l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Modelos>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EModelo> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EModelo>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Modelo] por indice
        /// </summary>
        public new EModelo this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Modelo con los datos de la fila
                return new EModelo(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Modelo] por clave
        /// </summary>
        public EModelo this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mds_rcd_cod = " + Ruts.Co(EModelo.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Modelo con los datos de la fila
                if (l_drData == null) return null;
                return new EModelo(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEModelos", null);

                foreach (EModelo l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Modelos
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Modelos
    /// </summary>
    public sealed partial class LETModelos : LET<EModelo>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Modelos
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEModelos GetAsLE()
        {
            // Llenamos la lista
            LEModelos l_lentRet= LEModelos.NewEmpty();

            foreach (EModelo l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Modelo] por clave
        /// </summary>
        public EModelo this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EModelo l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EModelo.FrmtCod(p_strCod))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: MotivoInfraccion
    /// <summary>
    /// Clase que representa la Entidad: MotivoInfraccion
    /// </summary>
    public sealed partial class EMotivoInfraccion : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EMotivoInfraccion(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MotivoInfraccion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EMotivoInfraccion(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: MotivoInfraccion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EMotivoInfraccion(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EMotivoInfraccion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mti_cod_codigo"]= XMLRuts.ExtractXAttr(l_xndData, "mti_cod_codigo");
            l_drTemp["mti_ede_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "mti_ede_descripcion");

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
        private EMotivoInfraccion(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: MotivoInfraccion
        /// </summary>
        /// <returns>Entidad vacia: MotivoInfraccion</returns>
        public static EMotivoInfraccion NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMotivoInfraccion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mti_cod_codigo"]= "";
            l_drTemp["mti_ede_descripcion"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMotivoInfraccion l_entRet= new EMotivoInfraccion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: MotivoInfraccion
        /// </summary>
        /// <param name="p_strCodigo">C�digo</param>
        /// <param name="p_strDescripcion">Descripci�n</param>
        /// <returns>Entidad: MotivoInfraccion</returns>
        public static EMotivoInfraccion NewFilled(string p_strCodigo,
                                                  string p_strDescripcion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EMotivoInfraccion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["mti_cod_codigo"]= p_strCodigo;
            l_drTemp["mti_ede_descripcion"]= p_strDescripcion;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EMotivoInfraccion l_entRet= new EMotivoInfraccion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: C�digo
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
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("mti_cod_codigo", typeof(string));
                l_dcStruct[1]= new DataColumn("mti_ede_descripcion", typeof(string));
                EMotivoInfraccion.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// C�digo
        /// </summary>
        public static string CodigoCmp
        {
           get {return "mti_cod_codigo";}
        }

        /// <summary>
        /// C�digo
        /// </summary>
        public string Codigo
        {
            get {return (string) InternalData["mti_cod_codigo"];}
            set {InternalData["mti_cod_codigo"]= EMotivoInfraccion.FrmtCodigo(value);}
        }

        /// <summary>
        /// Descripci�n
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "mti_ede_descripcion";}
        }

        /// <summary>
        /// Descripci�n
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["mti_ede_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["mti_ede_descripcion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EMotivoInfraccion] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EMotivoInfraccion] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EMotivoInfraccion", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mti_cod_codigo", Codigo));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mti_ede_descripcion", Descripcion));

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

    #region Lista-Entidad: MotivosInfracciones
    /// <summary>
    /// Clase que representa la Lista-Entidad: MotivosInfracciones
    /// </summary>
    public sealed partial class LEMotivosInfracciones : ListaEntidades, IEnumerable<EMotivoInfraccion>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: MotivosInfracciones
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMotivosInfracciones(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEMotivosInfracciones(string p_strXMLData) :
            base(EMotivoInfraccion.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EMotivoInfraccion(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEMotivosInfracciones(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: MotivosInfracciones
        /// </summary>
        /// <returns>Lista-Entidad vacia: MotivosInfracciones</returns>
        public static LEMotivosInfracciones NewEmpty()
        {
            return new LEMotivosInfracciones(EMotivoInfraccion.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEMotivoInfraccion">Entidad a agregar</param>
        public void AddEntity(EMotivoInfraccion p_entEMotivoInfraccion)
        {
            base.AddEntity(p_entEMotivoInfraccion);
        }

        /// <summary>
        /// Remueve una entidad [MotivoInfraccion] por clave
        /// </summary>
        public int RemoveEntity(string p_strCodigo)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "mti_cod_codigo = " + Ruts.Co(EMotivoInfraccion.FrmtCodigo(p_strCodigo));

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
        /// Verifca si una entidad [MotivoInfraccion] esta en la lista
        /// </summary>
        public bool Contains(string p_strCodigo)
        {
            using (EMotivoInfraccion l_entTemp= this[p_strCodigo])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: MotivosInfracciones
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EMotivoInfraccion> GetEnumerator() 
        {
            EMotivoInfraccion l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EMotivoInfraccion(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: MotivosInfracciones
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EMotivoInfraccion l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: MotivosInfracciones
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETMotivosInfracciones GetAsLET()
        {
            // Llenamos la lista tipada
            LETMotivosInfracciones l_lentRet= new LETMotivosInfracciones();

            foreach (EMotivoInfraccion l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<MotivosInfracciones>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EMotivoInfraccion> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EMotivoInfraccion>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivoInfraccion] por indice
        /// </summary>
        public new EMotivoInfraccion this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad MotivoInfraccion con los datos de la fila
                return new EMotivoInfraccion(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivoInfraccion] por clave
        /// </summary>
        public EMotivoInfraccion this[string p_strCodigo]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "mti_cod_codigo = " + Ruts.Co(EMotivoInfraccion.FrmtCodigo(p_strCodigo));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad MotivoInfraccion con los datos de la fila
                if (l_drData == null) return null;
                return new EMotivoInfraccion(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEMotivosInfracciones", null);

                foreach (EMotivoInfraccion l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: MotivosInfracciones
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: MotivosInfracciones
    /// </summary>
    public sealed partial class LETMotivosInfracciones : LET<EMotivoInfraccion>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: MotivosInfracciones
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEMotivosInfracciones GetAsLE()
        {
            // Llenamos la lista
            LEMotivosInfracciones l_lentRet= LEMotivosInfracciones.NewEmpty();

            foreach (EMotivoInfraccion l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [MotivoInfraccion] por clave
        /// </summary>
        public EMotivoInfraccion this[string p_strCodigo]
        {
            get {
                // Buscamos la entidad
                foreach (EMotivoInfraccion l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Codigo == EMotivoInfraccion.FrmtCodigo(p_strCodigo))
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Reparacion
    /// <summary>
    /// Clase que representa la Entidad: Reparacion
    /// </summary>
    public sealed partial class EReparacion : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Reparaciones
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EReparacion(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Reparacion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EReparacion(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Reparacion
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EReparacion(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EReparacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rep_cd6_cod"]= XMLRuts.ExtractXAttr(l_xndData, "rep_cd6_cod");
            l_drTemp["rep_xde_des"]= XMLRuts.ExtractXAttr(l_xndData, "rep_xde_des");
            l_drTemp["rep_rcd_codcat"]= XMLRuts.ExtractXAttr(l_xndData, "rep_rcd_codcat");
            l_drTemp["rep_cd1_solicitadetalle"]= XMLRuts.ExtractXAttr(l_xndData, "rep_cd1_solicitadetalle");
            l_drTemp["rep_categoria"]= XMLRuts.ExtractXAttr(l_xndData, "rep_categoria");

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
        private EReparacion(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Reparacion
        /// </summary>
        /// <returns>Entidad vacia: Reparacion</returns>
        public static EReparacion NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EReparacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rep_cd6_cod"]= "";
            l_drTemp["rep_xde_des"]= "";
            l_drTemp["rep_rcd_codcat"]= "";
            l_drTemp["rep_cd1_solicitadetalle"]= "";
            l_drTemp["rep_categoria"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EReparacion l_entRet= new EReparacion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Reparacion
        /// </summary>
        /// <param name="p_strCod">Codigo Reparacion</param>
        /// <param name="p_strDes">Reparacion</param>
        /// <param name="p_strCodcat">Categoria</param>
        /// <param name="p_strSolicitadetalle">Se Solicita Detalle</param>
        /// <returns>Entidad: Reparacion</returns>
        public static EReparacion NewFilled(string p_strCod,
                                            string p_strDes,
                                            string p_strCodcat,
                                            string p_strSolicitadetalle)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EReparacion.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rep_cd6_cod"]= p_strCod;
            l_drTemp["rep_xde_des"]= p_strDes;
            l_drTemp["rep_rcd_codcat"]= p_strCodcat;
            l_drTemp["rep_cd1_solicitadetalle"]= p_strSolicitadetalle;
            l_drTemp["rep_categoria"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EReparacion l_entRet= new EReparacion(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos est�ticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Codigo Reparacion
        /// </summary>
        public static string FrmtCod(string p_strCod)
        {
            if (p_strCod.Trim().Length > 6)
                p_strCod= p_strCod.Trim().Substring(0,6);

            return p_strCod.Trim().PadLeft(6).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Categoria
        /// </summary>
        public static string FrmtCodcat(string p_strCodcat)
        {
            if (p_strCodcat.Trim().Length > 2)
                p_strCodcat= p_strCodcat.Trim().Substring(0,2);

            return p_strCodcat.Trim().PadLeft(2).ToUpper();
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

                l_dcStruct[0]= new DataColumn("rep_cd6_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("rep_xde_des", typeof(string));
                l_dcStruct[2]= new DataColumn("rep_rcd_codcat", typeof(string));
                l_dcStruct[3]= new DataColumn("rep_categoria", typeof(string));
                l_dcStruct[4]= new DataColumn("rep_cd1_solicitadetalle", typeof(string));
                EReparacion.FillFixedFields(ref l_dcStruct, 5);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Codigo Reparacion
        /// </summary>
        public static string CodCmp
        {
           get {return "rep_cd6_cod";}
        }

        /// <summary>
        /// Codigo Reparacion
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["rep_cd6_cod"];}
            set {InternalData["rep_cd6_cod"]= EReparacion.FrmtCod(value);}
        }

        /// <summary>
        /// Reparacion
        /// </summary>
        public static string DesCmp
        {
           get {return "rep_xde_des";}
        }

        /// <summary>
        /// Reparacion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["rep_xde_des"]).Trim();}
            set {
                if (value.Trim().Length > 120) value= value.Trim().Substring(0,120);
                InternalData["rep_xde_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public static string CodcatCmp
        {
           get {return "rep_rcd_codcat";}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Codcat
        {
            get {return (string) InternalData["rep_rcd_codcat"];}
            set {InternalData["rep_rcd_codcat"]= EReparacion.FrmtCodcat(value);}
        }

        /// <summary>
        /// Se Solicita Detalle
        /// </summary>
        public static string SolicitadetalleCmp
        {
           get {return "rep_cd1_solicitadetalle";}
        }

        /// <summary>
        /// Se Solicita Detalle
        /// </summary>
        public string Solicitadetalle
        {
            get {return (string) InternalData["rep_cd1_solicitadetalle"];}
            set {InternalData["rep_cd1_solicitadetalle"]= value;}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Rep_categoria
        {
            get {return (string) InternalData["rep_categoria"];}
            set {InternalData["rep_categoria"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EReparacion] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EReparacion] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EReparacion", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rep_cd6_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rep_xde_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rep_rcd_codcat", Codcat));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rep_cd1_solicitadetalle", Solicitadetalle));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rep_categoria", Rep_categoria));

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

    #region Lista-Entidad: Reparaciones
    /// <summary>
    /// Clase que representa la Lista-Entidad: Reparaciones
    /// </summary>
    public sealed partial class LEReparaciones : ListaEntidades, IEnumerable<EReparacion>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Reparaciones
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEReparaciones(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEReparaciones(string p_strXMLData) :
            base(EReparacion.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EReparacion(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEReparaciones(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Reparaciones
        /// </summary>
        /// <returns>Lista-Entidad vacia: Reparaciones</returns>
        public static LEReparaciones NewEmpty()
        {
            return new LEReparaciones(EReparacion.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEReparacion">Entidad a agregar</param>
        public void AddEntity(EReparacion p_entEReparacion)
        {
            base.AddEntity(p_entEReparacion);
        }

        /// <summary>
        /// Remueve una entidad [Reparacion] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "rep_cd6_cod = " + Ruts.Co(EReparacion.FrmtCod(p_strCod));

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
        /// Verifca si una entidad [Reparacion] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EReparacion l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Reparaciones
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EReparacion> GetEnumerator() 
        {
            EReparacion l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EReparacion(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Reparaciones
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EReparacion l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Reparaciones
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETReparaciones GetAsLET()
        {
            // Llenamos la lista tipada
            LETReparaciones l_lentRet= new LETReparaciones();

            foreach (EReparacion l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Reparaciones>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EReparacion> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EReparacion>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Reparacion] por indice
        /// </summary>
        public new EReparacion this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Reparacion con los datos de la fila
                return new EReparacion(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Reparacion] por clave
        /// </summary>
        public EReparacion this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "rep_cd6_cod = " + Ruts.Co(EReparacion.FrmtCod(p_strCod));

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Reparacion con los datos de la fila
                if (l_drData == null) return null;
                return new EReparacion(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEReparaciones", null);

                foreach (EReparacion l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Reparaciones
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Reparaciones
    /// </summary>
    public sealed partial class LETReparaciones : LET<EReparacion>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Reparaciones
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEReparaciones GetAsLE()
        {
            // Llenamos la lista
            LEReparaciones l_lentRet= LEReparaciones.NewEmpty();

            foreach (EReparacion l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Reparacion] por clave
        /// </summary>
        public EReparacion this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EReparacion l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == EReparacion.FrmtCod(p_strCod))
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
