#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothCollisionData.h")]
public partial struct FClothCollisionData {
// ClothCollisionData
	public TArray<FClothCollisionPrim_Sphere> Spheres;
	public TArray<FClothCollisionPrim_SphereConnection> SphereConnections;
	public TArray<FClothCollisionPrim_Convex> Convexes;
	public TArray<FClothCollisionPrim_Box> Boxes;
}
