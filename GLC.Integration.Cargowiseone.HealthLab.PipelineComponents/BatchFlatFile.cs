using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System.IO;
using System.Xml;

namespace GLC.Integration.Cargowiseone.ClassicWatch.PipelineComp
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("B83AE1BA-F218-4557-A46B-51921C2A6A6B")]


    public class ClassicWatch856ASnFilename : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "BatchJcurveFF"; }
        }

        /// <summary>
        /// Version of the component.
        /// </summary>
        //[Browsable(false)]
        public string Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// Description of the component.
        /// </summary>
        // [Browsable(false)]
        public string Description
        {
            get { return "Batching JCurve Flat Files"; }
        }

        #endregion
        #region IComponentUI
        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }

        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }
        #endregion
        #region IComponent

        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {
            IBaseMessageContext messageContext = inmsg.Context;
            Stream originalStream = inmsg.BodyPart.GetOriginalDataStream();
            StreamReader strmread = new StreamReader(originalStream);
            string data1 = strmread.ReadToEnd();
            string strxml = "";
            string strxml1 = "";

            string[] pathls = Directory.GetFiles(@"C:\eAdapterOutbound\HLCSV\");
            string strxmldata = "<UniversalShipment xmlns=\"http://www.cargowise.com/Schemas/Universal/2011/11\" version =\"1.1\">";

            foreach (string ls in pathls)
            {             
                XmlDocument xdoc = new XmlDocument();
                string strdata = File.ReadAllText(ls);                
                xdoc.LoadXml(strdata);

                XmlNamespaceManager xmn = new XmlNamespaceManager(xdoc.NameTable);
                xmn.AddNamespace("xmlns2", "http://www.cargowise.com/Schemas/Universal/2011/11");

                XmlNodeList xmlnode = xdoc.SelectNodes("//xmlns2:Shipment", xmn);

                foreach (XmlNode node in xmlnode)
                {
                    strxml = strxml + node.OuterXml + Environment.NewLine;

                }

                File.Delete(ls);

            }

            strxml1 = strxmldata + strxml + "</UniversalShipment>";

            byte[] bytearray = Encoding.UTF8.GetBytes(strxml1);
            MemoryStream strm = new MemoryStream(bytearray);
            originalStream = strm;
            originalStream.Seek(0, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalStream;
            inmsg.Context = messageContext;
            return inmsg;
        }
        #endregion

    }
}
