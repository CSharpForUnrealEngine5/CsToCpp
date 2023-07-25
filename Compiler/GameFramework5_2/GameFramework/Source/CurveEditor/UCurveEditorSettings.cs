#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveEditorSettings.h")]
///<summary>Serializable options for curve editor.</summary>
public partial class UCurveEditorSettings : UObject {
// CurveEditorSettings
	public bool bAutoFrameCurveEditor;
	public int FrameInputPadding;
	public int FrameOutputPadding;
	public bool bShowBufferedCurves;
	public bool bShowCurveEditorCurveToolTips;
	public ECurveEditorTangentVisibility TangentVisibility;
	public ECurveEditorZoomPosition ZoomPosition;
	public bool bSnapTimeToSelection;
	public FLinearColor SelectionColor;
	public TArray<FCustomColorForChannel> CustomColors;
	public FLinearColor ParentSpaceCustomColor;
	public FLinearColor WorldSpaceCustomColor;
	public TArray<FCustomColorForSpaceSwitch> ControlSpaceCustomColors;
	public float TreeViewWidth;
}
