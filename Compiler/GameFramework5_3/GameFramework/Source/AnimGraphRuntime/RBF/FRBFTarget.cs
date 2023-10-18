namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about a particular target in the RBF, including scaling factor</summary>
[CppInclude("RBF/RBFSolver.h")]
public partial struct FRBFTarget {
	public float ScaleFactor;
	public bool bApplyCustomCurve;
	public FRichCurve CustomCurve;
	public ERBFDistanceMethod DistanceMethod;
	public ERBFFunctionType FunctionType;
}
