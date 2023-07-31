#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrailTool.h")]
public partial class UMotionTrailTool : UMultiSelectionTool {
	///<summary>Support for gizmo. Since the points aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>LeftClickBehavior</summary>
	public USingleClickInputBehavior LeftClickBehavior;
	///<summary>RightClickBehavior</summary>
	public USingleClickInputBehavior RightClickBehavior;
}
