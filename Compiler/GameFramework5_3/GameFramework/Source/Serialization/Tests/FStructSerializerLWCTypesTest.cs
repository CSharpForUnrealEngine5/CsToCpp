namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for LWC types.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerLWCTypesTest {
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
