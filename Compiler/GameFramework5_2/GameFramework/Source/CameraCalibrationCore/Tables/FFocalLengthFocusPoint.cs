#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tables/FocalLengthTable.h")]
///<summary>Contains list of focal length points associated to zoom value</summary>
public partial struct FFocalLengthFocusPoint {
// FocalLengthFocusPoint
	public float Focus;
	public FRichCurve Fx;
	public FRichCurve Fy;
	public TArray<FFocalLengthZoomPoint> ZoomPoints;
}
