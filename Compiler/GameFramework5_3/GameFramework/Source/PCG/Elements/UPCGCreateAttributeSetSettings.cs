namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates a new Attribute Set.</summary>
[CppInclude("Elements/PCGCreateAttribute.h")]
public partial class UPCGCreateAttributeSetSettings : UPCGCreateAttributeBaseSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertyOutputNoSourceSelector OutputTarget;
	///<summary>OutputAttributeName_DEPRECATED</summary>
	public FName OutputAttributeName_DEPRECATED;
}
