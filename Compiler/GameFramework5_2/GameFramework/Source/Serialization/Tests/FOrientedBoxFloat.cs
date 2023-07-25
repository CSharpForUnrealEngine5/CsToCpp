#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Float (Non LWC) version of FOrientedBox since the float version doesn't exist yet</summary>
public partial struct FOrientedBoxFloat {
// OrientedBoxFloat
	public FVector3f Center;
	public FVector3f AxisX;
	public FVector3f AxisY;
	public FVector3f AxisZ;
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
}
