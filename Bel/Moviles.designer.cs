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

    #region Entidad: Movil
    /// <summary>
    /// Clase que representa la Entidad: Movil
    /// </summary>
    public sealed partial class EMovil : Entidad
    {
        #region Miembros de la clase
            private LEMovilesEquip m_lentMovilesEquip= null;
            private LEMovilesEstado m_lentMovilesEstado= null;
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
            l_drTemp["mov_rcd_estado"]= XMLRuts.ExtractXAttr(l_xndData, "mov_rcd_estado");
            l_drTemp["mov_nro_kms"]= XMLRuts.ExtractXAttr(l_xndData, "mov_nro_kms", 0);
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
            m_lentMovilesEquip= LEMovilesEquip.NewEmpty();
            m_lentMovilesEstado= LEMovilesEstado.NewEmpty();
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
            l_drTemp["mov_rcd_estado"]= "";
            l_drTemp["mov_nro_kms"]= 0;
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
        /// <param name="p_strDes">des</param>
        /// <param name="p_strEstado">estado</param>
        /// <param name="p_iKms">Kilometros</param>
        /// <param name="p_strAnot">Anotaciones</param>
        /// <param name="p_strNrochasis">Nro Chasis</param>
        /// <param name="p_strNromotor">Nro Motor</param>
        /// <param name="p_strModelo">Modelo</param>
        /// <param name="p_iAniofabric">Año de fabricación</param>
        /// <param name="p_strPropio">Propio o no</param>
        /// <returns>Entidad: Movil</returns>
        public static EMovil NewFilled(string p_strPatente,
                                       string p_strDes,
                                       string p_strEstado,
                                       int p_iKms,
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
            l_drTemp["mov_rcd_estado"]= p_strEstado;
            l_drTemp["mov_nro_kms"]= p_iKms;
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
                DataColumn[] l_dcStruct= new DataColumn[14];

                l_dcStruct[0]= new DataColumn("mov_ecd_patente", typeof(string));
                l_dcStruct[1]= new DataColumn("mov_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("mov_rcd_estado", typeof(string));
                l_dcStruct[3]= new DataColumn("mov_nro_kms", typeof(int));
                l_dcStruct[4]= new DataColumn("mov_txt_anot", typeof(string));
                l_dcStruct[5]= new DataColumn("mov_des_nrochasis", typeof(string));
                l_dcStruct[6]= new DataColumn("mov_des_nromotor", typeof(string));
                l_dcStruct[7]= new DataColumn("mov_rcd_modelo", typeof(string));
                l_dcStruct[8]= new DataColumn("mov_nro_aniofabric", typeof(int));
                l_dcStruct[9]= new DataColumn("mov_cd1_propio", typeof(string));
                EMovil.FillFixedFields(ref l_dcStruct, 10);

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
        /// des
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
        /// estado
        /// </summary>
        public string Estado
        {
            get {return ((string) InternalData["mov_rcd_estado"]).Trim();}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["mov_rcd_estado"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Kilometros
        /// </summary>
        public int Kms
        {
            get {return (int) InternalData["mov_nro_kms"];}
            set {InternalData["mov_nro_kms"]= value;}
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
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_rcd_estado", Estado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "mov_nro_kms", Kms));
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
