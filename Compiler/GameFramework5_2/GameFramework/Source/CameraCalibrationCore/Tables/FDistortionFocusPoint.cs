#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tables/DistortionParametersTable.h")]
///<summary>Contains list of distortion parameters points associated to zoom value</summary>
public partial struct FDistortionFocusPoint {
// DistortionFocusPoint
	public float Focus;
	public FRichCurve MapBlendingCurve;
	public TArray<FDistortionZoomPoint> ZoomPoints;
}
