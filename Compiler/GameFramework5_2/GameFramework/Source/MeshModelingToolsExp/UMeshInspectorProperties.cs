#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshInspectorTool.h")]
public partial class UMeshInspectorProperties : UInteractiveToolPropertySet {
// MeshInspectorProperties
	public bool bWireframe;
	public bool bBoundaryEdges;
	public bool bBowtieVertices;
	public bool bPolygonBorders;
	public bool bUVSeams;
	public bool bUVBowties;
	public bool bMissingUVs;
	public bool bNormalSeams;
	public bool bTangentSeams;
	public bool bNormalVectors;
	public bool bTangentVectors;
	public float NormalLength;
	public float TangentLength;
	public EMeshInspectorToolDrawIndexMode ShowIndices;
}
