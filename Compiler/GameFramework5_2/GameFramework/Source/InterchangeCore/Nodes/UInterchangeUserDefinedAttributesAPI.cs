#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeUserDefinedAttribute.h")]
///<summary>UInterchangeUserDefinedAttributesAPI is used to store and retrieve user defined attributes (i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
public partial class UInterchangeUserDefinedAttributesAPI : UObject {
// InterchangeUserDefinedAttributesAPI
	public static bool CreateUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,bool Value,string PayloadKey) { return default; }
	public static bool CreateUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,float Value,string PayloadKey) { return default; }
	public static bool CreateUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,double Value,string PayloadKey) { return default; }
	public static bool CreateUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,int Value,string PayloadKey) { return default; }
	public static bool CreateUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,string Value,string PayloadKey) { return default; }
	public static bool RemoveUserDefinedAttribute(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName) { return default; }
	public static bool GetUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,bool OutValue,string OutPayloadKey) { return default; }
	public static bool GetUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,float OutValue,string OutPayloadKey) { return default; }
	public static bool GetUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,double OutValue,string OutPayloadKey) { return default; }
	public static bool GetUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,int OutValue,string OutPayloadKey) { return default; }
	public static bool GetUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,string OutValue,string OutPayloadKey) { return default; }
	public static void GetUserDefinedAttributeInfos(UInterchangeBaseNode InterchangeNode,TArray<FInterchangeUserDefinedAttributeInfo> UserDefinedAttributeInfos) {}
	public static void DuplicateAllUserDefinedAttribute(UInterchangeBaseNode InterchangeSourceNode,UInterchangeBaseNode InterchangeDestinationNode,bool bAddSourceNodeName) {}
}
