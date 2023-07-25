#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingSelectionInteraction.h")]
///<summary>UModelingSelectionInteraction provides element-level selection behavior (ie mesh triangles/edges/vertices)</summary>
public partial class UModelingSelectionInteraction : UObject {
// ModelingSelectionInteraction
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	public UMouseHoverBehavior HoverBehavior;
	public UInputBehaviorSet BehaviorSet;
	public UGeometrySelectionManager SelectionManager;
	public UTransformProxy TransformProxy;
	public UCombinedTransformGizmo TransformGizmo;
	public UDragAlignmentInteraction DragAlignmentInteraction;
	public UKeyAsModifierInputBehavior DragAlignmentToggleBehavior;
	public URectangleMarqueeInteraction RectangleMarqueeInteraction;
	public UPathSelectionInteraction PathSelectionInteraction;
}
