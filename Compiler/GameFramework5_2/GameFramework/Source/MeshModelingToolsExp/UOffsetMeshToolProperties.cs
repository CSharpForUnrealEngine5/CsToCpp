#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base properties of Offset</summary>
[CppInclude("OffsetMeshTool.h")]
public partial class UOffsetMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Type of Offsetting to apply</summary>
	public EOffsetMeshToolOffsetType OffsetType;
	///<summary>Offset Distance in World Units</summary>
	public float Distance;
	///<summary>If true, create a thickened shell, instead of only moving the input vertices</summary>
	public bool bCreateShell;
}
