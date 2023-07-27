#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>Old optimization settings.</summary>
public partial struct FStaticMeshOptimizationSettings {
// StaticMeshOptimizationSettings
	public EOptimizationType ReductionMethod;
	public float NumOfTrianglesPercentage;
	public float MaxDeviationPercentage;
	public float WeldingThreshold;
	public bool bRecalcNormals;
	public float NormalsThreshold;
	public byte SilhouetteImportance;
	public byte TextureImportance;
	public byte ShadingImportance;
}
