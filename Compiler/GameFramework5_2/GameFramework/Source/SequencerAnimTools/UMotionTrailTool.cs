namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrailTool.h")]
public partial class UMotionTrailTool : UMultiSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Support for gizmo. Since the points aren&#39;t individual components, we don&#39;t actually use UTransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>LeftClickBehavior</summary>
	public USingleClickInputBehavior LeftClickBehavior;
	///<summary>RightClickBehavior</summary>
	public USingleClickInputBehavior RightClickBehavior;
}
