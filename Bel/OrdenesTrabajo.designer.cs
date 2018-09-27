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
    // Fecha                    : 26/09/2018 22:31
    // Sistema                  : Mrln
    // Clase para Administrar   : Ordenes de Trabajo y sus Items
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma automática. Cualquier
    //    modificación que se realize sobre ella se perderá en la próxima
    //    regeneración.
    //****************************************************************************

    #region Entidad: OTItem
    /// <summary>
    /// Clase que representa la Entidad: OTItem
    /// </summary>
    public sealed partial class EOTItem : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: OtItems
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EOTItem(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: OTItem
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EOTItem(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: OTItem
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EOTItem(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EOTItem.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["oti_nro_nroot"]= XMLRuts.ExtractXAttr(l_xndData, "oti_nro_nroot", 1);
            l_drTemp["oti_nro_nroagrupador"]= XMLRuts.ExtractXAttr(l_xndData, "oti_nro_nroagrupador", 1);
            l_drTemp["oti_nro_nroitem"]= XMLRuts.ExtractXAttr(l_xndData, "oti_nro_nroitem", 1);
            l_drTemp["oti_des_desoperacion"]= XMLRuts.ExtractXAttr(l_xndData, "oti_des_desoperacion");
            l_drTemp["oti_des_destarea"]= XMLRuts.ExtractXAttr(l_xndData, "oti_des_destarea");
            l_drTemp["oti_rcd_codcategoria"]= XMLRuts.ExtractXAttr(l_xndData, "oti_rcd_codcategoria");
            l_drTemp["oti_imp_importe"]= XMLRuts.ExtractXAttr(l_xndData, "oti_imp_importe", (decimal) 0);
            l_drTemp["oti_ede_comentario"]= XMLRuts.ExtractXAttr(l_xndData, "oti_ede_comentario");
            l_drTemp["oti_d20_estado"]= XMLRuts.ExtractXAttr(l_xndData, "oti_d20_estado");
            l_drTemp["oti_imp_importecierre"]= XMLRuts.ExtractXAttr(l_xndData, "oti_imp_importecierre", (decimal) 0);
            l_drTemp["oti_ede_comentariocierre"]= XMLRuts.ExtractXAttr(l_xndData, "oti_ede_comentariocierre");
            l_drTemp["oti_cd6_codreparacion"]= XMLRuts.ExtractXAttr(l_xndData, "oti_cd6_codreparacion");
            l_drTemp["oti_categoria"]= XMLRuts.ExtractXAttr(l_xndData, "oti_categoria");
            l_drTemp["oti_kilometraje"]= XMLRuts.ExtractXAttr(l_xndData, "oti_kilometraje", 0);

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
        private EOTItem(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: OTItem
        /// </summary>
        /// <returns>Entidad vacia: OTItem</returns>
        public static EOTItem NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EOTItem.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["oti_nro_nroot"]= 1;
            l_drTemp["oti_nro_nroagrupador"]= 1;
            l_drTemp["oti_nro_nroitem"]= 1;
            l_drTemp["oti_des_desoperacion"]= "";
            l_drTemp["oti_des_destarea"]= "";
            l_drTemp["oti_rcd_codcategoria"]= "";
            l_drTemp["oti_imp_importe"]= 0;
            l_drTemp["oti_ede_comentario"]= "";
            l_drTemp["oti_d20_estado"]= "";
            l_drTemp["oti_imp_importecierre"]= 0;
            l_drTemp["oti_ede_comentariocierre"]= "";
            l_drTemp["oti_cd6_codreparacion"]= "";
            l_drTemp["oti_categoria"]= "";
            l_drTemp["oti_kilometraje"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EOTItem l_entRet= new EOTItem(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: OTItem
        /// </summary>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_strDesoperacion">Descripción de la operación</param>
        /// <param name="p_strDestarea">Descripción de la tarea</param>
        /// <param name="p_strCodcategoria">Categoría</param>
        /// <param name="p_dcImporte">Importe</param>
        /// <param name="p_strComentario">Comentario</param>
        /// <param name="p_strEstado">Estado</param>
        /// <param name="p_dcImportecierre">Importe Cierre</param>
        /// <param name="p_strComentariocierre">Comentario Cierre</param>
        /// <param name="p_strCodreparacion">Codigo Reparacion</param>
        /// <returns>Entidad: OTItem</returns>
        public static EOTItem NewFilled(int p_iNroot,
                                        int p_iNroagrupador,
                                        int p_iNroitem,
                                        string p_strDesoperacion,
                                        string p_strDestarea,
                                        string p_strCodcategoria,
                                        decimal p_dcImporte,
                                        string p_strComentario,
                                        string p_strEstado,
                                        decimal p_dcImportecierre,
                                        string p_strComentariocierre,
                                        string p_strCodreparacion)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EOTItem.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["oti_nro_nroot"]= p_iNroot;
            l_drTemp["oti_nro_nroagrupador"]= p_iNroagrupador;
            l_drTemp["oti_nro_nroitem"]= p_iNroitem;
            l_drTemp["oti_des_desoperacion"]= p_strDesoperacion;
            l_drTemp["oti_des_destarea"]= p_strDestarea;
            l_drTemp["oti_rcd_codcategoria"]= p_strCodcategoria;
            l_drTemp["oti_imp_importe"]= p_dcImporte;
            l_drTemp["oti_ede_comentario"]= p_strComentario;
            l_drTemp["oti_d20_estado"]= p_strEstado;
            l_drTemp["oti_imp_importecierre"]= p_dcImportecierre;
            l_drTemp["oti_ede_comentariocierre"]= p_strComentariocierre;
            l_drTemp["oti_cd6_codreparacion"]= p_strCodreparacion;
            l_drTemp["oti_categoria"]= "";
            l_drTemp["oti_kilometraje"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EOTItem l_entRet= new EOTItem(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Categoría
        /// </summary>
        public static string FrmtCodcategoria(string p_strCodcategoria)
        {
            if (p_strCodcategoria.Trim().Length > 2)
                p_strCodcategoria= p_strCodcategoria.Trim().Substring(0,2);

            return p_strCodcategoria.Trim().PadLeft(2).ToUpper();
        }

        /// <summary>
        /// Formatea una string: Codigo Reparacion
        /// </summary>
        public static string FrmtCodreparacion(string p_strCodreparacion)
        {
            if (p_strCodreparacion.Trim().Length > 6)
                p_strCodreparacion= p_strCodreparacion.Trim().Substring(0,6);

            return p_strCodreparacion.Trim().PadLeft(6).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[18];

                l_dcStruct[0]= new DataColumn("oti_nro_nroot", typeof(int));
                l_dcStruct[1]= new DataColumn("oti_nro_nroagrupador", typeof(int));
                l_dcStruct[2]= new DataColumn("oti_nro_nroitem", typeof(int));
                l_dcStruct[3]= new DataColumn("oti_des_desoperacion", typeof(string));
                l_dcStruct[4]= new DataColumn("oti_des_destarea", typeof(string));
                l_dcStruct[5]= new DataColumn("oti_rcd_codcategoria", typeof(string));
                l_dcStruct[6]= new DataColumn("oti_categoria", typeof(string));
                l_dcStruct[7]= new DataColumn("oti_imp_importe", typeof(decimal));
                l_dcStruct[8]= new DataColumn("oti_ede_comentario", typeof(string));
                l_dcStruct[9]= new DataColumn("oti_d20_estado", typeof(string));
                l_dcStruct[10]= new DataColumn("oti_imp_importecierre", typeof(decimal));
                l_dcStruct[11]= new DataColumn("oti_ede_comentariocierre", typeof(string));
                l_dcStruct[12]= new DataColumn("oti_cd6_codreparacion", typeof(string));
                l_dcStruct[13]= new DataColumn("oti_kilometraje", typeof(int));
                EOTItem.FillFixedFields(ref l_dcStruct, 14);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// nroOt
        /// </summary>
        public static string NrootCmp
        {
           get {return "oti_nro_nroot";}
        }

        /// <summary>
        /// nroOt
        /// </summary>
        public int Nroot
        {
            get {return (int) InternalData["oti_nro_nroot"];}
            set {InternalData["oti_nro_nroot"]= value;}
        }

        /// <summary>
        /// Numero de agrupador
        /// </summary>
        public static string NroagrupadorCmp
        {
           get {return "oti_nro_nroagrupador";}
        }

        /// <summary>
        /// Numero de agrupador
        /// </summary>
        public int Nroagrupador
        {
            get {return (int) InternalData["oti_nro_nroagrupador"];}
            set {InternalData["oti_nro_nroagrupador"]= value;}
        }

        /// <summary>
        /// Numero del item
        /// </summary>
        public static string NroitemCmp
        {
           get {return "oti_nro_nroitem";}
        }

        /// <summary>
        /// Numero del item
        /// </summary>
        public int Nroitem
        {
            get {return (int) InternalData["oti_nro_nroitem"];}
            set {InternalData["oti_nro_nroitem"]= value;}
        }

        /// <summary>
        /// Descripción de la operación
        /// </summary>
        public static string DesoperacionCmp
        {
           get {return "oti_des_desoperacion";}
        }

        /// <summary>
        /// Descripción de la operación
        /// </summary>
        public string Desoperacion
        {
            get {return ((string) InternalData["oti_des_desoperacion"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["oti_des_desoperacion"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Descripción de la tarea
        /// </summary>
        public static string DestareaCmp
        {
           get {return "oti_des_destarea";}
        }

        /// <summary>
        /// Descripción de la tarea
        /// </summary>
        public string Destarea
        {
            get {return ((string) InternalData["oti_des_destarea"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["oti_des_destarea"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Categoría
        /// </summary>
        public static string CodcategoriaCmp
        {
           get {return "oti_rcd_codcategoria";}
        }

        /// <summary>
        /// Categoría
        /// </summary>
        public string Codcategoria
        {
            get {return (string) InternalData["oti_rcd_codcategoria"];}
            set {InternalData["oti_rcd_codcategoria"]= EOTItem.FrmtCodcategoria(value);}
        }

        /// <summary>
        /// Importe
        /// </summary>
        public static string ImporteCmp
        {
           get {return "oti_imp_importe";}
        }

        /// <summary>
        /// Importe
        /// </summary>
        public decimal Importe
        {
            get {return (decimal) InternalData["oti_imp_importe"];}
            set {InternalData["oti_imp_importe"]= value;}
        }

        /// <summary>
        /// Comentario
        /// </summary>
        public static string ComentarioCmp
        {
           get {return "oti_ede_comentario";}
        }

        /// <summary>
        /// Comentario
        /// </summary>
        public string Comentario
        {
            get {return ((string) InternalData["oti_ede_comentario"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["oti_ede_comentario"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Estado
        /// </summary>
        public static string EstadoCmp
        {
           get {return "oti_d20_estado";}
        }

        /// <summary>
        /// Estado
        /// </summary>
        public string Estado
        {
            get {return ((string) InternalData["oti_d20_estado"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["oti_d20_estado"]= value.Trim();
            }
        }

        /// <summary>
        /// Importe Cierre
        /// </summary>
        public static string ImportecierreCmp
        {
           get {return "oti_imp_importecierre";}
        }

        /// <summary>
        /// Importe Cierre
        /// </summary>
        public decimal Importecierre
        {
            get {return (decimal) InternalData["oti_imp_importecierre"];}
            set {InternalData["oti_imp_importecierre"]= value;}
        }

        /// <summary>
        /// Comentario Cierre
        /// </summary>
        public static string ComentariocierreCmp
        {
           get {return "oti_ede_comentariocierre";}
        }

        /// <summary>
        /// Comentario Cierre
        /// </summary>
        public string Comentariocierre
        {
            get {return ((string) InternalData["oti_ede_comentariocierre"]).Trim();}
            set {
                if (value.Trim().Length > 60) value= value.Trim().Substring(0,60);
                InternalData["oti_ede_comentariocierre"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Codigo Reparacion
        /// </summary>
        public static string CodreparacionCmp
        {
           get {return "oti_cd6_codreparacion";}
        }

        /// <summary>
        /// Codigo Reparacion
        /// </summary>
        public string Codreparacion
        {
            get {return (string) InternalData["oti_cd6_codreparacion"];}
            set {InternalData["oti_cd6_codreparacion"]= EOTItem.FrmtCodreparacion(value);}
        }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Oti_categoria
        {
            get {return (string) InternalData["oti_categoria"];}
            set {InternalData["oti_categoria"]= value;}
        }

        /// <summary>
        /// Kilometraje
        /// </summary>
        public int Oti_kilometraje
        {
            get {return (int) InternalData["oti_kilometraje"];}
            set {InternalData["oti_kilometraje"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EOTItem] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EOTItem] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EOTItem", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_nro_nroot", Nroot));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_nro_nroagrupador", Nroagrupador));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_nro_nroitem", Nroitem));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_des_desoperacion", Desoperacion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_des_destarea", Destarea));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_rcd_codcategoria", Codcategoria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_imp_importe", Importe));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_ede_comentario", Comentario));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_d20_estado", Estado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_imp_importecierre", Importecierre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_ede_comentariocierre", Comentariocierre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_cd6_codreparacion", Codreparacion));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_categoria", Oti_categoria));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "oti_kilometraje", Oti_kilometraje));

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

    #region Lista-Entidad: OTItems
    /// <summary>
    /// Clase que representa la Lista-Entidad: OTItems
    /// </summary>
    public sealed partial class LEOTItems : ListaEntidades, IEnumerable<EOTItem>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: OtItems
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEOTItems(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEOTItems(string p_strXMLData) :
            base(EOTItem.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EOTItem(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEOTItems(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: OTItems
        /// </summary>
        /// <returns>Lista-Entidad vacia: OtItems</returns>
        public static LEOTItems NewEmpty()
        {
            return new LEOTItems(EOTItem.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEOTItem">Entidad a agregar</param>
        public void AddEntity(EOTItem p_entEOTItem)
        {
            base.AddEntity(p_entEOTItem);
        }

        /// <summary>
        /// Remueve una entidad [OTItem] por clave
        /// </summary>
        public int RemoveEntity(int p_iNroot,
                                int p_iNroagrupador,
                                int p_iNroitem)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "oti_nro_nroot = " + Ruts.Nu(p_iNroot) + " and " + 
                "oti_nro_nroagrupador = " + Ruts.Nu(p_iNroagrupador) + " and " + 
                "oti_nro_nroitem = " + Ruts.Nu(p_iNroitem);

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
        /// Verifca si una entidad [OTItem] esta en la lista
        /// </summary>
        public bool Contains(int p_iNroot,
                             int p_iNroagrupador,
                             int p_iNroitem)
        {
            using (EOTItem l_entTemp= this[p_iNroot,
                                           p_iNroagrupador,
                                           p_iNroitem])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: OTItems
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EOTItem> GetEnumerator() 
        {
            EOTItem l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EOTItem(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: OTItems
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EOTItem l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: OTItems
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETOTItems GetAsLET()
        {
            // Llenamos la lista tipada
            LETOTItems l_lentRet= new LETOTItems();

            foreach (EOTItem l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<OTItems>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EOTItem> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EOTItem>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [OTItem] por indice
        /// </summary>
        public new EOTItem this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad OTItem con los datos de la fila
                return new EOTItem(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [OTItem] por clave
        /// </summary>
        public EOTItem this[int p_iNroot,
                            int p_iNroagrupador,
                            int p_iNroitem]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "oti_nro_nroot = " + Ruts.Nu(p_iNroot) + " and " + 
                    "oti_nro_nroagrupador = " + Ruts.Nu(p_iNroagrupador) + " and " + 
                    "oti_nro_nroitem = " + Ruts.Nu(p_iNroitem);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad OTItem con los datos de la fila
                if (l_drData == null) return null;
                return new EOTItem(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEOTItems", null);

                foreach (EOTItem l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: OTItems
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: OTItems
    /// </summary>
    public sealed partial class LETOTItems : LET<EOTItem>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: OTItems
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEOTItems GetAsLE()
        {
            // Llenamos la lista
            LEOTItems l_lentRet= LEOTItems.NewEmpty();

            foreach (EOTItem l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [OTItem] por clave
        /// </summary>
        public EOTItem this[int p_iNroot,
                            int p_iNroagrupador,
                            int p_iNroitem]
        {
            get {
                // Buscamos la entidad
                foreach (EOTItem l_entItem in this) {
                    // Si existe -> la devolvemos
                    if ((l_entItem.Nroot == p_iNroot) &&
                        (l_entItem.Nroagrupador == p_iNroagrupador) &&
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

    #region Entidad: OrdenTrabajo
    /// <summary>
    /// Clase que representa la Entidad: OrdenTrabajo
    /// </summary>
    public sealed partial class EOrdenTrabajo : Entidad
    {
        #region Miembros de la clase
            private LEOTItems m_lentOTItems= null;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EOrdenTrabajo(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: OrdenTrabajo
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EOrdenTrabajo(string p_strXML) :
            this(p_strXML, false)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentOTItems= LEOTItems.NewEmpty();
        }

        /// <summary>
        /// Construye una entidad desde un XML: OrdenTrabajo
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EOrdenTrabajo(string p_strXML,
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
            l_dtTemp.Columns.AddRange(EOrdenTrabajo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["odt_nro_nro"]= XMLRuts.ExtractXAttr(l_xndData, "odt_nro_nro", 0);
            l_drTemp["odt_ecd_patente"]= XMLRuts.ExtractXAttr(l_xndData, "odt_ecd_patente");
            l_drTemp["odt_fyh_fecapertura"]= XMLRuts.ExtractXAttr(l_xndData, "odt_fyh_fecapertura", true);
            l_drTemp["odt_nom_operador"]= XMLRuts.ExtractXAttr(l_xndData, "odt_nom_operador");
            l_drTemp["odt_fyh_feccierre"]= XMLRuts.ExtractXAttr(l_xndData, "odt_fyh_feccierre", true);
            l_drTemp["odt_cod_codtaller"]= XMLRuts.ExtractXAttr(l_xndData, "odt_cod_codtaller");
            l_drTemp["odt_d20_estado"]= XMLRuts.ExtractXAttr(l_xndData, "odt_d20_estado");
            l_drTemp["odt_nro_kmsactuales"]= XMLRuts.ExtractXAttr(l_xndData, "odt_nro_kmsactuales", 0);
            l_drTemp["ot_taller"]= XMLRuts.ExtractXAttr(l_xndData, "ot_taller");

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
            m_lentOTItems= LEOTItems.NewEmpty();
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private EOrdenTrabajo(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
            // Creamos las listas-entidad hijas vacias
            m_lentOTItems= LEOTItems.NewEmpty();
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos públicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vacía: OrdenTrabajo
        /// </summary>
        /// <returns>Entidad vacia: OrdenTrabajo</returns>
        public static EOrdenTrabajo NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EOrdenTrabajo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["odt_nro_nro"]= 0;
            l_drTemp["odt_ecd_patente"]= "";
            l_drTemp["odt_fyh_fecapertura"]= DateTimeRuts.Empty;
            l_drTemp["odt_nom_operador"]= "";
            l_drTemp["odt_fyh_feccierre"]= DateTimeRuts.Empty;
            l_drTemp["odt_cod_codtaller"]= "";
            l_drTemp["odt_d20_estado"]= "";
            l_drTemp["odt_nro_kmsactuales"]= 0;
            l_drTemp["ot_taller"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EOrdenTrabajo l_entRet= new EOrdenTrabajo(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: OrdenTrabajo
        /// </summary>
        /// <param name="p_iNro">Número OT</param>
        /// <param name="p_strPatente">Patente</param>
        /// <param name="p_dtFecapertura">Fecha de apertura</param>
        /// <param name="p_strOperador">Operador</param>
        /// <param name="p_dtFeccierre">Fecha de cierre</param>
        /// <param name="p_strCodtaller">Taller</param>
        /// <param name="p_strEstado">Estado</param>
        /// <param name="p_iKmsactuales">Kms Movil</param>
        /// <returns>Entidad: OrdenTrabajo</returns>
        public static EOrdenTrabajo NewFilled(int p_iNro,
                                              string p_strPatente,
                                              DateTime p_dtFecapertura,
                                              string p_strOperador,
                                              DateTime p_dtFeccierre,
                                              string p_strCodtaller,
                                              string p_strEstado,
                                              int p_iKmsactuales)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EOrdenTrabajo.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["odt_nro_nro"]= p_iNro;
            l_drTemp["odt_ecd_patente"]= p_strPatente;
            l_drTemp["odt_fyh_fecapertura"]= p_dtFecapertura;
            l_drTemp["odt_nom_operador"]= p_strOperador;
            l_drTemp["odt_fyh_feccierre"]= p_dtFeccierre;
            l_drTemp["odt_cod_codtaller"]= p_strCodtaller;
            l_drTemp["odt_d20_estado"]= p_strEstado;
            l_drTemp["odt_nro_kmsactuales"]= p_iKmsactuales;
            l_drTemp["ot_taller"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EOrdenTrabajo l_entRet= new EOrdenTrabajo(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores

        //---------------------------------------------------------------
        // Metodos estáticos (Formateo de codigos alineados a derecha)
        //---------------------------------------------------------------

        /// <summary>
        /// Formatea una string: Taller
        /// </summary>
        public static string FrmtCodtaller(string p_strCodtaller)
        {
            if (p_strCodtaller.Trim().Length > 4)
                p_strCodtaller= p_strCodtaller.Trim().Substring(0,4);

            return p_strCodtaller.Trim().PadLeft(4).ToUpper();
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
                DataColumn[] l_dcStruct= new DataColumn[13];

                l_dcStruct[0]= new DataColumn("odt_nro_nro", typeof(int));
                l_dcStruct[1]= new DataColumn("odt_ecd_patente", typeof(string));
                l_dcStruct[2]= new DataColumn("odt_fyh_fecapertura", typeof(DateTime));
                l_dcStruct[3]= new DataColumn("odt_nom_operador", typeof(string));
                l_dcStruct[4]= new DataColumn("odt_fyh_feccierre", typeof(DateTime));
                l_dcStruct[5]= new DataColumn("odt_cod_codtaller", typeof(string));
                l_dcStruct[6]= new DataColumn("ot_taller", typeof(string));
                l_dcStruct[7]= new DataColumn("odt_d20_estado", typeof(string));
                l_dcStruct[8]= new DataColumn("odt_nro_kmsactuales", typeof(int));
                EOrdenTrabajo.FillFixedFields(ref l_dcStruct, 9);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// Número OT
        /// </summary>
        public static string NroCmp
        {
           get {return "odt_nro_nro";}
        }

        /// <summary>
        /// Número OT
        /// </summary>
        public int Nro
        {
            get {return (int) InternalData["odt_nro_nro"];}
            set {InternalData["odt_nro_nro"]= value;}
        }

        /// <summary>
        /// Patente
        /// </summary>
        public static string PatenteCmp
        {
           get {return "odt_ecd_patente";}
        }

        /// <summary>
        /// Patente
        /// </summary>
        public string Patente
        {
            get {return (string) InternalData["odt_ecd_patente"];}
            set {
                if (value.Trim().Length > 8) value= value.Trim().Substring(0,8);
                InternalData["odt_ecd_patente"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Fecha de apertura
        /// </summary>
        public static string FecaperturaCmp
        {
           get {return "odt_fyh_fecapertura";}
        }

        /// <summary>
        /// Fecha de apertura
        /// </summary>
        public DateTime Fecapertura
        {
            get {return (DateTime) InternalData["odt_fyh_fecapertura"];}
            set {InternalData["odt_fyh_fecapertura"]= value;}
        }

        /// <summary>
        /// Operador
        /// </summary>
        public static string OperadorCmp
        {
           get {return "odt_nom_operador";}
        }

        /// <summary>
        /// Operador
        /// </summary>
        public string Operador
        {
            get {return ((string) InternalData["odt_nom_operador"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["odt_nom_operador"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Fecha de cierre
        /// </summary>
        public static string FeccierreCmp
        {
           get {return "odt_fyh_feccierre";}
        }

        /// <summary>
        /// Fecha de cierre
        /// </summary>
        public DateTime Feccierre
        {
            get {return (DateTime) InternalData["odt_fyh_feccierre"];}
            set {InternalData["odt_fyh_feccierre"]= value;}
        }

        /// <summary>
        /// Taller
        /// </summary>
        public static string CodtallerCmp
        {
           get {return "odt_cod_codtaller";}
        }

        /// <summary>
        /// Taller
        /// </summary>
        public string Codtaller
        {
            get {return (string) InternalData["odt_cod_codtaller"];}
            set {InternalData["odt_cod_codtaller"]= EOrdenTrabajo.FrmtCodtaller(value);}
        }

        /// <summary>
        /// Estado
        /// </summary>
        public static string EstadoCmp
        {
           get {return "odt_d20_estado";}
        }

        /// <summary>
        /// Estado
        /// </summary>
        public string Estado
        {
            get {return ((string) InternalData["odt_d20_estado"]).Trim();}
            set {
                if (value.Trim().Length > 20) value= value.Trim().Substring(0,20);
                InternalData["odt_d20_estado"]= value.Trim();
            }
        }

        /// <summary>
        /// Kms Movil
        /// </summary>
        public static string KmsactualesCmp
        {
           get {return "odt_nro_kmsactuales";}
        }

        /// <summary>
        /// Kms Movil
        /// </summary>
        public int Kmsactuales
        {
            get {return (int) InternalData["odt_nro_kmsactuales"];}
            set {InternalData["odt_nro_kmsactuales"]= value;}
        }

        /// <summary>
        /// OrdenTrabajo Items
        /// </summary>
        public LEOTItems OTItems
        {
            get {return m_lentOTItems;}
            set {m_lentOTItems= value;}
        }

        /// <summary>
        /// Taller
        /// </summary>
        public string Ot_taller
        {
            get {return (string) InternalData["ot_taller"];}
            set {InternalData["ot_taller"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EOrdenTrabajo] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EOrdenTrabajo] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EOrdenTrabajo", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_nro_nro", Nro));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_ecd_patente", Patente));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_fyh_fecapertura", Fecapertura));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_nom_operador", Operador));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_fyh_feccierre", Feccierre));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_cod_codtaller", Codtaller));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_d20_estado", Estado));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "odt_nro_kmsactuales", Kmsactuales));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "ot_taller", Ot_taller));

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

    #region Lista-Entidad: OrdenesTrabajo
    /// <summary>
    /// Clase que representa la Lista-Entidad: OrdenesTrabajo
    /// </summary>
    public sealed partial class LEOrdenesTrabajo : ListaEntidades, IEnumerable<EOrdenTrabajo>
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: OrdenesTrabajo
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEOrdenesTrabajo(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEOrdenesTrabajo(string p_strXMLData) :
            base(EOrdenTrabajo.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EOrdenTrabajo(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEOrdenesTrabajo(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vacía: OrdenesTrabajo
        /// </summary>
        /// <returns>Lista-Entidad vacia: OrdenesTrabajo</returns>
        public static LEOrdenesTrabajo NewEmpty()
        {
            return new LEOrdenesTrabajo(EOrdenTrabajo.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEOrdenTrabajo">Entidad a agregar</param>
        public void AddEntity(EOrdenTrabajo p_entEOrdenTrabajo)
        {
            base.AddEntity(p_entEOrdenTrabajo);
        }

        /// <summary>
        /// Remueve una entidad [OrdenTrabajo] por clave
        /// </summary>
        public int RemoveEntity(int p_iNro)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "odt_nro_nro = " + Ruts.Nu(p_iNro);

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
        /// Verifca si una entidad [OrdenTrabajo] esta en la lista
        /// </summary>
        public bool Contains(int p_iNro)
        {
            using (EOrdenTrabajo l_entTemp= this[p_iNro])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: OrdenesTrabajo
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator<EOrdenTrabajo> GetEnumerator() 
        {
            EOrdenTrabajo l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EOrdenTrabajo(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: OrdenesTrabajo
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EOrdenTrabajo l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: OrdenesTrabajo
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETOrdenesTrabajo GetAsLET()
        {
            // Llenamos la lista tipada
            LETOrdenesTrabajo l_lentRet= new LETOrdenesTrabajo();

            foreach (EOrdenTrabajo l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una List<OrdenesTrabajo>
        /// </summary>
        /// <returns>Lista de entidades</returns>
        public List<EOrdenTrabajo> ToList()
        {
            // Usamos el metodo GetAsLET
            return (List<EOrdenTrabajo>) GetAsLET();
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [OrdenTrabajo] por indice
        /// </summary>
        public new EOrdenTrabajo this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad OrdenTrabajo con los datos de la fila
                return new EOrdenTrabajo(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [OrdenTrabajo] por clave
        /// </summary>
        public EOrdenTrabajo this[int p_iNro]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "odt_nro_nro = " + Ruts.Nu(p_iNro);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad OrdenTrabajo con los datos de la fila
                if (l_drData == null) return null;
                return new EOrdenTrabajo(l_drData);
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
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEOrdenesTrabajo", null);

                foreach (EOrdenTrabajo l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: OrdenesTrabajo
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: OrdenesTrabajo
    /// </summary>
    public sealed partial class LETOrdenesTrabajo : LET<EOrdenTrabajo>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: OrdenesTrabajo
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEOrdenesTrabajo GetAsLE()
        {
            // Llenamos la lista
            LEOrdenesTrabajo l_lentRet= LEOrdenesTrabajo.NewEmpty();

            foreach (EOrdenTrabajo l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------


        /// <summary>
        /// Indexer para acceder a cada entidad [OrdenTrabajo] por indice
        /// </summary>
        public EOrdenTrabajo this[long p_lIndice]
        {
            get {return base[(int) p_lIndice];}
        }
        /// <summary>
        /// Indexer para acceder a cada entidad [OrdenTrabajo] por clave
        /// </summary>
        public new EOrdenTrabajo this[int p_iNro]
        {
            get {
                // Buscamos la entidad
                foreach (EOrdenTrabajo l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Nro == p_iNro)
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
