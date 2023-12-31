namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditOffsetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>How the offset distance is set.</summary>
	public EPolyEditExtrudeDistanceMode DistanceMode;
	///<summary>Offset distance.</summary>
	public double Distance;
	///<summary>Which way to move vertices during the offset</summary>
	public EPolyEditOffsetModeOptions DirectionMode;
	///<summary>Controls the maximum distance vertices can move from the target distance in order to stay parallel with their source triangles.</summary>
	public double MaxDistanceScaleFactor;
	///<summary>Controls whether offsetting an entire open-border patch should create a solid or an open shell</summary>
	public bool bShellsToSolids;
	///<summary>What axis to measure the extrusion distance along.</summary>
	public EPolyEditExtrudeDirection MeasureDirection;
	///<summary>When offsetting regions that touch the mesh border, assign the side groups (groups on the</summary>
	public bool bUseColinearityForSettingBorderGroups;
}
