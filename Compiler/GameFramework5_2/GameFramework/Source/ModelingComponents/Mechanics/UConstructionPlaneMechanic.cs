#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/ConstructionPlaneMechanic.h")]
///<summary>UConstructionPlaneMechanic implements an interaction in which a 3D plane can be</summary>
public partial class UConstructionPlaneMechanic : UInteractionMechanic {
// ConstructionPlaneMechanic
	public UCombinedTransformGizmo PlaneTransformGizmo;
	public UTransformProxy PlaneTransformProxy;
	public USingleClickInputBehavior ClickToSetPlaneBehavior;
	public ULocalSingleClickInputBehavior MiddleClickToSetGizmoBehavior;
}
