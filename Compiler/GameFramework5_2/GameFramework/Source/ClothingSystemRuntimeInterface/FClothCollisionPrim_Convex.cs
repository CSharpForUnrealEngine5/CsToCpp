#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothCollisionPrim.h")]
///<summary>Data for a single convex element</summary>
public partial struct FClothCollisionPrim_Convex {
// ClothCollisionPrim_Convex
	public TArray<FPlane> Planes_DEPRECATED;
	public TArray<FClothCollisionPrim_ConvexFace> Faces;
	public TArray<FVector> SurfacePoints;
	public int BoneIndex;
}
