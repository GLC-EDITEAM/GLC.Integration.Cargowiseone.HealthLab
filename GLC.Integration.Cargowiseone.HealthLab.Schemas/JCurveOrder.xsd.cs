namespace GLC.Integration.Cargowiseone.HealthLab.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"HL_JCURVE")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL_JCURVE"})]
    public sealed class JCurveOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""HL_JCURVE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""OrderLineItem"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderLineItem_Child1"" type=""xs:unsignedShort"" />
              <xs:element name=""OrderLineItem_Child2"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child3"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child4"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child5"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child6"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child7"" type=""xs:unsignedShort"" />
              <xs:element name=""OrderLineItem_Child8"" type=""xs:unsignedByte"" />
              <xs:element name=""OrderLineItem_Child9"" type=""xs:unsignedByte"" />
              <xs:element name=""OrderLineItem_Child10"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child11"" type=""xs:unsignedInt"" />
              <xs:element name=""OrderLineItem_Child12"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child13"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child14"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child15"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child16"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child17"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child18"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child19"" type=""xs:unsignedShort"" />
              <xs:element name=""OrderLineItem_Child20"" type=""xs:decimal"" />
              <xs:element name=""OrderLineItem_Child21"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child22"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child23"" type=""xs:string"" />
              <xs:element name=""OrderLineItem_Child24"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child25"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child26"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child27"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child28"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child29"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child30"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child31"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child32"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child33"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child34"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child35"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child36"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child37"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child38"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child39"" type=""xs:anyType"" />
              <xs:element name=""OrderLineItem_Child40"" type=""xs:anyType"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public JCurveOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HL_JCURVE";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
