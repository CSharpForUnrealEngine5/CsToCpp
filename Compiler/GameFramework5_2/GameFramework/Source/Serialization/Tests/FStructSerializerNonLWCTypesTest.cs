#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for Non-LWC version of built in types.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerNonLWCTypesTest {
	public FVector3f Vector;
	public FVector2f Vector2D;
	public FVector4f Vector4;
	public FMatrix44f Matrix;
	public FPlane4f Plane;
	public FQuat4f Quat;
	public FRotator3f Rotator;
	public FTransform3f Transform;
	public FBox3f Box;
	public FBox2f Box2D;
	public FBoxSphereBounds3f BoxSphereBounds;
	public FOrientedBoxFloat OrientedBox;
	public float Float;
	public double Double;
	public TArray<FVector3f> VectorArray;
	public TMap<string,FVector3f> StrToVec;
	public TSet<FVector3f> VectorSet;
}
