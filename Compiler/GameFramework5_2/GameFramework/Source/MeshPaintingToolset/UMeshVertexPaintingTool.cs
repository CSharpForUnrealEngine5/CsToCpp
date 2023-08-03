#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintingTool.h")]
public partial class UMeshVertexPaintingTool : UBaseBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionMechanic</summary>
	public UMeshPaintSelectionMechanic SelectionMechanic;
	///<summary>VertexProperties</summary>
	public UMeshVertexPaintingToolProperties VertexProperties;
}
