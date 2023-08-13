namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGIntersectionElement.h")]
public partial class UPCGIntersectionSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DensityFunction</summary>
	public EPCGIntersectionDensityFunction DensityFunction;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
