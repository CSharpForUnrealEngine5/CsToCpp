#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
///<summary>Settings used to reduce a mesh.</summary>
public partial struct FMeshReductionSettings {
// MeshReductionSettings
	public float PercentTriangles;
	public uint MaxNumOfTriangles;
	public float PercentVertices;
	public uint MaxNumOfVerts;
	public float MaxDeviation;
	public float PixelError;
	public float WeldingThreshold;
	public float HardAngleThreshold;
	public int BaseLODModel;
	public EMeshFeatureImportance SilhouetteImportance;
	public EMeshFeatureImportance TextureImportance;
	public EMeshFeatureImportance ShadingImportance;
	public bool bRecalculateNormals;
	public bool bGenerateUniqueLightmapUVs;
	public bool bKeepSymmetry;
	public bool bVisibilityAided;
	public bool bCullOccluded;
	public EStaticMeshReductionTerimationCriterion TerminationCriterion;
	public EMeshFeatureImportance VisibilityAggressiveness;
	public EMeshFeatureImportance VertexColorImportance;
}
