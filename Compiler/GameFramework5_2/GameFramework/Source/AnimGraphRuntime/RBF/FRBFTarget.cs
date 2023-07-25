#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RBF/RBFSolver.h")]
///<summary>Data about a particular target in the RBF, including scaling factor</summary>
public partial struct FRBFTarget {
// RBFTarget
	public float ScaleFactor;
	public bool bApplyCustomCurve;
	public FRichCurve CustomCurve;
	public ERBFDistanceMethod DistanceMethod;
	public ERBFFunctionType FunctionType;
}
