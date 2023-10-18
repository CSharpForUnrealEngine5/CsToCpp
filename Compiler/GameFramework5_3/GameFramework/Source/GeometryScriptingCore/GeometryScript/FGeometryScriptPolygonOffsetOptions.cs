namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolygonFunctions.h")]
public partial struct FGeometryScriptPolygonOffsetOptions {
	public EGeometryScriptPolyOffsetJoinType JoinType;
	public double MiterLimit;
	public bool bOffsetBothSides;
	public double StepsPerRadianScale;
	public double MaximumStepsPerRadian;
}
