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
    // Fecha                    : 18/07/2018 08:16
    // Sistema                  : Mrln
    // Clase para Administrar   : Entidades Fijas
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: RowHistorial
    /// <summary>
    /// Clase que representa la Entidad: RowHistorial
    /// </summary>
    public sealed partial class ERowHistorial : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ERowHistorial(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: ERowHistorial
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ERowHistorial(string p_strXML)
        {
            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ERowHistorial.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rhi_fyh_fecha"]= XMLRuts.ExtractXAttr(l_xndData, "rhi_fyh_fecha", true);
            l_drTemp["rhi_des_tipo"]= XMLRuts.ExtractXAttr(l_xndData, "rhi_des_tipo");
            l_drTemp["rhi_xde_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "rhi_xde_descripcion");

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
        private ERowHistorial(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: RowHistorial
        /// </summary>
        /// <returns>Entidad vacia: RowHistorial</returns>
        public static ERowHistorial NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ERowHistorial.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rhi_fyh_fecha"]= new DateTime(1900,1,1,0,0,0);
            l_drTemp["rhi_des_tipo"]= "";
            l_drTemp["rhi_xde_descripcion"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            return new ERowHistorial(l_dtTemp);
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: RowHistorial
        /// </summary>
        /// <param name="p_dtFecha">Fecha</param>
        /// <param name="p_strTipo">Tipo</param>
        /// <param name="p_strDescripcion">Descripción</param>
        /// <returns>Entidad: RowHistorial</returns>
        public static ERowHistorial NewFilled(DateTime p_dtFecha,
                                              string p_strTipo,
                                              string p_strDescripcion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ERowHistorial.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["rhi_fyh_fecha"]= p_dtFecha;
            l_drTemp["rhi_des_tipo"]= p_strTipo;
            l_drTemp["rhi_xde_descripcion"]= p_strDescripcion;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            return new ERowHistorial(l_dtTemp);
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

                l_dcStruct[0]= new DataColumn("rhi_fyh_fecha", typeof(DateTime));
                l_dcStruct[1]= new DataColumn("rhi_des_tipo", typeof(string));
                l_dcStruct[2]= new DataColumn("rhi_xde_descripcion", typeof(string));
                ERowHistorial.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "rhi_xde_descripcion";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Descripcion
        {
            get {return (string) InternalData["rhi_xde_descripcion"];}
            set {InternalData["rhi_xde_descripcion"]= value;}
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public static string FechaCmp
        {
           get {return "rhi_fyh_fecha";}
        }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha
        {
            get {return (DateTime) InternalData["rhi_fyh_fecha"];}
            set {InternalData["rhi_fyh_fecha"]= value;}
        }

        /// <summary>
        /// Tipo
        /// </summary>
        public static string TipoCmp
        {
           get {return "rhi_des_tipo";}
        }

        /// <summary>
        /// Tipo
        /// </summary>
        public string Tipo
        {
            get {return (string) InternalData["rhi_des_tipo"];}
            set {InternalData["rhi_des_tipo"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [ERowHistorial] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ERowHistorial] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ERowHistorial", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rhi_xde_descripcion", Descripcion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rhi_fyh_fecha", Fecha));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "rhi_des_tipo", Tipo));

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

    #region Lista-Entidad: RowsHistorial
    /// <summary>
    /// Clase que representa la Lista-Entidad: RowsHistorial
    /// </summary>
    public sealed partial class LERowsHistorial : ListaEntidades, IEnumerable<ERowHistorial>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una DataTable
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LERowsHistorial(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            FillCaptions();
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LERowsHistorial(string p_strXMLData) :
            base(ERowHistorial.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ERowHistorial(l_xndItem.OuterXml));

            // Llenamos los captions
            FillCaptions();
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LERowsHistorial(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
            FillCaptions();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: RowsHistorial
        /// </summary>
        /// <returns>Lista-Entidad vacia: RowsHistorial</returns>
        public static LERowsHistorial NewEmpty()
        {
            return new LERowsHistorial(ERowHistorial.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entERowHistorial">Entidad a agregar</param>
        public void AddEntity(ERowHistorial p_entERowHistorial)
        {
            base.AddEntity(p_entERowHistorial);
        }

        /// <summary>
        /// Remueve una entidad [] por clave
        /// </summary>
        public int RemoveEntity(DateTime p_dtFecha)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "rhi_fyh_fecha = " + Ruts.Fh(p_dtFecha);

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
        /// Devuelve el enumerador de la lista-entidades: RowsHistorial
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<ERowHistorial> GetEnumerator() 
        {
            ERowHistorial l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ERowHistorial(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: RowsHistorial
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el arry con las entidades
            ArrayList l_alData= new ArrayList();

            foreach (ERowHistorial l_entData in this)
                l_alData.Add(l_entData);

            return l_alData;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: RowsHistorial
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETRowsHistorial GetAsLET()
        {
            // Llenamos la lista tipada
            LETRowsHistorial l_lentRet= new LETRowsHistorial();

            foreach (ERowHistorial l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }


        /// <summary>
        /// Devuelve la lista entidad como una List<>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<ERowHistorial> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<ERowHistorial>) GetAsLET();
        }
        #endregion

        #region Metodos privados de la clase
        //---------------------------------------------------------------
        // Metodos privados
        //---------------------------------------------------------------

        /// <summary>
        /// Completa los captions de la Lista Entidad
        /// </summary>
        private void FillCaptions()
        {
            ClearCaptions();
            ChangeCaption("rhi_xde_descripcion", "V1DescripciónCN1");
            ChangeCaption("rhi_fyh_fecha", "V1FechaFN2");
            ChangeCaption("rhi_des_tipo", "V1TipoCN1");
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [RowHistorial] por indice
        /// </summary>
        public new ERowHistorial this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad RowHistorial con los datos de la fila
                return new ERowHistorial(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [RowHistorial] por clave
        /// </summary>
        public ERowHistorial this[DateTime p_dtFecha]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "rhi_fyh_fecha = " + Ruts.Fh(p_dtFecha);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad RowHistorial con los datos de la fila
                if (l_drData == null) return null;
                return new ERowHistorial(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LERowsHistorial", null);

                foreach (ERowHistorial l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: RowsHistorial
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: RowsHistorial
    /// </summary>
    public sealed partial class LETRowsHistorial : LET<ERowHistorial>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: RowsHistorial
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LERowsHistorial GetAsLE()
        {
            // Llenamos la lista
            LERowsHistorial l_lentRet= LERowsHistorial.NewEmpty();

            foreach (ERowHistorial l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [RowHistorial] por clave
        /// </summary>
        public ERowHistorial this[DateTime p_dtFecha]
        {
            get {
                // Buscamos la entidad
                foreach (ERowHistorial l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Fecha == p_dtFecha)
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
