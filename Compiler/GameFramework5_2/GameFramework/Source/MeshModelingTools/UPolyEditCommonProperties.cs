#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
///<summary>These are properties that do not get enabled/disabled based on the action</summary>
public partial class UPolyEditCommonProperties : UInteractiveToolPropertySet {
// PolyEditCommonProperties
	public bool bShowWireframe;
	public bool bShowSelectableCorners;
	public bool bGizmoVisible;
	public ELocalFrameMode LocalFrameMode;
	public bool bLockRotation;
	public bool bLocalCoordSystem;
}
