#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ShapeComponent.h")]
///<summary>ShapeComponent is a PrimitiveComponent that is represented by a simple geometrical shape (sphere, capsule, box, etc).</summary>
public partial class UShapeComponent : UPrimitiveComponent {
// ShapeComponent
	public UBodySetup ShapeBodySetup;
	public UClass AreaClass;
	public FColor ShapeColor;
	public bool bDrawOnlyIfSelected;
	public bool bShouldCollideWhenPlacing;
	public bool bDynamicObstacle;
	public UClass AreaClassOverride;
	public bool bUseSystemDefaultObstacleAreaClass;
}
