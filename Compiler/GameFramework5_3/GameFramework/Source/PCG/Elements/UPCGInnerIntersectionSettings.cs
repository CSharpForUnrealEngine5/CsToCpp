namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGInnerIntersectionElement.h")]
public partial class UPCGInnerIntersectionSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DensityFunction</summary>
	public EPCGIntersectionDensityFunction DensityFunction;
	///<summary>[EDITOR ONLY] If enabled, output points with a density value of 0 will NOT be automatically filtered out.</summary>
	public bool bKeepZeroDensityPoints;
}
