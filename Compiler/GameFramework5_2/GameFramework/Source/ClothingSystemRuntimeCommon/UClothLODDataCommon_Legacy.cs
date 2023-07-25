#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothLODData_Legacy.h")]
///<summary>Deprecated, legacy definition kept for backward compatibility only.</summary>
public partial class UClothLODDataCommon_Legacy : UObject {
// ClothLODDataCommon_Legacy
	public UClothPhysicalMeshDataBase_Legacy PhysicalMeshData_DEPRECATED;
	public FClothPhysicalMeshData ClothPhysicalMeshData;
	public FClothCollisionData CollisionData;
	public TArray<FPointWeightMap> ParameterMasks;
}
