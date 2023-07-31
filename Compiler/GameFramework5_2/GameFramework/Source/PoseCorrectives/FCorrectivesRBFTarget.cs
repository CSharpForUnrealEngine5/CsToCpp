#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about a particular target in the RBF, including scaling factor</summary>
[CppInclude("CorrectivesRBFSolver.h")]
public partial struct FCorrectivesRBFTarget {
	public float ScaleFactor;
	public bool bApplyCustomCurve;
	public FRichCurve CustomCurve;
	public ERBFDistanceMethod DistanceMethod;
	public ERBFFunctionType FunctionType;
}
