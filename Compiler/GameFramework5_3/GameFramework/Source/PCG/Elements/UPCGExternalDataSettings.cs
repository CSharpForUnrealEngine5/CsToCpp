namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for external data input settings</summary>
[CppInclude("Elements/IO/PCGExternalData.h")]
public partial class UPCGExternalDataSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>AttributeMapping</summary>
	public TMap<string,FPCGAttributePropertyInputSelector> AttributeMapping;
}
