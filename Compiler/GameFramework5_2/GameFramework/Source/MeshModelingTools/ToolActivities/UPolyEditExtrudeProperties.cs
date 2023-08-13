namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditExtrudeProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>How the extrude distance is set.</summary>
	public EPolyEditExtrudeDistanceMode DistanceMode;
	///<summary>Distance to extrude.</summary>
	public double Distance;
	///<summary>Direction in which to extrude.</summary>
	public EPolyEditExtrudeDirection Direction;
	///<summary>What axis to measure the extrusion distance along.</summary>
	public EPolyEditExtrudeDirection MeasureDirection;
	///<summary>Controls whether extruding an entire open-border patch should create a solid or an open shell</summary>
	public bool bShellsToSolids;
	///<summary>How to move the vertices during the extrude</summary>
	public EPolyEditExtrudeModeOptions DirectionMode;
	///<summary>Controls the maximum distance vertices can move from the target distance in order to stay parallel with their source triangles.</summary>
	public double MaxDistanceScaleFactor;
	///<summary>When extruding regions that touch the mesh border, assign the side groups (groups on the</summary>
	public bool bUseColinearityForSettingBorderGroups;
}
