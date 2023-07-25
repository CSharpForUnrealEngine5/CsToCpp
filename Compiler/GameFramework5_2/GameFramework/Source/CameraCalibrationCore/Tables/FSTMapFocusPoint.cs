#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tables/STMapTable.h")]
///<summary>A data point associating focus and zoom to lens parameters</summary>
public partial struct FSTMapFocusPoint {
// STMapFocusPoint
	public float Focus;
	public FRichCurve MapBlendingCurve;
	public TArray<FSTMapZoomPoint> ZoomPoints;
}
