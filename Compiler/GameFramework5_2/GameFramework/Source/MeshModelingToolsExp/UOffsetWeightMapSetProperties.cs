namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OffsetMeshTool.h")]
public partial class UOffsetWeightMapSetProperties : UWeightMapSetProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum Offset Distance in World Units, for Weight Map values of zero (clamped to Distance)</summary>
	public float MinDistance;
}
