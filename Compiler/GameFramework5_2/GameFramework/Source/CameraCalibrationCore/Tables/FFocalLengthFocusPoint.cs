namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains list of focal length points associated to zoom value</summary>
[CppInclude("Tables/FocalLengthTable.h")]
public partial struct FFocalLengthFocusPoint {
	public float Focus;
	public FRichCurve Fx;
	public FRichCurve Fy;
	public TArray<FFocalLengthZoomPoint> ZoomPoints;
}
