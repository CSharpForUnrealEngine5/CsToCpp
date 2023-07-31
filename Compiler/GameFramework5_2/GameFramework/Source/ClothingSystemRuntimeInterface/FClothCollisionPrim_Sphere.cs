#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a single sphere primitive in the clothing simulation. This can either be a</summary>
[CppInclude("ClothCollisionPrim.h")]
public partial struct FClothCollisionPrim_Sphere {
	public int BoneIndex;
	public float Radius;
	public FVector LocalPosition;
}
