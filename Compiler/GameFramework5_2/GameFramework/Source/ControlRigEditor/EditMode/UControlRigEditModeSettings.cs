#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings object used to show useful information in the details panel</summary>
[CppInclude("EditMode/ControlRigEditModeSettings.h")]
public partial class UControlRigEditModeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to show all bones in the hierarchy</summary>
	public bool bDisplayHierarchy;
	///<summary>Whether to show all nulls in the hierarchy</summary>
	public bool bDisplayNulls;
	///<summary>Should we always hide control shapes in viewport</summary>
	public bool bHideControlShapes;
	///<summary>Should we always hide control shapes in viewport</summary>
	public bool bShowAllProxyControls;
	///<summary>Determins if controls should be rendered on top of other controls</summary>
	public bool bShowControlsAsOverlay;
	///<summary>Indicates a control being driven by a proxy control</summary>
	public FLinearColor DrivenControlColor;
	///<summary>Should we show axes for the selected elements</summary>
	public bool bDisplayAxesOnSelection;
	///<summary>The scale for axes to draw on the selection</summary>
	public float AxisScale;
	///<summary>If true we restore the coordinate space when changing Widget Modes in the Viewport</summary>
	public bool bCoordSystemPerWidgetMode;
	///<summary>If true we can only select Rig Controls in the scene not other Actors.</summary>
	public bool bOnlySelectRigControls;
	///<summary>If true when we transform multiple selected objects in the viewport they each transforms along their own local transform space</summary>
	public bool bLocalTransformsInEachLocalSpace;
	///<summary>The scale for Gizmos</summary>
	public float GizmoScale;
	///<summary>LastInViewportTweenWidgetLocation</summary>
	public FVector2D LastInViewportTweenWidgetLocation;
}
