namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ImageCenter focus point containing curves for CxCy</summary>
[CppInclude("Tables/ImageCenterTable.h")]
public partial struct FImageCenterFocusPoint {
	public float Focus;
	public FRichCurve Cx;
	public FRichCurve Cy;
}
