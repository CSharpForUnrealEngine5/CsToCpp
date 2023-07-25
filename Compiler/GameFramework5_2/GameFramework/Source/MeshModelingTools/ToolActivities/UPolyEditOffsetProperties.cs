#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditOffsetProperties : UInteractiveToolPropertySet {
// PolyEditOffsetProperties
	public EPolyEditExtrudeDistanceMode DistanceMode;
	public double Distance;
	public EPolyEditOffsetModeOptions DirectionMode;
	public double MaxDistanceScaleFactor;
	public bool bShellsToSolids;
	public EPolyEditExtrudeDirection MeasureDirection;
	public bool bUseColinearityForSettingBorderGroups;
}
