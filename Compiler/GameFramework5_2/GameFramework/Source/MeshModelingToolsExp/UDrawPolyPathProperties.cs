#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolyPathTool.h")]
public partial class UDrawPolyPathProperties : UInteractiveToolPropertySet {
// DrawPolyPathProperties
	public EDrawPolyPathWidthMode WidthMode;
	public float Width;
	public bool bRoundedCorners;
	public EDrawPolyPathRadiusMode RadiusMode;
	public float CornerRadius;
	public int RadialSlices;
	public bool bSinglePolyGroup;
	public EDrawPolyPathExtrudeMode ExtrudeMode;
	public float ExtrudeHeight;
	public float RampStartRatio;
}
