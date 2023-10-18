namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGOuterIntersectionElement.h")]
public partial class UPCGOuterIntersectionSettings : UPCGSettingsWithDynamicInputs {
	public static UClass StaticClass() {return default;}
	///<summary>DensityFunction</summary>
	public EPCGIntersectionDensityFunction DensityFunction;
	///<summary>If enabled, dynamic input pins that have no incoming data will be bypassed during the intersection operation</summary>
	public bool bIgnorePinsWithNoInput;
	///<summary>[EDITOR ONLY] If enabled, output points with a density value of 0 will NOT be automatically filtered out.</summary>
	public bool bKeepZeroDensityPoints;
}
