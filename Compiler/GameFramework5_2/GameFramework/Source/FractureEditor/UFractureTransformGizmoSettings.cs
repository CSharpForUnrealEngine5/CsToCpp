#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This helps create a 3D transform gizmo that can be used to adjust fracture placement</summary>
[CppInclude("FractureToolCutter.h")]
public partial class UFractureTransformGizmoSettings : UFractureToolSettings {
	///<summary>Use a 3D rigid transform gizmo to place the fracture pattern.  Only supports grouped fracture.</summary>
	public bool bUseGizmo;
	///<summary>Recenter the gizmo to the center of the selection when selection changes</summary>
	public bool bCenterOnSelection;
	///<summary>bShowUseGizmoOption</summary>
	public bool bShowUseGizmoOption;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>AttachedCutter</summary>
	public UFractureToolCutterBase AttachedCutter;
	///<summary>the tools context responsible for the gizmo</summary>
	public UInteractiveToolsContext UsedToolsContext;
}
