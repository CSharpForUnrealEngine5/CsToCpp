namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UModelingSelectionInteraction provides element-level selection behavior (ie mesh triangles/edges/vertices)</summary>
[CppInclude("ModelingSelectionInteraction.h")]
public partial class UModelingSelectionInteraction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>click-to-select behavior, various drag behaviors</summary>
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	///<summary>mouse hover behavior</summary>
	public UMouseHoverBehavior HoverBehavior;
	///<summary>set of all behaviors, will be passed up to UInputRouter</summary>
	public UInputBehaviorSet BehaviorSet;
	///<summary>SelectionManager</summary>
	public UGeometrySelectionManager SelectionManager;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>DragAlignmentInteraction</summary>
	public UDragAlignmentInteraction DragAlignmentInteraction;
	///<summary>DragAlignmentToggleBehavior</summary>
	public UKeyAsModifierInputBehavior DragAlignmentToggleBehavior;
	///<summary>RectangleMarqueeInteraction</summary>
	public URectangleMarqueeInteraction RectangleMarqueeInteraction;
	///<summary>PathSelectionInteraction</summary>
	public UPathSelectionInteraction PathSelectionInteraction;
}
