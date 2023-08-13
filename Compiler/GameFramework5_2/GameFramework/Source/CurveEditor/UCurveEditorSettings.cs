namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serializable options for curve editor.</summary>
[CppInclude("CurveEditorSettings.h")]
public partial class UCurveEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bAutoFrameCurveEditor</summary>
	public bool bAutoFrameCurveEditor;
	///<summary>Number of pixels to add as padding in the input axis when framing curve keys</summary>
	public int FrameInputPadding;
	///<summary>Number of pixels to add as padding in the output axis when framing curve keys</summary>
	public int FrameOutputPadding;
	///<summary>bShowBufferedCurves</summary>
	public bool bShowBufferedCurves;
	///<summary>bShowCurveEditorCurveToolTips</summary>
	public bool bShowCurveEditorCurveToolTips;
	///<summary>TangentVisibility</summary>
	public ECurveEditorTangentVisibility TangentVisibility;
	///<summary>ZoomPosition</summary>
	public ECurveEditorZoomPosition ZoomPosition;
	///<summary>bSnapTimeToSelection</summary>
	public bool bSnapTimeToSelection;
	///<summary>SelectionColor</summary>
	public FLinearColor SelectionColor;
	///<summary>CustomColors</summary>
	public TArray<FCustomColorForChannel> CustomColors;
	///<summary>ParentSpaceCustomColor</summary>
	public FLinearColor ParentSpaceCustomColor;
	///<summary>WorldSpaceCustomColor</summary>
	public FLinearColor WorldSpaceCustomColor;
	///<summary>ControlSpaceCustomColors</summary>
	public TArray<FCustomColorForSpaceSwitch> ControlSpaceCustomColors;
	///<summary>TreeViewWidth</summary>
	public float TreeViewWidth;
}
