#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transfer an attribute from a source metadata to a target data.</summary>
[CppInclude("Elements/PCGAttributeTransferElement.h")]
public partial class UPCGAttributeTransferSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SourceAttributeName</summary>
	public string SourceAttributeName;
	///<summary>TargetAttributeName</summary>
	public string TargetAttributeName;
}
