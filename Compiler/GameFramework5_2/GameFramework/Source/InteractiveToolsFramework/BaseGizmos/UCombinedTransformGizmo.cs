#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCombinedTransformGizmo provides standard Transformation Gizmo interactions,</summary>
[CppInclude("BaseGizmos/CombinedTransformGizmo.h")]
public partial class UCombinedTransformGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>The active target object for the Gizmo</summary>
	public UTransformProxy ActiveTarget;
	///<summary>bSnapToWorldGrid controls whether any position snapping is applied, if possible, for Axis and Plane translations, via the ContextQueriesAPI</summary>
	public bool bSnapToWorldGrid;
	///<summary>Optional grid size which overrides the Context Grid</summary>
	public bool bGridSizeIsExplicit;
	///<summary>ExplicitGridSize</summary>
	public FVector ExplicitGridSize;
	///<summary>Optional grid size which overrides the Context Rotation Grid</summary>
	public bool bRotationGridSizeIsExplicit;
	///<summary>ExplicitRotationGridSize</summary>
	public FRotator ExplicitRotationGridSize;
	///<summary>If true, then when using world frame, Axis and Plane translation snap to the world grid via the ContextQueriesAPI (in RotationSnapFunction)</summary>
	public bool bSnapToWorldRotGrid;
	///<summary>Whether to use the World/Local coordinate system provided by the context via the ContextyQueriesAPI.</summary>
	public bool bUseContextCoordinateSystem;
	///<summary>Current coordinate system in use. If bUseContextCoordinateSystem is true, this value will be updated internally every Tick()</summary>
	public EToolContextCoordinateSystem CurrentCoordinateSystem;
	///<summary>Whether to use the Gizmo Mode provided by the context via the ContextyQueriesAPI.</summary>
	public bool bUseContextGizmoMode;
	///<summary>Current dynamic sub-widget visibility mode to use (eg Translate-Only, Scale-Only, Combined, etc)</summary>
	public EToolContextTransformGizmoMode ActiveGizmoMode;
	///<summary>List of current-active child components</summary>
	public TArray<UPrimitiveComponent> ActiveComponents;
	///<summary>list of currently-active child gizmos</summary>
	public TArray<UInteractiveGizmo> ActiveGizmos;
	///<summary>Axis that points towards camera, X/Y plane tangents aligned to right/up. Shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoConstantFrameAxisSource CameraAxisSource;
	///<summary>X-axis source is shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource AxisXSource;
	///<summary>Y-axis source is shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource AxisYSource;
	///<summary>Z-axis source is shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource AxisZSource;
	///<summary>Local X-axis source (ie 1,0,0) is shared across Scale Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource UnitAxisXSource;
	///<summary>Y-axis source (ie 0,1,0) is shared across Scale Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource UnitAxisYSource;
	///<summary>Z-axis source (ie 0,0,1) is shared across Scale Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoComponentAxisSource UnitAxisZSource;
	///<summary>State target is shared across gizmos, and created internally during SetActiveTarget().</summary>
	public UGizmoTransformChangeStateTarget StateTarget;
}
