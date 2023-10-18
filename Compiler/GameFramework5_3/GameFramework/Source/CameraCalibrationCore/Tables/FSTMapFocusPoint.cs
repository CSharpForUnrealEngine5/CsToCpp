namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data point associating focus and zoom to lens parameters</summary>
[CppInclude("Tables/STMapTable.h")]
public partial struct FSTMapFocusPoint {
	public float Focus;
	public FRichCurve MapBlendingCurve;
	public TArray<FSTMapZoomPoint> ZoomPoints;
}
