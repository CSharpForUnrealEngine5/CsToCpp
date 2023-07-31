#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for visualizing and recomputing normals and tangents</summary>
[CppInclude("FractureToolRecomputeNormals.h")]
public partial class UFractureRecomputeNormalsSettings : UFractureToolSettings {
	///<summary>Whether to display normal vectors</summary>
	public bool bShowNormals;
	///<summary>Whether to display tangent and bitangent vectors</summary>
	public bool bShowTangents;
	///<summary>Length of display normal and tangent vectors</summary>
	public float Length;
	///<summary>Whether to only recompute tangents, and leave normals as they were</summary>
	public bool bOnlyTangents;
	///<summary>If true, update where edges are &#39;sharp&#39; by comparing adjacent triangle face normals vs the Sharp Edge Angle Threshold.</summary>
	public bool bRecomputeSharpEdges;
	///<summary>Threshold on angle of change in face normals across an edge, above which we create a sharp edge if bRecomputeSharpEdges is true</summary>
	public float SharpEdgeAngleThreshold;
	///<summary>Whether to only change internal surface normals / tangents</summary>
	public bool bOnlyInternalSurfaces;
}
