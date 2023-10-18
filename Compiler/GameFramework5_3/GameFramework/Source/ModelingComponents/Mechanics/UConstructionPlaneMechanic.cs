namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UConstructionPlaneMechanic implements an interaction in which a 3D plane can be</summary>
[CppInclude("Mechanics/ConstructionPlaneMechanic.h")]
public partial class UConstructionPlaneMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>PlaneTransformGizmo</summary>
	public UCombinedTransformGizmo PlaneTransformGizmo;
	///<summary>PlaneTransformProxy</summary>
	public UTransformProxy PlaneTransformProxy;
	///<summary>ClickToSetPlaneBehavior</summary>
	public USingleClickInputBehavior ClickToSetPlaneBehavior;
	///<summary>This is the behavior and behavior target used for the Shift+click behavior that sets the gizmo&#39;s position in the world.</summary>
	public ULocalSingleClickInputBehavior MiddleClickToSetGizmoBehavior;
}
