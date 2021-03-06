using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO.Compression;
using System.IO;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;

namespace GLC.Integration.Cargowiseone.ClassicWatch.PipelineComp
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("08D8DE79-2AF6-4603-8DEB-4B393A93F8BF")]
    public class SalesOrder_FileName : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "SalesorderFileName"; }
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
            get { return "SalesorderFileName"; }
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
            IBaseMessageContext context = inmsg.Context;
            Stream originalDataStream = inmsg.BodyPart.GetOriginalDataStream();
            string xml = new StreamReader(originalDataStream).ReadToEnd();
            DateTime now = new DateTime();
            now = DateTime.Now;
            XmlDocument document = new XmlDocument();
            document.LoadXml(xml);
            //string str2 = document.SelectSingleNode("//OrderNo").InnerText.ToString();
            string str3 = "DISPATCH_REPORT" + "_" + now.ToString("ddMMyyyy") +"_1";
            context.Promote("ReceivedFileName", "http://schemas.microsoft.com/BizTalk/2003/file-properties", str3);
            originalDataStream.Seek(0L, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalDataStream;
            inmsg.Context = context;
            return inmsg;
        }
        #endregion

    }
}


