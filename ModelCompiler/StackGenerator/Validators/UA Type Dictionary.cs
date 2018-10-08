#pragma warning disable 1591 
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Opc.Ua.CodeGenerator {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/", IsNullable=false)]
    public partial class Documentation {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string[] textField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class EnumeratedValue {
        
        private Documentation documentationField;
        
        private string nameField;
        
        private int valueField;
        
        private bool valueFieldSpecified;
        
        private string bitMaskField;
        
        /// <remarks/>
        public Documentation Documentation {
            get {
                return this.documentationField;
            }
            set {
                this.documentationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BitMask {
            get {
                return this.bitMaskField;
            }
            set {
                this.bitMaskField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class FieldType {
        
        private Documentation documentationField;
        
        private ComplexType complexTypeField;
        
        private string nameField;
        
        private System.Xml.XmlQualifiedName dataTypeField;
        
        private int valueRankField;
        
        public FieldType() {
            this.valueRankField = -1;
        }
        
        /// <remarks/>
        public Documentation Documentation {
            get {
                return this.documentationField;
            }
            set {
                this.documentationField = value;
            }
        }
        
        /// <remarks/>
        public ComplexType ComplexType {
            get {
                return this.complexTypeField;
            }
            set {
                this.complexTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ValueRank {
            get {
                return this.valueRankField;
            }
            set {
                this.valueRankField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class ComplexType : DataType {
        
        private FieldType[] fieldField;
        
        private System.Xml.XmlQualifiedName baseTypeField;
        
        private int xmlEncodingIdField;
        
        private int binaryEncodingIdField;
        
        private bool isAbstractField;
        
        public ComplexType() {
            this.xmlEncodingIdField = 0;
            this.binaryEncodingIdField = 0;
            this.isAbstractField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field")]
        public FieldType[] Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName BaseType {
            get {
                return this.baseTypeField;
            }
            set {
                this.baseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int XmlEncodingId {
            get {
                return this.xmlEncodingIdField;
            }
            set {
                this.xmlEncodingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int BinaryEncodingId {
            get {
                return this.binaryEncodingIdField;
            }
            set {
                this.binaryEncodingIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsAbstract {
            get {
                return this.isAbstractField;
            }
            set {
                this.isAbstractField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnumeratedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constant))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TypeDeclaration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class DataType {
        
        private Documentation documentationField;
        
        private string nameField;
        
        private bool allowArraysField;
        
        private bool notInAddressSpaceField;
        
        private int identifierField;
        
        private bool identifierFieldSpecified;
        
        private uint partNoField;
        
        private string categoryField;
        
        private ReleaseStatus releaseStatusField;
        
        private DataTypePurpose purposeField;
        
        public DataType() {
            this.allowArraysField = false;
            this.notInAddressSpaceField = false;
            this.partNoField = ((uint)(0));
            this.categoryField = "";
            this.releaseStatusField = ReleaseStatus.Released;
            this.purposeField = DataTypePurpose.Normal;
        }
        
        /// <remarks/>
        public Documentation Documentation {
            get {
                return this.documentationField;
            }
            set {
                this.documentationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowArrays {
            get {
                return this.allowArraysField;
            }
            set {
                this.allowArraysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NotInAddressSpace {
            get {
                return this.notInAddressSpaceField;
            }
            set {
                this.notInAddressSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdentifierSpecified {
            get {
                return this.identifierFieldSpecified;
            }
            set {
                this.identifierFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint PartNo {
            get {
                return this.partNoField;
            }
            set {
                this.partNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ReleaseStatus.Released)]
        public ReleaseStatus ReleaseStatus {
            get {
                return this.releaseStatusField;
            }
            set {
                this.releaseStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(DataTypePurpose.Normal)]
        public DataTypePurpose Purpose {
            get {
                return this.purposeField;
            }
            set {
                this.purposeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public enum ReleaseStatus {
        
        /// <remarks/>
        Released,
        
        /// <remarks/>
        Draft,
        
        /// <remarks/>
        Depreciated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public enum DataTypePurpose {
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        ServicesOnly,
        
        /// <remarks/>
        CodeGenerator,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class ServiceType : DataType {
        
        private FieldType[] requestField;
        
        private FieldType[] responseField;
        
        private InterfaceType interfaceTypeField;
        
        public ServiceType() {
            this.interfaceTypeField = InterfaceType.Session;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable=false)]
        public FieldType[] Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable=false)]
        public FieldType[] Response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(InterfaceType.Session)]
        public InterfaceType InterfaceType {
            get {
                return this.interfaceTypeField;
            }
            set {
                this.interfaceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public enum InterfaceType {
        
        /// <remarks/>
        Session,
        
        /// <remarks/>
        SecureChannel,
        
        /// <remarks/>
        Discovery,
        
        /// <remarks/>
        Registration,
        
        /// <remarks/>
        Test,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class EnumeratedType : DataType {
        
        private EnumeratedValue[] valueField;
        
        private bool isOptionSetField;
        
        private System.Xml.XmlQualifiedName baseTypeField;
        
        public EnumeratedType() {
            this.isOptionSetField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public EnumeratedValue[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsOptionSet {
            get {
                return this.isOptionSetField;
            }
            set {
                this.isOptionSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName BaseType {
            get {
                return this.baseTypeField;
            }
            set {
                this.baseTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class Constant : DataType {
        
        private string valueField;
        
        private Severity severityField;
        
        public Constant() {
            this.severityField = Severity.None;
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(Severity.None)]
        public Severity Severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public enum Severity {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Good,
        
        /// <remarks/>
        Uncertain,
        
        /// <remarks/>
        Bad,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class TypeDeclaration : DataType {
        
        private System.Xml.XmlQualifiedName sourceTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName SourceType {
            get {
                return this.sourceTypeField;
            }
            set {
                this.sourceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    public partial class ImportDirective {
        
        private string namespaceField;
        
        private string locationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://opcfoundation.org/UA/TypeDictionary/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opcfoundation.org/UA/TypeDictionary/", IsNullable=false)]
    public partial class TypeDictionary {
        
        private Documentation documentationField;
        
        private ImportDirective[] importField;
        
        private DataType[] itemsField;
        
        private string targetNamespaceField;
        
        private string targetVersionField;
        
        private System.DateTime targetPublicationDateField;
        
        /// <remarks/>
        public Documentation Documentation {
            get {
                return this.documentationField;
            }
            set {
                this.documentationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Import")]
        public ImportDirective[] Import {
            get {
                return this.importField;
            }
            set {
                this.importField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplexType", typeof(ComplexType))]
        [System.Xml.Serialization.XmlElementAttribute("Constant", typeof(Constant))]
        [System.Xml.Serialization.XmlElementAttribute("DataType", typeof(DataType))]
        [System.Xml.Serialization.XmlElementAttribute("EnumeratedType", typeof(EnumeratedType))]
        [System.Xml.Serialization.XmlElementAttribute("ServiceType", typeof(ServiceType))]
        [System.Xml.Serialization.XmlElementAttribute("TypeDeclaration", typeof(TypeDeclaration))]
        public DataType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetNamespace {
            get {
                return this.targetNamespaceField;
            }
            set {
                this.targetNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetVersion {
            get {
                return this.targetVersionField;
            }
            set {
                this.targetVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TargetPublicationDate {
            get {
                return this.targetPublicationDateField;
            }
            set {
                this.targetPublicationDateField = value;
            }
        }
    }
}
