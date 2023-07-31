#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated, legacy definition kept for backward compatibility only.</summary>
[CppInclude("ClothLODData_Legacy.h")]
public partial class UClothLODDataCommon_Legacy : UObject {
	///<summary>Deprecated, use ClothPhysicalMeshData instead</summary>
	public UClothPhysicalMeshDataBase_Legacy PhysicalMeshData_DEPRECATED;
	///<summary>Raw phys mesh data</summary>
	public FClothPhysicalMeshData ClothPhysicalMeshData;
	///<summary>Collision primitive and convex data for clothing collisions</summary>
	public FClothCollisionData CollisionData;
	///<summary>Parameter masks defining the physics mesh masked data</summary>
	public TArray<FPointWeightMap> ParameterMasks;
}
