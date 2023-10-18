namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/CollisionPrimitivesMechanic.h")]
public partial class UCollisionPrimitivesMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>Used for displaying Primitives/segments</summary>
	public UPreviewGeometry PreviewGeometry;
	///<summary>DrawnPrimitiveEdges</summary>
	public ULineSetComponent DrawnPrimitiveEdges;
	///<summary>Support for gizmos. Since the primitives aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy TranslateTransformProxy;
	///<summary>SphereTransformProxy</summary>
	public UTransformProxy SphereTransformProxy;
	///<summary>BoxTransformProxy</summary>
	public UTransformProxy BoxTransformProxy;
	///<summary>CapsuleTransformProxy</summary>
	public UTransformProxy CapsuleTransformProxy;
	///<summary>FullTransformProxy</summary>
	public UTransformProxy FullTransformProxy;
	///<summary>CurrentActiveProxy</summary>
	public UTransformProxy CurrentActiveProxy;
	///<summary>TranslateTransformGizmo</summary>
	public UCombinedTransformGizmo TranslateTransformGizmo;
	///<summary>SphereTransformGizmo</summary>
	public UCombinedTransformGizmo SphereTransformGizmo;
	///<summary>BoxTransformGizmo</summary>
	public UCombinedTransformGizmo BoxTransformGizmo;
	///<summary>CapsuleTransformGizmo</summary>
	public UCombinedTransformGizmo CapsuleTransformGizmo;
	///<summary>FullTransformGizmo</summary>
	public UCombinedTransformGizmo FullTransformGizmo;
	///<summary>Support for selection</summary>
	public URectangleMarqueeMechanic MarqueeMechanic;
}
