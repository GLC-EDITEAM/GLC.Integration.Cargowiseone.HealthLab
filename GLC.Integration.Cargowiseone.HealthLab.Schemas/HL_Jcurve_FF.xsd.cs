namespace GLC.Integration.Cargowiseone.HealthLab.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://GLC.Integration.Cargowiseone.HealthLab.Schemas.HL_Jcurve_FF",@"HL_JCURVE")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL_JCURVE"})]
    public sealed class HL_Jcurve_FF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://GLC.Integration.Cargowiseone.HealthLab.Schemas.HL_Jcurve_FF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://GLC.Integration.Cargowiseone.HealthLab.Schemas.HL_Jcurve_FF"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo standard=""Flat File"" codepage=""65001"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" root_reference=""HL_JCURVE"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""HL_JCURVE"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xD 0xA"" child_order=""postfix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element name=""Header"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" child_delimiter_type=""char"" child_delimiter="","" child_order=""infix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""OrderID"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""1"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""DeliveryName"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""2"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Delivery_Add1"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""3"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Delivery_Add2"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""4"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child5"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""5"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child6"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""6"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child7"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""7"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child8"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""8"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child9"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""9"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child10"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""10"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child11"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""11"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child12"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""12"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child13"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""13"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child14"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""14"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child15"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""15"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child16"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""16"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child17"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""17"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child18"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""18"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child19"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""19"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child20"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""20"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child21"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""21"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child22"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""22"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child23"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""23"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child24"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""24"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child25"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""25"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child26"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""26"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child27"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""27"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child28"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""28"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child29"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""29"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child30"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""30"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child31"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""31"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child32"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""32"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child33"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""33"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child34"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""34"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child35"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""35"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child36"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""36"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child37"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""37"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child38"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""38"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child39"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""39"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child40"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""40"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Header_Child41"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""41"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""OrderLineItem"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" child_delimiter_type=""char"" child_delimiter="","" child_order=""postfix"" sequence_number=""2"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""OrderLineItem_Child1"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""1"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child2"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""2"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child3"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""3"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child4"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""4"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child5"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""5"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child6"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""6"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child7"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""7"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child8"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""8"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child9"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""9"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child10"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""10"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child11"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""11"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child12"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""12"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child13"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""13"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child14"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""14"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child15"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""15"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child16"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""16"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child17"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""17"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child18"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""18"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child19"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""19"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child20"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""20"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child21"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""21"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child22"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""22"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child23"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""23"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child24"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""24"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child25"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""25"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child26"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""26"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child27"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""27"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child28"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""28"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child29"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""29"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child30"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""30"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child31"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""31"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child32"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""32"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child33"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""33"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child34"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""34"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child35"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""35"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child36"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""36"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child37"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""37"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child38"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""38"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child39"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""39"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrderLineItem_Child40"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""40"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HL_Jcurve_FF() {
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
