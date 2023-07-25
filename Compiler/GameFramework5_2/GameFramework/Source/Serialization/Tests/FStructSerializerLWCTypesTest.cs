#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for LWC types.</summary>
public partial struct FStructSerializerLWCTypesTest {
// StructSerializerLWCTypesTest
	public FVector Vector;
	public FVector2D Vector2D;
	public FVector4 Vector4;
	public FMatrix Matrix;
	public FPlane Plane;
	public FQuat Quat;
	public FRotator Rotator;
	public FTransform Transform;
	public FBox Box;
	public FBox2D Box2D;
	public FBoxSphereBounds BoxSphereBounds;
	public FOrientedBox OrientedBox;
	public float Float;
	public double Double;
	public TArray<FVector> VectorArray;
	public TMap<string,FVector> StrToVec;
	public TSet<FVector> VectorSet;
}
