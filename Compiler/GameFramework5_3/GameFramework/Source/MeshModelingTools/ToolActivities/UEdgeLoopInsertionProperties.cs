namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditInsertEdgeLoopActivity.h")]
public partial class UEdgeLoopInsertionProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Determines how edge loops position themselves vertically relative to loop direction.</summary>
	public EEdgeLoopPositioningMode PositionMode;
	///<summary>Determines how edge loops are added to the geometry</summary>
	public EEdgeLoopInsertionMode InsertionMode;
	///<summary>How many loops to insert at a time. Only used with &quot;even&quot; positioning mode.</summary>
	public int NumLoops;
	///<summary>ProportionOffset</summary>
	public double ProportionOffset;
	///<summary>DistanceOffset</summary>
	public double DistanceOffset;
	///<summary>When false, the distance/proportion offset is numerically specified, and mouse clicks just choose the edge.</summary>
	public bool bInteractive;
	///<summary>Measure the distance offset from the opposite side of the edges.</summary>
	public bool bFlipOffsetDirection;
	///<summary>When true, non-quad-like groups that stop the loop will be highlighted, with X&#39;s marking the corners.</summary>
	public bool bHighlightProblemGroups;
	///<summary>How close a new loop edge needs to pass next to an existing vertex to use that vertex rather than creating a new one.</summary>
	public double VertexTolerance;
}
