namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInterchangeUserDefinedAttributesAPI is used to store and retrieve user defined attributes (i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
[CppInclude("Nodes/InterchangeUserDefinedAttribute.h")]
public partial class UInterchangeUserDefinedAttributesAPI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CreateUserDefinedAttribute_Boolean</summary>
	public static bool CreateUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,bool Value,string PayloadKey) { return default; }
	///<summary>CreateUserDefinedAttribute_Float</summary>
	public static bool CreateUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,float Value,string PayloadKey) { return default; }
	///<summary>CreateUserDefinedAttribute_Double</summary>
	public static bool CreateUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,double Value,string PayloadKey) { return default; }
	///<summary>CreateUserDefinedAttribute_Int32</summary>
	public static bool CreateUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,int Value,string PayloadKey) { return default; }
	///<summary>CreateUserDefinedAttribute_FString</summary>
	public static bool CreateUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,string Value,string PayloadKey) { return default; }
	///<summary>Remove the specified user defined attribute</summary>
	public static bool RemoveUserDefinedAttribute(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName) { return default; }
	///<summary>GetUserDefinedAttribute_Boolean</summary>
	public static bool GetUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,bool OutValue,string OutPayloadKey) { return default; }
	///<summary>GetUserDefinedAttribute_Float</summary>
	public static bool GetUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,float OutValue,string OutPayloadKey) { return default; }
	///<summary>GetUserDefinedAttribute_Double</summary>
	public static bool GetUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,double OutValue,string OutPayloadKey) { return default; }
	///<summary>GetUserDefinedAttribute_Int32</summary>
	public static bool GetUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,int OutValue,string OutPayloadKey) { return default; }
	///<summary>GetUserDefinedAttribute_FString</summary>
	public static bool GetUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode,string UserDefinedAttributeName,string OutValue,string OutPayloadKey) { return default; }
	///<summary>GetUserDefinedAttributeInfos</summary>
	public static void GetUserDefinedAttributeInfos(UInterchangeBaseNode InterchangeNode,TArray<FInterchangeUserDefinedAttributeInfo> UserDefinedAttributeInfos) {}
	///<summary>DuplicateAllUserDefinedAttribute</summary>
	public static void DuplicateAllUserDefinedAttribute(UInterchangeBaseNode InterchangeSourceNode,UInterchangeBaseNode InterchangeDestinationNode,bool bAddSourceNodeName) {}
}
