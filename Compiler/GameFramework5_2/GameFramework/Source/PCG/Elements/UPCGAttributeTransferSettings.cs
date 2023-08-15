namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transfer an attribute from a source metadata to a target data.</summary>
[CppInclude("Elements/PCGAttributeTransferElement.h")]
public partial class UPCGAttributeTransferSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SourceAttributeName</summary>
	public FName SourceAttributeName;
	///<summary>TargetAttributeName</summary>
	public FName TargetAttributeName;
}
