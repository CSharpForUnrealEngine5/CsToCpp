#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for detailing collision automated test data.</summary>
[CppInclude("UnrealEd/CollisionAutomationTests.h")]
public partial struct FCollisionTestEntry {
	public string RootShapeAsset;
	public string ShapeType;
	public FHitResult HitResult;
}
