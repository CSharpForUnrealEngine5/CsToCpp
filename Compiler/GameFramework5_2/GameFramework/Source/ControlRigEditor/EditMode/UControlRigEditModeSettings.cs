#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMode/ControlRigEditModeSettings.h")]
///<summary>Settings object used to show useful information in the details panel</summary>
public partial class UControlRigEditModeSettings : UObject {
// ControlRigEditModeSettings
	public bool bDisplayHierarchy;
	public bool bDisplayNulls;
	public bool bHideControlShapes;
	public bool bShowAllProxyControls;
	public bool bShowControlsAsOverlay;
	public FLinearColor DrivenControlColor;
	public bool bDisplayAxesOnSelection;
	public float AxisScale;
	public bool bCoordSystemPerWidgetMode;
	public bool bOnlySelectRigControls;
	public bool bLocalTransformsInEachLocalSpace;
	public float GizmoScale;
	public FVector2D LastInViewportTweenWidgetLocation;
}
