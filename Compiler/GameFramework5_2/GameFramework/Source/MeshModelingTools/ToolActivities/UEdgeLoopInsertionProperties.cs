#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditInsertEdgeLoopActivity.h")]
public partial class UEdgeLoopInsertionProperties : UInteractiveToolPropertySet {
// EdgeLoopInsertionProperties
	public EEdgeLoopPositioningMode PositionMode;
	public EEdgeLoopInsertionMode InsertionMode;
	public int NumLoops;
	public double ProportionOffset;
	public double DistanceOffset;
	public bool bInteractive;
	public bool bFlipOffsetDirection;
	public bool bHighlightProblemGroups;
	public double VertexTolerance;
}
