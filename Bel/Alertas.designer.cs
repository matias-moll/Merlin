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
    // Fecha                    : 28/06/2018 17:06
    // Sistema                  : Mrln
    // Clase para Administrar   : Alertas
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: Alerta
    /// <summary>
    /// Clase que representa la Entidad: Alerta
    /// </summary>
    public sealed partial class EAlerta : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Alertas
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EAlerta(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Alerta
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EAlerta(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Alerta
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EAlerta(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EAlerta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["alr_nro_nroconfig"]= XMLRuts.ExtractXAttr(l_xndData, "alr_nro_nroconfig", 0);
            l_drTemp["alr_nro_nroalerta"]= XMLRuts.ExtractXAttr(l_xndData, "alr_nro_nroalerta", 0);
            l_drTemp["alr_des_descripcion"]= XMLRuts.ExtractXAttr(l_xndData, "alr_des_descripcion");
            l_drTemp["alr_xde_detalle"]= XMLRuts.ExtractXAttr(l_xndData, "alr_xde_detalle");
            l_drTemp["alr_cd1_importancia"]= XMLRuts.ExtractXAttr(l_xndData, "alr_cd1_importancia");
            l_drTemp["alr_fyh_fechadisparada"]= XMLRuts.ExtractXAttr(l_xndData, "alr_fyh_fechadisparada", true);
            l_drTemp["alr_fyh_fechavista"]= XMLRuts.ExtractXAttr(l_xndData, "alr_fyh_fechavista", true);
            l_drTemp["alr_nom_usuariovista"]= XMLRuts.ExtractXAttr(l_xndData, "alr_nom_usuariovista");
            l_drTemp["alr_nro_repetirendias"]= XMLRuts.ExtractXAttr(l_xndData, "alr_nro_repetirendias", 0);
            l_drTemp["alr_cd1_finalizada"]= XMLRuts.ExtractXAttr(l_xndData, "alr_cd1_finalizada");

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
        private EAlerta(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: Alerta
        /// </summary>
        /// <returns>Entidad vacia: Alerta</returns>
        public static EAlerta NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EAlerta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["alr_nro_nroconfig"]= 0;
            l_drTemp["alr_nro_nroalerta"]= 0;
            l_drTemp["alr_des_descripcion"]= "";
            l_drTemp["alr_xde_detalle"]= "";
            l_drTemp["alr_cd1_importancia"]= "";
            l_drTemp["alr_fyh_fechadisparada"]= DateTimeRuts.Empty;
            l_drTemp["alr_fyh_fechavista"]= DateTimeRuts.Empty;
            l_drTemp["alr_nom_usuariovista"]= "";
            l_drTemp["alr_nro_repetirendias"]= 0;
            l_drTemp["alr_cd1_finalizada"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EAlerta l_entRet= new EAlerta(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Alerta
        /// </summary>
        /// <param name="p_iNroconfig">Nro Config Alerta</param>
        /// <param name="p_iNroalerta">Nro Alerta</param>
        /// <param name="p_strDescripcion">Descripción</param>
        /// <param name="p_strDetalle">Detalle</param>
        /// <param name="p_strImportancia">Importancia</param>
        /// <param name="p_dtFechadisparada">Fecha Disparada</param>
        /// <param name="p_dtFechavista">Fecha Vista</param>
        /// <param name="p_strUsuariovista">Usuario Vista</param>
        /// <param name="p_iRepetirendias">Repetir en Dias</param>
        /// <param name="p_strFinalizada">Finalizada</param>
        /// <returns>Entidad: Alerta</returns>
        public static EAlerta NewFilled(int p_iNroconfig,
                                        int p_iNroalerta,
                                        string p_strDescripcion,
                                        string p_strDetalle,
                                        string p_strImportancia,
                                        DateTime p_dtFechadisparada,
                                        DateTime p_dtFechavista,
                                        string p_strUsuariovista,
                                        int p_iRepetirendias,
                                        string p_strFinalizada)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EAlerta.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["alr_nro_nroconfig"]= p_iNroconfig;
            l_drTemp["alr_nro_nroalerta"]= p_iNroalerta;
            l_drTemp["alr_des_descripcion"]= p_strDescripcion;
            l_drTemp["alr_xde_detalle"]= p_strDetalle;
            l_drTemp["alr_cd1_importancia"]= p_strImportancia;
            l_drTemp["alr_fyh_fechadisparada"]= p_dtFechadisparada;
            l_drTemp["alr_fyh_fechavista"]= p_dtFechavista;
            l_drTemp["alr_nom_usuariovista"]= p_strUsuariovista;
            l_drTemp["alr_nro_repetirendias"]= p_iRepetirendias;
            l_drTemp["alr_cd1_finalizada"]= p_strFinalizada;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EAlerta l_entRet= new EAlerta(l_dtTemp);
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
                DataColumn[] l_dcStruct= new DataColumn[14];

                l_dcStruct[0]= new DataColumn("alr_nro_nroconfig", typeof(int));
                l_dcStruct[1]= new DataColumn("alr_nro_nroalerta", typeof(int));
                l_dcStruct[2]= new DataColumn("alr_des_descripcion", typeof(string));
                l_dcStruct[3]= new DataColumn("alr_xde_detalle", typeof(string));
                l_dcStruct[4]= new DataColumn("alr_cd1_importancia", typeof(string));
                l_dcStruct[5]= new DataColumn("alr_fyh_fechadisparada", typeof(DateTime));
                l_dcStruct[6]= new DataColumn("alr_fyh_fechavista", typeof(DateTime));
                l_dcStruct[7]= new DataColumn("alr_nom_usuariovista", typeof(string));
                l_dcStruct[8]= new DataColumn("alr_nro_repetirendias", typeof(int));
                l_dcStruct[9]= new DataColumn("alr_cd1_finalizada", typeof(string));
                EAlerta.FillFixedFields(ref l_dcStruct, 10);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Nro Config Alerta
        /// </summary>
        public static string NroconfigCmp
        {
           get {return "alr_nro_nroconfig";}
        }

        /// <summary>
        /// Nro Config Alerta
        /// </summary>
        public int Nroconfig
        {
            get {return (int) InternalData["alr_nro_nroconfig"];}
            set {InternalData["alr_nro_nroconfig"]= value;}
        }

        /// <summary>
        /// Nro Alerta
        /// </summary>
        public static string NroalertaCmp
        {
           get {return "alr_nro_nroalerta";}
        }

        /// <summary>
        /// Nro Alerta
        /// </summary>
        public int Nroalerta
        {
            get {return (int) InternalData["alr_nro_nroalerta"];}
            set {InternalData["alr_nro_nroalerta"]= value;}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public static string DescripcionCmp
        {
           get {return "alr_des_descripcion";}
        }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Descripcion
        {
            get {return ((string) InternalData["alr_des_descripcion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["alr_des_descripcion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Detalle
        /// </summary>
        public static string DetalleCmp
        {
           get {return "alr_xde_detalle";}
        }

        /// <summary>
        /// Detalle
        /// </summary>
        public string Detalle
        {
            get {return ((string) InternalData["alr_xde_detalle"]).Trim();}
            set {
                if (value.Trim().Length > 120) value= value.Trim().Substring(0,120);
                InternalData["alr_xde_detalle"]= value.Trim();
            }
        }

        /// <summary>
        /// Importancia
        /// </summary>
        public static string ImportanciaCmp
        {
           get {return "alr_cd1_importancia";}
        }

        /// <summary>
        /// Importancia
        /// </summary>
        public string Importancia
        {
            get {return ((string) InternalData["alr_cd1_importancia"]).Trim();}
            set {
                if (value.Trim().Length > 1) value= value.Trim().Substring(0,1);
                InternalData["alr_cd1_importancia"]= value.Trim();
            }
        }

        /// <summary>
        /// Fecha Disparada
        /// </summary>
        public static string FechadisparadaCmp
        {
           get {return "alr_fyh_fechadisparada";}
        }

        /// <summary>
        /// Fecha Disparada
        /// </summary>
        public DateTime Fechadisparada
        {
            get {return (DateTime) InternalData["alr_fyh_fechadisparada"];}
            set {InternalData["alr_fyh_fechadisparada"]= value;}
        }

        /// <summary>
        /// Fecha Vista
        /// </summary>
        public static string FechavistaCmp
        {
           get {return "alr_fyh_fechavista";}
        }

        /// <summary>
        /// Fecha Vista
        /// </summary>
        public DateTime Fechavista
        {
            get {return (DateTime) InternalData["alr_fyh_fechavista"];}
            set {InternalData["alr_fyh_fechavista"]= value;}
        }

        /// <summary>
        /// Usuario Vista
        /// </summary>
        public static string UsuariovistaCmp
        {
           get {return "alr_nom_usuariovista";}
        }

        /// <summary>
        /// Usuario Vista
        /// </summary>
        public string Usuariovista
        {
            get {return ((string) InternalData["alr_nom_usuariovista"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["alr_nom_usuariovista"]= value.Trim();
            }
        }

        /// <summary>
        /// Repetir en Dias
        /// </summary>
        public static string RepetirendiasCmp
        {
           get {return "alr_nro_repetirendias";}
        }

        /// <summary>
        /// Repetir en Dias
        /// </summary>
        public int Repetirendias
        {
            get {return (int) InternalData["alr_nro_repetirendias"];}
            set {InternalData["alr_nro_repetirendias"]= value;}
        }

        /// <summary>
        /// Finalizada
        /// </summary>
        public static string FinalizadaCmp
        {
           get {return "alr_cd1_finalizada";}
        }

        /// <summary>
        /// Finalizada
        /// </summary>
        public string Finalizada
        {
            get {return ((string) InternalData["alr_cd1_finalizada"]).Trim();}
            set {
                if (value.Trim().Length > 1) value= value.Trim().Substring(0,1);
                InternalData["alr_cd1_finalizada"]= value.Trim();
            }
        }

        /// <summary>
        /// Devuelve la entidad [EAlerta] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EAlerta] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EAlerta", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_nro_nroconfig", Nroconfig));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_nro_nroalerta", Nroalerta));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_des_descripcion", Descripcion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_xde_detalle", Detalle));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_cd1_importancia", Importancia));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_fyh_fechadisparada", Fechadisparada));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_fyh_fechavista", Fechavista));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_nom_usuariovista", Usuariovista));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_nro_repetirendias", Repetirendias));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "alr_cd1_finalizada", Finalizada));

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

    #region Lista-Entidad: Alertas
    /// <summary>
    /// Clase que representa la Lista-Entidad: Alertas
    /// </summary>
    public sealed partial class LEAlertas : ListaEntidades, IEnumerable<EAlerta>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Alertas
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEAlertas(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEAlertas(string p_strXMLData) :
            base(EAlerta.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EAlerta(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEAlertas(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: Alertas
        /// </summary>
        /// <returns>Lista-Entidad vacia: Alertas</returns>
        public static LEAlertas NewEmpty()
        {
            return new LEAlertas(EAlerta.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEAlerta">Entidad a agregar</param>
        public void AddEntity(EAlerta p_entEAlerta)
        {
            base.AddEntity(p_entEAlerta);
        }

        /// <summary>
        /// Remueve una entidad [Alerta] por clave
        /// </summary>
        public int RemoveEntity(int p_iNroconfig,
                                int p_iNroalerta)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "alr_nro_nroconfig = " + Ruts.Nu(p_iNroconfig) + " and " + 
                "alr_nro_nroalerta = " + Ruts.Nu(p_iNroalerta);

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
        /// Verifca si una entidad [Alerta] esta en la lista
        /// </summary>
        public bool Contains(int p_iNroconfig,
                             int p_iNroalerta)
        {
            using (EAlerta l_entTemp= this[p_iNroconfig,
                                           p_iNroalerta])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Alertas
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EAlerta> GetEnumerator() 
        {
            EAlerta l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EAlerta(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Alertas
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EAlerta l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Alertas
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETAlertas GetAsLET()
        {
            // Llenamos la lista tipada
            LETAlertas l_lentRet= new LETAlertas();

            foreach (EAlerta l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<Alertas>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EAlerta> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EAlerta>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Alerta] por indice
        /// </summary>
        public new EAlerta this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Alerta con los datos de la fila
                return new EAlerta(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Alerta] por clave
        /// </summary>
        public EAlerta this[int p_iNroconfig,
                            int p_iNroalerta]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "alr_nro_nroconfig = " + Ruts.Nu(p_iNroconfig) + " and " + 
                    "alr_nro_nroalerta = " + Ruts.Nu(p_iNroalerta);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Alerta con los datos de la fila
                if (l_drData == null) return null;
                return new EAlerta(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEAlertas", null);

                foreach (EAlerta l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Alertas
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Alertas
    /// </summary>
    public sealed partial class LETAlertas : LET<EAlerta>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Alertas
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEAlertas GetAsLE()
        {
            // Llenamos la lista
            LEAlertas l_lentRet= LEAlertas.NewEmpty();

            foreach (EAlerta l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Alerta] por clave
        /// </summary>
        public EAlerta this[int p_iNroconfig,
                            int p_iNroalerta]
        {
            get {
                // Buscamos la entidad
                foreach (EAlerta l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Nroconfig == p_iNroconfig) &&
                        (l_entItem.Nroalerta == p_iNroalerta))
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
