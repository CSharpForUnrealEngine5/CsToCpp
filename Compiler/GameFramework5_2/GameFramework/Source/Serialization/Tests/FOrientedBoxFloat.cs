#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Float (Non LWC) version of FOrientedBox since the float version doesn&#39;t exist yet</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FOrientedBoxFloat {
	public FVector3f Center;
	public FVector3f AxisX;
	public FVector3f AxisY;
	public FVector3f AxisZ;
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
}
