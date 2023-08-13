namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common Cloth LOD representation for all clothing assets.</summary>
[CppInclude("ClothLODData.h")]
public partial struct FClothLODDataCommon {
	public FClothPhysicalMeshData PhysicalMeshData;
	public FClothCollisionData CollisionData;
	public bool bUseMultipleInfluences;
	public float SkinningKernelRadius;
	public bool bSmoothTransition;
	public TArray<FClothParameterMask_Legacy> ParameterMasks_DEPRECATED;
	public TArray<FPointWeightMap> PointWeightMaps;
}
