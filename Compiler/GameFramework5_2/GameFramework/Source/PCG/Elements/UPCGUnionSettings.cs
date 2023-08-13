namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGUnionElement.h")]
public partial class UPCGUnionSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Type</summary>
	public EPCGUnionType Type;
	///<summary>DensityFunction</summary>
	public EPCGUnionDensityFunction DensityFunction;
}
