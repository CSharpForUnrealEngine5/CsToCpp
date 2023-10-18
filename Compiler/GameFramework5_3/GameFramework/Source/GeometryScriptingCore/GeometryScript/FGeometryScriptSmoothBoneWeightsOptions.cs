namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBoneWeightFunctions.h")]
public partial struct FGeometryScriptSmoothBoneWeightsOptions {
	public EGeometryScriptSmoothBoneWeightsType DistanceWeighingType;
	public float Stiffness;
	public int MaxInfluences;
	public int VoxelResolution;
}
