#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolRecomputeNormals.h")]
///<summary>Settings for visualizing and recomputing normals and tangents</summary>
public partial class UFractureRecomputeNormalsSettings : UFractureToolSettings {
// FractureRecomputeNormalsSettings
	public bool bShowNormals;
	public bool bShowTangents;
	public float Length;
	public bool bOnlyTangents;
	public bool bRecomputeSharpEdges;
	public float SharpEdgeAngleThreshold;
	public bool bOnlyInternalSurfaces;
}
