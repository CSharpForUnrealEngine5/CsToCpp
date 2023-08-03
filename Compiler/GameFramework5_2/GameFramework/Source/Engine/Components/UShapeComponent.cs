#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ShapeComponent is a PrimitiveComponent that is represented by a simple geometrical shape (sphere, capsule, box, etc).</summary>
[CppInclude("Components/ShapeComponent.h")]
public partial class UShapeComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Description of collision</summary>
	public UBodySetup ShapeBodySetup;
	///<summary>AreaClass</summary>
	public UClass AreaClass;
	///<summary>Color used to draw the shape.</summary>
	public FColor ShapeColor;
	///<summary>Only show this component if the actor is selected</summary>
	public bool bDrawOnlyIfSelected;
	///<summary>If true it allows Collision when placing even if collision is not enabled</summary>
	public bool bShouldCollideWhenPlacing;
	///<summary>If set, shape will be exported for navigation as dynamic modifier instead of using regular collision data</summary>
	public bool bDynamicObstacle;
	///<summary>Navigation area type override, null / none = no change to nav mesh.</summary>
	public UClass AreaClassOverride;
	///<summary>Uses FNavigationSystem::GetDefaultObstacleArea() by default instead of AreaClassOverride, bDynamicObstacle must be true to use this.</summary>
	public bool bUseSystemDefaultObstacleAreaClass;
}
