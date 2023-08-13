namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a single box primitive.</summary>
[CppInclude("ClothCollisionPrim.h")]
public partial struct FClothCollisionPrim_Box {
	public FVector LocalPosition;
	public FQuat LocalRotation;
	public FVector HalfExtents;
	public int BoneIndex;
}
