#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineGeneratorPanel.h")]
public partial class UArcSplineGenerator : USplineGeneratorBase {
// ArcSplineGenerator
	public int NumberOfPoints;
	public float Radius;
	public float Degrees;
	public bool bReverseDir;
	public bool bKeepFirstKeyTangent;
	public bool bBranchRight;
}
