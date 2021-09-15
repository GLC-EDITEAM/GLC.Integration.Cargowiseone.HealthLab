namespace GLC.Integration.Cargowiseone.HealthLab.Schemas.XSLT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurveOrder", typeof(global::GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurveOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    public sealed class TransformHealthLabToShipment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0""  xmlns:ns0=""http://www.cargowise.com/Schemas/Universal/2011/11""  xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/HL_JCURVE"" />
  </xsl:template>
  <xsl:template match=""/HL_JCURVE"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;GDS&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;US&quot;)"" />
    <!--<xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCGDSTRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCLAXLAX&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;GLC&quot;)"" />
    <!--<xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;TRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;LAX&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;WarehouseOrder&quot;)"" />
    <ns0:UniversalShipment>
          <ns0:Shipment>
            <ns0:DataContext>
              <ns0:Company>
                <ns0:Code>
                  <xsl:value-of select=""$var:v1"" />
                </ns0:Code>
                <ns0:Country>
                  <ns0:Code>
                    <xsl:value-of select=""$var:v2"" />
                  </ns0:Code>
                </ns0:Country>
              </ns0:Company>
              <ns0:DataProvider>
                <xsl:value-of select=""$var:v3"" />
              </ns0:DataProvider>
              <ns0:EnterpriseID>
                <xsl:value-of select=""$var:v4"" />
              </ns0:EnterpriseID>
              <EventBranch>
              <Code>LOS</Code>
                </EventBranch>
              <ns0:ServerID>
                <xsl:value-of select=""$var:v5"" />
              </ns0:ServerID>
              <ns0:DataTargetCollection>
                <ns0:DataTarget>
                  <ns0:Type>
                    <xsl:value-of select=""$var:v6"" />
                  </ns0:Type>
                </ns0:DataTarget>
              </ns0:DataTargetCollection>
            </ns0:DataContext>
            <ns0:LocalProcessing>
              <ns0:DeliveryRequiredBy>
                <xsl:value-of select=""userCSharp:DateimeConversion(ScheduledShipDate/text())"" />
              </ns0:DeliveryRequiredBy>
            </ns0:LocalProcessing>
            <ns0:Order>
              <ns0:OrderNumber>
                <xsl:value-of select=""OrderID/text()"" />
              </ns0:OrderNumber>
                <ns0:Type>
                  <ns0:Code>ORD</ns0:Code>
                  <ns0:Description>ORDER</ns0:Description>
              </ns0:Type>
              <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;RED&quot;)"" />
              <ns0:Warehouse>
                <ns0:Code>
                  <xsl:value-of select=""$var:v9"" />
                </ns0:Code>
                <ns0:Name>RED</ns0:Name>
              </ns0:Warehouse>
              <ns0:OrderLineCollection>
                <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;Complete&quot;)"" />
                <xsl:attribute name=""Content"">
                  <xsl:value-of select=""$var:v10"" />
                </xsl:attribute>
                <xsl:for-each select=""OrderLineItem"">
                  <ns0:OrderLine>                    
                    <ns0:OrderedQty>
                      <xsl:value-of select=""OrderLineItem_Child8/text()""/>
                    </ns0:OrderedQty>
                    <!--<ns0:OrderedQtyUnit>
                      <ns0:Code>
                        <xsl:value-of select=""userCSharp:Replacefun(ORDERED_QUANTITYUNIT/text())"" />
                      </ns0:Code>
                    </ns0:OrderedQtyUnit>-->
                    <!--<ns0:PackageQty>
                      <xsl:value-of select=""PACKS/text()"" />
                    </ns0:PackageQty>-->
                    <ns0:Product>
                      <ns0:Code>
                        <xsl:value-of select=""OrderLineItem_Child10/text()"" />
                      </ns0:Code>
                    </ns0:Product>
                  <CustomizedFieldCollection>
                      <CustomizedField>
                        <DataType>String</DataType>
                        <Key>ORDERLINEPO#</Key>
                        <Value>
                          <xsl:value-of select=""//OrderLinePurchaseOrderReference/text()"" />
                        </Value>
                      </CustomizedField>
            </CustomizedFieldCollection>
                  </ns0:OrderLine>
                </xsl:for-each>
              
              </ns0:OrderLineCollection>
            </ns0:Order>

            
            
            <ns0:OrganizationAddressCollection>              
                <ns0:OrganizationAddress>
                  <ns0:AddressType>ConsignorDocumentaryAddress</ns0:AddressType>
                  <ns0:OrganizationCode>HEALABAU</ns0:OrganizationCode>
                </ns0:OrganizationAddress>             
              <ns0:OrganizationAddress>
                <ns0:AddressType>ConsigneeAddress</ns0:AddressType>
                <ns0:Address1>
                  <xsl:value-of select=""DeliveryAddress1/text()""/>
                </ns0:Address1>
                <ns0:Address2>
                  <xsl:value-of select=""DeliveryAddress2/text()""/>
                </ns0:Address2>
                <ns0:City>
                  <xsl:value-of select=""DeliverySuburb/text()""/>
                </ns0:City>
                <ns0:State>
                  <xsl:value-of select=""DeliveryState/text()""/>
                </ns0:State>
                <ns0:CompanyName>
                  <xsl:value-of select=""DeliveryName/text()""/>
                </ns0:CompanyName>
                <ns0:Country>
                  <ns0:Code>
                    <xsl:value-of select=""DestinationCountry/text()""/>
                  </ns0:Code>
                </ns0:Country>
                <ns0:Postcode>
                  <xsl:value-of select=""DeliveryPostCode/text()""/>
                </ns0:Postcode>
              </ns0:OrganizationAddress>
            </ns0:OrganizationAddressCollection>
          </ns0:Shipment>
       
      
    </ns0:UniversalShipment>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[     
  public string Replacefun(string strin)    {     strin=strin.Replace("","","""");     return strin;    }    public string StringConcat(string param0){   return param0;}
  public string DateimeConversion(string strin)            
  {                        DateTime strdatetime = new DateTime();
                           string strin1 = strin.Substring(2, 2) + ""/"" + strin.Substring(0, 2) + ""/"" + strin.Substring(4, 4);
                          strdatetime = DateTime.Parse(strin1);            
                          strin = strdatetime.ToString(""yyyy-MM-ddTHH:mm:ss"");            
                          return strin;             
                          }
                          public bool LogicalEq(string val1, string val2){bool ret = false;double d1 = 0;double d2 = 0;if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2)){ret = d1 == d2;}else{ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;}return ret;}public bool IsNumeric(string val){if (val == null){return false;}double d = 0;return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}public bool IsNumeric(string val, ref double d){if (val == null){return false;}return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);}
  ]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurveOrder";
        
        private const global::GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurveOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurveOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _TrgSchemas;
            }
        }
    }
}
