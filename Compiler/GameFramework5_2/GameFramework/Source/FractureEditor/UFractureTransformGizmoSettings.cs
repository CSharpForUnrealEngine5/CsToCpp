#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCutter.h")]
///<summary>This helps create a 3D transform gizmo that can be used to adjust fracture placement</summary>
public partial class UFractureTransformGizmoSettings : UFractureToolSettings {
// FractureTransformGizmoSettings
	public bool bUseGizmo;
	public bool bCenterOnSelection;
	public bool bShowUseGizmoOption;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
	public UFractureToolCutterBase AttachedCutter;
	public UInteractiveToolsContext UsedToolsContext;
}
