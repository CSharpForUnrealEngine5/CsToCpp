namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains list of distortion parameters points associated to zoom value</summary>
[CppInclude("Tables/DistortionParametersTable.h")]
public partial struct FDistortionFocusPoint {
	public float Focus;
	public FRichCurve MapBlendingCurve;
	public TArray<FDistortionZoomPoint> ZoomPoints;
}
