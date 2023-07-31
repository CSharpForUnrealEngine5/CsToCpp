#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements settings for the graph editor.</summary>
[CppInclude("GraphEditorSettings.h")]
public partial class UGraphEditorSettings : UObject {
	///<summary>The visual styling to use for graph editor pins (in Blueprints, materials, etc...)</summary>
	public EBlueprintPinStyleType DataPinStyle;
	///<summary>Switch between using the right and middle mouse button for panning (defaults to right)</summary>
	public EGraphPanningMouseButton PanningMouseButton;
	///<summary>The amount of padding above a pin (defaults to 4)</summary>
	public float PaddingAbovePin;
	///<summary>The amount of padding below a pin (defaults to 4)</summary>
	public float PaddingBelowPin;
	///<summary>The amount of horizontal padding towards the center of a node on an input pin (defaults to 10)</summary>
	public float PaddingRightOfInput;
	///<summary>The amount of horizontal padding towards the center of a node on an output pin (defaults to 10)</summary>
	public float PaddingLeftOfOutput;
	///<summary>The amount of padding towards the node edge (defaults to 10, can be negative to make pins overlap or stick out of a node</summary>
	public float PaddingTowardsNodeEdge;
	///<summary>If enabled, allows splines to be Alt+Clicked to break them or Ctrl+Dragged to move them as if these actions were taking place on the associated pin.</summary>
	public bool bTreatSplinesLikePins;
	///<summary>The distance threshold controlling how close the mouse has to be to the spline in order to trigger a hover response</summary>
	public float SplineHoverTolerance;
	///<summary>The additional distance around the spline to count as close, preventing other actions if the user just misses the spline when clicking</summary>
	public float SplineCloseTolerance;
	///<summary>The maximum value to clamp the absolute value of the horizontal distance between endpoints when calculating tangents (when the wire is moving forward)</summary>
	public float ForwardSplineHorizontalDeltaRange;
	///<summary>The maximum value to clamp the absolute value of the vertical distance between endpoints when calculating tangents (when the wire is moving forward)</summary>
	public float ForwardSplineVerticalDeltaRange;
	///<summary>The amount that the horizontal delta affects the generated tangent handle of splines (when the wire is moving forward)</summary>
	public FVector2D ForwardSplineTangentFromHorizontalDelta;
	///<summary>The amount that the vertical delta affects the generated tangent handle of splines (when the wire is moving forward)</summary>
	public FVector2D ForwardSplineTangentFromVerticalDelta;
	///<summary>The maximum value to clamp the absolute value of the horizontal distance between endpoints when calculating tangents (when the wire is moving backwards)</summary>
	public float BackwardSplineHorizontalDeltaRange;
	///<summary>The maximum value to clamp the absolute value of the vertical distance between endpoints when calculating tangents (when the wire is moving backwards)</summary>
	public float BackwardSplineVerticalDeltaRange;
	///<summary>The amount that the horizontal delta affects the generated tangent handle of splines (when the wire is moving backwards)</summary>
	public FVector2D BackwardSplineTangentFromHorizontalDelta;
	///<summary>The amount that the vertical delta affects the generated tangent handle of splines (when the wire is moving backwards)</summary>
	public FVector2D BackwardSplineTangentFromVerticalDelta;
	///<summary>The default color is used only for types not specifically defined below.  Generally if it&#39;s seen, it means another type needs to be defined so that the wire in question can have an appropriate color.</summary>
	public FLinearColor DefaultPinTypeColor;
	///<summary>Execution pin type color</summary>
	public FLinearColor ExecutionPinTypeColor;
	///<summary>Boolean pin type color</summary>
	public FLinearColor BooleanPinTypeColor;
	///<summary>Byte pin type color</summary>
	public FLinearColor BytePinTypeColor;
	///<summary>Class pin type color</summary>
	public FLinearColor ClassPinTypeColor;
	///<summary>Integer pin type color</summary>
	public FLinearColor IntPinTypeColor;
	///<summary>Integer64 pin type color</summary>
	public FLinearColor Int64PinTypeColor;
	///<summary>Floating-point pin type color</summary>
	public FLinearColor FloatPinTypeColor;
	///<summary>Double pin type color</summary>
	public FLinearColor DoublePinTypeColor;
	///<summary>Real pin type color</summary>
	public FLinearColor RealPinTypeColor;
	///<summary>Name pin type color</summary>
	public FLinearColor NamePinTypeColor;
	///<summary>Asset pin type color</summary>
	public FLinearColor SoftObjectPinTypeColor;
	///<summary>Asset Class pin type color</summary>
	public FLinearColor SoftClassPinTypeColor;
	///<summary>Delegate pin type color</summary>
	public FLinearColor DelegatePinTypeColor;
	///<summary>Object pin type color</summary>
	public FLinearColor ObjectPinTypeColor;
	///<summary>Interface pin type color</summary>
	public FLinearColor InterfacePinTypeColor;
	///<summary>String pin type color</summary>
	public FLinearColor StringPinTypeColor;
	///<summary>Text pin type color</summary>
	public FLinearColor TextPinTypeColor;
	///<summary>Struct pin type color</summary>
	public FLinearColor StructPinTypeColor;
	///<summary>Wildcard pin type color</summary>
	public FLinearColor WildcardPinTypeColor;
	///<summary>Vector pin type color</summary>
	public FLinearColor VectorPinTypeColor;
	///<summary>Rotator pin type color</summary>
	public FLinearColor RotatorPinTypeColor;
	///<summary>Transform pin type color</summary>
	public FLinearColor TransformPinTypeColor;
	///<summary>Index pin type color</summary>
	public FLinearColor IndexPinTypeColor;
	///<summary>Event node title color</summary>
	public FLinearColor EventNodeTitleColor;
	///<summary>CallFunction node title color</summary>
	public FLinearColor FunctionCallNodeTitleColor;
	///<summary>Pure function call node title color</summary>
	public FLinearColor PureFunctionCallNodeTitleColor;
	///<summary>Parent class function call node title color</summary>
	public FLinearColor ParentFunctionCallNodeTitleColor;
	///<summary>Function Terminator node title color</summary>
	public FLinearColor FunctionTerminatorNodeTitleColor;
	///<summary>Exec Branch node title color</summary>
	public FLinearColor ExecBranchNodeTitleColor;
	///<summary>Exec Sequence node title color</summary>
	public FLinearColor ExecSequenceNodeTitleColor;
	///<summary>Result node title color</summary>
	public FLinearColor ResultNodeTitleColor;
	///<summary>Default Comment node title color</summary>
	public FLinearColor DefaultCommentNodeTitleColor;
	///<summary>Preview node title color</summary>
	public FLinearColor PreviewNodeTitleColor;
	///<summary>The thickness of a data wire</summary>
	public float DefaultDataWireThickness;
	///<summary>The thickness of an execution wire when not debugging</summary>
	public float DefaultExecutionWireThickness;
	///<summary>The color to display execution wires that were just executed</summary>
	public FLinearColor TraceAttackColor;
	///<summary>TraceAttackWireThickness</summary>
	public float TraceAttackWireThickness;
	///<summary>How long is the attack color fully visible</summary>
	public float TraceAttackHoldPeriod;
	///<summary>How long does it take to fade from the attack to the sustain color</summary>
	public float TraceDecayPeriod;
	///<summary>TraceDecayExponent</summary>
	public float TraceDecayExponent;
	///<summary>TraceSustainColor</summary>
	public FLinearColor TraceSustainColor;
	///<summary>TraceSustainWireThickness</summary>
	public float TraceSustainWireThickness;
	///<summary>How long is the sustain color fully visible</summary>
	public float TraceSustainHoldPeriod;
	///<summary>The color to fade to for execution wires on release</summary>
	public FLinearColor TraceReleaseColor;
	///<summary>The thickness to drop down to during release / for unexecuted wires when debugging</summary>
	public float TraceReleaseWireThickness;
	///<summary>How long does it take to fade from the sustain to the release color</summary>
	public float TraceReleasePeriod;
	///<summary>TraceReleaseExponent</summary>
	public float TraceReleaseExponent;
	///<summary>How much of a bonus does an exec get for being near the top of the trace stack, and how does that fall off with position?</summary>
	public float TracePositionBonusPeriod;
	///<summary>TracePositionExponent</summary>
	public float TracePositionExponent;
	///<summary>The amount of padding to add in order to auto collate multiple created nodes when using tab context menu (defaults to 20)</summary>
	public float PaddingAutoCollateIncrement;
	///<summary>If a key press (default Tab) should open the create node context menu when the mouse is on top of blank areas of the graph (defaults to true)</summary>
	public bool bOpenCreateMenuOnBlankGraphAreas;
	///<summary>Whether a comment node should move any fully enclosed nodes around when it is moved</summary>
	public ECommentBoxMode DefaultCommentNodeMoveMode;
	///<summary>Whether to show a zoom-invariant comment bubble when zoomed out (making the comment node&#39;s text readable at any distance)</summary>
	public bool bShowCommentBubbleWhenZoomedOut;
}
