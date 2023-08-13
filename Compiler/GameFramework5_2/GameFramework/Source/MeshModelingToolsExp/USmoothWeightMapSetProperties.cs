namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothMeshTool.h")]
public partial class USmoothWeightMapSetProperties : UWeightMapSetProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Fractional Minimum Smoothing Parameter in World Units, for Weight Map values of zero</summary>
	public float MinSmoothMultiplier;
}
