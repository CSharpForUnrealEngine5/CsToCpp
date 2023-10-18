namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Old optimization settings.</summary>
[CppInclude("Engine/StaticMesh.h")]
public partial struct FStaticMeshOptimizationSettings {
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
