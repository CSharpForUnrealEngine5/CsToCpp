#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGizmoActor.h")]
public partial class ALandscapeGizmoActor : AActor {
// LandscapeGizmoActor
	public float Width;
	public float Height;
	public float LengthZ;
	public float MarginZ;
	public float MinRelativeZ;
	public float RelativeScaleZ;
	public ULandscapeInfo TargetLandscapeInfo;
	public UBillboardComponent SpriteComponent;
}
