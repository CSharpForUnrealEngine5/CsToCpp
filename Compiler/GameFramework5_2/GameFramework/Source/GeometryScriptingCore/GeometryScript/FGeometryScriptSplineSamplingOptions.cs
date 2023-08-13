namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolyPathFunctions.h")]
public partial struct FGeometryScriptSplineSamplingOptions {
	public int NumSamples;
	public float ErrorTolerance;
	public EGeometryScriptSampleSpacing SampleSpacing;
	public ESplineCoordinateSpace CoordinateSpace;
}
