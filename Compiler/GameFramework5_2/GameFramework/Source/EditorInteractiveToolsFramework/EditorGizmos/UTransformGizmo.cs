namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformGizmo provides standard Transformation Gizmo interactions,</summary>
[CppInclude("EditorGizmos/TransformGizmo.h")]
public partial class UTransformGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>The active target object for the Gizmo</summary>
	public UTransformProxy ActiveTarget;
	///<summary>The hit target object</summary>
	public UGizmoElementHitMultiTarget HitTarget;
	///<summary>The mouse click behavior of the gizmo is accessible so that it can be modified to use different mouse keys.</summary>
	public UClickDragInputBehavior MouseBehavior;
	///<summary>Transform Gizmo Source</summary>
	public object /*TransformGizmoSource*/ TransformGizmoSource;
	///<summary>Root of renderable gizmo elements</summary>
	public UGizmoElementGroup GizmoElementRoot;
	///<summary>Gizmo view context, needed for screen space interactions</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>Whether gizmo is visible.</summary>
	public bool bVisible;
	///<summary>Whether gizmo is interacting.</summary>
	public bool bInInteraction;
	///<summary>If true, then when using world frame, Axis and Plane translation snap to the world grid via the ContextQueriesAPI (in PositionSnapFunction)</summary>
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
	///<summary>Translate X Axis</summary>
	public UGizmoElementArrow TranslateXAxisElement;
	///<summary>Translate Y Axis</summary>
	public UGizmoElementArrow TranslateYAxisElement;
	///<summary>Translate Z Axis</summary>
	public UGizmoElementArrow TranslateZAxisElement;
	///<summary>Translate screen-space</summary>
	public UGizmoElementRectangle TranslateScreenSpaceElement;
	///<summary>Translate planar XY handle</summary>
	public UGizmoElementRectangle TranslatePlanarXYElement;
	///<summary>Translate planar YZ handle</summary>
	public UGizmoElementRectangle TranslatePlanarYZElement;
	///<summary>Translate planar XZ handle</summary>
	public UGizmoElementRectangle TranslatePlanarXZElement;
	///<summary>Rotate X Axis</summary>
	public UGizmoElementTorus RotateXAxisElement;
	///<summary>Rotate Y Axis</summary>
	public UGizmoElementTorus RotateYAxisElement;
	///<summary>Rotate Z Axis</summary>
	public UGizmoElementTorus RotateZAxisElement;
	///<summary>Rotate outer circle</summary>
	public UGizmoElementCircle RotateOuterCircleElement;
	///<summary>Rotate arcball outer circle</summary>
	public UGizmoElementCircle RotateArcballOuterElement;
	///<summary>Rotate arcball inner circle</summary>
	public UGizmoElementCircle RotateArcballInnerElement;
	///<summary>Rotate screen space circle</summary>
	public UGizmoElementCircle RotateScreenSpaceElement;
	///<summary>Scale X Axis object</summary>
	public UGizmoElementArrow ScaleXAxisElement;
	///<summary>Scale Y Axis object</summary>
	public UGizmoElementArrow ScaleYAxisElement;
	///<summary>Scale Z Axis object</summary>
	public UGizmoElementArrow ScaleZAxisElement;
	///<summary>Scale planar XY handle</summary>
	public UGizmoElementRectangle ScalePlanarXYElement;
	///<summary>Scale planar YZ handle</summary>
	public UGizmoElementRectangle ScalePlanarYZElement;
	///<summary>Scale planar XZ handle</summary>
	public UGizmoElementRectangle ScalePlanarXZElement;
	///<summary>Uniform scale object</summary>
	public UGizmoElementBox ScaleUniformElement;
	///<summary>Axis that points towards camera, X/Y plane tangents aligned to right/up. Shared across Gizmos, and created internally during SetActiveTarget()</summary>
	public UGizmoConstantFrameAxisSource CameraAxisSource;
	///<summary>The state target is created internally during SetActiveTarget()</summary>
	public UGizmoObjectModifyStateTarget StateTarget;
	///<summary>Materials and colors to be used when drawing the items for each axis</summary>
	public UMaterialInterface TransparentVertexColorMaterial;
	///<summary>GridMaterial</summary>
	public UMaterialInterface GridMaterial;
	///<summary>AxisMaterialX</summary>
	public UMaterialInstanceDynamic AxisMaterialX;
	///<summary>AxisMaterialY</summary>
	public UMaterialInstanceDynamic AxisMaterialY;
	///<summary>AxisMaterialZ</summary>
	public UMaterialInstanceDynamic AxisMaterialZ;
	///<summary>CurrentAxisMaterial</summary>
	public UMaterialInstanceDynamic CurrentAxisMaterial;
	///<summary>GreyMaterial</summary>
	public UMaterialInstanceDynamic GreyMaterial;
	///<summary>WhiteMaterial</summary>
	public UMaterialInstanceDynamic WhiteMaterial;
	///<summary>OpaquePlaneMaterialXY</summary>
	public UMaterialInstanceDynamic OpaquePlaneMaterialXY;
	///<summary>Percentage-based scale multiplier</summary>
	public double ScaleMultiplier;
	///<summary>Current transform</summary>
	public FTransform CurrentTransform;
	///<summary>Currently rendered transform mode</summary>
	public EGizmoTransformMode CurrentMode;
	///<summary>Currently rendered axis list</summary>
	public EAxisList CurrentAxisToDraw;
	///<summary>Last hit part</summary>
	public ETransformGizmoPartIdentifier LastHitPart;
	///<summary>Active axis type (only valid between state target BeginModify/EndModify)</summary>
	public EAxisList InteractionAxisList;
	///<summary>Active world space axis origin (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionAxisOrigin;
	///<summary>Active world space axis (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionAxisDirection;
	///<summary>Active interaction start hit param (only valid between state target BeginModify/EndModify)</summary>
	public float InteractionAxisStartParam;
	///<summary>Active interaction current hit param (only valid between state target BeginModify/EndModify)</summary>
	public float InteractionAxisCurrParam;
	///<summary>Active world space planar origin (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarOrigin;
	///<summary>Active world space normal used for planar (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarNormal;
	///<summary>Active world space axis X used for planar (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarAxisX;
	///<summary>Active world space axis Y used for planar (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarAxisY;
	///<summary>Active interaction start point planar (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarStartPoint;
	///<summary>Active interaction current point planar (only valid between state target BeginModify/EndModify)</summary>
	public FVector InteractionPlanarCurrPoint;
	///<summary>Active interaction rotation start angle (only valid between state target BeginModify/EndModify)</summary>
	public float InteractionStartAngle;
	///<summary>Active interaction rotation curr angle (only valid between state target BeginModify/EndModify)</summary>
	public float InteractionCurrAngle;
	///<summary>Active interaction screen axis dir (only valid between state target BeginModify/EndModify)</summary>
	public FVector2D InteractionScreenAxisDirection;
	///<summary>Active interaction screen start pos (only valid between state target BeginModify/EndModify)</summary>
	public FVector2D InteractionScreenStartPos;
	///<summary>Active interaction screen end pos (only valid between state target BeginModify/EndModify)</summary>
	public FVector2D InteractionScreenEndPos;
	///<summary>Active interaction screen current pos (only valid between state target BeginModify/EndModify)</summary>
	public FVector2D InteractionScreenCurrPos;
}
