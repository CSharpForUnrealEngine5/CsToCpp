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
