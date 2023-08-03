#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshInspectorTool.h")]
public partial class UMeshInspectorProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Toggle visibility of all mesh edges</summary>
	public bool bWireframe;
	///<summary>Toggle visibility of open boundary edges</summary>
	public bool bBoundaryEdges;
	///<summary>Toggle visibility of bowtie vertices</summary>
	public bool bBowtieVertices;
	///<summary>Toggle visibility of polygon borders</summary>
	public bool bPolygonBorders;
	///<summary>Toggle visibility of UV seam edges</summary>
	public bool bUVSeams;
	///<summary>Toggle visibility of UV bowtie vertices</summary>
	public bool bUVBowties;
	///<summary>Toggle visibility of triangles with missing UVs</summary>
	public bool bMissingUVs;
	///<summary>Toggle visibility of Normal seam edges</summary>
	public bool bNormalSeams;
	///<summary>Toggle visibility of Tangent seam edges</summary>
	public bool bTangentSeams;
	///<summary>Toggle visibility of normal vectors</summary>
	public bool bNormalVectors;
	///<summary>Toggle visibility of tangent vectors</summary>
	public bool bTangentVectors;
	///<summary>Length of line segments representing normal vectors</summary>
	public float NormalLength;
	///<summary>Length of line segments representing tangent vectors</summary>
	public float TangentLength;
	///<summary>Draw the mesh indices of the selected type. A maximum of 500 visible indices will be rendered.</summary>
	public EMeshInspectorToolDrawIndexMode ShowIndices;
}
