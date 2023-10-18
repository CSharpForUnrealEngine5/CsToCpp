namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolygonFunctions.h")]
public partial struct FGeometryScriptOpenPathOffsetOptions {
	public EGeometryScriptPolyOffsetJoinType JoinType;
	public double MiterLimit;
	public EGeometryScriptPathOffsetEndType EndType;
	public double StepsPerRadianScale;
	public double MaximumStepsPerRadian;
}
