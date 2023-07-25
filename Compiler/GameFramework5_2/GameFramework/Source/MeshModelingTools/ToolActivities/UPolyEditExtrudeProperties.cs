#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditExtrudeProperties : UInteractiveToolPropertySet {
// PolyEditExtrudeProperties
	public EPolyEditExtrudeDistanceMode DistanceMode;
	public double Distance;
	public EPolyEditExtrudeDirection Direction;
	public EPolyEditExtrudeDirection MeasureDirection;
	public bool bShellsToSolids;
	public EPolyEditExtrudeModeOptions DirectionMode;
	public double MaxDistanceScaleFactor;
	public bool bUseColinearityForSettingBorderGroups;
}
