namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for Iterative Offsetting</summary>
[CppInclude("OffsetMeshTool.h")]
public partial class UIterativeOffsetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Number of Offsetting iterations</summary>
	public int Steps;
	///<summary>Control whether the boundary is allowed to move</summary>
	public bool bOffsetBoundaries;
	///<summary>Amount of smoothing applied per Offset step</summary>
	public float SmoothingPerStep;
	///<summary>Reproject smooth vertices onto non-smoothed Offset Surface at each step (expensive but better-preserves uniform distance)</summary>
	public bool bReprojectSmooth;
}
