#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintingTool.h")]
public partial class UMeshColorPaintingToolProperties : UMeshVertexPaintingToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not to apply Vertex Color Painting to the Red Channel</summary>
	public bool bWriteRed;
	///<summary>Whether or not to apply Vertex Color Painting to the Green Channel</summary>
	public bool bWriteGreen;
	///<summary>Whether or not to apply Vertex Color Painting to the Blue Channel</summary>
	public bool bWriteBlue;
	///<summary>Whether or not to apply Vertex Color Painting to the Alpha Channel</summary>
	public bool bWriteAlpha;
	///<summary>When unchecked the painting on the base LOD will be propagate automatically to all other LODs when exiting the mode or changing the selection</summary>
	public bool bPaintOnSpecificLOD;
	///<summary>LOD Index to which should specifically be painted</summary>
	public int LODIndex;
}
