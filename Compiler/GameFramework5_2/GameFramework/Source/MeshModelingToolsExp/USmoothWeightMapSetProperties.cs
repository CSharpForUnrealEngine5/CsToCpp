#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothMeshTool.h")]
public partial class USmoothWeightMapSetProperties : UWeightMapSetProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Fractional Minimum Smoothing Parameter in World Units, for Weight Map values of zero</summary>
	public float MinSmoothMultiplier;
}
