using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System.IO;
using System.Xml;

namespace GLC.Integration.Cargowiseone.HealthLab.PipelineComponents
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("00372DEC-0806-428F-8EFD-BBE302842E69")]


    public class JCurveFFDebatch : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "DeBatchJcurveFF"; }
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
            get { return "Debatching JCurve Flat Files"; }
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
            string data = strmread.ReadToEnd();

            data = data.Replace(@"http://GLC.Integration.Cargowiseone.HealthLab.Schemas.HL_Jcurve_FF", "");
            string strxml = "";

            var shipcode = new List<string>();
            var ponum = new List<string>();
            //string inmsg = File.ReadAllText(@"C:\Users\shashi\AppData\Local\Temp\_SchemaData\HL_Jcurve_FF_output.xml");
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(data);

            //XmlNamespaceManager xmn = new XmlNamespaceManager(xdoc.NameTable);
            //xmn.AddNamespace("xmlns2", "http://GLC.Integration.Cargowiseone.HealthLab.Schemas.HL_Jcurve_FF");

            XmlNodeList xmlnode = xdoc.SelectNodes("HL_JCURVE/OrderLineItem");


            foreach (XmlNode node in xmlnode)
            {
                var strcod = node.SelectSingleNode("OrderLineItem_Child1").InnerText;
                shipcode.Add(strcod);
            }
            List<string> mylist = shipcode.Distinct().ToList();


            string filepath;
            int cnt = mylist.Count();
            string strxml1 = "";
            string strfinalxml = "";
            for (int i = 0; i < cnt; i++)
            {
                string codeval = mylist[i];
                string headerxml = "";
                int flag = 0;
                foreach (XmlNode node in xmlnode)
                {

                    string id = node.SelectSingleNode("OrderLineItem_Child1").InnerText;
                    string DeliveryName = node.SelectSingleNode("OrderLineItem_Child2").InnerText;
                    string DeliveryAddress1 = node.SelectSingleNode("OrderLineItem_Child3").InnerText;
                    string DeliveryAddress2 = node.SelectSingleNode("OrderLineItem_Child4").InnerText;
                    string DeliverySuburb = node.SelectSingleNode("OrderLineItem_Child5").InnerText;
                    string DeliveryState = node.SelectSingleNode("OrderLineItem_Child6").InnerText;
                    string DeliveryPostCode = node.SelectSingleNode("OrderLineItem_Child7").InnerText;
                    string ScheduledShipDate = node.SelectSingleNode("OrderLineItem_Child18").InnerText;
                    string OrderLinePurchaseOrderReference = node.SelectSingleNode("OrderLineItem_Child19").InnerText;
                    string DestinationCountry = node.SelectSingleNode("OrderLineItem_Child17").InnerText;
                    if (codeval == id)
                    {
                        if (flag == 0)
                        {
                            headerxml = "<OrderID>" + id + "</OrderID>" + "<OrderLinePurchaseOrderReference>"+OrderLinePurchaseOrderReference+"</OrderLinePurchaseOrderReference>" + "<DeliveryName>" + DeliveryName + "</DeliveryName>" + "<DeliveryAddress1>" + DeliveryAddress1 + "</DeliveryAddress1>" + "<DeliveryAddress2>" + DeliveryAddress2 + "</DeliveryAddress2>" + "<DeliverySuburb>" + DeliverySuburb + "</DeliverySuburb>" + "<DeliveryState>" + DeliveryState + "</DeliveryState>" + "<DeliveryPostCode>" + DeliveryPostCode + "</DeliveryPostCode>" + "<ScheduledShipDate>" + ScheduledShipDate + "</ScheduledShipDate>" + "<DestinationCountry>" + DestinationCountry + "</DestinationCountry>";

                        }

                        strxml1 = strxml1 + node.OuterXml.ToString();
                    }

                }

                strfinalxml = "<HL_JCURVE>" + headerxml + strxml1 + " </HL_JCURVE>";
                filepath = @"C:\HealthTest\" + codeval + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xml";
                strxml1 = "";
                File.WriteAllText(filepath, strfinalxml);
            }


            byte[] bytearray = Encoding.UTF8.GetBytes(strxml);
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

