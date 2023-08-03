#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container class that owns resource descriptors. This is used to ensure we don&#39;t end up</summary>
[CppInclude("OptimusDeformer.h")]
public partial class UOptimusResourceContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Descriptions</summary>
	public TArray<UOptimusResourceDescription> Descriptions;
}
