namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transfer an attribute from a source metadata to a target data.</summary>
[CppInclude("Elements/PCGAttributeTransferElement.h")]
public partial class UPCGAttributeTransferSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SourceAttributeProperty</summary>
	public FPCGAttributePropertyInputSelector SourceAttributeProperty;
	///<summary>TargetAttributeProperty</summary>
	public FPCGAttributePropertyOutputSelector TargetAttributeProperty;
	///<summary>SourceAttributeName_DEPRECATED</summary>
	public FName SourceAttributeName_DEPRECATED;
	///<summary>TargetAttributeName_DEPRECATED</summary>
	public FName TargetAttributeName_DEPRECATED;
}
