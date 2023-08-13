namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated, use FClothPhysicalMeshData instead.</summary>
[CppInclude("ClothPhysicalMeshDataNv_Legacy.h")]
public partial class UClothPhysicalMeshDataNv_Legacy : UClothPhysicalMeshDataBase_Legacy {
	public static UClass StaticClass() {return default;}
	///<summary>The distance that each vertex can move away from its reference (skinned) position</summary>
	public TArray<float> MaxDistances;
	///<summary>Distance along the plane of the surface that the particles can travel (separation constraint)</summary>
	public TArray<float> BackstopDistances;
	///<summary>Radius of movement to allow for backstop movement</summary>
	public TArray<float> BackstopRadiuses;
	///<summary>Strength of anim drive per-particle (spring driving particle back to skinned location</summary>
	public TArray<float> AnimDriveMultipliers;
}
