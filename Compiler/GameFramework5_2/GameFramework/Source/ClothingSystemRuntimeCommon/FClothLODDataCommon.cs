#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothLODData.h")]
///<summary>Common Cloth LOD representation for all clothing assets.</summary>
public partial struct FClothLODDataCommon {
// ClothLODDataCommon
	public FClothPhysicalMeshData PhysicalMeshData;
	public FClothCollisionData CollisionData;
	public bool bUseMultipleInfluences;
	public float SkinningKernelRadius;
	public bool bSmoothTransition;
	public TArray<FClothParameterMask_Legacy> ParameterMasks_DEPRECATED;
	public TArray<FPointWeightMap> PointWeightMaps;
}
