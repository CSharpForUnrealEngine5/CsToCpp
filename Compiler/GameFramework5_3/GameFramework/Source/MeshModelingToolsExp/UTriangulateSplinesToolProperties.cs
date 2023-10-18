namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for controlling the spline triangulation</summary>
[CppInclude("TriangulateSplinesTool.h")]
public partial class UTriangulateSplinesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>How far to allow the triangulation boundary can deviate from the spline curve before we add more vertices</summary>
	public double ErrorTolerance;
	///<summary>Whether and how to flatten the curves. If curves are flattened, they can also be offset and combined</summary>
	public EFlattenCurveMethod FlattenMethod;
	///<summary>Note: Combining and offsetting curves only works when curves are flattened; curves will be left separate and non-offset if FlattenMethod is DoNotFlatten</summary>
	public ECombineCurvesMethod CombineMethod;
	///<summary>If &gt; 0, Extrude the triangulation by this amount</summary>
	public double Thickness;
	///<summary>Whether to flip the facing direction of the generated mesh</summary>
	public bool bFlipResult;
	///<summary>How to handle open curves: Either offset them, or treat them as closed curves</summary>
	public EOffsetOpenCurvesMethod OpenCurves;
	///<summary>How much offset to apply to curves</summary>
	public double CurveOffset;
	///<summary>Whether and how to apply offset to closed curves</summary>
	public EOffsetClosedCurvesMethod OffsetClosedCurves;
	///<summary>The shape of the ends of offset curves</summary>
	public EOpenCurveEndShapes EndShapes;
	///<summary>The shape of joins between segments of an offset curve</summary>
	public EOffsetJoinMethod JoinMethod;
	///<summary>How far a miter join can extend before it is replaced by a square join</summary>
	public double MiterLimit;
}
