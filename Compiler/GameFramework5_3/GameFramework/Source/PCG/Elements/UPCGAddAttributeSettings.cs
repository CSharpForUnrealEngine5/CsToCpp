namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Add a new attribute.</summary>
[CppInclude("Elements/PCGCreateAttribute.h")]
public partial class UPCGAddAttributeSettings : UPCGCreateAttributeBaseSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertyOutputSelector OutputTarget;
	///<summary>OutputAttributeName_DEPRECATED</summary>
	public FName OutputAttributeName_DEPRECATED;
}
