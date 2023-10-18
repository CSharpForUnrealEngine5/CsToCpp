namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditInsertEdgeActivity.h")]
public partial class UGroupEdgeInsertionProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Determines how group edges are added to the geometry</summary>
	public EGroupEdgeInsertionMode InsertionMode;
	///<summary>If true, edge insertions are chained together so that each end point becomes the new start point</summary>
	public bool bContinuousInsertion;
	///<summary>How close a new loop edge needs to pass next to an existing vertex to use that vertex rather than creating a new one (used for plane cut).</summary>
	public double VertexTolerance;
}
