#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GraphEditorSettings.h")]
///<summary>Implements settings for the graph editor.</summary>
public partial class UGraphEditorSettings : UObject {
// GraphEditorSettings
	public byte DataPinStyle;
	public EGraphPanningMouseButton PanningMouseButton;
	public float PaddingAbovePin;
	public float PaddingBelowPin;
	public float PaddingRightOfInput;
	public float PaddingLeftOfOutput;
	public float PaddingTowardsNodeEdge;
	public bool bTreatSplinesLikePins;
	public float SplineHoverTolerance;
	public float SplineCloseTolerance;
	public float ForwardSplineHorizontalDeltaRange;
	public float ForwardSplineVerticalDeltaRange;
	public FVector2D ForwardSplineTangentFromHorizontalDelta;
	public FVector2D ForwardSplineTangentFromVerticalDelta;
	public float BackwardSplineHorizontalDeltaRange;
	public float BackwardSplineVerticalDeltaRange;
	public FVector2D BackwardSplineTangentFromHorizontalDelta;
	public FVector2D BackwardSplineTangentFromVerticalDelta;
	public FLinearColor DefaultPinTypeColor;
	public FLinearColor ExecutionPinTypeColor;
	public FLinearColor BooleanPinTypeColor;
	public FLinearColor BytePinTypeColor;
	public FLinearColor ClassPinTypeColor;
	public FLinearColor IntPinTypeColor;
	public FLinearColor Int64PinTypeColor;
	public FLinearColor FloatPinTypeColor;
	public FLinearColor DoublePinTypeColor;
	public FLinearColor RealPinTypeColor;
	public FLinearColor NamePinTypeColor;
	public FLinearColor SoftObjectPinTypeColor;
	public FLinearColor SoftClassPinTypeColor;
	public FLinearColor DelegatePinTypeColor;
	public FLinearColor ObjectPinTypeColor;
	public FLinearColor InterfacePinTypeColor;
	public FLinearColor StringPinTypeColor;
	public FLinearColor TextPinTypeColor;
	public FLinearColor StructPinTypeColor;
	public FLinearColor WildcardPinTypeColor;
	public FLinearColor VectorPinTypeColor;
	public FLinearColor RotatorPinTypeColor;
	public FLinearColor TransformPinTypeColor;
	public FLinearColor IndexPinTypeColor;
	public FLinearColor EventNodeTitleColor;
	public FLinearColor FunctionCallNodeTitleColor;
	public FLinearColor PureFunctionCallNodeTitleColor;
	public FLinearColor ParentFunctionCallNodeTitleColor;
	public FLinearColor FunctionTerminatorNodeTitleColor;
	public FLinearColor ExecBranchNodeTitleColor;
	public FLinearColor ExecSequenceNodeTitleColor;
	public FLinearColor ResultNodeTitleColor;
	public FLinearColor DefaultCommentNodeTitleColor;
	public FLinearColor PreviewNodeTitleColor;
	public float DefaultDataWireThickness;
	public float DefaultExecutionWireThickness;
	public FLinearColor TraceAttackColor;
	public float TraceAttackWireThickness;
	public float TraceAttackHoldPeriod;
	public float TraceDecayPeriod;
	public float TraceDecayExponent;
	public FLinearColor TraceSustainColor;
	public float TraceSustainWireThickness;
	public float TraceSustainHoldPeriod;
	public FLinearColor TraceReleaseColor;
	public float TraceReleaseWireThickness;
	public float TraceReleasePeriod;
	public float TraceReleaseExponent;
	public float TracePositionBonusPeriod;
	public float TracePositionExponent;
	public float PaddingAutoCollateIncrement;
	public bool bOpenCreateMenuOnBlankGraphAreas;
	public byte DefaultCommentNodeMoveMode;
	public bool bShowCommentBubbleWhenZoomedOut;
}
