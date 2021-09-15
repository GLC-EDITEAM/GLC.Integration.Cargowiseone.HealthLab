namespace GLC.Integration.Cargowiseone.HealthLab.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendBatchJCurve : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents>        <Component>          <Name>GLC.Integration.Cargowiseone.ClassicWatch.PipelineComp.S"+
"alesOrder_FileName,GLC.Integration.Cargowiseone.HealthLab.PipelineComponents, Version=1.0.0.0, Cultu"+
"re=neutral, PublicKeyToken=da1b1bbd578bf3b0</Name>          <ComponentName>SalesorderFileName</Compo"+
"nentName>          <Description>SalesorderFileName</Description>          <Version>1.0</Version>    "+
"      <Properties />          <CachedDisplayName>SalesorderFileName</CachedDisplayName>          <Ca"+
"chedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>  "+
"    <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemble\" minOccurs=\"0\" maxOccurs=\"1\" exec"+
"Method=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />      <Components>        <Component> "+
"         <Name>Microsoft.BizTalk.Component.FFAsmComp,Microsoft.BizTalk.Pipeline.Components, Version="+
"3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentName>Flat file a"+
"ssembler</ComponentName>          <Description>Flat file assembler component.</Description>         "+
" <Version>1.0</Version>          <Properties>            <Property Name=\"HeaderSpecName\" />         "+
"   <Property Name=\"DocumentSpecName\">              <Value xsi:type=\"xsd:string\">GLC.Integration.Carg"+
"owiseone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF, GLC.Integration.Cargowiseone.HealthLab."+
"Schemas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=da1b1bbd578bf3b0</Value>            </Prop"+
"erty>            <Property Name=\"TrailerSpecName\" />            <Property Name=\"TargetCharset\">     "+
"         <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"TargetCod"+
"ePage\">              <Value xsi:type=\"xsd:int\">0</Value>            </Property>            <Property"+
" Name=\"PreserveBom\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>"+
"            <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">TargetCodeP"+
"age</Value>            </Property>          </Properties>          <CachedDisplayName>Flat file asse"+
"mbler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      "+
"</Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Enco"+
"de\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6\" /> "+
"     <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "38cc9922-6e72-49d3-81da-731f208cc556";
        
        public SendBatchJCurve()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4101-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("GLC.Integration.Cargowiseone.ClassicWatch.PipelineComp.SalesOrder_FileName,GLC.Integration.Cargowiseone.HealthLab.PipelineComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=da1b1bbd578bf3b0");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.FFAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"HeaderSpecName\""+
" />    <Property Name=\"DocumentSpecName\">      <Value xsi:type=\"xsd:string\">GLC.Integration.Cargowis"+
"eone.HealthLab.Schemas.JCurve_Outbound.JCurveOutBoundFF, GLC.Integration.Cargowiseone.HealthLab.Sche"+
"mas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=da1b1bbd578bf3b0</Value>    </Property>    <Pr"+
"operty Name=\"TrailerSpecName\" />    <Property Name=\"TargetCharset\">      <Value xsi:type=\"xsd:string"+
"\" />    </Property>    <Property Name=\"TargetCodePage\">      <Value xsi:type=\"xsd:int\">0</Value>    "+
"</Property>    <Property Name=\"PreserveBom\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </P"+
"roperty>    <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">TargetCodePage</Val"+
"ue>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
