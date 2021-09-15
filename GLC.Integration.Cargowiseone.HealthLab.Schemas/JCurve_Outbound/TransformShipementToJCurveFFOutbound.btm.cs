namespace GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF", typeof(global::GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF))]
    public sealed class TransformShipementToJCurveFFOutbound : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF"" xmlns:s0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UniversalShipment"" />
  </xsl:template>
  <xsl:template match=""/s0:UniversalShipment"">
    <ns0:JCurveOBFF>
      <JCurveOBFF_Header>
        <JCurveOBFF_Header_Child1>Company Name</JCurveOBFF_Header_Child1>
        <JCurveOBFF_Header_Child2>Tracking Number</JCurveOBFF_Header_Child2>
        <JCurveOBFF_Header_Child3>Item</JCurveOBFF_Header_Child3>
        <JCurveOBFF_Header_Child4>keep the column</JCurveOBFF_Header_Child4>
        <JCurveOBFF_Header_Child5></JCurveOBFF_Header_Child5>
        <JCurveOBFF_Header_Child6>Order ID</JCurveOBFF_Header_Child6>
        <JCurveOBFF_Header_Child7>Qty</JCurveOBFF_Header_Child7>
        <JCurveOBFF_Header_Child8>Courier</JCurveOBFF_Header_Child8>
        <JCurveOBFF_Header_Child9>Container ID</JCurveOBFF_Header_Child9>
        <JCurveOBFF_Header_Child10>Lot Number</JCurveOBFF_Header_Child10>
        <JCurveOBFF_Header_Child11>Expiration Date</JCurveOBFF_Header_Child11>
        <JCurveOBFF_Header_Child12>Order Line Purchase Order Reference</JCurveOBFF_Header_Child12>
      </JCurveOBFF_Header>
      <xsl:for-each select=""s0:Shipment"">
        <xsl:for-each select=""s0:MilestoneCollection/s0:Milestone"">
          <xsl:if test=""s0:EventCode='FIN'"">
            <xsl:value-of select=""userCSharp:setactualdate(s0:ActualDate/text())""/>
          </xsl:if>
        </xsl:for-each>
        <xsl:variable name =""companyName"">
          <xsl:for-each select=""s0:OrganizationAddressCollection/s0:OrganizationAddress"">
            <xsl:if test=""s0:AddressType='TransportCompanyDocumentaryAddress'"">
              <xsl:value-of select=""s0:CompanyName/text()""/>
            </xsl:if>
          </xsl:for-each>
        </xsl:variable>
        
        
        
        <xsl:for-each select=""s0:CommercialInfo"">
        <xsl:for-each select=""s0:CommercialInvoiceCollection"">
          <xsl:for-each select=""s0:CommercialInvoice"">
            <xsl:for-each select=""s0:CommercialInvoiceLineCollection"">
              <xsl:for-each select=""s0:CommercialInvoiceLine"">
                <xsl:variable name=""varCommerProduct"">
                 <xsl:for-each select=""s0:CustomizedFieldCollection/s0:CustomizedField"">
                      <xsl:if test=""s0:Key/text()='Product Code'"">                        
                          <xsl:value-of select=""s0:Value/text()""/>
                        </xsl:if>                      
                    </xsl:for-each>
                  </xsl:variable>                
               <JCurveOBFF_LineItem>
                  <JCurveOBFF_LineItem_Child1>HL</JCurveOBFF_LineItem_Child1>
                  <JCurveOBFF_LineItem_Child2>
                      <xsl:if test=""../../../../../s0:Order/s0:TransportReference/text()"">
                     <xsl:value-of select=""../../../../../s0:Order/s0:TransportReference/text()""/>
                   </xsl:if> 
                 </JCurveOBFF_LineItem_Child2>
                 
                  <JCurveOBFF_LineItem_Child3>
                  <xsl:value-of select=""$varCommerProduct""/>
                </JCurveOBFF_LineItem_Child3>
                 <JCurveOBFF_LineItem_Child5>
                  <xsl:value-of select=""userCSharp:getactualdate()""/>
                </JCurveOBFF_LineItem_Child5>
                <JCurveOBFF_LineItem_Child6>
                  <xsl:if test=""../../../../../s0:Order/s0:OrderNumber/text()"">
                     <xsl:value-of select=""../../../../../s0:Order/s0:OrderNumber/text()""/>
                   </xsl:if> 
                </JCurveOBFF_LineItem_Child6>
                <JCurveOBFF_LineItem_Child7>
                  <xsl:value-of select=""s0:InvoiceQuantity/text()""/>
                </JCurveOBFF_LineItem_Child7>
                <JCurveOBFF_LineItem_Child8>
                  <xsl:value-of select=""userCSharp:replacecomp($companyName)""/>
                </JCurveOBFF_LineItem_Child8>
                 
                  <JCurveOBFF_LineItem_Child10>                 
                      <xsl:for-each select=""s0:CustomizedFieldCollection/s0:CustomizedField"">
                        <xsl:if test=""s0:Key/text()='LOT NUMBER'"">
                          <xsl:value-of select=""s0:Value/text()""/>
                        </xsl:if>
                      </xsl:for-each>                   
                </JCurveOBFF_LineItem_Child10>
                <JCurveOBFF_LineItem_Child11>                  
                        <xsl:for-each select=""s0:CustomizedFieldCollection/s0:CustomizedField"">
                          <xsl:if test=""s0:Key/text()='Expiry'"">
                            <xsl:value-of select=""s0:Value/text()""/>
                          </xsl:if>
                        </xsl:for-each>                      
                </JCurveOBFF_LineItem_Child11>
                <JCurveOBFF_LineItem_Child12>
                  <xsl:for-each select=""../../../../../s0:Order"">
                    <xsl:for-each select=""s0:OrderLineCollection/s0:OrderLine"">
                        <xsl:if test=""s0:Product/s0:Code/text()=$varCommerProduct"">
                          <xsl:for-each select=""s0:CustomizedFieldCollection/s0:CustomizedField"">
                          <xsl:if test=""s0:Key='ORDERLINEPO#'"">
                            <xsl:value-of select=""s0:Value/text()""/>
                          </xsl:if>                   
                        </xsl:for-each>
                     </xsl:if>
                  </xsl:for-each>
                  </xsl:for-each>                 
                  
                </JCurveOBFF_LineItem_Child12>
                 
                </JCurveOBFF_LineItem>                
              
              </xsl:for-each>
            </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          </xsl:for-each>      
         
        <xsl:value-of select=""userCSharp:resetactualdate()""/>
      </xsl:for-each>
    </ns0:JCurveOBFF>
  </xsl:template>

  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
public string StringConcat(string param0) { return param0; }
public string strindate="""";
public string actualdate="""";
public string DateimeConversion(string strin)
{ 
   if(strin !="""" && strindate=="""")
    {
        strindate = strin.Substring(8, 2) + ""/"" + strin.Substring(5, 2) + ""/"" + strin.Substring(0, 4);
        actualdate=strindate;
     }
    
   return strindate; }
   
   
public string replacecomp(string strin)
{
  strin=strin.Replace("","",""-"");
  return strin;
  }
  
  
public void setactualdate(string strin)
{ 
   if(strin !="""")
    {
        actualdate = strin.Substring(8, 2) + ""/"" + strin.Substring(5, 2) + ""/"" + strin.Substring(0, 4);
        
     }
    
   }

   
public string getactualdate()
{
  return actualdate;
}
  
  public void resetactualdate()
 {
    actualdate="""";
 }
  
 public void resetdate()
 {
    strindate="""";
 }
   
 
  ]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF";
        
        private const global::GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.Cargowiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF";
                return _TrgSchemas;
            }
        }
    }
}
