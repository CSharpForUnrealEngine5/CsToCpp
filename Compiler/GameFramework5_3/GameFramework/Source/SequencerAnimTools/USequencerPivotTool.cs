namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pivot tool class</summary>
[CppInclude("SequencerAnimEditPivotTool.h")]
public partial class USequencerPivotTool : UMultiSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>ClickBehavior</summary>
	public USingleClickInputBehavior ClickBehavior;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
}
