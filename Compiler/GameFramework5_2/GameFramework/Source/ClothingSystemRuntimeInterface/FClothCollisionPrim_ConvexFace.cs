#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a convex face.</summary>
[CppInclude("ClothCollisionPrim.h")]
public partial struct FClothCollisionPrim_ConvexFace {
	public FPlane Plane;
	public TArray<int> Indices;
}
