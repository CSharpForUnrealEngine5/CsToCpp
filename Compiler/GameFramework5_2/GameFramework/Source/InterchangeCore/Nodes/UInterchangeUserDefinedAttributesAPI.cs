#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeUserDefinedAttribute.h")]
///<summary>UInterchangeUserDefinedAttributesAPI is used to store and retrieve user defined attributes (i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
public partial class UInterchangeUserDefinedAttributesAPI : UObject {
// InterchangeUserDefinedAttributesAPI
	public bool CreateUserDefinedAttribute_Boolean(UObject InterchangeNode,string UserDefinedAttributeName,bool Value,string PayloadKey) { return default; }
	public bool CreateUserDefinedAttribute_Float(UObject InterchangeNode,string UserDefinedAttributeName,float Value,string PayloadKey) { return default; }
	public bool CreateUserDefinedAttribute_Double(UObject InterchangeNode,string UserDefinedAttributeName,double Value,string PayloadKey) { return default; }
	public bool CreateUserDefinedAttribute_Int32(UObject InterchangeNode,string UserDefinedAttributeName,int Value,string PayloadKey) { return default; }
	public bool CreateUserDefinedAttribute_FString(UObject InterchangeNode,string UserDefinedAttributeName,string Value,string PayloadKey) { return default; }
	public bool RemoveUserDefinedAttribute(UObject InterchangeNode,string UserDefinedAttributeName) { return default; }
	public bool GetUserDefinedAttribute_Boolean(UObject InterchangeNode,string UserDefinedAttributeName,bool OutValue,string OutPayloadKey) { return default; }
	public bool GetUserDefinedAttribute_Float(UObject InterchangeNode,string UserDefinedAttributeName,float OutValue,string OutPayloadKey) { return default; }
	public bool GetUserDefinedAttribute_Double(UObject InterchangeNode,string UserDefinedAttributeName,double OutValue,string OutPayloadKey) { return default; }
	public bool GetUserDefinedAttribute_Int32(UObject InterchangeNode,string UserDefinedAttributeName,int OutValue,string OutPayloadKey) { return default; }
	public bool GetUserDefinedAttribute_FString(UObject InterchangeNode,string UserDefinedAttributeName,string OutValue,string OutPayloadKey) { return default; }
	public void GetUserDefinedAttributeInfos(UObject InterchangeNode,TArray<FInterchangeUserDefinedAttributeInfo> UserDefinedAttributeInfos) {}
	public void DuplicateAllUserDefinedAttribute(UObject InterchangeSourceNode,UObject InterchangeDestinationNode,bool bAddSourceNodeName) {}
}
