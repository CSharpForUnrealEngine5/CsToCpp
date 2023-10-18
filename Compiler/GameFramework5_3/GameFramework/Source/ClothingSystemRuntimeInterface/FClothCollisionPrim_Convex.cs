namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a single convex element</summary>
[CppInclude("ClothCollisionPrim.h")]
public partial struct FClothCollisionPrim_Convex {
	public TArray<FPlane> Planes_DEPRECATED;
	public TArray<FClothCollisionPrim_ConvexFace> Faces;
	public TArray<FVector> SurfacePoints;
	public int BoneIndex;
}
