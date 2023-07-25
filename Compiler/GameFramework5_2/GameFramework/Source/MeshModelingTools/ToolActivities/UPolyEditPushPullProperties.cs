#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditPushPullProperties : UInteractiveToolPropertySet {
// PolyEditPushPullProperties
	public EPolyEditExtrudeDistanceMode DistanceMode;
	public double Distance;
	public EPolyEditPushPullModeOptions DirectionMode;
	public double MaxDistanceScaleFactor;
	public bool bShellsToSolids;
	public EPolyEditExtrudeDirection MeasureDirection;
	public bool bUseColinearityForSettingBorderGroups;
}
